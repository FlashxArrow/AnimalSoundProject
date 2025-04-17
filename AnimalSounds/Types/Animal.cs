namespace AnimalSoundsApp.Types
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract string MakeSound();
    }
}
