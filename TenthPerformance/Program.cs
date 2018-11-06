using System;

namespace TenthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for (int i=a; i<b; i++)
            {
                if(i % n == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine(); 
        }
    }
}
