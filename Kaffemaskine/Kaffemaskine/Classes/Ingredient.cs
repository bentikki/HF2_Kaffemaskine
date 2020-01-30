using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    abstract class Ingredient
    {
        private int amount;
        public string Name { get; }
        public int Amount { get { return this.amount; } }

        protected Ingredient(string name, int amount)
        {
            Name = name;
            this.amount = amount;
        }
    }
}
