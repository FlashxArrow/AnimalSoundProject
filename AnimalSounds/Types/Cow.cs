namespace AnimalSoundsApp.Types
{
    public class Cow : Animal
    {
        public Cow() : base("Cow") { }
        public override string MakeSound() => "Moow";
    }
}
