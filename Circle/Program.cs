using System;


namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.Write("{0:0.00} {1:0.00}", 2*Math.PI*r,Math.PI*r*r);

        }
    }
}
