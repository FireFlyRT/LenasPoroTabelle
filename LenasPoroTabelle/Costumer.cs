using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenasPoroTabelle
{
    public class Costumer
    {
        public Costumer(string name, Porosnacks porosnacks)
        {
            Name = name;
            Porosnacks = porosnacks;
        }

        public string Name { get; set; }

        public Porosnacks Porosnacks { get; set; }
    }
}
