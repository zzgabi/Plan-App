using System;
using System.Collections.Generic;

namespace PlanApp.Models.DBObjects
{
    public partial class AdminManagement
    {
        public Guid IdStatus { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } = null!;
        public string? Email { get; set; }
        public string? Mesaj { get; set; }
    }
}
