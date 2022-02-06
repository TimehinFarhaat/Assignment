using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
   public static class Average
    {
        public static double Averages (this IEnumerable<int> number)
        {
            return number.Average();
        }
    }
}
