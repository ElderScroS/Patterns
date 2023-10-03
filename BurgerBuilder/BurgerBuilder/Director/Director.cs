using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    internal class Director
    {
        private List<IBurger> _burgers;
        private List<string> _additions;
        private double _amount;

        public Director()
        {
            this._burgers = new List<IBurger>();
            this._additions = new List<string>();
        }
        public Director(List<IBurger> burgers, List<string> additions)
        {
            this._burgers = burgers;
            this._additions = additions;
        }

        public void AddKetcup()
        {
            this._additions.Add("Ketcup [ 0.50$ ]");
            this._amount += 0.50;
        }
        public void AddMayonnaise()
        {
            this._additions.Add("Mayonnaise [ 0.50$ ]");
            this._amount += 0.50;
        }

        public void AddCocaCola_450ml()
        {
            this._additions.Add("CocaCola 450ml [ 1.60$ ]");
            this._amount += 1.60;
        }
        public void AddCocaCola_1l()
        {
            this._additions.Add("CocaCola 1l [ 3.60$ ]");
            this._amount += 3.60;
        }
        public void AddFuseTea_750ml()
        {
            this._additions.Add("FuseTea 750ml [ 2.75$ ]");
            this._amount += 2.75;
        }

        public void AddNuggets_3x()
        {
            this._additions.Add("Nuggets 3x [ 2$ ]");
            this._amount += 2;
        }
        public void AddNuggets_6x()
        {
            this._additions.Add("Nuggets 6x [ 5$ ]");
            this._amount += 5;
        }
        public void AddNuggets_9x()
        {
            this._additions.Add("Nuggets 9x [ 8$ ]");
            this._amount += 8;
        }

        public void AddBigMac()
        {
            IBurger burger = new BigMac();
            this._burgers.Add(burger);
            this._amount += 5;
        }
        public void AddDoubleBigMac()
        {
            IBurger burger = new DoubleBigMac();
            this._burgers.Add(burger);
            this._amount += 7;
        }
        public void AddChickenBurger()
        {
            IBurger burger = new ChickenBurger();
            this._burgers.Add(burger);
            this._amount += 2;
        }
        public void AddCheeseBurger()
        {
            IBurger burger = new CheeseBurger();
            this._burgers.Add(burger);
            this._amount += 3;
        }


        public void ClearOrder()
        {
            this._burgers.Clear();
            this._additions.Clear();
            this._amount = 0;
        }

        public void GetBurgers()
        {
            for (int i = 0; i < this._burgers.Count; i++)
            {
                this._burgers[i].GetBurger();
            }
        }
        public void GetAdditions()
        {
            for (int i = 0; i < this._additions.Count; i++)
                Console.WriteLine($"{i + 1}: - {this._additions[i]}");
        }
        public void GetAmount() => Console.WriteLine($"Total sum: {this._amount}$ ");
    }
}
