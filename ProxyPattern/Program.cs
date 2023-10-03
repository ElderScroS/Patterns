using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISite mysite = new SiteProxy(new Site());
            Console.WriteLine(mysite.GetPage(1));
            Console.WriteLine(mysite.GetPage(2));
            Console.WriteLine(mysite.GetPage(3));
            Console.WriteLine(mysite.GetPage(4));
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine("-----");
            Console.WriteLine(mysite.GetPage(2));
            Console.WriteLine("-----");
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine(mysite.GetPage(5));
            Console.WriteLine(mysite.GetPage(5));

        }
    }
}
