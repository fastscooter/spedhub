using Microsoft.EntityFrameworkCore;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Repositories;

namespace SpedHub.Data.Repositories
{
    public class ServiceRepository: AbstractRepository, IServiceRepository
    {
        public ServiceRepository(SpedHubDbContext context) : base(context)
        {
        }

        public async Task<Service> Add(Service newService)
        {
            await Context.Services.AddAsync(newService);
            await Context.SaveChangesAsync();
            return newService;
        }
        public async Task<bool> Delete(int id)
        {
            if(!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Services.FindAsync(id);
            Context.Services.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Service>> GetAll() =>
            await Context.Services
            .Include(s => s.Student).AsNoTrackingWithIdentityResolution().ToListAsync();

        public async Task<Service> GetById(int? id) =>
            await Context.Services.FindAsync(id);
        public async Task<List<Service>> GetByStudentId(int id)
        {
            var student = await Context.Students
                .Include(s => s.Services)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            return [.. student.Services];
        }

        public async Task<bool> Update(Service goal)
        {
            if(!await Exists(goal.Id))
            {
                return false;
            }
            Context.Services.Update(goal);
            await Context.SaveChangesAsync();
            return true;

        }
        protected override async Task<bool> Exists(int id) =>
            await Context.Services.AnyAsync(x => x.Id == id);
    }
}
