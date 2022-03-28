using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasm_Cache_Library.Library
{
    class Helper
    {
        public static string WriteByteArray(byte[] bytes)
        {
            return (BitConverter.ToString(bytes));
        }

        public static string WriteReverseByteArray(byte[] bytes)
        {
            return (BitConverter.ToString(bytes.Reverse().ToArray()));
        }


    }
}
