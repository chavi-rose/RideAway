using Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace RideAwayDl
{
   public interface InterfacePassengerDL
    {
        void AddPassenger(Passenger passenger);
        List<Passenger> GetPassengers();
        int numOfPassengersDL();
    }
}
