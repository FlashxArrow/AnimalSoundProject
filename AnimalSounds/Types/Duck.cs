namespace AnimalSoundsApp.Types
{
    public class Duck : Animal
    {
        public Duck() : base("Duck") { }
        public override string MakeSound() => "Quack";
    }
}
