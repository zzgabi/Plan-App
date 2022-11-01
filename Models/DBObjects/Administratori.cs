using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class Administratori
    {
        public Guid IdAdministrator { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid IdCamin { get; set; }

        public virtual Camine IdCaminNavigation { get; set; } = null!;
    }
}
