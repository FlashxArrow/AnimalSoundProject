namespace AnimalSoundsApp.Types
{
    public class Duck : Animal
    {
        public override string MakeSound()
        {
            return IsHungry() ? "Quack... (I'm hungry!)" : "Quack";
        }
    }
}
