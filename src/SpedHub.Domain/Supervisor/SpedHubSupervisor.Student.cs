using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Extensions;

namespace SpedHub.Domain.Supervisor
{
    public partial class SpedHubSupervisor
    {
        public async Task<IEnumerable<StudentApiModel>> GetAllStudents()
        {
            var students = await _studentRepository.GetAll();
            return students.ConvertAll();
        }

        public async Task<StudentApiModel?> GetStudentById(int id)
        {
            var allStudents = await _studentRepository.GetAll();
            var student = allStudents.First(s => s.Id == id);
            var converted = student.Convert();
            return converted;
        }
    }
}
