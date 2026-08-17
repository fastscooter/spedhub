using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SpedHub.Domain.Supervisor;
using SpedHub.Domain.Text;

namespace SpedHub.UI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GenerateController: ControllerBase
    {
        private readonly ISpedHubTextGenerationService _textGenerator;

        public GenerateController(ISpedHubTextGenerationService textGenerator)
        {
            this._textGenerator = textGenerator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GenerateIntroduction(int id)
        {

            //var text = await _textGenerator.GenerateIntroduction(id);
            var text = @"
# Qualifications

# Present Levels

";

            return Content(text, "text/markdown");
        }

    }
}
