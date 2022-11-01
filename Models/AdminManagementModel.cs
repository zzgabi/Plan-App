using System.ComponentModel.DataAnnotations;

namespace PlanApp.Models
{
    public class AdminManagementModel
    {
        public Guid IdStatus { get; set; }
        [DisplayFormat(DataFormatString = "0:MM/dd/yyyy")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public string Status { get; set; } = null!;
        public string? Email { get; set; }
        public string? Mesaj { get; set; }
    }
}
