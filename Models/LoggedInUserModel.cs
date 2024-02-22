namespace Nutrition.Models
{
    public class LoggedInUserModel
    {
        public int Id { get; set; }
        public UserDetailsModel Details { get; set; }


        public void Reset()
        {
            Id = 0;
            Details = null;
        }
    }

}
