namespace AnimalSoundsApp.Types
{
    public class Lion : Animal
    {
        public Lion() : base("Lion") { }
        public override string MakeSound() => "Roar";
    }
}
