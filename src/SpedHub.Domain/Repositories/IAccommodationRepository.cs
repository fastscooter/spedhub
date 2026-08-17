using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IAccommodationRepository : IDisposable
    {
        Task<List<Accommodation>> GetAll();
        Task<Accommodation> GetById(int? id);
        Task<List<Accommodation>> GetByStudentId(int studentId);
        Task<Accommodation> Add(Accommodation newAccommodation);
        Task<bool> Update(Accommodation accommodation);
        Task<bool> Delete(int id);

    }
}
