using System;

class Program
{
    static void Main()
    {
        double x, y, a;

        Console.Write("Please enter value for x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter value for y: ");
        y = Convert.ToDouble(Console.ReadLine());

        a = Math.Pow(2, -x) * Math.Sqrt(Math.Pow(x, -4) + Math.Sqrt(Math.Abs(y)));

        Console.WriteLine("Result is a: " + a);
    }
}

