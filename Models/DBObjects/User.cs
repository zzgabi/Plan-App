using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class User
    {
        public Guid IdUser { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
