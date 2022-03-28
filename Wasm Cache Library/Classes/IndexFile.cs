using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasm_Cache_Library.Classes
{
    public class IndexFile
    {

        public IndexHeader indexHeader { get; set; }
        public List<IndexRecord> indexRecords { get; set; }


        public IndexFile(string IndexPath)
        {
                        indexRecords = new List<IndexRecord>();
            try
            {

                using (FileStream fsSource = new FileStream(IndexPath + "the-real-index",
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


                    if (bytes.Count() >= 40)       //Check the file at least has enough bytes for the header
                    {
                        byte[] headerBytes = new byte[40];
                        Buffer.BlockCopy(bytes, 0, headerBytes, 0, 40);

                        //Create the simple file header
                        indexHeader = new IndexHeader(headerBytes);

                        for (int i = 0; i < indexHeader.IndexFileCount; i++)
                        {
                            byte[] indexBytes = new byte[24];
                            Buffer.BlockCopy(bytes, 40 + (i *24), indexBytes, 0, 24);
                            IndexRecord indexFile = new IndexRecord(indexBytes);
                            indexRecords.Add(indexFile);
                        }

                    }
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }

        }


    }
}
