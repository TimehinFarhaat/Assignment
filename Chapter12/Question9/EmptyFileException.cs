using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class EmptyFileException:Exception
    {
        public EmptyFileException(string message) : base(message)
        {

        }
    }
}
