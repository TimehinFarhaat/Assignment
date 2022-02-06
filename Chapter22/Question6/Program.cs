using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;


namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numlist = new List<int>() { 3, 7, 21, 63, 34, 45, 42 };
            var multiple = numlist.Where(y => y % 3 == 0 && y % 7 == 0);
            foreach (var number in multiple)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            var multiples = from x in numlist where x % 3 == 0 && x % 7 == 0 select x;
            foreach (var l in multiples)
            {
                Console.WriteLine(l);
            }

        }
    }
}
