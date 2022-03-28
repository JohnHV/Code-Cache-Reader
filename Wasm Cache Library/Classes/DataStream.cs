using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Library;
using System.Security.Cryptography;

namespace Wasm_Cache_Library.Classes
{
    public class DataStream
    {
        public byte[] Data0 { get; set; }

        public string Data0String
        {
            get
            {
                return Encoding.Default.GetString(Data0);
                //return Helper.WriteByteArray(Data0);
            }
        }

        public string LargeFileKey
        {
            get
            {
                if (Data0.Count() >= 64)
                {

                    byte[] largeFileKey = new byte[64];
                    Buffer.BlockCopy(Data0, 12, largeFileKey, 0, 64);
                    return Encoding.Default.GetString(largeFileKey);
                }
                else
                    return "";
            }
        }


        public string ByteCodeHash
        {
            get
            {
                if (Data0.Count() >= 40)
                {

                    byte[] bytecode = new byte[Data0.Count() - 40];
                    Buffer.BlockCopy(Data0, 8, bytecode, 0, Data0.Count() - 40);
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        // ComputeHash - returns byte array  
                        byte[] bytes = sha256Hash.ComputeHash(bytecode);

                        // Convert byte array to a string   
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }
                        return builder.ToString();
                    }
                }
                else
                    return "";
            }
        }


    }
}
