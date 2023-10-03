using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal interface IButton
    {
        string Name { get; }
        string Color { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        double Length { get; set; }

        void GetButtonProperties();
    }
}
