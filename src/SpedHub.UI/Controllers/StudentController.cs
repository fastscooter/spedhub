using Microsoft.AspNetCore.Mvc;
using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Supervisor;

namespace SpedHub.UI.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class StudentController: ControllerBase
    {
        private readonly ISpedHubSupervisor _supervisor;
        public StudentController(ISpedHubSupervisor supervisor)
        {
            _supervisor = supervisor;
        }



        /// <summary>
        /// Gets All Students in the Database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<StudentApiModel>>> Get()
        {
            try
            {
                var students = await _supervisor.GetAllStudents();

                return new ObjectResult(students);
            }
            catch(Exception ex)
            {
                var message = ex.Message;
                return StatusCode(500, message);
            }
        }

    }
}
