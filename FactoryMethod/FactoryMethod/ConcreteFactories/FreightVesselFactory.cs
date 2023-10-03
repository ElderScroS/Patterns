using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class FreightVesselFactory : VesselFactory
    {
        public override IVessel GetVessel()
        {
            FreightVessel freightVessel = new FreightVessel();

            return freightVessel;
        }
    }
}
