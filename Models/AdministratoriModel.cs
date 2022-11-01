namespace PlanApp.Models
{
    public class AdministratoriModel
    {
        public Guid IdAdministrator { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid IdCamin { get; set; }
    }
}
