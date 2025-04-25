namespace AnimalSoundsProject.Types
{
    public class Cow : Animal
    {
        public override string MakeSound()
        {
            return IsHungry() ? "Moo... (I'm hungry!)" : "Moo";
        }
    }
}
