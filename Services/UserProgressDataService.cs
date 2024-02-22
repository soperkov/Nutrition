using Nutrition.Models;

namespace Nutrition.Services
{
    public class UserProgressDataService
    {
        private readonly AppDbContext _context;
        public UserProgressDataService(AppDbContext context)
        {
            _context = context;
        }

        public List<UserProgressDataModel> GetUserProgressData(int userId)
        {
            var result = _context.UserProgress.Where(u => u.UserId == userId).ToList();
            return result;
        }

        public void AddUserProgressDataDetails(int userId, UserProgressDataModel data)
        {
            data.UserId = userId;
            _context.UserProgress.Add(data);
            _context.SaveChanges();
        }

        
    }
}
