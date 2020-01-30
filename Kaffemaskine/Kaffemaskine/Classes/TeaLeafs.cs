using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    abstract class TeaLeafs : Ingredient
    {
        public TeaLeafs(string name, int amount) : base(name, amount) { }
    }
}
