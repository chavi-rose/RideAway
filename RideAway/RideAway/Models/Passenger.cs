using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class Passenger
    {
        public int Id { get; set; }
        public int? IdentityNumber { get; set; }
        public string RavKavId { get; set; }
        public DateTime ValidationDate { get; set; }
        public int? ReasonOfDelayId { get; set; }
        public int SourceStationId { get; set; }
        public int? DestinationStationId { get; set; }
        public int? DestinationRouteId { get; set; }
    }
}
