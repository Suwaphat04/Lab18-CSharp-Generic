using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> planets = new Stack<string>();

        Console.WriteLine("Push planets (Mercury to Pluto) into stack");
        planets.Push("Mercury");
        planets.Push("Venus");
        planets.Push("Earth");
        planets.Push("Mars");
        planets.Push("Jupiter");
        planets.Push("Saturn");
        planets.Push("Uranus");
        planets.Push("Neptune");
        planets.Push("Pluto");

        Console.WriteLine("\nItems in stack:");
        foreach (var item in planets)
        {
            Console.WriteLine(item);
        }

        Console.Write("\nRemove top item in stack: ");
        var popItem = planets.Pop();
        Console.WriteLine(popItem);

        Console.WriteLine("\nRemaining items in stack:");
        foreach (var item in planets)
        {
            Console.WriteLine(item);
        }
    }
}
