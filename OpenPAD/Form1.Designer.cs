
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
            this.document = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainFont = new System.Windows.Forms.FontDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.forecolorDial = new System.Windows.Forms.ColorDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hiddenBold = new System.Windows.Forms.Button();
            this.hiddenItalic = new System.Windows.Forms.Button();
            this.hiddenUnderline = new System.Windows.Forms.Button();
            this.hiddenFore = new System.Windows.Forms.Button();
            this.hiddenHighlight = new System.Windows.Forms.Button();
            this.hiddenLal = new System.Windows.Forms.Button();
            this.hiddenRal = new System.Windows.Forms.Button();
            this.hiddenCAl = new System.Windows.Forms.Button();
            this.hiddenEx = new System.Windows.Forms.Button();
            this.hiddenPed = new System.Windows.Forms.Button();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaPerPostaElettronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontViewer = new System.Windows.Forms.TextBox();
            this.fontSelector = new System.Windows.Forms.Button();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.interline = new System.Windows.Forms.NumericUpDown();
            this.toolsSave = new System.Windows.Forms.Button();
            this.toolsSaveN = new System.Windows.Forms.Button();
            this.toolsP = new System.Windows.Forms.Button();
            this.toolsMail = new System.Windows.Forms.Button();
            this.toolsNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interline)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.newbtn);
            this.panel1.Controls.Add(this.toolsMail);
            this.panel1.Controls.Add(this.RightA);
            this.panel1.Controls.Add(this.forecolor);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.CentA);
            this.panel1.Controls.Add(this.highlight);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.leftA);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.toolsNew);
            this.panel1.Controls.Add(this.underline);
            this.panel1.Controls.Add(this.fontViewer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.italic);
            this.panel1.Controls.Add(this.fontSelector);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.toolsP);
            this.panel1.Controls.Add(this.bold);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.toolsSaveN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.interline);
            this.panel1.Controls.Add(this.toolsSave);
            this.panel1.Controls.Add(this.fontSize);
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 63);
            this.panel1.TabIndex = 0;
            // 
            // document
            // 
            this.document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document.Location = new System.Drawing.Point(12, 102);
            this.document.Name = "document";
            this.document.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.document.ShowSelectionMargin = true;
            this.document.Size = new System.Drawing.Size(1046, 459);
            this.document.TabIndex = 0;
            this.document.Text = "";
            this.document.TextChanged += new System.EventHandler(this.document_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.guidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
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
            this.inviaPerPostaElettronicaToolStripMenuItem,
            this.informazioniToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
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
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.hiddenPed);
            this.panel6.Controls.Add(this.hiddenEx);
            this.panel6.Controls.Add(this.hiddenCAl);
            this.panel6.Controls.Add(this.hiddenRal);
            this.panel6.Controls.Add(this.hiddenLal);
            this.panel6.Controls.Add(this.hiddenHighlight);
            this.panel6.Controls.Add(this.hiddenFore);
            this.panel6.Controls.Add(this.hiddenUnderline);
            this.panel6.Controls.Add(this.hiddenItalic);
            this.panel6.Controls.Add(this.hiddenBold);
            this.panel6.Location = new System.Drawing.Point(1061, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 120);
            this.panel6.TabIndex = 5;
            // 
            // hiddenBold
            // 
            this.hiddenBold.Location = new System.Drawing.Point(3, 3);
            this.hiddenBold.Name = "hiddenBold";
            this.hiddenBold.Size = new System.Drawing.Size(75, 23);
            this.hiddenBold.TabIndex = 0;
            this.hiddenBold.Text = "&b";
            this.hiddenBold.UseVisualStyleBackColor = true;
            this.hiddenBold.Click += new System.EventHandler(this.hiddenBold_Click);
            // 
            // hiddenItalic
            // 
            this.hiddenItalic.Location = new System.Drawing.Point(84, 3);
            this.hiddenItalic.Name = "hiddenItalic";
            this.hiddenItalic.Size = new System.Drawing.Size(75, 23);
            this.hiddenItalic.TabIndex = 1;
            this.hiddenItalic.Text = "&i";
            this.hiddenItalic.UseVisualStyleBackColor = true;
            this.hiddenItalic.Click += new System.EventHandler(this.hiddenItalic_Click);
            // 
            // hiddenUnderline
            // 
            this.hiddenUnderline.Location = new System.Drawing.Point(165, 3);
            this.hiddenUnderline.Name = "hiddenUnderline";
            this.hiddenUnderline.Size = new System.Drawing.Size(75, 23);
            this.hiddenUnderline.TabIndex = 2;
            this.hiddenUnderline.Text = "&u";
            this.hiddenUnderline.UseVisualStyleBackColor = true;
            this.hiddenUnderline.Click += new System.EventHandler(this.hiddenUnderline_Click);
            // 
            // hiddenFore
            // 
            this.hiddenFore.Location = new System.Drawing.Point(3, 32);
            this.hiddenFore.Name = "hiddenFore";
            this.hiddenFore.Size = new System.Drawing.Size(75, 23);
            this.hiddenFore.TabIndex = 3;
            this.hiddenFore.Text = "&f";
            this.hiddenFore.UseVisualStyleBackColor = true;
            this.hiddenFore.Click += new System.EventHandler(this.hiddenFore_Click);
            // 
            // hiddenHighlight
            // 
            this.hiddenHighlight.Location = new System.Drawing.Point(84, 32);
            this.hiddenHighlight.Name = "hiddenHighlight";
            this.hiddenHighlight.Size = new System.Drawing.Size(75, 23);
            this.hiddenHighlight.TabIndex = 4;
            this.hiddenHighlight.Text = "&h";
            this.hiddenHighlight.UseVisualStyleBackColor = true;
            this.hiddenHighlight.Click += new System.EventHandler(this.hiddenHighlight_Click);
            // 
            // hiddenLal
            // 
            this.hiddenLal.Location = new System.Drawing.Point(165, 32);
            this.hiddenLal.Name = "hiddenLal";
            this.hiddenLal.Size = new System.Drawing.Size(75, 23);
            this.hiddenLal.TabIndex = 5;
            this.hiddenLal.Text = "&l";
            this.hiddenLal.UseVisualStyleBackColor = true;
            this.hiddenLal.Click += new System.EventHandler(this.hiddenLal_Click);
            // 
            // hiddenRal
            // 
            this.hiddenRal.Location = new System.Drawing.Point(3, 61);
            this.hiddenRal.Name = "hiddenRal";
            this.hiddenRal.Size = new System.Drawing.Size(75, 23);
            this.hiddenRal.TabIndex = 6;
            this.hiddenRal.Text = "&r";
            this.hiddenRal.UseVisualStyleBackColor = true;
            this.hiddenRal.Click += new System.EventHandler(this.hiddenRal_Click);
            // 
            // hiddenCAl
            // 
            this.hiddenCAl.Location = new System.Drawing.Point(84, 61);
            this.hiddenCAl.Name = "hiddenCAl";
            this.hiddenCAl.Size = new System.Drawing.Size(75, 23);
            this.hiddenCAl.TabIndex = 7;
            this.hiddenCAl.Text = "&c";
            this.hiddenCAl.UseVisualStyleBackColor = true;
            this.hiddenCAl.Click += new System.EventHandler(this.hiddenCAl_Click);
            // 
            // hiddenEx
            // 
            this.hiddenEx.Location = new System.Drawing.Point(165, 61);
            this.hiddenEx.Name = "hiddenEx";
            this.hiddenEx.Size = new System.Drawing.Size(75, 23);
            this.hiddenEx.TabIndex = 8;
            this.hiddenEx.Text = "&x";
            this.hiddenEx.UseVisualStyleBackColor = true;
            this.hiddenEx.Click += new System.EventHandler(this.hiddenEx_Click);
            // 
            // hiddenPed
            // 
            this.hiddenPed.Location = new System.Drawing.Point(3, 90);
            this.hiddenPed.Name = "hiddenPed";
            this.hiddenPed.Size = new System.Drawing.Size(75, 23);
            this.hiddenPed.TabIndex = 9;
            this.hiddenPed.Text = "&y";
            this.hiddenPed.UseVisualStyleBackColor = true;
            this.hiddenPed.Click += new System.EventHandler(this.hiddenPed_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annullaToolStripMenuItem,
            this.ripetiToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.annullaToolStripMenuItem.Text = "&Annulla";
            this.annullaToolStripMenuItem.Click += new System.EventHandler(this.annullaToolStripMenuItem_Click);
            // 
            // ripetiToolStripMenuItem
            // 
            this.ripetiToolStripMenuItem.Name = "ripetiToolStripMenuItem";
            this.ripetiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ripetiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ripetiToolStripMenuItem.Text = "&Ripeti";
            this.ripetiToolStripMenuItem.Click += new System.EventHandler(this.ripetiToolStripMenuItem_Click);
            // 
            // guidaToolStripMenuItem
            // 
            this.guidaToolStripMenuItem.Name = "guidaToolStripMenuItem";
            this.guidaToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.guidaToolStripMenuItem.Text = "Gui&da";
            this.guidaToolStripMenuItem.Click += new System.EventHandler(this.guidaToolStripMenuItem_Click);
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuovoToolStripMenuItem.Image = global::OpenPAD.Properties.Resources._new;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.open;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.apriToolStripMenuItem.Text = "&Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.save;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaConNomeToolStripMenuItem
            // 
            this.salvaConNomeToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.nameSave;
            this.salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
            this.salvaConNomeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salvaConNomeToolStripMenuItem.Text = "Salva &con nome";
            this.salvaConNomeToolStripMenuItem.Click += new System.EventHandler(this.salvaConNomeToolStripMenuItem_Click);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.print;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.stampaToolStripMenuItem.Text = "&Stam&pa";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // inviaPerPostaElettronicaToolStripMenuItem
            // 
            this.inviaPerPostaElettronicaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.mail;
            this.inviaPerPostaElettronicaToolStripMenuItem.Name = "inviaPerPostaElettronicaToolStripMenuItem";
            this.inviaPerPostaElettronicaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inviaPerPostaElettronicaToolStripMenuItem.Text = "&Invia per posta elettronica";
            this.inviaPerPostaElettronicaToolStripMenuItem.Click += new System.EventHandler(this.inviaPerPostaElettronicaToolStripMenuItem_Click);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.info;
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.informazioniToolStripMenuItem.Text = "Informa&zioni";
            this.informazioniToolStripMenuItem.Click += new System.EventHandler(this.informazioniToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.exit;
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // fontViewer
            // 
            this.fontViewer.Location = new System.Drawing.Point(155, 6);
            this.fontViewer.Multiline = true;
            this.fontViewer.Name = "fontViewer";
            this.fontViewer.Size = new System.Drawing.Size(170, 24);
            this.fontViewer.TabIndex = 7;
            // 
            // fontSelector
            // 
            this.fontSelector.Location = new System.Drawing.Point(331, 6);
            this.fontSelector.Name = "fontSelector";
            this.fontSelector.Size = new System.Drawing.Size(39, 23);
            this.fontSelector.TabIndex = 8;
            this.fontSelector.Text = "...";
            this.fontSelector.UseVisualStyleBackColor = true;
            this.fontSelector.Click += new System.EventHandler(this.fontSelector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dimensione:";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(188, 36);
            this.fontSize.Margin = new System.Windows.Forms.Padding(2);
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
            this.fontSize.Size = new System.Drawing.Size(137, 20);
            this.fontSize.TabIndex = 9;
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
            this.panel3.Location = new System.Drawing.Point(503, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 56);
            this.panel3.TabIndex = 4;
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(516, 6);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(39, 23);
            this.bold.TabIndex = 13;
            this.bold.Text = "G";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(560, 6);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(39, 23);
            this.italic.TabIndex = 14;
            this.italic.Text = "C";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.Location = new System.Drawing.Point(604, 6);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(39, 23);
            this.underline.TabIndex = 15;
            this.underline.Text = "S";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // leftA
            // 
            this.leftA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftA.Location = new System.Drawing.Point(516, 36);
            this.leftA.Name = "leftA";
            this.leftA.Size = new System.Drawing.Size(39, 23);
            this.leftA.TabIndex = 17;
            this.leftA.Text = "|||";
            this.leftA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftA.UseVisualStyleBackColor = true;
            this.leftA.Click += new System.EventHandler(this.leftA_Click);
            // 
            // CentA
            // 
            this.CentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentA.Location = new System.Drawing.Point(560, 36);
            this.CentA.Name = "CentA";
            this.CentA.Size = new System.Drawing.Size(39, 23);
            this.CentA.TabIndex = 18;
            this.CentA.Text = "|||";
            this.CentA.UseVisualStyleBackColor = true;
            this.CentA.Click += new System.EventHandler(this.CentA_Click);
            // 
            // RightA
            // 
            this.RightA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightA.Location = new System.Drawing.Point(604, 36);
            this.RightA.Name = "RightA";
            this.RightA.Size = new System.Drawing.Size(39, 23);
            this.RightA.TabIndex = 19;
            this.RightA.Text = "|||";
            this.RightA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightA.UseVisualStyleBackColor = true;
            this.RightA.Click += new System.EventHandler(this.RightA_Click);
            // 
            // forecolor
            // 
            this.forecolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecolor.ForeColor = System.Drawing.Color.Red;
            this.forecolor.Location = new System.Drawing.Point(648, 6);
            this.forecolor.Name = "forecolor";
            this.forecolor.Size = new System.Drawing.Size(39, 23);
            this.forecolor.TabIndex = 16;
            this.forecolor.Text = "A";
            this.forecolor.UseVisualStyleBackColor = true;
            this.forecolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // highlight
            // 
            this.highlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.highlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight.ForeColor = System.Drawing.Color.Black;
            this.highlight.Location = new System.Drawing.Point(648, 36);
            this.highlight.Name = "highlight";
            this.highlight.Size = new System.Drawing.Size(39, 23);
            this.highlight.TabIndex = 20;
            this.highlight.Text = "A";
            this.highlight.UseVisualStyleBackColor = false;
            this.highlight.Click += new System.EventHandler(this.highlight_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(692, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 56);
            this.panel4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "PED";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "inter:";
            // 
            // interline
            // 
            this.interline.DecimalPlaces = 1;
            this.interline.Increment = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            this.interline.Location = new System.Drawing.Point(451, 24);
            this.interline.Margin = new System.Windows.Forms.Padding(2);
            this.interline.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.interline.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.interline.Name = "interline";
            this.interline.Size = new System.Drawing.Size(45, 20);
            this.interline.TabIndex = 12;
            this.interline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interline.ValueChanged += new System.EventHandler(this.interline_ValueChanged);
            // 
            // toolsSave
            // 
            this.toolsSave.BackgroundImage = global::OpenPAD.Properties.Resources.save;
            this.toolsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsSave.Location = new System.Drawing.Point(7, 6);
            this.toolsSave.Name = "toolsSave";
            this.toolsSave.Size = new System.Drawing.Size(29, 23);
            this.toolsSave.TabIndex = 1;
            this.toolsSave.Text = "&s";
            this.toolsSave.UseVisualStyleBackColor = true;
            this.toolsSave.Click += new System.EventHandler(this.toolsSave_Click);
            // 
            // toolsSaveN
            // 
            this.toolsSaveN.BackgroundImage = global::OpenPAD.Properties.Resources.nameSave;
            this.toolsSaveN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsSaveN.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsSaveN.Location = new System.Drawing.Point(7, 33);
            this.toolsSaveN.Name = "toolsSaveN";
            this.toolsSaveN.Size = new System.Drawing.Size(29, 23);
            this.toolsSaveN.TabIndex = 2;
            this.toolsSaveN.Text = "&a";
            this.toolsSaveN.UseVisualStyleBackColor = true;
            this.toolsSaveN.Click += new System.EventHandler(this.toolsSaveN_Click);
            // 
            // toolsP
            // 
            this.toolsP.BackgroundImage = global::OpenPAD.Properties.Resources.print;
            this.toolsP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsP.Location = new System.Drawing.Point(42, 6);
            this.toolsP.Name = "toolsP";
            this.toolsP.Size = new System.Drawing.Size(29, 23);
            this.toolsP.TabIndex = 3;
            this.toolsP.Text = "&p";
            this.toolsP.UseVisualStyleBackColor = true;
            this.toolsP.Click += new System.EventHandler(this.toolsP_Click);
            // 
            // toolsMail
            // 
            this.toolsMail.BackgroundImage = global::OpenPAD.Properties.Resources.mail;
            this.toolsMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMail.Location = new System.Drawing.Point(75, 6);
            this.toolsMail.Name = "toolsMail";
            this.toolsMail.Size = new System.Drawing.Size(29, 23);
            this.toolsMail.TabIndex = 5;
            this.toolsMail.Text = "&m";
            this.toolsMail.UseVisualStyleBackColor = true;
            this.toolsMail.Click += new System.EventHandler(this.toolsMail_Click);
            // 
            // toolsNew
            // 
            this.toolsNew.BackgroundImage = global::OpenPAD.Properties.Resources.open;
            this.toolsNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolsNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsNew.Location = new System.Drawing.Point(75, 33);
            this.toolsNew.Name = "toolsNew";
            this.toolsNew.Size = new System.Drawing.Size(29, 23);
            this.toolsNew.TabIndex = 6;
            this.toolsNew.Text = "&o";
            this.toolsNew.UseVisualStyleBackColor = true;
            this.toolsNew.Click += new System.EventHandler(this.toolsNew_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(107, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 56);
            this.panel2.TabIndex = 3;
            // 
            // help
            // 
            this.help.BackgroundImage = global::OpenPAD.Properties.Resources.info;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help.Location = new System.Drawing.Point(704, 5);
            this.help.Margin = new System.Windows.Forms.Padding(2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(55, 52);
            this.help.TabIndex = 24;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // newbtn
            // 
            this.newbtn.BackgroundImage = global::OpenPAD.Properties.Resources._new;
            this.newbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.Location = new System.Drawing.Point(42, 33);
            this.newbtn.Margin = new System.Windows.Forms.Padding(2);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(29, 23);
            this.newbtn.TabIndex = 4;
            this.newbtn.Text = "&n";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 573);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.document);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPAD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interline)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem inviaPerPostaElettronicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog mainFont;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ColorDialog forecolorDial;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button hiddenPed;
        private System.Windows.Forms.Button hiddenEx;
        private System.Windows.Forms.Button hiddenCAl;
        private System.Windows.Forms.Button hiddenRal;
        private System.Windows.Forms.Button hiddenLal;
        private System.Windows.Forms.Button hiddenHighlight;
        private System.Windows.Forms.Button hiddenFore;
        private System.Windows.Forms.Button hiddenUnderline;
        private System.Windows.Forms.Button hiddenItalic;
        private System.Windows.Forms.Button hiddenBold;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ripetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidaToolStripMenuItem;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button toolsMail;
        private System.Windows.Forms.Button RightA;
        private System.Windows.Forms.Button forecolor;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button CentA;
        private System.Windows.Forms.Button highlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button leftA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button toolsNew;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.TextBox fontViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button fontSelector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button toolsP;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toolsSaveN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown interline;
        private System.Windows.Forms.Button toolsSave;
        private System.Windows.Forms.NumericUpDown fontSize;
    }
}

