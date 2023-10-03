using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class PassengerVessel : IVessel
    {
        public readonly string m_name;
        public readonly double m_price;


        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public int QuantityOfDecks { get; set; }
        public double LoadCapacity { get; set; }

        public PassengerVessel() 
        {
            m_name = "Passenger Vessel";
            m_price = 150000;

            Width = 50;
            Height = 50;
            Length = 50;
            QuantityOfDecks = 15;
            LoadCapacity = 2000;
        }
        public PassengerVessel(double price, double width, double height, double length, int quantityDecks, double loadCapacity)
        {
            this.m_name = "Passenger Vessel";
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
