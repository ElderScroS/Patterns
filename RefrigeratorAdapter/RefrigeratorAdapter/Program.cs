using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RefrigeratorAdapter
{
    internal class Program
    {
        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("0 - Go Back\n");
            Console.WriteLine("1 - Water to refrigerator");
            Console.WriteLine("2 - Ice to refrigerator");
            Console.WriteLine("3 - Water to freezer");
            Console.WriteLine("4 - Ice to freezer\n\n");

            Console.Write("Choose -> ");
        }

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                PrintMenu(); int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\t\t\t\t\t\tGoodbye!!!\n\n\n\n\t\t\t");
                            flag = false;

                            break;
                        }
                    case 1:
                        {
                            Console.Clear();

                            IRefrigerator refrigerator = new AdapterRefrigerator(WaterCondition.Water);

                            Console.WriteLine("\n\n\n\t\t\t\t\tPress any key to continue...");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            IRefrigerator refrigerator = new AdapterRefrigerator(WaterCondition.Ice);

                            Console.WriteLine("\n\n\n\t\t\t\t\tPress any key to continue...");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            IRefrigerator freezer = new AdapterFreezer(WaterCondition.Water);

                            Console.WriteLine("\n\n\n\t\t\t\t\tPress any key to continue...");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();

                            IRefrigerator freezer = new AdapterFreezer(WaterCondition.Ice);

                            Console.WriteLine("\n\n\n\t\t\t\t\tPress any key to continue...");
                            Console.ReadKey();

                            break;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\t\t\t\t\t\tWrong input!!!");
                        Thread.Sleep(2000);

                        break;
                }
            }
        }
    }
}
