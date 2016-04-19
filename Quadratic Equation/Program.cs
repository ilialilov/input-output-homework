using System;


namespace Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double sqrtpart = b * b - 4 * a * c;
            double x1, x2;
            if (sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("{0:F2}", Math.Min(x1, x2));
                Console.WriteLine("{0:F2}", Math.Max(x1, x2));
            }
            else if (sqrtpart == 0)
            {
                x1 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine(x1);
            }
            else Console.WriteLine("no real roots");

        }
    }
}
