using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IGoalRepository: IDisposable
    {
        Task<List<Goal>> GetAll();
        Task<Goal> GetById(int? id);
        Task<List<Goal>> GetByStudentId(int id);
        Task<Goal> Add(Goal newGoal);
        Task<bool> Update(Goal goal);
        Task<bool> Delete(int id);
    }
}
