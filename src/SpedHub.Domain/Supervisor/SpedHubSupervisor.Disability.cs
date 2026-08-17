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
        public async Task<IEnumerable<DisabilityApiModel>> GetAllDisabilities()
        {
            var disabilities = await _disabilityRepository.GetAll();
            return disabilities.ConvertAll();
        }

        public async Task<DisabilityApiModel?> GetDisabilityById(int id)
        {
            var disability = await _disabilityRepository.GetById(id);
            return disability.Convert();
        }

        public async Task<IEnumerable<DisabilityApiModel>> GetDisabilitiesByStudentId(int studentId)
        {
            var disabilities = await _disabilityRepository.GetByStudentId(studentId);
            return disabilities.ConvertAll();
        }
    }
}
