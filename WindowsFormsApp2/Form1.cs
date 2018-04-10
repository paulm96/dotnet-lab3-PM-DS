//Autorzy Mordal Paweł, Damian Szczepański

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
        private BindingList<ITask> TaskList = new BindingList<ITask>();

        public Form1()
        {
            InitializeComponent();
            Log.log("\r\nProgram_start ", "yyyy.MM.dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ITask task in TaskList)
            {
                task.Do();
            }
            
            //Stanlabel.Text = "";
            //var mailcounter = 0;

            //foreach (Task task in TaskList)
            //{
            //    Stanlabel.Text = "Proszę czekać...";
            //    this.Refresh();
            //    //logika
            //    try
            //    {
            //        html.LoadHtml(task.Url);
            //        var attachmentURL = Searcher.SearchForSpecificString(task.Text, html.Doc);
            //        mail = new Mail(task.Mail);
            //        mail.SendEmail(attachmentURL);
            //        Stanlabel.Text = "Gotowe!";
            //        this.Refresh();
            //        mailcounter++;
            //    }
            //    catch (UriFormatException msg)
            //    {
            //        Stanlabel.Text = "Bład!\r\n";
            //        Stanlabel.Text += "Sprobuj podac adres strony w postaci https://...";
            //        this.Refresh();
            //        Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
            //        //return;
            //    }
            //    catch (ArgumentNullException msg)
            //    {
            //        Stanlabel.Text = "Ups, cos poszlo nie tak :( Sprawdz log :)";
            //        this.Refresh();
            //        Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
            //    }
            //    catch (WebException msg)
            //    {
            //        Stanlabel.Text = "Ups, cos poszlo nie tak :( Sprawdz log :)";
            //        this.Refresh();
            //        Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
            //    }
            //    catch (ArgumentException msg)
            //    {
            //        Stanlabel.Text = "Nie znaleziono stringa :(";
            //        this.Refresh();
            //        Log.log("exception_caught: " + msg, "HH:mm:ss");
            //    }
            //}

            //Stanlabel.Text = Stanlabel.Text + "\r\nWysłano maili: " + mailcounter.ToString();
            //Stanlabel.Text += ". Liczba tasków: " + TaskList.Count;
            //Stanlabel.Text += " \r\nSprawdź log dla dokładniejszych informacji :)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Nazwatextbox.Text == "" || URLTextbox.Text == "" || TextTextbox.Text == "" || MailTextbox.Text == "")
                Stanlabel.Text = "Żadne pole nie powinno być puste!";
            else
            {
                ImageSearch imageSearch = new ImageSearch(URLTextbox.Text, TextTextbox.Text);
                SendEmail sendEmail = new SendEmail(MailTextbox.Text);
                ITask itask = new ITask(Nazwatextbox.Text ,sendEmail, imageSearch);
                TaskList.Add(itask);
                Tasklistbox.DataSource = TaskList;
            }
        }

        private void Czyscbutton_Click(object sender, EventArgs e)
        {
            Stanlabel.Text = "";
            TaskList.Clear();
            Tasklistbox.DataSource = TaskList;            
        }

        private void Serialbutton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("serial.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<ITask>));
            serializer.Serialize(fs, TaskList);
            fs.Close();
            Log.log("serialization BindingList ", "HH:mm:ss");
            Stanlabel.Text = "Wykonano serializację";
        }


        private void DeSerialbutton_Click_1(object sender, EventArgs e)
        {
            TaskList.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(Task));
            FileStream fs = new FileStream(@"serial.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(BindingList<ITask>));
            BindingList<ITask> proc = (BindingList<ITask>)xs.Deserialize(fs);
            foreach (ITask p in proc)
            {
                TaskList.Add(p);
            }
            Tasklistbox.DataSource = TaskList;
            fs.Close();
            Log.log("deserialization BindingList ", "HH:mm:ss");
            Stanlabel.Text = "Wykonano deserializację";
        }
    }
}
