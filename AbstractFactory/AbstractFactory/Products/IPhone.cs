using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal interface IPhone
    {
        string Name { get; }
        double Price { get; }
        string Model { get; set; }
        bool Case { get; set; }
        int Memory { get; set; }
        IProcessor Processor { get; set; }
        IScreen Screen { get; set; }
        IButton Button { get; set; }

        double GetPrice();
    }
}
