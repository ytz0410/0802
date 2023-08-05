/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int count;
            int i = 0, j = 0, k = 1;
            for(i=1;i<=n;i++)
            {
                for(j=m-1;j>0;j--)
                {
                    Console.Write(" ");
                }
                m -= 1;
                for(j=0;j<2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(count=n-1;count>0;count--)
            {
                for(j=0;j<k;j++)
                {
                    Console.Write(" ");
                }
                k++;
                for(j=2*count-1;j>0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}*/