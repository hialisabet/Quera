using System;

namespace Quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Factorial(int input)
        {
            if (input == 0 || input == 1)
            {
                return 1;
            }
            else
            {
                return input * Factorial(input - 1);
            }
        }

        public static void _00589_Factorial()
        {
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                int input = int.Parse(str);
                Console.WriteLine(Factorial(input));
            }
        }

        public static void _02885_YekSoaleSade()
        {
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                int input = int.Parse(str);
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("man khoshghlab hastam");
                }
            }
        }

        public static void _03429_Yakhdarchi()
        {
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                int input = int.Parse(str);
                if (input > 100)
                {
                    Console.WriteLine("Steam");
                }
                else if (input < 0)
                {
                    Console.WriteLine("Ice");
                }
                else
                {
                    Console.WriteLine("Water");
                }
            }
        }

        public static void _03537_SoaleZard()
        {
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                int input = int.Parse(str);
                Console.Write("W");
                for (int i = 0; i < input; i++)
                {
                    Console.Write("o");
                }
                Console.Write("w!");
            }
        }

    }
}