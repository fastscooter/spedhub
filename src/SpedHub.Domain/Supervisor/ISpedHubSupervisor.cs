using SpedHub.Domain.ApiModels;

namespace SpedHub.Domain.Supervisor
{
    public interface ISpedHubSupervisor
    {
        // Disability
        Task<IEnumerable<DisabilityApiModel>> GetAllDisabilities();

        Task<DisabilityApiModel?> GetDisabilityById(int id);

        Task<IEnumerable<DisabilityApiModel>> GetDisabilitiesByStudentId(int studentId);

        //Goal
        Task<IEnumerable<GoalApiModel>> GetAllGoals();

        Task<GoalApiModel?> GetGoalById(int id);

        Task<IEnumerable<GoalApiModel>> GetGoalsByStudentId(int studentId);

        // Service

        Task<IEnumerable<ServiceApiModel>> GetAllServices();

        Task<ServiceApiModel?> GetServiceById(int? id);

        Task<IEnumerable<ServiceApiModel>> GetServicesByStudentId(int studentId);

        // Student
        Task<IEnumerable<StudentApiModel>> GetAllStudents();

        Task<StudentApiModel?> GetStudentById(int id);

        // Accommodation
        Task<IEnumerable<AccommodationApiModel>> GetAllAccommodations();

        Task<AccommodationApiModel> GetAccommodationById(int id);

        Task<IEnumerable<AccommodationApiModel>> GetAccommodationsByStudentId(int studentId);

        //Area
        Task<IEnumerable<AreaApiModel>> GetAllAreas();
        Task<IEnumerable<AreaApiModel>> GetAreasByDisabilityId(int disabilityId);
        Task<IEnumerable<AreaApiModel>> GetAreaById(int areaId);

    }
}
