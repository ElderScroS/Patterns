using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RefrigeratorAdapter
{
    enum WaterCondition
    {
        None,
        Water,
        Ice
    }

    internal class Refrigerator : IRefrigerator
    {
        private WaterCondition _waterCondition = WaterCondition.None;

        public Refrigerator(WaterCondition waterCondition)
        {
            if (waterCondition == WaterCondition.Ice)
            {
                Console.WriteLine("\n\n\n\t\t\t\tConverting ice to water...");
                this._waterCondition = WaterCondition.Water;

                Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t\tConverted:)");
            }
            else
            {
                Console.WriteLine("\n\n\n\t\t\t\tNo Conversion Needed");
                this._waterCondition = WaterCondition.Water;
            }
        }

        public void GetWaterCondition() => Console.WriteLine($"The condition of water is {this._waterCondition}");
    }
}