using System;

class Program
{
    static void Main()
    {
        int a = 20, b = 30;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        Swap<int>(ref a, ref b);
        Console.WriteLine($"After Swap:  a = {a}, b = {b}");

        string h = "Hello", w = "World";
        Console.WriteLine($"Before Swap: h = {h}, w = {w}");
        Swap<string>(ref h, ref w);
        Console.WriteLine($"After Swap:  h = {h}, w = {w}");
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
