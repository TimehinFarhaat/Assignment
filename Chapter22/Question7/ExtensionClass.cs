using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
  public static class ExtensionClass
    {
        public static string Sentence( this string text)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(text);
        }
    }
}
