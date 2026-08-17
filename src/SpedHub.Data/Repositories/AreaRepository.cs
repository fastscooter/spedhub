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
    public class AreaRepository: AbstractRepository, IAreaRepository
    {

        public AreaRepository(SpedHubDbContext context) : base(context)
        {
        }

        public async Task<Area> Add(Area newArea)
        {
            await Context.Areas.AddAsync(newArea);
            await Context.SaveChangesAsync();
            return newArea;
        }
        public async Task<bool> Delete(int id)
        {
            if(!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Areas.FindAsync(id);
            Context.Areas.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Area>> GetAll() =>
            await Context.Areas.AsNoTrackingWithIdentityResolution().ToListAsync();


        public async Task<List<Area>> GetByDisabilityId(int disabilityId)
        {
            List<Area> result = await Context.Areas.ToListAsync();

            return [.. result.Where(x => x.DisabilityId == disabilityId)];

        }
        public Task<Area> GetById(int? id) => throw new NotImplementedException();
        public Task<List<Area>> GetByStudentId(int studentId) => throw new NotImplementedException();
        public Task<bool> Update(Area area) => throw new NotImplementedException();
        protected override Task<bool> Exists(int id) => throw new NotImplementedException();
    }
}
