using System;

namespace compareNumbers
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a,b));
        }
    }
}
