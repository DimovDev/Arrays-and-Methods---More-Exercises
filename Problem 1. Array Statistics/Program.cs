using System;
using System.Linq;

namespace Problem_1._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = num.Min();
            int max = num.Max();
              double numSum= num.Sum();
            double Average = numSum / num.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {numSum}" );
            Console.WriteLine($"Average = {Average}" );

        }
    }
}
