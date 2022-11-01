using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class Studenti
    {
        public Studenti()
        {
            Platis = new HashSet<Plati>();
        }

        public Guid IdStudent { get; set; }
        public string NumeStudent { get; set; } = null!;
        public string Mobil { get; set; } = null!;
        public string? Email { get; set; }
        public Guid IdCamera { get; set; }
        public string StatusPlata { get; set; } = null!;
        public decimal RestPlata { get; set; }

        public virtual Camere IdCameraNavigation { get; set; } = null!;
        public virtual ICollection<Plati> Platis { get; set; }
    }
}
