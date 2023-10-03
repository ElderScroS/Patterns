using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class SamsungScreen : IScreen
    {
        private string m_name = null;

        public SamsungScreen()
        {
            this.m_name = "Samsung Screen";
            this.ProtectiveFilm = false;
            this.ScreenResolution = "1920x1080 FHD";
        }
        public SamsungScreen(string name, bool protectiveFilm, string screenResolution)
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
