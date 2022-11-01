using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class Camere
    {
        public Camere()
        {
            Platis = new HashSet<Plati>();
            Studentis = new HashSet<Studenti>();
        }

        public Guid IdCamera { get; set; }
        public string StatusCamera { get; set; } = null!;
        public int TotalLocuri { get; set; }
        public int LocuriOcupate { get; set; }
        public int LocuriLibere { get; set; }
        public Guid IdCamin { get; set; }
        public decimal PretCamera { get; set; }
        public string? Poza { get; set; }
        public string? NumeCam { get; set; }

        public virtual Camine IdCaminNavigation { get; set; } = null!;
        public virtual ICollection<Plati> Platis { get; set; }
        public virtual ICollection<Studenti> Studentis { get; set; }
    }
}
