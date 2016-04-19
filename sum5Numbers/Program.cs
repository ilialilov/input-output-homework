using System;


namespace sum5Numbers
{
    class Program
    {
        static void Main()
        {
            int x = 0;
            int sum = 0; 
        for (int i =0;i<5;i++)
            { x = int.Parse(Console.ReadLine());
                sum = sum + x; 
            }
            Console.WriteLine(sum);
        }
    }
}
