using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class ChickenBurger : IBurger
    {
        private Burger _chickenBurger;

        public ChickenBurger()
        {
            this._chickenBurger = new Burger(BurgerType.ChickenBurger, 2);
        }

        public void GetBurger()
        {
            Console.WriteLine($"Type of Burger: {this._chickenBurger.GetBurgerType()} [ {this._chickenBurger.GetBurgerPrice()}$ ]");
        }
    }
}
