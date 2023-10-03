using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAdapter
{
    internal class AdapterRefrigerator : Refrigerator, IRefrigerator
    {
        public AdapterRefrigerator(WaterCondition condition) : base(condition) { }

        public void GetWaterCondition() 
        {
            base.GetWaterCondition();
        }
    }
}
