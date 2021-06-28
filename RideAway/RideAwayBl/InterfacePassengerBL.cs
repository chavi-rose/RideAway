
using System;
using System.Collections.Generic;
using System.Text;
using Entities;


namespace RideAwayBl
{
  public  interface InterfacePassengerBL
    {
     void AddPassenger(Passenger passanger);
        List<Passenger> GetPassengers();
        int numOfPassengersBL();
    }
}
//desktop - iquc79o.RideAway.dbo