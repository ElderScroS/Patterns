using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    enum BurgerType
    {
        None,
        CheeseBurger,
        ChickenBurger,
        BigMac,
        DoubleBigMac
    }

    internal interface IBurger
    {
        void GetBurger();
    }
}
