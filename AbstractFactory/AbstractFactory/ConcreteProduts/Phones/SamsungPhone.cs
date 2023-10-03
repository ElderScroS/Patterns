using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace AbstractFactory
{
    internal class SamsungPhone : IPhone
    {
        private string m_name;
        private double m_price;

        public bool Case { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public IProcessor Processor { get; set; }
        public IScreen Screen { get; set; }
        public IButton Button { get; set; }

        public SamsungPhone()
        {
            this.m_name = "Samsung Phone";
            this.Model = "Samsung S8+";
            this.m_price = 1200;
            this.Memory = 64;
        }
        public SamsungPhone(int memory, string model, IProcessor processor, IScreen screen, bool Case, IButton button, double price)
        {
            this.m_name = "Samsung Phone";
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
