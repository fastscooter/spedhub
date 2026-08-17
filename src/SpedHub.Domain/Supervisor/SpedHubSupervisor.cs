using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Repositories;

namespace SpedHub.Domain.Supervisor
{
    public partial class SpedHubSupervisor: ISpedHubSupervisor
    {
        private readonly IDisabilityRepository _disabilityRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IAccommodationRepository _accommodationRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly IAreaRepository _areaRepository;

        public SpedHubSupervisor(IDisabilityRepository disabilityRepository,
                                 IStudentRepository studentRepository,
                                 IGoalRepository goalRepository,
                                 IAccommodationRepository accommodationRepository,
                                 IServiceRepository serviceRepository,
                                 IAreaRepository areaRepository)
        {
            _disabilityRepository = disabilityRepository;
            _studentRepository = studentRepository;
            _goalRepository = goalRepository;
            _accommodationRepository = accommodationRepository;
            _serviceRepository = serviceRepository;
            _areaRepository = areaRepository;
        }

    }
}
