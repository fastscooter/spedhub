using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Extensions;

namespace SpedHub.Domain.Supervisor
{
    public partial class SpedHubSupervisor
    {
        public async Task<AccommodationApiModel> GetAccommodationById(int id) =>
            (await _accommodationRepository.GetById(id)).Convert();
        public async Task<IEnumerable<AccommodationApiModel>> GetAccommodationsByStudentId(int studentId)
        {
            var accommodations = await _accommodationRepository.GetByStudentId(studentId);
            return accommodations.ConvertAll();
        }
        public async Task<IEnumerable<AccommodationApiModel>> GetAllAccommodations()
        {
            List<Accommodation> accommodations = await _accommodationRepository.GetAll();
            return accommodations.ConvertAll();
        }
    }
}
