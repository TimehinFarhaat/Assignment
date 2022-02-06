using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionn1
{
    public   static class StringBuilder
    {
        public static string SubString(this string word,int index,int length)
        {
            return word.Substring(index, length);
        }
    }
}
