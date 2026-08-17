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
    public class AccommodationRepository: AbstractRepository, IAccommodationRepository
    {
        public AccommodationRepository(SpedHubDbContext context) : base(context)
        {
        }

        public async Task<Accommodation> Add(Accommodation newAccommodation)
        {
            await Context.Accommodations.AddAsync(newAccommodation);
            await Context.SaveChangesAsync();
            return newAccommodation;
        }
        public async Task<bool> Delete(int id)
        {
            if(!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Accommodations.FindAsync(id);
            Context.Accommodations.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Accommodation>> GetAll() =>
            await Context.Accommodations
            .Include(s => s.Student).AsNoTrackingWithIdentityResolution().ToListAsync();

        public async Task<Accommodation> GetById(int? id) =>
            await Context.Accommodations.FindAsync(id);
        public async Task<List<Accommodation>> GetByStudentId(int id)
        {
            var student = await Context.Students
                .Include(s => s.Accommodations)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            return [.. student.Accommodations];
        }

        public async Task<bool> Update(Accommodation goal)
        {
            if(!await Exists(goal.Id))
            {
                return false;
            }
            Context.Accommodations.Update(goal);
            await Context.SaveChangesAsync();
            return true;

        }
        protected override async Task<bool> Exists(int id) =>
            await Context.Accommodations.AnyAsync(x => x.Id == id);
    }
}
