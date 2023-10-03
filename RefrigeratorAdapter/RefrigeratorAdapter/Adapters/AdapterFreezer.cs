using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAdapter
{
    internal class AdapterFreezer : Freezer, IRefrigerator
    {
        public AdapterFreezer(WaterCondition condition) : base(condition) { }

        public void GetWaterCondition() 
        {
            base.GetWaterCondition();
        }
    }
}
