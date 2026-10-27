using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.WriteLine("Sum of two integers: " + c.Add(10, 20));
        Console.WriteLine("Sum of two doubles: " + c.Add(2.5, 3.5));
        Console.WriteLine("Sum of three integers: " + c.Add(10, 20, 30));
    }
}