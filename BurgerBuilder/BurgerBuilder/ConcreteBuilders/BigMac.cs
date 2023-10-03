using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class BigMac : IBurger
    {
        private Burger _bigMac;

        public BigMac()
        {
            this._bigMac = new Burger(BurgerType.BigMac, 5);
        }

        public void GetBurger()
        {
            Console.WriteLine($"Type of Burger: {this._bigMac.GetBurgerType()} [ {this._bigMac.GetBurgerPrice()}$ ]");
        }
    }
}
