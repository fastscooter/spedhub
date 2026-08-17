using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IServiceRepository: IDisposable
    {
        Task<List<Service>> GetAll();
        Task<Service> GetById(int? id);
        Task<List<Service>> GetByStudentId(int studentId);
        Task<Service> Add(Service newService);
        Task<bool> Update(Service service);
        Task<bool> Delete(int id);
    }
}
