using Microsoft.EntityFrameworkCore;

namespace GoalTrackerServices
{
    public class GoalServices
    {

        private readonly AppDbContext _db;
        public GoalServices(AppDbContext db)
        {
            _db= db;
        }

    

        public async Task CreateGoal(String ?title = null,String ?desc= null,String ?CompleteCondition= null)
        {
            var goal =new Goal{Desc=desc,Title= title,CompleteCondition=CompleteCondition};
            _db.Goals.Add(goal);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Goal>> GetGoals()
        {
            return await _db.Goals.ToListAsync();
        }
    }
}