using System;
using System.Threading;

namespace RefrigeratorAdapter
{
    internal class Freezer : IRefrigerator
    {
        private WaterCondition _waterCondition = WaterCondition.None;

        public Freezer(WaterCondition waterCondition)
        {
            if (waterCondition == WaterCondition.Water)
            {
                Console.WriteLine("\n\n\n\t\t\t\tConverting water to ice...");
                this._waterCondition = WaterCondition.Ice;

                Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t\tConverted:)");
            }
            else
            {
                Console.WriteLine("\n\n\n\t\t\t\tNo Conversion Needed");
                this._waterCondition = WaterCondition.Ice;
            }
        }

        public void GetWaterCondition() => Console.WriteLine($"The condition of water is {_waterCondition}");
    }
}
