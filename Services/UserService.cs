using Nutrition.Models;

namespace Nutrition.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context) {
            _context = context;
        }

        public void CreateUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserModel GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username);
        }

        public UserModel Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
