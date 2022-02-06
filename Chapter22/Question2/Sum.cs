using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question2
{
    public static class Sum
    {
        public static int IncreaseWith(this IEnumerable<int> list)
        {
           return list.Sum();
        }
    }
}
