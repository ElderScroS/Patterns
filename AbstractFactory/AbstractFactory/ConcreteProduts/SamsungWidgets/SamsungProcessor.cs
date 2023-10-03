using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class SamsungProcessor : IProcessor
    {
        private string m_name = null;

        public SamsungProcessor()
        {
            this.m_name = "MediaTec";
            this.Frequency = 2.24;
            this.Cores = 8;
            this.PublishingDate = DateTime.Now.ToString();
        }
        public SamsungProcessor(string name, double frequency, int cores, string publishingDate)
        {
            this.m_name = name;
            this.Frequency = frequency;
            this.Cores = cores;
            this.PublishingDate = publishingDate;
        }

        public string Name => m_name;
        public double Frequency { get; set; }
        public int Cores { get; set; }
        public string PublishingDate { get; set; }

        public void GetProcessorProperties()
        {
            if (m_name == null)
                Console.WriteLine("Error!!!");
            else
            {
                Console.WriteLine($"Name - {Name}");
                Console.WriteLine($"Frequency - {Frequency} HZ");
                Console.WriteLine($"Cores - {Cores}");
                Console.WriteLine($"Publicshing Date - {PublishingDate}");
            }
        }
    }
}
