using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AppleFactory : IFactory
    {
        public IButton CreateButton() => new AppleButton();
        public IProcessor CreateProcessor() => new AppleProcessor();
        public IScreen CreateScreen() => new AppleScreen();
        public IPhone CreatePhone() => new ApplePhone();
        public IPhone CreatePhone(string model, int memory, IProcessor processor, IScreen screen, bool Case, IButton button, double price)
        {
            return new ApplePhone(model, memory, processor, screen, Case, button, price);
        }
    }
}
