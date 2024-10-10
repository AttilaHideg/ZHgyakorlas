using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Animal
    {
        public Animal(string name, int legCount, bool isOmnivore)
        {
            Name = name;
            LegCount = legCount;
            IsOmnivore = isOmnivore;
        }

        public string Name { get; set; }
        public int LegCount { get; set; }
        public string Type { get; set; }
        public bool IsOmnivore { get; set; }

        public override string ToString()
        {
            return $"{Name} vagyok, {LegCount} lábbal";
        }

    }
}
