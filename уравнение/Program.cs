
using System;

class Program
{
    static void Solve(double c1, double c2)
    {
        double a1 = 4;
        double a2 = 2;
        double b1 = 6;
        double b2 = 4;

        double d = a1 * b2 - a2 * b1;

        double x = (c1 * b2 - c2 * b1) / d;
        double y = (a1 * c2 - a2 * c1) / d;

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        if (a1 * x + b1 * y == c1 &&
            a2 * x + b2 * y == c2)
        {
            Console.WriteLine("Тест пройден");
        }
        else
        {
            Console.WriteLine("Тест не пройден");
        }
    }

    static void Main()
    {
        Solve(16, 8);
        Solve(16, 10);
        Solve(26, 16);
    }
}
