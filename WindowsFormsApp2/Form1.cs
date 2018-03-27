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
using System.Xml.Serialization;

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
            html.LoadHtml(textBox1.Text);
            var attachmentURL = Searcher.SearchForSpecificString(textBox2.Text, html.Doc);

            if (attachmentURL != "")
            {
                mail = new Mail(textBox3.Text);
                mail.SendEmail(attachmentURL);
            }
            
            Log.log("Program_end ", "HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] tab= new string[3];
            Task[] tab = { textBox1.Text, textBox2.Text, textBox3.Text };
            //Proceses.Add(tab);
        }

        public void SerializationObject ()
        {
            html.LoadHtml();
            mail.SendEmail();
            mail.
        }
    }
}
