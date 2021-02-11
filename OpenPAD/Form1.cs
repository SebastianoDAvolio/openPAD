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
        bool saved = false;
        public Form1(string path)
        {
            CMDpath = path;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Appear('C');
            fontViewer.Text = document.Font.Name;
            fontSize.Value = (decimal)document.Font.Size;
            if (CMDpath != "NOPATH")
            {
                filename = CMDpath;
                if (CMDpath.Contains(".rtf"))
                {
                    Read(CMDpath, true);
                }
                else
                {
                    Read(CMDpath, false);
                }
            }
            else
            {
                filename = "";
            }
        }
        private string ExportFile()
        {
            string tempName = filename;
            filename = "comms/" + DateTime.Now.Ticks.ToString() + ".rtf";
            if (!System.IO.Directory.Exists("comms"))
            {
                System.IO.Directory.CreateDirectory("comms");
            }
            save(false);
            string exp = filename;
            filename = tempName;
            return exp;
        }
        private void Read(string addr, bool asRtf)
        {
            if (asRtf)
            {
                try
                {
                    document.LoadFile(addr);
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore durante il caricamento del file rtf, verra` tentato il caricamento come file di testo semplice", "Errore durante la lettura del file rtf", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Errore durante il caricamento del file di testo, il file system ha presentato il seguente errore: " + ex.Message, "Errore durante la lettura del file di testo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Read(openFileDialog1.FileName, true);
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
            if (document.Text != "")
            {
                DialogResult res = MessageBox.Show("Il documento non e' vuoto, sicuro di voler cancellare le modifiche?", "Nuovo documento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    document.Clear();
                    filename = "";
                }
            }
            else
            {
                document.Clear();
                filename = "";
            }
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
                if (document.SelectedText.Length == 0)
                {
                    document.Font = mainFont.Font;
                }
                else
                {
                    document.SelectionFont = mainFont.Font;
                }
            }
            fontSize.Value = (decimal)document.Font.Size;
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(false);
        }

        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(true);
        }


        private void save(bool name)
        {
            if (name == true)
            {
                DialogResult res = saveFile.ShowDialog();
                filename = saveFile.FileName;
                if (res == DialogResult.OK)
                {
                    execSave(filename);
                }
            }
            else
            {
                if (filename!="")
                {
                    execSave(filename);
                }
                else
                {
                    save(true);
                }
                
            }
        }

        private void execSave(string name)
        {
            if (name.Contains(".rtf"))
            {
                System.IO.File.WriteAllText(name, document.Rtf);
            }
            else
            {
                System.IO.File.WriteAllText(name, document.Text);
            }
            saved = true;
        }

        private void inviaPerPostaElettronicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exp = ExportFile();
            email form = new email(exp);
            form.Show();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(document.Width,document.Height);
            //Rectangle rc = new Rectangle(0, 0, this.document.Width, this.document.Height);
            //document.DrawToBitmap(bm, rc);
            //e.Graphics.DrawImage(bm, 0, 0);

            string stringToPrint = "";
            if (saved)
            {

                printDocument1.DocumentName = filename;

                //per stampare il file aperto --> però prima bisogna salvare
                using (FileStream stream = new FileStream(CMDpath, FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    stringToPrint = reader.ReadToEnd();
                }
            }
            else
            {

            }



            //per stampare cosa c'è scritto in "document"
            //stringToPrint = document.Text;

            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);



            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);

            e.HasMorePages = (stringToPrint.Length > 0);
        }

        private void anteprimaDiStampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //documento da visualizzare nell'anteprima
            //printPreviewDialog1.Document = filename;

            printPreviewDialog1.ShowDialog();
        }

        private void document_TextChanged(object sender, EventArgs e)
        {
            fontViewer.Text = document.Font.Name.ToString();
        }

        private void newDoc_btn_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            if (document.SelectedText.Length == 0)
            {
                document.SelectAll();
                document.Font = new Font(document.SelectionFont.FontFamily, (float)fontSize.Value,
                document.SelectionFont.Style, document.SelectionFont.Unit);
            }
            else
            {
                document.SelectionFont = new Font(document.SelectionFont.FontFamily, (float)fontSize.Value,
                document.SelectionFont.Style, document.SelectionFont.Unit);
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            Appear('B');
        }

        private void Appear(char style)
        {
            if (document.SelectedText.Length == 0)
            {
                document.SelectAll();
            }
            switch (style)
            {
                case 'B':
                    if (document.SelectionFont.Bold)
                    {
                        document.SelectionFont= new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Regular, document.SelectionFont.Unit);
                    }
                    else
                    {
                        document.SelectionFont = new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Bold, document.SelectionFont.Unit);
                    }

                    break;
                case 'I':
                    if (document.SelectionFont.Italic)
                    {
                        document.SelectionFont = new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Regular, document.SelectionFont.Unit);
                    }
                    else
                    {
                        document.SelectionFont = new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Italic, document.SelectionFont.Unit);
                    }

                    break;
                case 'U':
                    if (document.SelectionFont.Underline)
                    {
                        document.SelectionFont = new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Regular, document.SelectionFont.Unit);
                    }
                    else
                    {
                        document.SelectionFont = new Font(document.SelectionFont.FontFamily, document.SelectionFont.Size,
                        FontStyle.Underline, document.SelectionFont.Unit);
                    }

                    break;
                case 'L':
                    if (document.SelectionAlignment == HorizontalAlignment.Left)
                    {
                        document.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else
                    {
                        document.SelectionAlignment = HorizontalAlignment.Left;
                    }
                    break;
                case 'R':
                    if (document.SelectionAlignment == HorizontalAlignment.Right)
                    {
                        document.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else
                    {
                        document.SelectionAlignment = HorizontalAlignment.Right;
                    }
                    break;
                case 'C':
                    if (document.SelectionAlignment == HorizontalAlignment.Center)
                    {
                        document.SelectionAlignment = HorizontalAlignment.Left;
                    }
                    else
                    {
                        document.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    break;
                case 'F':
                    Color color=Color.Black;
                    DialogResult res = forecolorDial.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        color = forecolorDial.Color;
                        if (document.SelectionColor == color)
                        {
                            document.SelectionColor = Color.Black;
                        }
                        else
                        {
                            document.SelectionColor = color;
                        }
                        forecolorDial.Color = Color.Black;
                    }
                    break;
                case 'H':
                    Color colorB = Color.Black;
                    DialogResult resB = forecolorDial.ShowDialog();
                    if (resB == DialogResult.OK)
                    {
                        colorB = forecolorDial.Color;
                        if (document.SelectionBackColor == colorB)
                        {
                            document.SelectionBackColor = Color.White;
                        }
                        else
                        {
                            document.SelectionBackColor = colorB;
                        }
                        forecolorDial.Color = Color.White;
                    }
                    break;
                //case 'X':
                    //esponente
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            Appear('I');
        }

        private void underline_Click(object sender, EventArgs e)
        {
            Appear('U');
        }

        private void leftA_Click(object sender, EventArgs e)
        {
            Appear('L');
        }

        private void CentA_Click(object sender, EventArgs e)
        {
            Appear('C');
        }

        private void RightA_Click(object sender, EventArgs e)
        {
            Appear('R');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appear('F');
        }

        private void highlight_Click(object sender, EventArgs e)
        {
            Appear('H');
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Appear('X');
        }

        private void toolsSave_Click(object sender, EventArgs e)
        {
            save(false);
        }

        private void toolsSaveN_Click(object sender, EventArgs e)
        {
            save(true);
        }

        private void toolsMail_Click(object sender, EventArgs e)
        {
            string exp = ExportFile();
            email form = new email(exp);
            form.Show();
        }

        private void toolsNew_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename.Contains(".rtf"))
                {
                    Read(openFileDialog1.FileName, true);
                }
                else
                {
                    Read(openFileDialog1.FileName, false);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewDoc();
        }
    }
}
