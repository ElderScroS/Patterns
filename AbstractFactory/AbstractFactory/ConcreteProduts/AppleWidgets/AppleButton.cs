using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class AppleButton : IButton
    {
        private string m_name = null;

        public string Color { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public AppleButton()
        {
            this.m_name = "Apple Button";
            this.Color = "Grey";
            this.Height = 20;
            this.Width = 10;
            this.Length = 10;
        }
        public AppleButton(string name, string color, double width, double height, double length)
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