/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            char[] ch = n.ToCharArray();
            foreach(char c in ch)
            {
                if(Char.IsLetter(c))
                {
                    Console.Write(Re(c));
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
        static char Re(char c)
        {
            if(c >= 'a' && c <= 'x')
            {
                return (char)(c + 3);
            }
            return c;
        }
    }
}*/