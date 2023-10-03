using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal interface IProcessor
    {
        string Name { get; }
        double Frequency { get; set; }
        int Cores { get; set; }
        string PublishingDate { get; set; }

        void GetProcessorProperties();
    }
}
