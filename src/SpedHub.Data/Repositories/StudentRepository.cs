using Microsoft.EntityFrameworkCore;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Repositories;

namespace SpedHub.Data.Repositories
{
    public class StudentRepository: AbstractRepository, IStudentRepository
    {
        public StudentRepository(SpedHubDbContext context) : base(context)
        {
        }
        public async Task<Student> Add(Student newStudent)
        {
            await Context.Students.AddAsync(newStudent);
            await Context.SaveChangesAsync();
            return newStudent;
        }
        public async Task<bool> Delete(int id)
        {
            if(!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Students.FindAsync(id);
            Context.Students.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Student>> GetAll() =>
            await Context.Students
            .Include(s => s.Accommodations)
            .Include(s => s.Services)
            .Include(s => s.Disabilities)
            .Include(s => s.Goals).ToListAsync();

        public async Task<Student> GetById(int? id) =>
            (await GetAll()).FirstOrDefault(s => s.Id == id);

        public async Task<bool> Update(Student student)
        {
            if(!await Exists(student.Id))
            {
                return false;
            }
            Context.Students.Update(student);
            await Context.SaveChangesAsync();
            return true;

        }
        protected override async Task<bool> Exists(int id) =>
            await Context.Students.AnyAsync(x => x.Id == id);



    }
}
