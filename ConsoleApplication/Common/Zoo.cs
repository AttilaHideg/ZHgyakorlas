using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Zoo
    {
        List<Animal> animals = new List<Animal>();

        public List<IStorable> Storable = new List<IStorable>();
               
        public bool AddAnimal(Animal animal)
        {
            animals.Add(animal);
            return true;
        }

        public int HowManyLegs()
        {
            var sum = 0;
            foreach (var animal in animals)
            {
                if(animal.IsOmnivore)
                    sum += animal.LegCount;
            }
            return sum;
        }
    }
}
