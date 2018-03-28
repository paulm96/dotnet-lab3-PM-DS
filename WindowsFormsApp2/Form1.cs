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

        private HTML html = new HTML();
        private Mail mail;
        private BindingList<Task> TaskList = new BindingList<Task>();

        public Form1()
        {
            InitializeComponent();
            Log.log("\r\nProgram_start ", "yyyy.MM.dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stanlabel.Text = "";
            var mailcounter = 0;

            foreach (Task task in TaskList)
            {
                Stanlabel.Text = "Proszę czekać...";
                this.Refresh();
                //logika
                try
                {
                    html.LoadHtml(task.Url);
                    var attachmentURL = Searcher.SearchForSpecificString(task.Text, html.Doc);
                    mail = new Mail(task.Mail);
                    mail.SendEmail(attachmentURL);
                    Stanlabel.Text = "Gotowe!";
                    this.Refresh();
                    mailcounter++;
                }
                catch (UriFormatException msg)
                {
                    Stanlabel.Text = "Bład!\r\n";
                    Stanlabel.Text += "Sprobuj podac adres strony w postaci https://...";
                    this.Refresh();
                    Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
                    //return;
                }
                catch (ArgumentNullException msg)
                {
                    Stanlabel.Text = "Ups, cos poszlo nie tak :( Sprawdz log :)";
                    this.Refresh();
                    Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
                }
                catch (WebException msg)
                {
                    Stanlabel.Text = "Ups, cos poszlo nie tak :( Sprawdz log :)";
                    this.Refresh();
                    Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
                }
                catch (ArgumentException msg)
                {
                    Stanlabel.Text = "Nie znaleziono stringa :(";
                    this.Refresh();
                    Log.log("exception_caught: " + msg, "HH:mm:ss");
                }
            }

            Stanlabel.Text = Stanlabel.Text + "\r\nWysłano maili: " + mailcounter.ToString();
            Stanlabel.Text += ". Liczba tasków: " + TaskList.Count;
            Stanlabel.Text += " \r\nSprawdź log dla dokładniejszych informacji :)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Nazwatextbox.Text == "" || URLTextbox.Text == "" || TextTextbox.Text == "" || MailTextbox.Text == "")
                Stanlabel.Text = "Żadne pole nie powinno być puste!";
            else
            {
                Task task = new Task(Nazwatextbox.Text, URLTextbox.Text, TextTextbox.Text, MailTextbox.Text);
                TaskList.Add(task);
                Tasklistbox.DataSource = TaskList;
            }
        }

        private void Czyscbutton_Click(object sender, EventArgs e)
        {
            Stanlabel.Text = "";
            TaskList.Clear();
            Tasklistbox.DataSource = TaskList;            
        }

        public void SerializationObject (string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Task>));

            /// /   Task i = new Task();
            // Stream writer = new FileStream(filename, FileMode.Create);
            // foreach (Task element in TaskList)
            //{
                //i.Mail=element.Mail;
                //i.Name=element.Name;
                //i.Text=element.Text;
                //i.Url=element.Url;

                serializer.Serialize(fs,TaskList);
           // }
            fs.Close();
            // serializer.Serialize(writer, element);

            
            // writer.Close();
            

        }

        private void Serialbutton_Click(object sender, EventArgs e)
        {
            SerializationObject("serial.xml");
        }

        public void Deserialization_object(string file)
        {
            
            XmlSerializer serializer = new
            XmlSerializer(typeof(Task));
            FileStream fs = new FileStream(@file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //XmlReader reader = XmlReader.Create(fs);
            XmlSerializer xs = new XmlSerializer(typeof(BindingList<Task>));
            //Task i;

            // Use the Deserialize method to restore the object's state.
            //i = (Task)serializer.Deserialize(reader);

            // Task proc = new Task (i.Name,i.Url,i.Text,i.Mail );
            //TaskList.Add(proc);
            //Tasklistbox.DataSource = TaskList;
            BindingList<Task> proc = (BindingList<Task>)xs.Deserialize(fs);
            foreach (Task p in proc)
            {
                TaskList.Add(p);
            }
            //label1.Text = TaskList.Count().ToString();
            Tasklistbox.DataSource = TaskList;
           // foreach (Task elem in TaskList)
            //{
                /*label1.Text += (
                  elem.Name + "\t" +
                  elem.Url + "\t" +
                  elem.Text + "\t" +
                  elem.Mail + "\t");
                  */
              //  label1.Text += (elem.Name + "\t");
           // }
            fs.Close();
            
        }



        private void DeSerialbutton_Click_1(object sender, EventArgs e)
        {
            TaskList.Clear();
            Deserialization_object("serial.xml");
        }
    }
}
