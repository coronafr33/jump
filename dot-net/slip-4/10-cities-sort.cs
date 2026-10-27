using System;

class Program
{
    static void Main()
    {
        string[] cities = new string[10];

        Console.WriteLine("Enter names of 10 cities:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("City " + (i + 1) + ": ");
            cities[i] = Console.ReadLine();
        }

        Array.Sort(cities, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("\nCities in sorted order:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(cities[i]);
        }
    }
}