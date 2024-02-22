using Microsoft.EntityFrameworkCore;
using Nutrition.Models;

namespace Nutrition
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<UserDetailsModel> UserDetails { get; set; }

        public DbSet<UserProgressDataModel> UserProgress { get; set; }

        
    }
}