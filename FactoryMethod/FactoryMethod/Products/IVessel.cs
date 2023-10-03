using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal interface IVessel
    {
        string Name { get; }
        double Width { get; set; }
        double Length { get; set; }
        double Height { get; set; }
        double LoadCapacity { get; set; }
        int QuantityOfDecks { get; set; }

        double GetVesselPrice();
    }
}
