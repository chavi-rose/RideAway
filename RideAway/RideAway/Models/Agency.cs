using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class Agency
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string AgencyUrl { get; set; }
        public string AgencyTimezone { get; set; }
        public string AgencyLang { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyFareUrl { get; set; }
    }
}
