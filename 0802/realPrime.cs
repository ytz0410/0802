using System;
using System.Collections.Generic;

public class Program
{
    static bool isPrime(int i)
    {
        bool isprime = true;
        int j = 0;
        for (j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isprime = false;
                return isprime;
            }
        }
        return isprime;
    }
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(' ');
        int[] intArr = new int[strArr.Length];
        int i = 0, j = 0;
        int temp = 0;
        int number = 0;
        for(j = 0; j < strArr.Length; j++)
        {
            temp = Convert.ToInt32(strArr[j]);
            intArr[j] = temp;
        }
        int n = intArr[0];
        int m = intArr[1];
        for (i = n; i <= m; i++)
        {
            bool isprime = isPrime(i);
            if (isprime)
            {
                temp = i;
                number = 0;
                while(temp%10!=0)
                {
                    number = number * 10 + temp % 10;
                    temp /= 10;
                }
                bool isprime1 = isPrime(number);
                if (isprime1)
                {
                    Console.WriteLine(i + " ");
                    Console.WriteLine();
                }
            }
        }        
    }
}