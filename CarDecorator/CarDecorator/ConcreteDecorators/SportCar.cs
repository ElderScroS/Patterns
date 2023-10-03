using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    internal class SportCar : SimpleCar
    {
        public SportCar() : base() { }
        public SportCar(ICar car, double speed, double loadCapacity, int price) : base(car, speed, loadCapacity, price) { }

        public override void Drive()
        {
            Console.WriteLine("\n\nYou are driving Sport Car!");
            Console.WriteLine("Have a good trip:)\n\n");
        }
        public override void GetPropertiesOfCar()
        {
            Console.WriteLine($"\n\t\tType of Car: Sport Car");
            Console.WriteLine($"\t\tSpeed of Sport Car: {base.m_speed} km/h");
            Console.WriteLine($"\t\tLoad Capacity Sport Car {base.m_loadCapacity} kg");
            Console.WriteLine($"\t\tPrice of Sport Car {base.m_price} $\n\n");
        }
    }
}