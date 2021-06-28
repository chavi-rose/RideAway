using Entities;
using RideAwayDl;
using System;
using System.Collections.Generic;
using System.Text;

namespace RideAwayBl
{
    public class ReasonOfDelayBL : InterfaceReasonOfDelayBL
    {
        InterfaceReasonOfDelayDL IReasonOfDelayDL;
        public ReasonOfDelayBL(InterfaceReasonOfDelayDL IReasonOfDelayDL)
        {
            this.IReasonOfDelayDL = IReasonOfDelayDL;
        }
        public List<ReasonOfDelay> GetAll()
        {
            return IReasonOfDelayDL.GetAll();
        }
    }
}
