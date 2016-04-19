using System;


namespace fibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write("{0}, {1}",a,b);
          
            for (int i = 0; i<n-2;i++)
            { c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c; 
            }
        }
    }
}
