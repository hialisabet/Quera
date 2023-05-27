using BenchmarkDotNet.Attributes;

namespace Quera
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Benchmark]
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

    }
}
