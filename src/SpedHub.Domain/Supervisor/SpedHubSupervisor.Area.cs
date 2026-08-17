using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpedHub.Domain.ApiModels;

namespace SpedHub.Domain.Supervisor
{
    public partial class SpedHubSupervisor
    {
        public async Task<IEnumerable<AreaApiModel>> GetAllAreas()
        {
            var areas = await _areaRepository.GetAll();

            return areas.ConvertAll();
        }
    }
}
