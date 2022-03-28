using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Wasm_Cache_Library;
using Wasm_Cache_Library.Classes;

namespace Wasm_Cache_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text.Trim();

            //read in the index file to a collection of index entries
            IndexFile indexFile = new IndexFile(filePath + @"index-dir\");


            //read in all the cache files into a collection
            List<CacheFile> cacheList = new List<CacheFile>();
            foreach (var indexEntry in indexFile.indexRecords)
            {
                CacheFile cacheFile = new CacheFile(indexEntry.FileName, filePath);
                cacheList.Add(cacheFile);

            }
            //start to create the overall cache structure
            List<OverallCacheStructure> overallList = new List<OverallCacheStructure>();
            foreach (var indexEntry in indexFile.indexRecords.Where(x => x.FileSize > 512))
            {
                OverallCacheStructure overallSingle = new OverallCacheStructure();
                CacheFile largeFile = cacheList.Where(x => x.FileName == indexEntry.FileName).First();
                overallSingle.LargeFile = largeFile;
                overallSingle.LargeIndexEntry = indexEntry;
                if (overallSingle.LargeFile.EOFstream0.stream_size == 0)        //to make sure this is a large file, check that Stream 0 is empty
                {
                    overallList.Add(overallSingle);
                }
            }

            //find the small files to go with the large files based on the large file keys
            foreach (var overallSingle in overallList)
            {
                CacheFile smallFile = cacheList.Where(x => x.Stream0.LargeFileKey == overallSingle.LargeFile.FileKey.KeyString).FirstOrDefault();
                if (smallFile != null)
                {
                    overallSingle.SmallFile = smallFile;
                    overallSingle.SmallIndexEntry = indexFile.indexRecords.Where(x => x.FileName == smallFile.FileName).FirstOrDefault();


                }
            }

            //add the orphaned small files in plus ones linking to the same file
            foreach (var indexEntry in indexFile.indexRecords.Where(x => x.FileSize == 512))
            {
                //see if the small file is already in the structure
                if (overallList.Where(x => x.SmallFilename == indexEntry.FileName).Count() == 0)
                {
                    OverallCacheStructure overallSingle = new OverallCacheStructure();
                    CacheFile smallFile = cacheList.Where(x => x.FileName == indexEntry.FileName).First();
                    overallSingle.SmallFile = smallFile;
                    overallSingle.SmallIndexEntry = indexEntry;
                    //see if there is a large file to match to
                    CacheFile largeFile = cacheList.Where(x => x.FileKey.KeyString == overallSingle.SmallFile.Stream0.LargeFileKey).FirstOrDefault();
                    if (largeFile != null)
                    {
                        overallSingle.LargeFile = largeFile;
                        overallSingle.LargeIndexEntry = indexFile.indexRecords.Where(x => x.FileName == largeFile.FileName).FirstOrDefault();
                    }

                    overallList.Add(overallSingle);
                }
            }


            overallList.Sort((x,y) => x.LargeFilename.CompareTo(y.LargeFilename));
            dgvCacheIndex.DataSource = overallList;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\Code Cache\wasm\";
        }

        private void cmbBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrowser.SelectedItem.ToString()=="Chrome")
            {
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\Code Cache\wasm\";
            } else
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\Code Cache\wasm\";

        }
    }
}
