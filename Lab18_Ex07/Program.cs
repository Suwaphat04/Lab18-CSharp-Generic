using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> CourseName = new List<string>();
        CourseName.Add("OOP");
        CourseName.Add("Network");
        CourseName.Add("Electronics");
        CourseName.Add("Web programming");

        Console.WriteLine("Course Names:");
        foreach (var item in CourseName)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        List<int> CourseID = new List<int>();
        CourseID.Add(3687);
        CourseID.Add(3785);
        CourseID.Add(3781);
        CourseID.Add(3722);

        Console.WriteLine("Course IDs:");
        foreach (var item in CourseID)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        int count = CourseID.Count < CourseName.Count ? CourseID.Count : CourseName.Count;

        Console.WriteLine("Courses with IDs:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(CourseID[i] + " - " + CourseName[i]);
        }
    }
}

