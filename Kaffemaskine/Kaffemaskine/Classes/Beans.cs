using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    abstract class Beans : Ingredient
    {
        public Beans(string name, int amount) : base(name, amount) { }
    }
}
