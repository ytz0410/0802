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
            for(i=1;i<=n;i++)
            {
                for(j=1;j<m;j++)
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
            
        }
    }
}
*/