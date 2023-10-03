using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class PassengerVesselFactory : VesselFactory
    {
        public override IVessel GetVessel()
        {
            PassengerVessel passengerVessel = new PassengerVessel();

            return passengerVessel;
        }
    }
}
