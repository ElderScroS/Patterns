using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class UnidentifiedVesselFactory : VesselFactory
    {
        public override IVessel GetVessel()
        {
            UnidentifiedVessel unidentifiedVessel = new UnidentifiedVessel();

            return unidentifiedVessel;
        }
    }
}
