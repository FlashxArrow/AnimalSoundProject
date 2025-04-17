using System;
using System.Collections.Generic;
using AnimalSoundsApp.Types;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Cow(),
            new Duck(),
            new Lion()
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
            animal.Feed(6);
            Console.WriteLine(animal.MakeSound());
        }
    }
}
