using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace SpedHub.UI.Formatters
{
    public class MarkdownOutputFormatter: TextOutputFormatter
    {
        public MarkdownOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/markdown"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            // Allow formatting if the return type is a string or implements a custom markdown interface/model
            return typeof(string).IsAssignableFrom(type);
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var content = context.Object?.ToString() ?? string.Empty;

            await response.WriteAsync(content, selectedEncoding);
        }
    }
}
