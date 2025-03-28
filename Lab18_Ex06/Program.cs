using System;

class Program
{
    static void Main()
    {
        var nextStation = new ARL<string>();
        Console.WriteLine("Next station : " + nextStation.DisplayData("Ladkrabang"));

        var fare = new ARL<float>();
        Console.WriteLine("Fare         : ฿" + fare.DisplayData(15.0f));
    }
}

class ARL<T>
{
    public T DisplayData(T data)
    {
        return data;
    }
}
