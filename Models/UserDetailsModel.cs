using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Nutrition.Models
{
    public class UserDetailsModel
    {
        [Key]public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Years { get; set; }
        public string Sex { get; set; } 
    }
}
