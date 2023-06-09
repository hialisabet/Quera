﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _072881_SoupSabzijat();
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

        public static List<int> FindDivisors(int number)
        {
            List<int> divisors = new List<int>();
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                    int quotient = number / i;
                    if (quotient != i)
                    {
                        divisors.Add(quotient);
                    }
                }
            }

            divisors.Sort();
            return divisors;
        }

        public static void _000280_AdadeFisaghoresi()
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

        public static void _000282_KamelBoodanYaNaboodan()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> divisors = FindDivisors(n);
            divisors.RemoveAt(divisors.Count - 1);
            int sumOfDivs = 0;
            foreach (int i in divisors)
            {
                sumOfDivs += i;
            }
            if (sumOfDivs == n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        public static void _000588_Maximum()
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int max = int.Parse(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (int.Parse(str[i]) > max)
                {
                    max = int.Parse(str[i]);
                }
            }
            Console.WriteLine(max);
        }

        public static void _000589_Factorial()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        public static void _000591_ChapeMorabba()
        {
            int input = int.Parse(Console.ReadLine());
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

        public static void _000615_TarikhTavalod()
        {
            string str = Console.ReadLine();
            // start from index 0, and get 2 chars
            string saal = str.Substring(0, 2);
            // start from index 2, and get 2 chars
            string maah = str.Substring(2, 2);
            Console.WriteLine("saal:" + saal);
            Console.WriteLine("maah:" + maah);
        }

        public static void _000616_TavanDo()
        {
            int input = int.Parse(Console.ReadLine());
            string inputBinary = Convert.ToString(input, 2);
            string outputBinary = '1' + new string('0', inputBinary.Length);
            Console.WriteLine(Convert.ToInt32(outputBinary, 2));
        }

        public static void _000649_AvalBini()
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

        public static void _002636_ShatranjHerfei()
        {
            string[] str = Console.ReadLine().Split();
            int[] result = new int[str.Length];
            result[0] = 1 - int.Parse(str[0]);
            result[1] = 1 - int.Parse(str[1]);
            result[2] = 2 - int.Parse(str[2]);
            result[3] = 2 - int.Parse(str[3]);
            result[4] = 2 - int.Parse(str[4]);
            result[5] = 8 - int.Parse(str[5]);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + ' ');
            }
        }

        public static void _002659_TesteBinaei()
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

        public static void _002885_YekSoaleSade()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("man khoshghlab hastam");
            }
        }

        public static void _003403_Sadetar()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int sum = a + b + c + d;
            float avg = (float) sum / 4;
            int product = a * b * c * d;
            int max = new[] { a, b, c, d }.Max();
            int min = new[] { a, b, c, d }.Min();
            Console.WriteLine("Sum : " + sum.ToString("####0.000000"));
            Console.WriteLine("Average : " + avg.ToString("####0.000000"));
            Console.WriteLine("Product : " + product.ToString("####0.000000"));
            // Find Max of more than 2 numbers
            Console.WriteLine("MAX : " + max.ToString("####0.000000"));
            // Find Min of more than 2 numbers
            Console.WriteLine("MIN : " + min.ToString("####0.000000"));
        }

        public static void _003404_ToCheghadrEzafeVaznDari()
        {
            float w = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float bmi = w / (h * h);

            Console.WriteLine(bmi.ToString("####0.00"));
            //Console.WriteLine(bmi.ToString("0.00"));
            //Console.WriteLine(bmi.ToString("F2"));
            //Console.WriteLine(bmi.ToString("N2"));
            //Console.WriteLine(string.Format("{0:0.00}", bmi));
            //Console.WriteLine(string.Format("{0:F2}", bmi));
            //Console.WriteLine(string.Format("{0:N2}", bmi));

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            } else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Normal");
            } else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            } else if ((bmi >= 30))
            {
                Console.WriteLine("Obese");
            }
            
        }

        public static void _003405_ChapBarAx()
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

        public static void _003408_SoaleBarnamenevisiBarnamenevisiSoal()
        {
            string[] sentence = Console.ReadLine().Split();
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i] + ' ');
            }
        }

        public static void _003409_JadvalZarbGondeh()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void _003414_DoNoghtehKhat()
        {
            string[] str = Console.ReadLine().Split();
            int mRow = int.Parse(str[0]);
            int mColumn = int.Parse(str[1]);
            int rRow = int.Parse(str[2]);
            int rColumn = int.Parse(str[3]);
            if (mRow == rRow)
            {
                Console.WriteLine("Vertical");
            }
            else if (mColumn == rColumn)
            {
                Console.WriteLine("Horizontal");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }

        public static void _003429_Yakhdarchi()
        {
            int input = int.Parse(Console.ReadLine());
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

        public static void _003537_SoaleZard()
        {
            int input = int.Parse(Console.ReadLine());
            Console.Write("W");
            for (int i = 0; i < input; i++)
            {
                Console.Write("o");
            }
            Console.Write("w!");
        }

        public static void _004065_KharDarChamanFaravooneh()
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

        public static void _006082_AsemanShekarAbad()
        {
            string[] str = Console.ReadLine().Split();
            int row = int.Parse(str[0]);
            int count = 0;
            for (int i = 0; i < row; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void _008838_KomakBeCopy()
        {
            string[] str = Console.ReadLine().Split();
            int n = int.Parse(str[0]);
            for (int i = 0; i < n; i++)
            {
                Console.Write("copy of ");
            }
            Console.Write(str[1]);
        }

        public static void _009774_AdadChapKon()
        {

        }

        public static void _010162_RoozeAzadiBayanDarBarareh()
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Bala Barare");
            }
            else
            {
                Console.WriteLine("Payin Barare");
            }
        }

        public static void _010325_HamayeshZendegiBehtar()
        {
            string[] str = Console.ReadLine().Split();
            int row = int.Parse(str[0]);
            int chair = int.Parse(str[1]);
            if (chair <= 10)
            {
                Console.Write("Right " + (11 - row) + " " + chair);
            }
            else
            {
                Console.Write("Left " + (11 - row) + " " + (21 - chair));
            }
        }

        public static void _017675_ReshtehFibonacci()
        {

        }

        public static void _020256_RejimeSakht()
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

        public static void _031025_SabaVaSoaleSade()
        {
            
        }

        public static void _051865_BehdashtVaSalamat()
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

        public static void _072881_SoupSabzijat()
        {
            string[] str = Console.ReadLine().Split();
            int n = int.Parse(str[0]);
            float k = float.Parse(str[1]);
            float s = float.Parse(str[2]);
            if ((n * k) <= s)
            {
                Console.WriteLine("Kafie!");
            } else
            {
                Console.WriteLine("Na! yeki bayad bere sabzi bekhare");
            }
        }

        public static void _108665_KalamehKalameh()
        {
            string str = Console.ReadLine();
            int vowel = 0;
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') vowel++;
            }
            Console.WriteLine(Math.Pow(2, vowel));
        }

    }
}