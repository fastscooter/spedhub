using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IDisabilityRepository: IDisposable
    {

        Task<List<Disability>> GetAll();
        Task<Disability> GetById(int? id);
        Task<List<Disability>> GetByStudentId(int studentId);
        Task<Disability> Add(Disability newDisability);
        Task<bool> Update(Disability disability);
        Task<bool> Delete(int id);

    }
}
