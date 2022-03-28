using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasm_Cache_Library.Classes
{
    public class OverallCacheStructure
    {
        public CacheFile SmallFile { get; set; }
        public CacheFile LargeFile { get; set; }
        public IndexRecord SmallIndexEntry { get; set; }
        public IndexRecord LargeIndexEntry { get; set; }
        public string SmallFilename
        {
            get
            {
                if (SmallIndexEntry != null)
                {
                    return SmallIndexEntry.FileName;
                }
                else
                    return "";
            }
        }
        public string LargeFilename
        {
            get
            {
                if (LargeIndexEntry != null)
                {
                    return LargeIndexEntry.FileName;
                }
                else
                    return "";
            }
        }

        public string Key
        {
            get
            {
                if (SmallFile != null)
                {
                    return SmallFile.FileKey.KeyString;
                }
                else
                    return "";
            }
        }

        public string ResourceName
        {
            get
            {
                if (SmallFile != null)
                {


                    byte[] keyBites = SmallFile.FileKey.KeyBytes;
                    byte[] searchBytes = new byte[2];
                    searchBytes[0] = 32;
                    searchBytes[1] = 10;
                    int breakValue = 0;
                    for (int i = 0; i < keyBites.Length; i++)
                    {
                        if (keyBites.Skip(i).Take(searchBytes.Length).SequenceEqual(searchBytes))
                        {
                            breakValue = i;
                        }

                    }

                    byte[] fileNamebytes = new byte[breakValue - 4];
                    Buffer.BlockCopy(keyBites, 4, fileNamebytes, 0, breakValue - 4);

                    return Encoding.Default.GetString(fileNamebytes);
                }
                else
                    return "";
            }
        }

        public string DomainName
        {
            get
            {
                if (SmallFile != null)
                {


                    byte[] keyBites = SmallFile.FileKey.KeyBytes;
                    byte[] searchBytes = new byte[2];
                    searchBytes[0] = 32;
                    searchBytes[1] = 10;
                    int breakValue = 0;
                    for (int i = 0; i < keyBites.Length; i++)
                    {
                        if (keyBites.Skip(i).Take(searchBytes.Length).SequenceEqual(searchBytes))
                        {
                            breakValue = i;
                        }

                    }

                    byte[] fileNamebytes = new byte[keyBites.Count() - breakValue - 2];
                    Buffer.BlockCopy(keyBites, breakValue + 2, fileNamebytes, 0, keyBites.Count() - breakValue - 2);

                    return Encoding.Default.GetString(fileNamebytes);
                }
                else
                    return "";
            }
        }

        public string LargelastUsed
        {
            get
            {
                if (LargeIndexEntry != null)
                    return LargeIndexEntry.LastUsed.ToString("HH:mm:ss dd/MM/yyyy");
                else
                    return "";
            }
        }

        public string SmallLastUsed
        {
            get
            {
                if (SmallIndexEntry != null)
                    return SmallIndexEntry.LastUsed.ToString("HH:mm:ss dd/MM/yyyy");
                else
                    return "";
            }
        }

        public int LargeFileStreamSize
        {
            get
            {
                if (LargeFile != null)

                    return LargeFile.EOFstream1.stream_size;

                else
                    return 0;
            }
        }

        public string ByteCodeHash
        {
            get
            {
                if (LargeFile != null)
                    return LargeFile.Stream1.ByteCodeHash;
                else
                    return "";
            }
        }
    }
}
