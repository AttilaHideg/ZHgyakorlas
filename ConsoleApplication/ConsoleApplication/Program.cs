

using Common;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal animal1 = new Mammal("Zsiráf",4,true);
            Mammal animal2 = new Mammal("Medve",4,false);
            Insect animal3 = new Insect("Pók",8,false);

            animal1.Child = new Mammal("KisZsiráf",4,true);
            //animal2.Child = new Mammal("KisMedve",4,true);

            Zoo zoo = new Zoo();
            zoo.AddAnimal(animal1);
            zoo.AddAnimal(animal2);
            zoo.AddAnimal(animal3);

            zoo.Storable.Add(animal1);
            zoo.Storable.Add(animal2);
            zoo.Storable.Add(animal3);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(zoo.Storable[i].GetID());
            }

            Console.WriteLine("Zoo created");
        }
    }
}
