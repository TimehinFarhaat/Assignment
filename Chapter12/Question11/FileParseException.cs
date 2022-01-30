using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class FileParseException:Exception
    {
        public FileParseException(string message,string fileName,int lines) : base(message)
        {

        }
    }
}
