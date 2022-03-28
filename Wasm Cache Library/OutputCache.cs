using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasm_Cache_Library.Classes;
using Wasm_Cache_Library.Library;

namespace Wasm_Cache_Library
{
    public class OutputCache
    {

        public static string WholeFile(string FileName, string FilePath)
        {
            string output = "";

            try
            {

                using (FileStream fsSource = new FileStream(FilePath + FileName,
                    FileMode.Open, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    int numBytesToRead = (int)fsSource.Length;
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    output = Helper.WriteByteArray(bytes);

                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }

            return output;
        }




    }
}
