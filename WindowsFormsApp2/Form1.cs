using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private HTML html = new HTML();
        private Mail mail;

        List <Task> Proceses =new List<Task>();
      

        private void button1_Click(object sender, EventArgs e)
        {

            Log.log("\r\nProgram_start ", "yyyy.MM.dd HH:mm:ss");
            Stanlabel.Text = "Proszę czekać...";           
            this.Refresh();

            html.LoadHtml(URLTextbox.Text);
            var attachmentURL = Searcher.SearchForSpecificString(TextTextbox.Text, html.Doc);            
            if (attachmentURL != "")
            {
                mail = new Mail(MailTextbox.Text);
                mail.SendEmail(attachmentURL);              
            }

            Stanlabel.Text = "Gotowe!";
            Wykonajbutton.Click += button1_Click;
            this.Refresh();
            Log.log("Program_end ", "HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] tab= new string[3];
            string[] tab = { URLTextbox.Text, TextTextbox.Text, MailTextbox.Text };
            //Proceses.Add(tab);
        }
    }
}
