﻿
namespace OpenPAD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontSelector = new System.Windows.Forms.Button();
            this.fontViewer = new System.Windows.Forms.TextBox();
            this.document = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteprimaDiStampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaPerPostaElettronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainFont = new System.Windows.Forms.FontDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bold = new System.Windows.Forms.Button();
            this.italic = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.leftA = new System.Windows.Forms.Button();
            this.CentA = new System.Windows.Forms.Button();
            this.RightA = new System.Windows.Forms.Button();
            this.forecolor = new System.Windows.Forms.Button();
            this.highlight = new System.Windows.Forms.Button();
            this.forecolorDial = new System.Windows.Forms.ColorDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toolsSave = new System.Windows.Forms.Button();
            this.toolsSaveN = new System.Windows.Forms.Button();
            this.toolsPP = new System.Windows.Forms.Button();
            this.toolsP = new System.Windows.Forms.Button();
            this.toolsMail = new System.Windows.Forms.Button();
            this.toolsNew = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.toolsNew);
            this.panel1.Controls.Add(this.toolsMail);
            this.panel1.Controls.Add(this.toolsPP);
            this.panel1.Controls.Add(this.toolsP);
            this.panel1.Controls.Add(this.toolsSaveN);
            this.panel1.Controls.Add(this.toolsSave);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.highlight);
            this.panel1.Controls.Add(this.forecolor);
            this.panel1.Controls.Add(this.RightA);
            this.panel1.Controls.Add(this.CentA);
            this.panel1.Controls.Add(this.leftA);
            this.panel1.Controls.Add(this.underline);
            this.panel1.Controls.Add(this.italic);
            this.panel1.Controls.Add(this.bold);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.fontSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.fontSelector);
            this.panel1.Controls.Add(this.fontViewer);
            this.panel1.Location = new System.Drawing.Point(-3, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 97);
            this.panel1.TabIndex = 0;
            // 
            // fontSelector
            // 
            this.fontSelector.Location = new System.Drawing.Point(574, 10);
            this.fontSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontSelector.Name = "fontSelector";
            this.fontSelector.Size = new System.Drawing.Size(58, 35);
            this.fontSelector.TabIndex = 2;
            this.fontSelector.Text = "...";
            this.fontSelector.UseVisualStyleBackColor = true;
            this.fontSelector.Click += new System.EventHandler(this.fontSelector_Click);
            // 
            // fontViewer
            // 
            this.fontViewer.Location = new System.Drawing.Point(418, 10);
            this.fontViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontViewer.Multiline = true;
            this.fontViewer.Name = "fontViewer";
            this.fontViewer.Size = new System.Drawing.Size(148, 35);
            this.fontViewer.TabIndex = 1;
            // 
            // document
            // 
            this.document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document.Location = new System.Drawing.Point(84, 143);
            this.document.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.document.Name = "document";
            this.document.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.document.ShowSelectionMargin = true;
            this.document.Size = new System.Drawing.Size(1440, 898);
            this.document.TabIndex = 0;
            this.document.Text = "";
            this.document.TextChanged += new System.EventHandler(this.document_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1622, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaConNomeToolStripMenuItem,
            this.stampaToolStripMenuItem,
            this.anteprimaDiStampaToolStripMenuItem,
            this.inviaPerPostaElettronicaToolStripMenuItem,
            this.informazioniToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuovoToolStripMenuItem.Image = global::OpenPAD.Properties.Resources._new;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.open;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.apriToolStripMenuItem.Text = "&Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.save;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaConNomeToolStripMenuItem
            // 
            this.salvaConNomeToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.nameSave;
            this.salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
            this.salvaConNomeToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.salvaConNomeToolStripMenuItem.Text = "Salva &con nome";
            this.salvaConNomeToolStripMenuItem.Click += new System.EventHandler(this.salvaConNomeToolStripMenuItem_Click);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.print;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.stampaToolStripMenuItem.Text = "&Stam&pa";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // anteprimaDiStampaToolStripMenuItem
            // 
            this.anteprimaDiStampaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.preview;
            this.anteprimaDiStampaToolStripMenuItem.Name = "anteprimaDiStampaToolStripMenuItem";
            this.anteprimaDiStampaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.anteprimaDiStampaToolStripMenuItem.Text = "Antepri&ma di stampa";
            this.anteprimaDiStampaToolStripMenuItem.Click += new System.EventHandler(this.anteprimaDiStampaToolStripMenuItem_Click);
            // 
            // inviaPerPostaElettronicaToolStripMenuItem
            // 
            this.inviaPerPostaElettronicaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.mail;
            this.inviaPerPostaElettronicaToolStripMenuItem.Name = "inviaPerPostaElettronicaToolStripMenuItem";
            this.inviaPerPostaElettronicaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.inviaPerPostaElettronicaToolStripMenuItem.Text = "&Invia per posta elettronica";
            this.inviaPerPostaElettronicaToolStripMenuItem.Click += new System.EventHandler(this.inviaPerPostaElettronicaToolStripMenuItem_Click);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.info;
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.informazioniToolStripMenuItem.Text = "Informa&zioni";
            this.informazioniToolStripMenuItem.Click += new System.EventHandler(this.informazioniToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.exit;
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openDialog";
            this.openFileDialog1.Filter = "Rich Text File (*.rtf)|*.rtf|Simple Text txt (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Rich Text File (*.rtf)|*.rtf|Simple Text txt (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(349, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 84);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dimensione:";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(468, 56);
            this.fontSize.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(164, 26);
            this.fontSize.TabIndex = 6;
            this.fontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(829, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 84);
            this.panel3.TabIndex = 4;
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(846, 10);
            this.bold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(58, 35);
            this.bold.TabIndex = 7;
            this.bold.Text = "G";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(912, 10);
            this.italic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(58, 35);
            this.italic.TabIndex = 8;
            this.italic.Text = "C";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.Location = new System.Drawing.Point(978, 10);
            this.underline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(58, 35);
            this.underline.TabIndex = 9;
            this.underline.Text = "S";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // leftA
            // 
            this.leftA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftA.Location = new System.Drawing.Point(846, 55);
            this.leftA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftA.Name = "leftA";
            this.leftA.Size = new System.Drawing.Size(58, 35);
            this.leftA.TabIndex = 10;
            this.leftA.Text = "|||";
            this.leftA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftA.UseVisualStyleBackColor = true;
            this.leftA.Click += new System.EventHandler(this.leftA_Click);
            // 
            // CentA
            // 
            this.CentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentA.Location = new System.Drawing.Point(912, 55);
            this.CentA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CentA.Name = "CentA";
            this.CentA.Size = new System.Drawing.Size(58, 35);
            this.CentA.TabIndex = 11;
            this.CentA.Text = "|||";
            this.CentA.UseVisualStyleBackColor = true;
            this.CentA.Click += new System.EventHandler(this.CentA_Click);
            // 
            // RightA
            // 
            this.RightA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightA.Location = new System.Drawing.Point(978, 55);
            this.RightA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightA.Name = "RightA";
            this.RightA.Size = new System.Drawing.Size(58, 35);
            this.RightA.TabIndex = 11;
            this.RightA.Text = "|||";
            this.RightA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightA.UseVisualStyleBackColor = true;
            this.RightA.Click += new System.EventHandler(this.RightA_Click);
            // 
            // forecolor
            // 
            this.forecolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecolor.ForeColor = System.Drawing.Color.Red;
            this.forecolor.Location = new System.Drawing.Point(1044, 9);
            this.forecolor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forecolor.Name = "forecolor";
            this.forecolor.Size = new System.Drawing.Size(58, 35);
            this.forecolor.TabIndex = 12;
            this.forecolor.Text = "A";
            this.forecolor.UseVisualStyleBackColor = true;
            this.forecolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // highlight
            // 
            this.highlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.highlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight.ForeColor = System.Drawing.Color.Black;
            this.highlight.Location = new System.Drawing.Point(1044, 55);
            this.highlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highlight.Name = "highlight";
            this.highlight.Size = new System.Drawing.Size(58, 35);
            this.highlight.TabIndex = 13;
            this.highlight.Text = "A";
            this.highlight.UseVisualStyleBackColor = false;
            this.highlight.Click += new System.EventHandler(this.highlight_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(1109, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 84);
            this.panel4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 51);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "PED";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(755, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147418112});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 26);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "inter:";
            // 
            // toolsSave
            // 
            this.toolsSave.BackgroundImage = global::OpenPAD.Properties.Resources.save;
            this.toolsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsSave.Location = new System.Drawing.Point(196, 10);
            this.toolsSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsSave.Name = "toolsSave";
            this.toolsSave.Size = new System.Drawing.Size(43, 35);
            this.toolsSave.TabIndex = 18;
            this.toolsSave.UseVisualStyleBackColor = true;
            this.toolsSave.Click += new System.EventHandler(this.toolsSave_Click);
            // 
            // toolsSaveN
            // 
            this.toolsSaveN.BackgroundImage = global::OpenPAD.Properties.Resources.nameSave;
            this.toolsSaveN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsSaveN.Location = new System.Drawing.Point(196, 51);
            this.toolsSaveN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsSaveN.Name = "toolsSaveN";
            this.toolsSaveN.Size = new System.Drawing.Size(43, 35);
            this.toolsSaveN.TabIndex = 19;
            this.toolsSaveN.UseVisualStyleBackColor = true;
            this.toolsSaveN.Click += new System.EventHandler(this.toolsSaveN_Click);
            // 
            // toolsPP
            // 
            this.toolsPP.BackgroundImage = global::OpenPAD.Properties.Resources.preview;
            this.toolsPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsPP.Location = new System.Drawing.Point(247, 51);
            this.toolsPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsPP.Name = "toolsPP";
            this.toolsPP.Size = new System.Drawing.Size(43, 35);
            this.toolsPP.TabIndex = 21;
            this.toolsPP.UseVisualStyleBackColor = true;
            // 
            // toolsP
            // 
            this.toolsP.BackgroundImage = global::OpenPAD.Properties.Resources.print;
            this.toolsP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsP.Location = new System.Drawing.Point(247, 10);
            this.toolsP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsP.Name = "toolsP";
            this.toolsP.Size = new System.Drawing.Size(43, 35);
            this.toolsP.TabIndex = 20;
            this.toolsP.UseVisualStyleBackColor = true;
            // 
            // toolsMail
            // 
            this.toolsMail.BackgroundImage = global::OpenPAD.Properties.Resources.mail;
            this.toolsMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsMail.Location = new System.Drawing.Point(298, 10);
            this.toolsMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsMail.Name = "toolsMail";
            this.toolsMail.Size = new System.Drawing.Size(43, 35);
            this.toolsMail.TabIndex = 22;
            this.toolsMail.UseVisualStyleBackColor = true;
            this.toolsMail.Click += new System.EventHandler(this.toolsMail_Click);
            // 
            // toolsNew
            // 
            this.toolsNew.BackgroundImage = global::OpenPAD.Properties.Resources.open;
            this.toolsNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsNew.Location = new System.Drawing.Point(298, 51);
            this.toolsNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsNew.Name = "toolsNew";
            this.toolsNew.Size = new System.Drawing.Size(43, 35);
            this.toolsNew.TabIndex = 23;
            this.toolsNew.UseVisualStyleBackColor = true;
            this.toolsNew.Click += new System.EventHandler(this.toolsNew_Click);
            // 
            // help
            // 
            this.help.BackgroundImage = global::OpenPAD.Properties.Resources.info;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help.Location = new System.Drawing.Point(1445, 10);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(82, 80);
            this.help.TabIndex = 24;
            this.help.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(1429, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 84);
            this.panel5.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::OpenPAD.Properties.Resources._new;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(87, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 80);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1622, 1042);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.document);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPAD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox document;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaConNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteprimaDiStampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inviaPerPostaElettronicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fontSelector;
        private System.Windows.Forms.TextBox fontViewer;
        private System.Windows.Forms.FontDialog mainFont;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button RightA;
        private System.Windows.Forms.Button CentA;
        private System.Windows.Forms.Button leftA;
        private System.Windows.Forms.Button highlight;
        private System.Windows.Forms.Button forecolor;
        private System.Windows.Forms.ColorDialog forecolorDial;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toolsNew;
        private System.Windows.Forms.Button toolsMail;
        private System.Windows.Forms.Button toolsPP;
        private System.Windows.Forms.Button toolsP;
        private System.Windows.Forms.Button toolsSaveN;
        private System.Windows.Forms.Button toolsSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button button3;
    }
}

