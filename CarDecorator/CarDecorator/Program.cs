using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarDecorator
{
    internal class Program
    {
        public static List<SimpleCar> cars = new List<SimpleCar>();

        public static void PrintMainMenu()
        {
            Console.Clear();

            Console.WriteLine("0 - Exit\n");
            Console.WriteLine("1 - Drive");
            Console.WriteLine("2 - Add Truck");
            Console.WriteLine("3 - Add Sport Car");
            Console.WriteLine("4 - Remove Car\n");
        }

        #region Choices

        public static void DriveCar()
        {
            bool flag = true;
            bool ifcar = false;

            ICar car = new SimpleCar();

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("0 - Go Back\n\n");
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.Write($"{i + 1}: "); cars[i].GetPropertiesOfCar();
                }

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    flag = false;
                else if (choice >= 1 && choice <= cars.Count)
                {
                    car = cars[choice - 1];
                    ifcar = true;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("\n\nIndex out of range!!!");
                    Thread.Sleep(2000);
                }
            }

            if (ifcar)
            {
                while (true)
                {
                    car.Drive();

                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\tPress any key to continue");
                    Console.ReadKey();

                    break;
                }
            }
        }
        public static void AddTruck()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();

                ICar car = new SimpleCar();

                double speed;
                while (true)
                {
                    Console.Write("\nSpeed Of Truck -> ");

                    speed = int.Parse(Console.ReadLine());
                    if (speed >= 100 && speed <= 250)
                        break;
                    else Console.WriteLine("\n\nAt least 100 km/h / Not more 250 km/h!!!\n\n");
                }

                double loadCapacity;
                while (true)
                {
                    Console.Write("\nLoad Capacity of Truck -> ");

                    loadCapacity = int.Parse(Console.ReadLine());
                    if (loadCapacity >= 800 && loadCapacity <= 2000)
                        break;
                    else Console.WriteLine("\n\nAt least 800 kg / Not more 2000 kg!!!\n\n");
                }

                int price;
                while (true)
                {
                    Console.Write("\nPrice of Truck -> ");

                    price = int.Parse(Console.ReadLine());
                    if (price >= 10000)
                        break;
                    else Console.WriteLine("\n\nAt least 10000 $!!!\n\n");
                }

                Truck truck = new Truck(car, speed, loadCapacity, price);
                cars.Add(truck);

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t\t\tHas been added:)");
                Thread.Sleep(2000);
                flag = false;
            }
        }
        public static void AddSportCar()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();

                ICar car = new SimpleCar();

                double speed;
                while (true)
                {
                    Console.Write("Speed Of Sport Car -> ");

                    speed = int.Parse(Console.ReadLine());
                    if (speed >= 300)
                        break;
                    else Console.WriteLine("\n\nAt least 300 km/h!!!\n\n");
                }

                double loadCapacity;
                while (true)
                {
                    Console.Write("\nLoad Capacity of Sport Car -> ");

                    loadCapacity = int.Parse(Console.ReadLine());
                    if (loadCapacity >= 500 && loadCapacity <= 1000)
                        break;
                    else Console.WriteLine("\n\nAt least 500 kg / Not more 1000 kg!!!\n\n");
                }

                int price;
                while (true)
                {
                    Console.Write("\nPrice of Sport Car -> ");

                    price = int.Parse(Console.ReadLine());
                    if (price >= 20000)
                        break;
                    else Console.WriteLine("\n\nAt least 20000 $!!!\n\n");
                }

                SimpleCar sportCar = new SportCar(car, speed, loadCapacity, price);
                cars.Add(sportCar);

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t\t\tHas been added:)");
                Thread.Sleep(2000);
                flag = false;
            }
        }
        public static void RemoveCar()
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("0 - Go Back\n\n");
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.Write($"{i + 1}: "); cars[i].GetPropertiesOfCar();
                }

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    flag = false;
                else if (choice >= 1 && choice <= cars.Count)
                {
                    cars.RemoveAt(choice - 1);
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t\t\tHas been deleted:)");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("\n\nIndex out of range!!!");
                    Thread.Sleep(2000);
                }
            }
        }

        #endregion

        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                PrintMainMenu();
                Console.Write("Choose -> "); int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.Clear();

                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\tGoodbye:)\n\n\n\n\n\n\n");
                        flag = false;

                        break;
                    case 1:
                        DriveCar();

                        break;
                    case 2:
                        AddTruck();

                        break;
                    case 3:
                        AddSportCar();

                        break;
                    case 4:
                        RemoveCar();

                        break;
                    default:
                        Console.WriteLine("Wrong Input!!!");
                        break;
                }
            }
        }
    }
}
