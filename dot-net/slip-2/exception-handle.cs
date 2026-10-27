using System;

interface ICalculator
{
    double Divide(double a, double b);
}

class Calculator : ICalculator
{
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException(
                "Cannot divide by zero."
            );
        }

        return a / b;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            ICalculator c = new Calculator();

            Console.WriteLine("Result: " + c.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers.");
        }
    }
}