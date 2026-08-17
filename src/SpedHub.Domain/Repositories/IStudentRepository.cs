using SpedHub.Domain.Entities;

namespace SpedHub.Domain.Repositories
{
    public interface IStudentRepository: IDisposable
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int? id);
        Task<Student> Add(Student newStudent);
        Task<bool> Update(Student student);
        Task<bool> Delete(int id);
    }
}
