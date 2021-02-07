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

namespace OpenPAD
{
    public partial class Form1 : Form
    {
        string CMDpath;
        string filename;
        public Form1(string path)
        {
            CMDpath = path;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CMDpath!="NOPATH")
            {
                Read(CMDpath);
            }
        }

        private void Read(string addr)
        {
            if(addr.Contains(".rtf")){
                document.LoadFile(addr);
            }
            else
            {
                StreamReader sr = new StreamReader(addr);
                document.Text = sr.ReadToEnd();
            }
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                Read(openFileDialog1.FileName);
            }
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void NewDoc()
        {
            document.Clear();
            filename = "";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
