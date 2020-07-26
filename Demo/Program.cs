using System;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (int i =1; i < 11; i++)
            {
                int a = i;
                if (i > 15) { a = a - 15; };
                Console.ForegroundColor = (System.ConsoleColor)a;
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }

 
}
