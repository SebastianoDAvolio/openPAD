using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OpenPAD
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SebastianoDAvolio/openPAD");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sebastianodavolio.altervista.org/openpad/");
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1("HOME");
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if (res==DialogResult.OK)
            {
                this.Hide();
                Form1 edit = new Form1(openFileDialog1.FileName);
                edit.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 edit = new Form1(Application.StartupPath+"\\samples\\menu.rtf");
            edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 edit = new Form1(Application.StartupPath + "\\samples\\curriculum.rtf");
            edit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 edit = new Form1(Application.StartupPath + "\\samples\\bolletta.rtf");
            edit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 edit = new Form1(Application.StartupPath + "\\samples\\auguri.rtf");
            edit.Show();
        }
    }
}
