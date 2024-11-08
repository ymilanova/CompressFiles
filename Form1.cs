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
            showFileNameTxt.Enabled = false;
            compressedFileName.Enabled = false;
            

        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if (ofd.ShowDialog() == DialogResult.OK)
             _path = ofd.FileName; 
            showFileNameTxt.Text = _path;
            compressBtn.Enabled = true;
            decompressBtn.Enabled = true;
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            string cfp = _path + ".comp";
            compressedFileName.Text = cfp;
            FileStream ofs = new FileStream(_path, FileMode.Open, FileAccess.Read);
            FileStream cfs = new FileStream(cfp, FileMode.Create);
            GZipStream cs = new GZipStream(cfs, CompressionMode.Compress);           
            ofs.CopyTo(cs);            
            cs.Close();
            cfs.Close();
            ofs.Close();
            CompressingBytes(_path, cfp);
        }
        private void decompressBtn_Click(object sender, EventArgs e)
        {  
            string dfp = _path.Replace(".comp", "");
            compressedFileName.Text= dfp;
            FileStream cfs = new FileStream(_path, FileMode.Open);
            FileStream dfs = new FileStream(dfp, FileMode.Create);
            GZipStream ds = new GZipStream(cfs, CompressionMode.Decompress);
            ds.CopyTo(dfs);
            DecompressingBytes(dfp, _path);
            ds.Close();
            dfs.Close();
            cfs.Close();
        }

        private void CompressingBytes(string inital, string newpath)
        {
            FileInfo of = new FileInfo(inital); 
            FileInfo cf = new FileInfo(newpath); 
            double bytes = of.Length- cf.Length;
            savedSpacelbl.Text = $"{bytes} bytes";

        }
        private void DecompressingBytes(string inital, string newpath)
        {
            FileInfo of = new FileInfo(inital);
            FileInfo cf = new FileInfo(newpath);
            double bytes = cf.Length - of.Length;
            savedSpacelbl.Text = $"{bytes} bytes";

        }


    }
}
