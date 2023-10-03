using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal interface IFactory
    {
        IButton CreateButton();
        IProcessor CreateProcessor();
        IScreen CreateScreen();
        IPhone CreatePhone();
        IPhone CreatePhone(string model, int memory, IProcessor processor, IScreen screen, bool Case, IButton button, double price);
    }
}
