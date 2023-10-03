using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace AbstractFactory
{
    internal class ApplePhone : IPhone
    {
        private string m_name;
        private double m_price;

        public bool Case { get; set; }
        public int Memory { get; set; }
        public string Model { get; set; }
        public IProcessor Processor { get; set; }
        public IScreen Screen { get; set; }
        public IButton Button { get; set; }

        public ApplePhone()
        {
            this.m_name = "Apple Phone";
            this.Model = "Iphone 10 Pro Max";
            this.Memory = 64;
            this.m_price = 2000;
        }
        public ApplePhone(string model, int memory, IProcessor processor, IScreen screen, bool Case, IButton button, double price)
        {
            this.m_name = "Apple Phone";
            this.m_price = price;

            this.Memory = memory;
            this.Model = model;
            this.Processor = processor;
            this.Screen = screen;
            this.Case = Case;
            this.Button = button;
        }

        public string Name => m_name;
        public double Price => m_price;

        public double GetPrice() => Price;
    }
}
