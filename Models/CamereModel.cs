namespace PlanApp.Models
{
    public class CamereModel
    {
        public Guid IdCamera { get; set; }
        public string StatusCamera { get; set; } = null!;
        public int TotalLocuri { get; set; }
        public int LocuriOcupate { get; set; }
        public int LocuriLibere { get; set; }
        public Guid IdCamin { get; set; }
        public decimal PretCamera { get; set; }
        public string? Poza { get; set; }
        public string? NumeCam { get; set; }
    }
}
