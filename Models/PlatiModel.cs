using System.ComponentModel.DataAnnotations;

namespace PlanApp.Models
{
    public class PlatiModel
    {
        public Guid IdPlata { get; set; }
        public Guid IdCamin { get; set; }
        public Guid IdStudent { get; set; }
        [DisplayFormat(DataFormatString = "0:MM/dd/yyyy")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public Guid IdCamera { get; set; }
    }
}
