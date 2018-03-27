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
using System.Xml;

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

        private BindingList<Task> TaskList = new BindingList<Task>();
      

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

            Task task = new Task(Nazwatextbox.Text, URLTextbox.Text, TextTextbox.Text, MailTextbox.Text);
            TaskList.Add(task);
            Tasklistbox.DataSource = TaskList;            
        }

        private void Czyscbutton_Click(object sender, EventArgs e)
        {
            TaskList.Clear();
            Tasklistbox.DataSource = TaskList;            
        }

        public void SerializationObject (string filename)
        {

            XmlSerializer serializer =
     new XmlSerializer(typeof(Task));

        /// /   Task i = new Task();
            Stream writer = new FileStream(filename, FileMode.Create);
            foreach (Task element in TaskList) {
               //i.Mail=element.Mail;
                //i.Name=element.Name;
                //i.Text=element.Text;
                //i.Url=element.Url;

               
                serializer.Serialize(writer, element);
               
            }
            writer.Close();

        }

        private void Serialbutton_Click(object sender, EventArgs e)
        {
            SerializationObject("serial.xml");
        }

        public void Deserialization_object(string file)
        {
            
            XmlSerializer serializer = new
            XmlSerializer(typeof(Task));
            FileStream fs = new FileStream(file, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            Task i;

            // Use the Deserialize method to restore the object's state.
            i = (Task)serializer.Deserialize(reader);

            Task proc = new Task (i.Name,i.Url,i.Text,i.Mail );
            TaskList.Add(proc);
            Tasklistbox.DataSource = TaskList;

            label1.Text= (
             i.Name + "\t" +
             i.Url + "\t" +
             i.Text + "\t" +
             i.Mail + "\t");
            fs.Close();

        }



        private void DeSerialbutton_Click_1(object sender, EventArgs e)
        {
                Deserialization_object("serial.xml");
        }
    }
}
