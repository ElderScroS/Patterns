using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class DoubleBigMac : IBurger
    {
        private Burger _doubleBigMac;

        public DoubleBigMac()
        {
            this._doubleBigMac = new Burger(BurgerType.DoubleBigMac, 7);
        }

        public void GetBurger()
        {
            Console.WriteLine($"Tpe of Burger: {this._doubleBigMac.GetBurgerType()} [ {this._doubleBigMac.GetBurgerPrice()}$ ]");
        }
    }
}
