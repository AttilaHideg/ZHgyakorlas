using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Mammal : Animal, IStorable
    {
        public Mammal(string name, int legCount, bool isOmnivore) : base(name, legCount, isOmnivore)
        {
            Type = "Mammal"; 
        }

        public Mammal Child { get; set; }

        public string GetID()
        {
           return Name;
        }
    }
}
