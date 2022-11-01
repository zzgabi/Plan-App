namespace PlanApp.Models
{
    public class StudentiModel
    {
        public Guid IdStudent { get; set; }
        public string NumeStudent { get; set; } = null!;
        public string Mobil { get; set; } = null!;
        public string? Email { get; set; }
        public Guid IdCamera { get; set; }
        public string StatusPlata { get; set; } = null!;
        public decimal RestPlata { get; set; }
    }
}
