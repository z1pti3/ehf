using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ehf
{
    public partial class Form_main : Form
    {
        List<file_attachment> fas = new List<file_attachment>();

        public Form_main()
        {
            InitializeComponent();
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            listBox_attachments.Items.Clear();
            fas.Clear();
            foreach (string attachment in textBox_email.Text.Split(new string[] { "Content-Type:" }, StringSplitOptions.None))
            {
                if (attachment.Contains("name=\""))
                {
                    if (attachment.Contains("Content-Transfer-Encoding: base64"))
                    {
                        string fname = attachment.Split(new string[] { "name=\"" }, StringSplitOptions.None)[1].Split('\"')[0];
                        string b64 = Regex.Split(attachment, @"(\r\n){2}", RegexOptions.ExplicitCapture)[1].Split('-')[0];
                        fas.Add(new file_attachment { filename = fname, base64 = b64 });
                        listBox_attachments.Items.Add(fname);
                    }
                }
            }
        }

        private void listBox_attachments_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_attachments.SelectedIndex != -1)
            {
                File.WriteAllBytes(Path.GetTempPath()+fas[listBox_attachments.SelectedIndex].filename,Convert.FromBase64String(fas[listBox_attachments.SelectedIndex].base64));
                Process proc = Process.Start(Path.GetTempPath() + fas[listBox_attachments.SelectedIndex].filename);
            }
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (file_attachment fa in fas)
            {
                if (File.Exists(Path.GetTempPath() + fa.filename))
                {
                    File.Delete(Path.GetTempPath() + fa.filename);
                }
            }
        }

        private void textBox_email_Click(object sender, EventArgs e)
        {
            textBox_email.SelectAll();
        }
    }

    public class file_attachment
    {
        public string filename { get; set; }
        public string base64 { get; set; }
    }
}
