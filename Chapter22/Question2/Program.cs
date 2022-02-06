using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var half = num.Averages();
            Console.WriteLine(half);
            var high = num.Maximum();
            Console.WriteLine(high);
            var less = num.Minimum();
            Console.WriteLine(less);
            var sum = num.IncreaseWith();
            Console.WriteLine(sum);
        }
    }
}
