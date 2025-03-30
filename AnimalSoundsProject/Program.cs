using System;
using System.Collections.Generic;
using AnimalSoundsApp.Types;
using AnimalSoundsProject.Types;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Cow(),
            new Lion(),
            new Duck()
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
        }
    }
}
