using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Extensions;

namespace SpedHub.Domain.Supervisor
{
    public partial class SpedHubSupervisor
    {
        public async Task<IEnumerable<GoalApiModel>> GetAllGoals()
        {
            var goals = await _goalRepository.GetAll();
            return goals.ConvertAll();
        }


        public async Task<GoalApiModel?> GetGoalById(int id)
        {
            var goal = await _goalRepository.GetById(id);
            return goal.Convert();
        }

        public async Task<IEnumerable<GoalApiModel>> GetGoalsByStudentId(int studentId)
        {
            var goals = await _goalRepository.GetByStudentId(studentId);
            return goals.ConvertAll();
        }
    }
}
