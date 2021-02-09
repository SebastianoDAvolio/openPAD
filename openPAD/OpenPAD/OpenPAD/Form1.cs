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
        bool newFile=true;
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
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento del file di testo, il file system ha presentato il seguente errore: "+ex.Message,"Errore durante la lettura del file di testo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile = false;
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                //filename = openFileDialog1.SafeFileName;
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
            newFile = true;
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
            if (newFile == true)
            {
                if (CMDpath != "NOPATH")
                {
                    if (CMDpath.Contains(".rtf"))
                    {
                        saveWithName(true);
                    }
                    else
                    {
                        saveWithName(false);
                    }
                }
            }
            else
            {
                save(true);
            }
            
        }

        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (CMDpath.Contains(".rtf"))
                {
                    saveWithName(true);
                }
                else
                {
                    saveWithName(false);
                }
        }


        private void save(bool asRtf) //non funziona
        {
            if (asRtf)
            {
                //salvataggio file rtf
            }
            else
            {
                try
                {
                    if (CMDpath != "NOPATH")
                    {
                        if (CMDpath.Contains(".rtf"))
                        {
                            Read(CMDpath, true);
                        }
                        else
                        {
                            Read(CMDpath, false);
                        }
                    }
                    StreamWriter myStream = new StreamWriter(CMDpath);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    if (myStream != null)
                    {
                        myStream.Write(document.Text);
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il salvataggio del file di testo, Errore:" + ex.Message, "Errore durante la scritture del file di testo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void saveWithName(bool asRtf) //non salva il font e grassetto/corsivo/sottolineato
        {
            if (asRtf)
            {
                //salvataggio file rtf con nome
            }
            else
            {
                try
                {
                    Stream myStream;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    var fileContent = string.Empty;
                    saveFileDialog1.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt| All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream = saveFileDialog1.OpenFile()) != null)
                        {
                            using (StreamWriter writer = new StreamWriter(myStream))
                            {
                                writer.Write(document.Text);
                                writer.Close();
                            }
                            myStream.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il salvataggio del file di testo, Errore:" + ex.Message,"Errore durante la scritture del file di testo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
