using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IAreaRepository: IDisposable
    {

        Task<List<Area>> GetAll();
        Task<Area> GetById(int? id);
        Task<List<Area>> GetByStudentId(int studentId);
        Task<List<Area>> GetByDisabilityId(int disabilityId);
        Task<Area> Add(Area newArea);
        Task<bool> Update(Area area);
        Task<bool> Delete(int id);
    }
}
