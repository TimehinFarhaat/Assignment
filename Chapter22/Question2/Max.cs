using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
   public static class Max
    {
        public static int  Maximum(this IEnumerable<int> number)
        {
            return number.Max();
        }
    }
}
