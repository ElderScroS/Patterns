using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class AppleScreen : IScreen
    {
        private string m_name = null;

        public AppleScreen()
        {
            this.m_name = "Apple Screen";
            this.ProtectiveFilm = false;
            this.ScreenResolution = "2040x1440 FHD+";
        }
        public AppleScreen(string name, bool protectiveFilm, string screenResolution)
        {
            this.m_name = name;
            this.ProtectiveFilm = protectiveFilm;
            this.ScreenResolution = screenResolution;
        }

        public string Name => m_name;
        public bool ProtectiveFilm { get; set; }
        public string ScreenResolution { get; set; }

        public void GetScreenProperties()
        {
            if (m_name == null)
                Console.WriteLine("Error!!!");
            else
            {
                Console.WriteLine($"Name - {Name}");

                if (ProtectiveFilm)
                    Console.WriteLine($"The presence of protective film - True");
                else
                    Console.WriteLine($"The presence of protective film - False");

                Console.WriteLine($"Screen Resolution - {ScreenResolution}");
            }
        }
    }
}
