using System;


namespace sum5Numbers
{
    class Program
    {
        static void Main()
        {
            double x = 0;
            double sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                sum = sum + x;
            }
            Console.WriteLine(sum);
        }
    }
}
