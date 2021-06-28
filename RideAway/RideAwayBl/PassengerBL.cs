
using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using RideAwayDl;

namespace RideAwayBl
{
   public class PassengerBL : InterfacePassengerBL
    {

        InterfacePassengerDL IPassengerDL;
        public PassengerBL(InterfacePassengerDL IPassengerDL)
        {
            this.IPassengerDL = IPassengerDL;
        }

        public void AddPassenger(Passenger passanger)
        {
            //ToDo check if the passenger already in the table.
             IPassengerDL.AddPassenger(passanger);
        }

        public List<Passenger> GetPassengers()
        {
            return IPassengerDL.GetPassengers();
        }
        public int numOfPassengersBL()
        {
           return IPassengerDL.numOfPassengersDL();
        }
    }
}
