using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public bool IsActive { get; set; }
        public int? FromStopId { get; set; }
        public int? ToStopId { get; set; }
    }
}
