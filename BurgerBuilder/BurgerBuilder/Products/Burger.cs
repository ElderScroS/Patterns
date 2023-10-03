using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class Burger
    {
        private BurgerType _burgerType;
        private double _burgerPrice;

        public Burger()
        {
            this._burgerType = BurgerType.None;
            this._burgerPrice = 0;
        }
        public Burger(BurgerType burgerType, double burgerPrice)
        {
            this._burgerType = burgerType;
            this._burgerPrice = burgerPrice;
        }

        public BurgerType GetBurgerType() => this._burgerType;
        public double GetBurgerPrice() => this._burgerPrice;
    }
}
