using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class CheeseBurger : IBurger
    {
        private Burger _cheeseBurger;

        public CheeseBurger()
        {
            this._cheeseBurger = new Burger(BurgerType.CheeseBurger, 3);
        }

        public void GetBurger()
        {
            Console.WriteLine($"Type of Burger: {this._cheeseBurger.GetBurgerType()} [ {this._cheeseBurger.GetBurgerPrice()}$ ]");
        }
    }
}
