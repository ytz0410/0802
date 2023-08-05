/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int i = 0, j = 0;
            for (i = 1; i <= n; i++)
            {
                for (j = m - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                m -= 1;
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
*/