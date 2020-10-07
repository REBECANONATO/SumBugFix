using System;

namespace SumBugFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }

        private static double Average(double v1, double v2)
        {
            return (v1 + v2) / 2;
        }
    }
}
