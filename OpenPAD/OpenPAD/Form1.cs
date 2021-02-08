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
            fontViewer.Text = document.Font.Name;
            if (CMDpath!="NOPATH")
            {
                if (CMDpath.Contains(".rtf"))
                {
                    Read(CMDpath, true);
                }
                else {
                    Read(CMDpath,false);
                }
            }
        }

        private void Read(string addr, bool asRtf)
        {
            if(asRtf){
                try
                {
                    document.LoadFile(addr);
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore durante il caricamento del file rtf, verra` tentato il caricamento come file di testo semplice","Errore durante la lettura del file rtf",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Read(addr, false);
                }
                
            }
            else
            {
                try
                {
                    StreamReader sr = new StreamReader(addr);
                    document.Text = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento del file di testo, il file system ha presentato il seguente errore: "+ex.Message,"Errore durante la lettura del file di testo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename.Contains(".rtf"))
                {
                    Read(openFileDialog1.FileName,true);
                }
                else
                {
                    Read(openFileDialog1.FileName, false);
                }
                
            }
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void NewDoc()
        {
            if (document.Text != "") {
                document.Clear();
                filename = "";
            }
            //inserire conferma operazione
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

        private void fontSelector_Click(object sender, EventArgs e)
        {
            DialogResult res = mainFont.ShowDialog();
            if (res == DialogResult.OK)
            {
                fontViewer.Text = mainFont.Font.Name;
                if (document.SelectedText.Length==0)
                {
                    document.Font = mainFont.Font;
                }
                else
                {
                    document.SelectionFont = mainFont.Font;
                }
            }
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
