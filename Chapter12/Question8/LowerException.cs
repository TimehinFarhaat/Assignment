using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class LowerException:Exception
    {
        public LowerException(string message) : base(message)
        {

        }
    }
}
