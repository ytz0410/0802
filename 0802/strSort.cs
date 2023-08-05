/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int n = 0;
            int[] intArr = new int[strArr.Length];
            int i = 0;
            for(i=0;i<strArr.Length;i++)
            {
                n = Convert.ToInt32(strArr[i]);
                intArr[i] = n;
            }
            Array.Sort(intArr);
            foreach(int temp in intArr)
            {
                Console.Write(temp + " ");
            }
        }
    }
}*/