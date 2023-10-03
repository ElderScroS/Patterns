using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class SpecializedVessel : IVessel
    {
        public readonly string m_name;
        public readonly double m_price;


        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double LoadCapacity { get; set; }
        public int QuantityOfDecks { get; set; }


        public SpecializedVessel()
        {
            m_name = "Specialized Vessel";  
            m_price = 600000;

            Width = 70;
            Height = 80;
            Length = 150;
            QuantityOfDecks = 10;
            LoadCapacity = 4000;
        }
        public SpecializedVessel(double price, double width, double height, double length, int quantityDecks, double loadCapacity)
        {
            this.m_name = "Specialized Vessel";
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
