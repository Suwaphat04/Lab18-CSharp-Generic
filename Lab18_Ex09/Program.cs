using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> planets = new Queue<string>();

        Console.WriteLine("Add planets (Mercury to Pluto)");
        planets.Enqueue("Mercury");
        planets.Enqueue("Venus");
        planets.Enqueue("Earth");
        planets.Enqueue("Mars");
        planets.Enqueue("Jupiter");
        planets.Enqueue("Saturn");
        planets.Enqueue("Uranus");
        planets.Enqueue("Neptune");
        planets.Enqueue("Pluto");

        Console.WriteLine("\nItems in queue:");
        foreach (var item in planets)
        {
            Console.WriteLine(item);
        }

        Console.Write("\nRemove first item in queue: ");
        var removeItem = planets.Dequeue();
        Console.WriteLine(removeItem);

        Console.WriteLine("\nRemaining items in queue:");
        foreach (var item in planets)
        {
            Console.WriteLine(item);
        }
    }
}
