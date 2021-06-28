using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAwayDl
{
  public  class StopDL : InterfaceStopDL
    {


        public List<Stop> GetStopsList()
        {
            using (var db = new RideAwayContext())
            {
                return db.Stops.ToList();
            }
        }

        List<Stop> InterfaceStopDL.GetStopsList()
        {
            throw new NotImplementedException();
        }
    }
}
