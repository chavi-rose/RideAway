using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class ReasonOfDelay
    {
        public int ReasonId { get; set; }
        public string ReasonDescription { get; set; }
        public bool? IsResetWaitingTime { get; set; }
    }
}
