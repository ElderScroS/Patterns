using System;
using System.Collections.Generic;
using System.Threading;

namespace AbstractFactory
{
    internal class Program
    {
        public static List<IPhone> SamsungPhones = new List<IPhone>();
        public static List<IPhone> ApplePhones = new List<IPhone>();


        #region Prints

        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("[ 0 ] - Exit\n");
            Console.WriteLine("[ 1 ] - Samsung");
            Console.WriteLine("[ 2 ] - Apple\n\n");
        }
        public static void SamsungMenu()
        {
            Console.Clear();

            Console.WriteLine("[ 0 ] - Go back\n");
            Console.WriteLine("[ 1 ] - Add Samsung(default)");
            Console.WriteLine("[ 2 ] - Add Samsung(manually)");
            Console.WriteLine("[ 3 ] - Remove Samsung\n\n");
        }
        public static void AppleMenu()
        {
            Console.Clear();

            Console.WriteLine("[ 0 ] - Go back\n");
            Console.WriteLine("[ 1 ] - Add Apple(default)");
            Console.WriteLine("[ 2 ] - Add Apple(manually)");
            Console.WriteLine("[ 3 ] - Remove Apple\n\n");
        }

        #endregion


        #region Choices

        public static void SamsungChoice()
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();

                SamsungMenu();

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        flag = false;

                        break;
                    case 1:
                        AddSamsungDefault();

                        break;
                    case 2:
                        AddSamsungManualy();

                        break;
                    case 3:
                        RemoveSamsung();

                        break;
                    default:
                        Console.WriteLine("\n\n\t\t\t\t\t\t\tWrong Input!!!\n\n\n\n\n\n\n\n\n\n\n");
                        Thread.Sleep(3000);

                        break;
                }
            }
        }
        public static void IphoneChoice()
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();

                AppleMenu();

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        flag = false;

                        break;
                    case 1:
                        AddAppleDefault();

                        break;
                    case 2:
                        AddAppleManualy();

                        break;
                    case 3:
                        RemoveApple();

                        break;
                    default:
                        Console.WriteLine("\n\n\t\t\t\t\t\t\tWrong Input!!!\n\n\n\n\n\n\n\n\n\n\n");
                        Thread.Sleep(3000);

                        break;
                }
            }
        }

        #endregion


        #region SamsungFuncs

        public static void AddSamsungDefault()
        {
            IFactory tempFactory = new SamsungFactory();

            SamsungPhones.Add(tempFactory.CreatePhone());
        }
        public static void AddSamsungManualy()
        {
            Console.Clear();

            IFactory samsungFactory = new SamsungFactory();

            Console.Write("Enter Model: ");
            string phoneModel = Console.ReadLine();

            Console.Write("Enter Memory: ");
            int memory;
            while (true)
            {
                memory = int.Parse(Console.ReadLine());
                if (memory > 30)
                    break;
            }

            Console.Write("Case available - 1/ Case not available - 0: ");
            int Case;
            while (true)
            {
                Case = int.Parse(Console.ReadLine());

                if (Case == 0 || Case == 1)
                    break;
            }
             
            Console.Write("Enter Price: ");
            int price;
            while (true)
            {
                price = int.Parse(Console.ReadLine());

                if (price > 400)
                    break;
            }

            SamsungPhones.Add(samsungFactory.CreatePhone(phoneModel, memory, new SamsungProcessor(), new SamsungScreen(),
                                        Convert.ToBoolean(Case), new SamsungButton(), price));

        }
        public static void RemoveSamsung()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("0 - Go Back\n\n");
                ShowSamsungPhones();

                Console.Write("\n\nChoose Apple Phone to delete: ");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 0)
                    break;
                else if (ch > 0 && ch <= SamsungPhones.Count)
                {
                    SamsungPhones.RemoveAt(ch - 1);

                    Console.Clear();
                    Console.WriteLine("Has been deleted");
                    Thread.Sleep(4000);
                }
            }
        }

        public static void ShowSamsungPhones()
        {
            for (int i = 0; i < SamsungPhones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Phone Name - {SamsungPhones[i].Name}");
                Console.WriteLine($"   Phone Model - {SamsungPhones[i].Model}");
                Console.WriteLine($"   Phone Memory - {SamsungPhones[i].Memory}");
                Console.WriteLine($"   Phone Price - {SamsungPhones[i].Price}");
                Console.WriteLine("\n");
            }
        }

        #endregion


        #region IphoneFuncs

        public static void AddAppleDefault()
        {
            IFactory tempFactory = new AppleFactory();

            ApplePhones.Add(tempFactory.CreatePhone());
        }
        public static void AddAppleManualy()
        {
            Console.Clear();

            IFactory appleFactory = new AppleFactory();

            Console.Write("Enter Model: ");
            string phoneModel = Console.ReadLine();

            Console.Write("Enter Memory: ");
            int memory;
            while (true)
            {
                memory = int.Parse(Console.ReadLine());
                if (memory > 64)
                    break;
            }

            Console.Write("Case available - 1/ Case not available - 0: ");
            int Case;
            while (true)
            {
                Case = int.Parse(Console.ReadLine());

                if (Case == 0 || Case == 1)
                    break;
            }

            Console.Write("Enter Price: ");
            int price;
            while (true)
            {
                price = int.Parse(Console.ReadLine());

                if (price > 1000)
                    break;
            }

            ApplePhones.Add(appleFactory.CreatePhone(phoneModel, memory, new AppleProcessor(), new AppleScreen(),
                                        Convert.ToBoolean(Case), new AppleButton(), price));
        }
        public static void RemoveApple()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("0 - Go Back\n\n");
                ShowApplePhones();

                Console.Write("\n\nChoose Apple Phone to delete: ");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 0)
                    break;
                else if (ch > 0 && ch <= ApplePhones.Count)
                {
                    ApplePhones.RemoveAt(ch - 1);

                    Console.Clear();
                    Console.WriteLine("Has been deleted");
                    Thread.Sleep(4000);
                }
            }
        }


        public static void ShowApplePhones()
        {
            for (int i = 0; i < ApplePhones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Phone Name - {ApplePhones[i].Name}");
                Console.WriteLine($"   Phone Model - {ApplePhones[i].Model}");
                Console.WriteLine($"   Phone Memory - {ApplePhones[i].Memory}");
                Console.WriteLine($"   Phone Price - {ApplePhones[i].Price}");
                Console.WriteLine("\n\n");
            }

        }

        #endregion



        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();

                PrintMenu();

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\n\n\t\t\t\t\t\t\tGoodbye!!!\n\n\n\n\n\n\n\n\n\n\n");
                        flag = false;

                        break;
                    case 1:
                        SamsungChoice();

                        break;
                    case 2:
                        IphoneChoice();

                        break;
                    default:
                        Console.WriteLine("\n\n\t\t\t\t\t\t\tWrong Input!!!\n\n\n\n\n\n\n\n\n\n\n");
                        Thread.Sleep(3000);

                        break;
                }
            }
        }
    }
}