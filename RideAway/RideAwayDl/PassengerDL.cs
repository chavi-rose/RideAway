using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAwayDl
{
    public class PassengerDL : InterfacePassengerDL
    {
        //InterfaceRideAwayContextDL IRideAwayContextDL;
        //public PassengerDL(InterfaceRideAwayContextDL IRideAwayContextDL)
        //{
        //    this.IRideAwayContextDL = IRideAwayContextDL;
        //}
        public void AddPassenger(Passenger passenger)
        {
            using (var db = new RideAwayContext())
            {
                db.Passengers.Add(passenger);
                db.SaveChanges();
            }
        }

        public List<Passenger> GetPassengers()
        {
            using (var db = new RideAwayContext())
            {
                return db.Passengers.ToList();
            }
        }
        public int numOfPassengersDL()
        {
            using (var db = new RideAwayContext())
            {
                return db.Passengers.Count();
            }
        }
    }
}
