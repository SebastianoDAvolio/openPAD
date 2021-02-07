
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.document = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteprimaDiStampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaPerPostaElettronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 63);
            this.panel1.TabIndex = 0;
            // 
            // document
            // 
            this.document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document.Location = new System.Drawing.Point(56, 93);
            this.document.Name = "document";
            this.document.ShowSelectionMargin = true;
            this.document.Size = new System.Drawing.Size(960, 520);
            this.document.TabIndex = 2;
            this.document.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openDialog";
            this.openFileDialog1.Filter = "Rich Text File (*.rtf)|*.rtf|Simple Text txt (*.txt)|*.txt|All files (*.*)|*.*";
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
            // 
            // salvaConNomeToolStripMenuItem
            // 
            this.salvaConNomeToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.nameSave;
            this.salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
            this.salvaConNomeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salvaConNomeToolStripMenuItem.Text = "Salva &con nome";
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.print;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.stampaToolStripMenuItem.Text = "&Stam&pa";
            // 
            // anteprimaDiStampaToolStripMenuItem
            // 
            this.anteprimaDiStampaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.preview;
            this.anteprimaDiStampaToolStripMenuItem.Name = "anteprimaDiStampaToolStripMenuItem";
            this.anteprimaDiStampaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.anteprimaDiStampaToolStripMenuItem.Text = "Antepri&ma di stampa";
            // 
            // inviaPerPostaElettronicaToolStripMenuItem
            // 
            this.inviaPerPostaElettronicaToolStripMenuItem.Image = global::OpenPAD.Properties.Resources.mail;
            this.inviaPerPostaElettronicaToolStripMenuItem.Name = "inviaPerPostaElettronicaToolStripMenuItem";
            this.inviaPerPostaElettronicaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inviaPerPostaElettronicaToolStripMenuItem.Text = "&Invia per posta elettronica";
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
            // button1
            // 
            this.button1.BackgroundImage = global::OpenPAD.Properties.Resources._new;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(5, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 43);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1081, 614);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.document);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}

