using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class Trips1
    {
        public int RouteId { get; set; }
        public int ServiceId { get; set; }
        public string TripId { get; set; }
        public string TripHeadsign { get; set; }
        public int DirectionId { get; set; }
        public int ShapeId { get; set; }
    }
}
