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
        public async Task<ServiceApiModel?> GetServiceById(int? id)
        {
            var service = await _serviceRepository.GetById(id);
            return service.Convert();
        }
        public async Task<IEnumerable<ServiceApiModel>> GetServicesByStudentId(int studentId)
        {
            var services = await _serviceRepository.GetByStudentId(studentId);
            return services.ConvertAll();
        }

        public async Task<IEnumerable<ServiceApiModel>> GetAllServices()
        {
            var services = await _serviceRepository.GetAll();
            return services.ConvertAll();
        }

    }
}
