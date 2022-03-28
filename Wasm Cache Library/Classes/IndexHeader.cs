using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasm_Cache_Library.Classes
{
    public class IndexHeader
    {
        private byte[] headerBytes;

        public IndexHeader(byte[] headerBytes)
        {
            this.headerBytes = headerBytes;



        }

        public int IndexFileCount
        {
            get
            {
                return BitConverter.ToInt32(headerBytes, 20);
            }
        }

        public long CacheSize
        {
            get
            {
                return BitConverter.ToInt64(headerBytes, 28);
            }
        }
    }
}
