using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressFiles
{
    public partial class Form1 : Form
    {
        private string _path;
        public Form1()
        {
            InitializeComponent();
            compressBtn.Enabled = false;
            decompressBtn.Enabled = false;
            compressedFileName.ReadOnly = true;
            showFileNameTxt.ReadOnly = true;
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
             _path = openFileDialog.FileName; showFileNameTxt.Text = _path;
            compressBtn.Enabled = true;
            decompressBtn.Enabled = true;
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            if (_path == null) 
            { 
                MessageBox.Show("Error"); return; 
            }
            string compressedFilePath = _path + ".gz";
            compressedFileName.Text = compressedFilePath;
            FileStream originalFileStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            FileStream compressedFileStream = new FileStream(compressedFilePath, FileMode.Create);
            GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);
            
                originalFileStream.CopyTo(compressionStream); 

            CompressingBytes(_path, compressedFilePath);
            compressionStream.Close();
            compressedFileStream.Close();
            originalFileStream.Close();
           
           

        }
        private void decompressBtn_Click(object sender, EventArgs e)
        {
            if (_path == null)
            {
                MessageBox.Show("Error"); return;
            }
            string decompressedFilePath = _path.Replace(".gz", "");
            compressedFileName.Text= decompressedFilePath;
           FileStream compressedFileStream = new FileStream(_path, FileMode.Open);

            FileStream decompressedFileStream = new FileStream(decompressedFilePath, FileMode.Create);

            GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress);
            {
                decompressionStream.CopyTo(decompressedFileStream);
            }
            DecompressingBytes(decompressedFilePath, _path);
            decompressionStream.Close();
            decompressedFileStream.Close();
            compressedFileStream.Close();

        }

      
        private void CompressingBytes(string originalFilePath, string compressedFilePath)
        {
            FileInfo originalFile = new FileInfo(originalFilePath); 
            FileInfo compressedFile = new FileInfo(compressedFilePath); 
            double savings = (originalFile.Length- compressedFile.Length);
            savedSpacelbl.Text = $"{savings} bytes";

        }
        private void DecompressingBytes(string originalFilePath, string compressedFilePath)
        {
            FileInfo originalFile = new FileInfo(originalFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);
            double savings = (originalFile.Length - compressedFile.Length);
            LostSpaceLbl.Text = $"{savings} bytes";

        }


    }
}
