using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;

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
            if (mittText.Text!="" && desttxt.Text!="" && objtxt.Text!="")
            {
                var client = new SmtpClient();
                MailMessage message = new MailMessage(mittText.Text, desttxt.Text, objtxt.Text, "");
                Attachment file = new Attachment(filename);
                message.Attachments.Add(file);
                client.UseDefaultCredentials = true;
                client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                client.PickupDirectoryLocation = Application.StartupPath+"\\comms";
                client.Send(message);
                var defaultMsgPath = new DirectoryInfo("comms").GetFiles()
                      .OrderByDescending(f => f.LastWriteTime)
                      .First();
                var realMsgPath = Path.Combine("comms", DateTime.Now.Ticks.ToString()+".eml");
                File.Move(defaultMsgPath.FullName, realMsgPath);
                Process.Start(realMsgPath);
                this.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
