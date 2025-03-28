﻿using System;

class Program
{
    static void Main()
    {
        // Generic method calls
        Generic.Print(10);
        Generic.Print("Hello World");
        Generic.Print(12345.678);
    }
}

public static class Generic
{
    public static void Print<T>(T value)
    {
        System.Console.WriteLine(value);
    }
}
