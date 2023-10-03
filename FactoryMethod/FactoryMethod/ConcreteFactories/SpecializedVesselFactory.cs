using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class SpecializedVesselFactory : VesselFactory
    {
        public override IVessel GetVessel()
        {
            SpecializedVessel specializedVessel = new SpecializedVessel();

            return specializedVessel;
        }
    }
}
