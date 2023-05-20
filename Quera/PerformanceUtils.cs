using System.Diagnostics;

namespace Quera
{
    internal class PerformanceUtils
    {
        public static void Measure(Action action)
        {
            // Start the stopwatch to measure execution time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Run the action
            action();

            // Stop the stopwatch
            stopwatch.Stop();

            // Print the execution time
            Console.WriteLine("Execution time: " + stopwatch.ElapsedMilliseconds + " ns");

            // Print the memory usage
            long memoryUsage = GC.GetTotalMemory(false);
            Console.WriteLine("Memory used: " + memoryUsage + " bytes");
        }
    }
}
