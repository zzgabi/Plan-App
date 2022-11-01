namespace PlanApp.Models
{
    public class UserModel
    {
        public Guid IdUser { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
