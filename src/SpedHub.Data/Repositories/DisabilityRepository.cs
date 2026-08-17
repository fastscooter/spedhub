using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Repositories;

namespace SpedHub.Data.Repositories
{
    public class DisabilityRepository: AbstractRepository, IDisabilityRepository
    {
        public DisabilityRepository(SpedHubDbContext context) : base(context)
        {
        }

        public async Task<Disability> Add(Disability newDisability)
        {
            await Context.Disabilities.AddAsync(newDisability);
            await Context.SaveChangesAsync();
            return newDisability;
        }
        public async Task<bool> Delete(int id)
        {
            if (!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Disabilities.FindAsync(id);
            Context.Disabilities.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Disability>> GetAll() =>
            await Context.Disabilities.AsNoTrackingWithIdentityResolution().ToListAsync();

        public async Task<Disability> GetById(int? id)
        {
            var disability = await Context.Disabilities.FindAsync(id);
            return disability;
        }
        public async Task<List<Disability>> GetByStudentId(int studentId) => await Context.Disabilities
                .Include(x => x.Areas)
                .Where(d => d.StudentId == studentId)
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
        public async Task<bool> Update(Disability disability)
        {
            if(!await Exists(disability.Id))
            {
                return false;
            }
            Context.Disabilities.Update(disability);
            await Context.SaveChangesAsync();
            return true;

        }

        protected override async Task<bool> Exists(int id) =>
            await Context.Disabilities.AnyAsync(a => a.Id == id);
    }
}
