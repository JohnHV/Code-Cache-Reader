using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Library;

namespace Wasm_Cache_Library.Classes
{
    public class Key
    {
        public string KeyString { get; set; }
        public byte[] KeyBytes { get; set; }

        public Key(byte[] key)
        {
            KeyBytes = key;
            KeyString = Encoding.Default.GetString(key);
        }

        public byte[] KeySHA256Bytes { get; set; }

        public string KeySHA256String
        {
            get
            {
                return Encoding.Default.GetString(KeySHA256Bytes);
            }
        }


    }
}
