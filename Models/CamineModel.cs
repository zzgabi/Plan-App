namespace PlanApp.Models
{
    public class CamineModel
    {
        public Guid IdCamin { get; set; }
        public string NumeCamin { get; set; } = null!;
        public string Oras { get; set; } = null!;
        public string AdresaCamin { get; set; } = null!;
        public int NrCamere { get; set; }
        public string? Foto { get; set; }
    }
}
