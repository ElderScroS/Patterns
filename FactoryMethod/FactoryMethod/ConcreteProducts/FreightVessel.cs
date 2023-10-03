using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class FreightVessel : IVessel
    {
        public readonly string m_name;
        public readonly double m_price;



        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double LoadCapacity { get; set; }
        public int QuantityOfDecks { get; set; }


        public FreightVessel()
        {
            m_name = "Freight Vessel";
            m_price = 400000;

            Width = 100;
            Height = 100;
            Length = 100;
            LoadCapacity = 10000;
            QuantityOfDecks = 20;
        }
        public FreightVessel(double price, double width, double height, double length, int quantityDecks, double loadCapacity)
        {
            this.m_name = "Freight Vessel";
            this.m_price = price;

            this.Width = width;
            this.Height = height;
            this.Length = length;
            this.QuantityOfDecks = quantityDecks;
            this.LoadCapacity = loadCapacity;
        }

        public string Name => m_name;
        public double GetVesselPrice() => m_price;
    }
}
