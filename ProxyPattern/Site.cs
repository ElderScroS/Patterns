using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Site : ISite
    {
        public string GetPage(int num) => "Eto stranica " + num;
    }
}
