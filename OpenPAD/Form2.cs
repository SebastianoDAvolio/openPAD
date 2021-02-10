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
    public partial class email : Form
    {
        string filename;
        public email(string file)
        {
            filename = file;
            InitializeComponent();
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:"+ System.Net.WebUtility.UrlEncode(desttxt.Text)+"?subject="+objtxt.Text+ "&attachment="+ System.Net.WebUtility.UrlEncode(filename));
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void email_Load(object sender, EventArgs e)
        {

        }
    }
}
