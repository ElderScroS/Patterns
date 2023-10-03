using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal abstract class VesselFactory
    {
        public abstract IVessel GetVessel();
    }
}
