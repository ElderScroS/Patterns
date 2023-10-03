using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    internal class SimpleCar : ICar
    {
        protected ICar m_car;
        protected double m_speed;
        protected double m_loadCapacity;
        protected int m_price;

        public SimpleCar()
        {
            this.m_speed = 150.0;
            this.m_loadCapacity = 1200;
            this.m_price = 9000;
        }

        public SimpleCar(ICar car, double speed, double loadCapacity, int price)
        {
            Car = car;
            Speed = speed;
            LoadCapacity = loadCapacity;
            Price = price;
            this.m_car = car;
            this.m_speed = speed;
            this.m_loadCapacity = loadCapacity;
            this.m_price = price;
        }

        public ICar Car { get; }
        public double Speed { get; set; }
        public double LoadCapacity { get; set; }
        public int Price { get; set;  }

        public virtual void Drive() => m_car.Drive();
        public virtual void GetPropertiesOfCar() => m_car.GetPropertiesOfCar();
    }
}
