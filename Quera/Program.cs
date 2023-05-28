using System;
using System.Collections.Generic;

namespace Quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _00649_AvalBini();
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            if (number == 2 || number == 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 5; i <= sqrt; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
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
            }
            else
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

        public static void _00591_CahpeMorabba()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            for (int i = 0; i < input; i++)
            {
                if (i == 0 || i == input - 1)
                {
                    Console.WriteLine(new string('*', input));
                }
                else
                {
                    Console.WriteLine('*' + new string(' ', input - 2) + '*');
                }
            }
        }

        public static void _00616_TavanDo()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            string inputBinary = Convert.ToString(input, 2);
            string outputBinary = '1' + new string('0', inputBinary.Length);
            Console.WriteLine(Convert.ToInt32(outputBinary, 2));
        }

        public static void _00649_AvalBini()
        {
            string strA = Console.ReadLine();
            int a = int.Parse(strA);
            string strB = Console.ReadLine();
            int b = int.Parse(strB);

            bool isFirstPrime = true;

            for (int i = a + 1; i < b; i++)
            {
                if (IsPrime(i))
                {
                    if (!isFirstPrime)
                    {
                        Console.Write(",");
                    }
                    Console.Write(i);
                    isFirstPrime = false;
                }
            }

        }

        public static void _02659_TesteBinaei()
        {
            int n = int.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int blindness = 0;
            for (int i = 0; i < n; i++)
            {
                if (first[i] != second[i])
                {
                    blindness++;
                }
            }
            Console.WriteLine(blindness);
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

            int number;
            while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                numbers.Add(number);
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void _03408_SoaleBarnamenevisiBarnamenevisiSoal()
        {
            string str = Console.ReadLine();
            int n = int.Parse(str);
            string[] sentence = Console.ReadLine().Split();
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i] + ' ');
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
                Console.WriteLine((a + b) * (l / 2));
            }
            else
            {
                Console.WriteLine((a + b) * ((l - 1) / 2) + a);
            }
        }

        public static void _08838_KomakBeCopy()
        {
            string[] str = Console.ReadLine().Split();
            int n = int.Parse(str[0]);
            for (int i = 0; i < n; i++)
            {
                Console.Write("copy of ");
            }
            Console.Write(str[1]);
        }

        public static void _10162_RoozeAzadiBayanDarBarareh()
        {
            string str = Console.ReadLine();
            int input = int.Parse(str);
            if (input % 2 == 0)
            {
                Console.WriteLine("Bala Barare");
            }
            else
            {
                Console.WriteLine("Payin Barare");
            }
        }

        public static void _20256_RejimeSakht()
        {
            string str = Console.ReadLine();
            int red = 0;
            int yellow = 0;
            int green = 0;
            foreach (char c in str)
            {
                if (c == 'G')
                {
                    green++;
                }
                else if (c == 'R')
                {
                    red++;
                }
                else if (c == 'Y')
                {
                    yellow++;
                }
            }
            if (red >= 3 || (red >= 2 && yellow >= 2) || green == 0)
            {
                Console.WriteLine("nakhor lite");
            }
            else
            {
                Console.WriteLine("rahat baash");
            }
        }

        public static void _51865_BehdashtVaSalamat()
        {
            string strX = Console.ReadLine();
            int x = int.Parse(strX);
            string strN = Console.ReadLine();
            int n = int.Parse(strN);
            if (n == 0)
            {
                Console.WriteLine(20);
            }
            else if (n == 7)
            {
                Console.WriteLine(x);
            }
            else
            {
                x = x - n;
                Console.WriteLine((x < 0) ? 0 : x);
            }
        }

    }
}