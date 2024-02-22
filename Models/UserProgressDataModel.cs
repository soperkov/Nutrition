using System.ComponentModel.DataAnnotations;

namespace Nutrition.Models
{
    public class UserProgressDataModel
    {
        [Key]public int Id { get; set; }
        public int UserId { get; set; }
        public double BMI { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Years { get; set; }
        public DateTime DateOfMeasures { get; set; }
    }
}
