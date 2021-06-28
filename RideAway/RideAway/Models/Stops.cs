using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class Stops
    {
        public int StopId { get; set; }
        public int StopCode { get; set; }
        public string StopName { get; set; }
        public string StopDesc { get; set; }
        public double StopLat { get; set; }
        public double StopLon { get; set; }
        public int LocationType { get; set; }
        public string ParentStation { get; set; }
        public int ZoneId { get; set; }
    }
}
