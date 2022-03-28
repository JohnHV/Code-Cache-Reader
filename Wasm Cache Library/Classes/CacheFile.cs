using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasm_Cache_Library.Classes
{
    public class CacheFile
    {
        public SimpleFileHeader FileHeader { get; set; }
        public Key FileKey { get; set; }
        public DataStream Stream1 { get; set; }
        public SimpleFileEOF EOFstream1 { get; set; }
        public DataStream Stream0 { get; set; }
        public SimpleFileEOF EOFstream0 { get; set; }
        public string FileName { get; set; }



        public CacheFile(string _fileName, string FilePath)
        {
            try
            {

                using (FileStream fsSource = new FileStream(FilePath + _fileName,
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
                    
                    
                    if (bytes.Count() > 24)       //Check the file at least has enough bytes for the header
                    {
                        byte[] headerBytes = new byte[24];
                        Buffer.BlockCopy(bytes, 0, headerBytes, 0, 24);

                        //Create the simple file header
                        FileHeader = new SimpleFileHeader(headerBytes);

                        //Create the key
                        byte[] keyBites = new byte[FileHeader.KeyLength];
                        Buffer.BlockCopy(bytes, 24, keyBites, 0, FileHeader.KeyLength);
                        FileKey = new Key(keyBites);

                        //Create the EOF Object next because this contains the number of bytes in the data stream
                        byte[] footerBytes = new byte[24];
                        Buffer.BlockCopy(bytes, bytes.Count()-24, footerBytes, 0, 24);
                        EOFstream0 = new SimpleFileEOF(footerBytes);

                        //Get the SHA256 of the key
                        byte[] keyShaBytes = new byte[32];
                        Buffer.BlockCopy(bytes, bytes.Count() - 56, keyShaBytes, 0, 32);
                        FileKey.KeySHA256Bytes = keyShaBytes;

                        //Get the data stream
                        byte[] data0 = new byte[EOFstream0.stream_size];
                        Buffer.BlockCopy(bytes, bytes.Count() - 56 - EOFstream0.stream_size, data0, 0, EOFstream0.stream_size);
                        Stream0 = new DataStream();
                        Stream0.Data0 = data0;

                        //create the EOF object for stream 1, which is in the middle of the file
                        footerBytes = new byte[24];
                        Buffer.BlockCopy(bytes, bytes.Count() - 56 - EOFstream0.stream_size - 24, footerBytes, 0, 24);
                        EOFstream1 = new SimpleFileEOF(footerBytes);

                        //Get the data stream
                        byte[] data1 = new byte[EOFstream1.stream_size];
                        Buffer.BlockCopy(bytes, bytes.Count() - 80 - EOFstream0.stream_size - EOFstream1.stream_size, data1, 0, EOFstream1.stream_size);
                        Stream1 = new DataStream();
                        Stream1.Data0 = data1;

                        FileName = _fileName;
                    }
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }


        }




    }

    public class Class1
    {
    }
}
