using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal interface IScreen
    {
        string Name { get; }
        bool ProtectiveFilm { get; set; }
        string ScreenResolution { get; set; }

        void GetScreenProperties();
    }
}
