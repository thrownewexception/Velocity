using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity.core
{
    internal class utilities
    {
        public static MemoryStream convert_stringutf8_to_stream(string str)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(str ?? ""));
        }
    }
}
