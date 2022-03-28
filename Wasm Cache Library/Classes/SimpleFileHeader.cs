using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Library;

namespace Wasm_Cache_Library.Classes
{
    public class SimpleFileHeader
    {
        private byte[] _HeaderBytes;

        public string initial_magic_number
        {
            get
            {
                return Helper.WriteByteArray(initial_magic_number_bytes);
            }
        }
        public byte[] initial_magic_number_bytes
        {
            get
            {
                byte[] _initial_magic_number_bytes = new byte[8];
                Buffer.BlockCopy(_HeaderBytes, 0, _initial_magic_number_bytes, 0, 8);
                return _initial_magic_number_bytes;
            }
        }

        public bool initial_magic_number_ok
        {
            get
            {
                if (initial_magic_number == "30-5C-72-A7-1B-6D-FB-FC")
                    return true;
                else
                    return false;
            }
        }

        public int KeyLength
        {
            get
            {
                return BitConverter.ToInt32(_HeaderBytes, 12);
            }
        }

        public string KeyHash
        {
            get
            {
                byte[] KeyHashBytes = new byte[4];
                Buffer.BlockCopy(_HeaderBytes, 16, KeyHashBytes, 0, 4);
                return Helper.WriteByteArray(KeyHashBytes);

            }
        }
        public int Version
        {
            get
            {
                return BitConverter.ToInt32(_HeaderBytes, 8);
            }
        }


        public SimpleFileHeader(byte[] HeaderRaw)
        {
            _HeaderBytes = HeaderRaw;

        }
    }
}
