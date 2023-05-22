using System;
using System.Collections.Generic;

namespace Quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _04065_KharDarChamanFaravooneh();
            //PerformanceUtils.Measure(() =>
            //{
            //});          
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

        public static void _00280_AdadeFisaghoresi()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) ||
                Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) ||
                Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

        }

        public static void _00589_Factorial()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            Console.WriteLine(Factorial(input));
        }

        public static void _00616_TavanDo()
        {
            //https://docs.google.com/document/d/1kcwlIamCsdGc4-HjS2nbYB1JtxlVVm9trfxzVWm-Fns/edit#heading=h.4prh5tu56954
            string str = Console.ReadLine();
            int input = int.Parse(str);
            string inputBinary = Convert.ToString(input, 2);
            string outputBinary = '1' + new string('0', inputBinary.Length);
            Console.WriteLine(Convert.ToInt32(outputBinary, 2));
        }

        public static void _02885_YekSoaleSade()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("man khoshghlab hastam");
            }
        }

        public static void _03405_ChapBarAx()
        {
            List<int> numbers = new List<int>();

            // Read numbers until 0 is encountered
            int number;
            while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                numbers.Add(number);
            }

            // Print the numbers in reverse order
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void _03429_Yakhdarchi()
        {
            string str = Console.ReadLine();
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

        public static void _03537_SoaleZard()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            Console.Write("W");
            for (int i = 0; i < input; i++)
            {
                Console.Write("o");
            }
            Console.Write("w!");
        }

        public static void _04065_KharDarChamanFaravooneh()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int l = int.Parse(str[2]);
            if (l % 2 == 0)
            {
                Console.WriteLine((a+b)*(l/2));
            } else
            {
                Console.WriteLine((a+b)*((l-1)/2) + a);
            }
        }

        public static void _09774_AdadChapKon()
        {
            string str = Console.ReadLine();
            //...
        }

    }
}