using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> numbers = new Queue<int>();

        Console.WriteLine("Add 3 elements (5, 10, 15)");
        numbers.Enqueue(5); 
        numbers.Enqueue(10); 
        numbers.Enqueue(15);

        Console.WriteLine("\nItems in queue:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.Write("\nRemove first item in queue: ");
        var removeItem = numbers.Dequeue();
        Console.WriteLine(removeItem);

        Console.WriteLine("\nRemaining items in queue:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}
