using Entities;
using RideAwayDl;
using System;
using System.Collections.Generic;
using System.Text;

namespace RideAwayBl
{
   public class StopBL : InterfaceStopBL
    {
        InterfaceStopDL IstopDL;
        public StopBL(InterfaceStopDL IstopDL)
        {
            this.IstopDL = IstopDL;
        }
        public List<Stop> GetStopsList()
        {
            return IstopDL.GetStopsList();
        }
    }
}
