using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class SamsungFactory : IFactory
    {
        public IButton CreateButton() => new SamsungButton();
        public IProcessor CreateProcessor() => new SamsungProcessor();
        public IScreen CreateScreen() => new SamsungScreen();
        public IPhone CreatePhone() => new SamsungPhone();
        public IPhone CreatePhone(string model, int memory, IProcessor processor, IScreen screen, bool Case, IButton button, double price)
        {
            return new SamsungPhone(memory, model, processor, screen, Case, button, price); ;
        }
    }
}
