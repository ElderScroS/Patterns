using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class Program
    {
        public static Director order = new Director();

        #region Prints

        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("Esc - Exit\n");
            Console.WriteLine("Press 'A' - Add Additions in order");
            Console.WriteLine("Press 'B' - Add Burger in order");
            Console.WriteLine("Press 'C' - Clear Order");
            Console.WriteLine("Press 'S' - Show Order");
            Console.WriteLine("Press 'F' - Finish");
        }
        public static void PrintBurgers()
        {
            Console.Clear();

            Console.WriteLine("0 - Go back\n");
            Console.WriteLine("1 - Add ChickenBurger [ 2$ ]");
            Console.WriteLine("2 - Add CheeseBurger [ 3$ ]");
            Console.WriteLine("3 - Add Big Mac [ 5$ ]");
            Console.Write("4 - Add DoubleBigMac [ 6$ ]\n\nChoose -> ");
        }
        public static void PrintAdditions()
        {
            Console.Clear();

            Console.WriteLine("0 - Go back\n");
            Console.WriteLine("1 - Add Ketcup [ 0.50$ ]");
            Console.WriteLine("2 - Add Mayonnaise [ 0.50$ ]");
            Console.WriteLine("3 - Add CocaCola 450ml [ 1.60$ ]");
            Console.WriteLine("4 - Add CocaCola 1l [ 3.60$ ]");
            Console.WriteLine("5 - Add FuseTea 750ml [ 2.75$ ]");
            Console.WriteLine("6 - Add Nuggets 3x [ 2$ ]");
            Console.WriteLine("7 - Add Nuggets 6x [ 5$ ]");
            Console.Write("8 - Add Nuggets 9x [ 8$ ]\n\nChoose -> ");
        }

        #endregion

        #region Choices

        public static void AddBurgersInOrder()
        {
            bool flag = true;
            while (flag)
            {
                PrintBurgers();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        flag = false; 

                        break;
                    case 1:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddChickenBurger();

                        break; 
                    case 2:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddCheeseBurger();

                        break;
                    case 3:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddBigMac();

                        break;
                    case 4:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddDoubleBigMac();

                        break;
                    default:
                        Console.Clear();

                        Console.WriteLine("\n\n\n\t\t\t\tWrong input!!!");
                        Thread.Sleep(2000);

                        break;
                }
            }
        }
        public static void AddAdditionsInOrder()
        {
            bool flag = true;
            while (flag)
            {
                PrintAdditions();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        flag = false;

                        break;
                    case 1:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddKetcup();

                        break;
                    case 2:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddMayonnaise();

                        break;
                    case 3:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddCocaCola_450ml();

                        break;
                    case 4:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddCocaCola_1l();

                        break;
                    case 5:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddFuseTea_750ml();

                        break;
                    case 6:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddNuggets_3x();

                        break;
                    case 7:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddNuggets_6x();

                        break;
                    case 8:
                        Console.Clear();
                        Thread.Sleep(500);
                        order.AddNuggets_9x();

                        break;
                    default:
                        Console.Clear();

                        Console.WriteLine("\n\n\n\t\t\t\tWrong input!!!");
                        Thread.Sleep(2000);

                        break;
                }
            }
        }
        public static void ShowOrder()
        {
            Console.Clear();

            Console.WriteLine("==========================================================\n\n");

            order.GetBurgers();
            order.GetAdditions();

            Console.WriteLine("\n\n==========================================================\n\n");

            order.GetAmount();

            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                PrintMenu();

                Console.WriteLine("\n\n\n\t\t\t");
                ConsoleKeyInfo choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.Escape)
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\tGoodbye:)\n\n\n\n\n\n");

                    flag = false;
                }
                else if (choice.Key == ConsoleKey.B)
                {
                    AddBurgersInOrder();
                }
                else if (choice.Key == ConsoleKey.A)
                {
                    AddAdditionsInOrder();
                }
                else if (choice.Key == ConsoleKey.C)
                {
                    order.ClearOrder();
                }
                else if (choice.Key == ConsoleKey.S)
                {
                    ShowOrder();
                }
                else if (choice.Key == ConsoleKey.F)
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tThanks for your order!!! Enjoy your meal:)");

                    flag = false;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\n\n\t\t\t\t\t\tWrong input!!!");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
