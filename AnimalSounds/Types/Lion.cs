namespace AnimalSoundsApp.Types
{
    public class Lion : Animal
    {
        public override string MakeSound()
        {
            return IsHungry() ? "Roar... (I'm hungry!)" : "Roar";
        }
    }
}
