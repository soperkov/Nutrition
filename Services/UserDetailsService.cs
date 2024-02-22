using Nutrition.Models;

namespace Nutrition.Services
{
    public class UserDetailsService
    {
        private readonly AppDbContext _context;
        public UserDetailsService(AppDbContext context)
        {
            _context = context;
        }
        public UserDetailsModel GetUserDetails(UserModel user)
        {
            return _context.UserDetails.FirstOrDefault(x => x.UserId == user.Id);
        }

        public void AddUserDetails(int userId, UserDetailsModel details)
        {
            details.UserId = userId;
            _context.UserDetails.Add(details);
            _context.SaveChanges();
        }

        public UserDetailsModel GetUserDetails(int userId)
        {
            return _context.UserDetails.FirstOrDefault(x => x.UserId == userId);
        }

        public void UpdateUserDetails(int userId, UserDetailsModel updatedDetails)
        {
            UserDetailsModel user = _context.UserDetails.FirstOrDefault(u => u.UserId == userId);

            if (user != null)
            {
                user.Height = updatedDetails.Height;
                user.Weight = updatedDetails.Weight;
                user.Years = updatedDetails.Years;

                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("User not found");
            }
        }
    }
}
