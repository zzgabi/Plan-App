using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class Plati
    {
        public Guid IdPlata { get; set; }
        public Guid IdCamin { get; set; }
        public Guid IdStudent { get; set; }
        public DateTime Data { get; set; }
        public Guid IdCamera { get; set; }

        public virtual Camere IdCameraNavigation { get; set; } = null!;
        public virtual Camine IdCaminNavigation { get; set; } = null!;
        public virtual Studenti IdStudentNavigation { get; set; } = null!;
    }
}
