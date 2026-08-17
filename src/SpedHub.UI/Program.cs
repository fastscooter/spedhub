using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.OpenApi;
using SpedHub.UI.Configurations;
using SpedHub.UI.Formatters;

namespace SpedHub.UI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            builder.Services.AddControllers(
                    options =>
                    {
                        options.RespectBrowserAcceptHeader = true; // Enables content negotiation based on Accept header
                        options.OutputFormatters.Add(new MarkdownOutputFormatter());
                    }
                )
                .AddJsonOptions(o =>
                {
                    o.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    o.JsonSerializerOptions.WriteIndented = true;
                    o.JsonSerializerOptions.Converters.Add(JsonConverters.DateOnly);

                }).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressConsumesConstraintForFormFileParameters = true;
                options.SuppressInferBindingSourcesForParameters = true;
                options.SuppressModelStateInvalidFilter = true;
                options.SuppressMapClientErrors = true;
                options.ClientErrorMapping[StatusCodes.Status404NotFound].Link =
                    "https://httpstatuses.com/404";
            });

            builder.Services.AddOpenApi();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "SpedHub API",
                    Description = "An API for Special Education Student Data Retrieval",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
                //var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

            });

            builder.Services.ConfigureTextGenerationSerivce();
            builder.Services.ConfigureRepositories();
            builder.Services.ConfigureSupervisor();
            builder.Services.AddConnectionProvider();
            builder.Services.AddCORS();

            var app = builder.Build();

            app.MapOpenApi();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();


            app.MapControllers();

            app.Run();
        }
    }

    public static class JsonConverters
    {
        public static DateOnlyConverter DateOnly = new DateOnlyConverter();
    }

    public class DateOnlyConverter: JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var formatted = value.ToString("yyyy-MM-dd");
            writer.WriteStringValue(formatted);
        }
    }
}
