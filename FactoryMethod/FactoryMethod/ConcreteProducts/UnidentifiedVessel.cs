using System;
using System.Collections.Generic;

namespace FactoryMethod
{ 
    internal class UnidentifiedVessel : IVessel
    {
        public readonly string m_name;
        public readonly double m_price;


        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double LoadCapacity { get; set; }
        public int QuantityOfDecks { get; set; }


        public UnidentifiedVessel()
        {
            m_name = "Unidentified Vessel";
            Width = 0;
            Height = 0;
            Length = 0;
            m_price = 0;
            QuantityOfDecks = 0;
            LoadCapacity = 0;
        }
        public UnidentifiedVessel(double price, double width, double height, double length, int quantityDecks, double loadCapacity)
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
