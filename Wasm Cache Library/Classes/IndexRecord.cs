using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Library;

namespace Wasm_Cache_Library.Classes
{
    public class IndexRecord
    {
        private byte[] indexBytes;

        public IndexRecord(byte[] indexBytes)
        {
            this.indexBytes = indexBytes;
            var microseconds = BitConverter.ToInt64(this.indexBytes, 8);
            var miliseconds = microseconds / 1000;
            var seconds = BitConverter.ToInt64(this.indexBytes, 8);
        }

        public string FileName
        {
            get
            {
                byte[] filenameBytes = new byte[8];
                Buffer.BlockCopy(this.indexBytes, 0, filenameBytes, 0, 8);
                return Helper.WriteReverseByteArray(filenameBytes).Replace("-", "").ToLower() + "_0";
            }
        }
        public DateTime LastUsed
        {
            get
            {

                var seconds = BitConverter.ToInt64(this.indexBytes, 8)/1000;
                DateTime basedate = new DateTime(1601, 1, 1, 0, 0, 0);

                return basedate.AddMilliseconds(seconds);

            }
        }
        public long FileSize
        {
            get
            {
                return BitConverter.ToInt64(this.indexBytes, 16);
            }
        }
    }
}
