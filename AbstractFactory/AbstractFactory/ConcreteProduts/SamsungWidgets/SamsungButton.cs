using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class SamsungButton :IButton
    {
        private string m_name = null;

        public string Color { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public SamsungButton()
        {
            this.m_name = "Samsung Button";
            this.Color = "Red";
            this.Height = 10;
            this.Width = 15;
            this.Length = 10;
        }
        public SamsungButton(string name, string color, double width, double height, double length)
        {
            m_name = name;
            Color = color;
            Width = width;
            Height = height;
            Length = length;
        }

        public string Name => m_name;

        public void GetButtonProperties()
        {
            if (m_name == null)
                Console.WriteLine("Error!!!");
            else
            {
                Console.WriteLine($"Name - {Name}");
                Console.WriteLine($"Color - {Color}");
                Console.WriteLine($"Width   - {Width}");
                Console.WriteLine($"Height - {Height}");
                Console.WriteLine($"Length - {Length}");
            }
        }
    }
}
