using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class Camine
    {
        public Camine()
        {
            Administratoris = new HashSet<Administratori>();
            Cameres = new HashSet<Camere>();
            Platis = new HashSet<Plati>();
        }

        public Guid IdCamin { get; set; }
        public string NumeCamin { get; set; } = null!;
        public string Oras { get; set; } = null!;
        public string AdresaCamin { get; set; } = null!;
        public int NrCamere { get; set; }
        public string? Foto { get; set; }

        public virtual ICollection<Administratori> Administratoris { get; set; }
        public virtual ICollection<Camere> Cameres { get; set; }
        public virtual ICollection<Plati> Platis { get; set; }
    }
}
