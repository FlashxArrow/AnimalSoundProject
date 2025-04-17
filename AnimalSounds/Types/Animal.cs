using System;

namespace AnimalSoundsApp.Types
{
    public abstract class Animal
    {
        // Numai subclasele pot accesa direct
        private int hungerLevel = 6; // 0 = plin, 10 = foame maximă

        public string Name => GetType().Name;

        public abstract string MakeSound();

        public void Feed(int amount)
        {
            hungerLevel = Math.Max(hungerLevel - amount, 0);
        }

        public bool IsHungry()
        {
            return hungerLevel > 5;
        }

        public int GetHungerLevel()
        {
            return hungerLevel;
        }
    }
}
