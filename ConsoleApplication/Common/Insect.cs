namespace Common
{
    public class Insect : Animal, IStorable
    {
        public Insect(string name, int legCount, bool isOmnivore) : base(name, legCount, isOmnivore)
        {
            Type = "Insect";
        }

        public string GetID()
        {
            return $"{Type} with {LegCount} legs";
        }
    }
}
