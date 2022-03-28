using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Library;

namespace Wasm_Cache_Library.Classes
{
    public class SimpleFileEOF
    {
        private byte[] _FooterBytes;

        public int Flags
        {
            get
            {
                return BitConverter.ToInt32(_FooterBytes, 8);
            }
        }

        public SimpleFileEOF(byte[] FooterRaw)
        {
            _FooterBytes = FooterRaw;

        }

        public string final_magic_number
        {
            get
            {
                return Helper.WriteByteArray(final_magic_number_bytes);
            }
        }

        public byte[] final_magic_number_bytes
        {
            get
            {
                byte[] _final_magic_number_bytes = new byte[8];
                Buffer.BlockCopy(_FooterBytes, 0, _final_magic_number_bytes, 0, 8);
                return _final_magic_number_bytes;
            }
        }

        public byte[] data_crc_bytes
        {
            get
            {
                byte[] _data_crc_bytes = new byte[4];
                Buffer.BlockCopy(_FooterBytes, 12, _data_crc_bytes, 0, 4);
                return _data_crc_bytes;
            }
        }

        public int stream_size
        {
            get
            {
                return BitConverter.ToInt32(_FooterBytes, 16);
            }
        }

    }
}
