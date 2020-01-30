using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    abstract class Drink
    {
        public string Name { get; }

        public Drink(string name)
        {
            Name = name;
        }

    }
}
