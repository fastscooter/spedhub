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
    public class GoalRepository : AbstractRepository, IGoalRepository
    {
        public GoalRepository(SpedHubDbContext context) : base(context)
        {
        }
        public async Task<Goal> Add(Goal newGoal)
        {
            await Context.Goals.AddAsync(newGoal);
            await Context.SaveChangesAsync();
            return newGoal;
        }
        public async Task<bool> Delete(int id)
        {
            if(!await Exists(id))
            {
                return false;
            }
            var toRemove = await Context.Goals.FindAsync(id);
            Context.Goals.Remove(toRemove);
            await Context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Goal>> GetAll() =>
            await Context.Goals
            .Include(s => s.Student).AsNoTrackingWithIdentityResolution().ToListAsync();

        public async Task<Goal> GetById(int? id) =>
            await Context.Goals.FindAsync(id);
        public async Task<List<Goal>> GetByStudentId(int id)
        {
            var student = await Context.Students
                .Include(s => s.Goals)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            return [.. student.Goals];
        }

        public async Task<bool> Update(Goal goal)
        {
            if(!await Exists(goal.Id))
            {
                return false;
            }
            Context.Goals.Update(goal);
            await Context.SaveChangesAsync();
            return true;

        }
        protected override async Task<bool> Exists(int id) =>
            await Context.Goals.AnyAsync(x => x.StudentId == id);
    }
}
