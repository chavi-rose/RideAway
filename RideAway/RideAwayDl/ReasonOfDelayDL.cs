using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAwayDl
{
   public class ReasonOfDelayDL : InterfaceReasonOfDelayDL
    {

        public List<ReasonOfDelay> GetAll()
        {
            using (var db = new RideAwayContext())
            {
             return db.ReasonOfDelays.ToList();
            }
        }
    }
}
