using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class StopTimes
    {
        public string TripId { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public int StopId { get; set; }
        public int StopSequence { get; set; }
        public int PickupType { get; set; }
        public int DropOffType { get; set; }
        public int ShapeDistTraveled { get; set; }
    }
}
