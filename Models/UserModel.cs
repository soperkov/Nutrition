using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel.DataAnnotations;

namespace Nutrition.Models
{
    public class UserModel
    {
        [Key]public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; } 

    }
}
