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
            Log.log("\r\nProgram_start ", "yyyy.MM.dd HH:mm:ss");
        }

        private HTML html = new HTML();
        private Mail mail;

        private BindingList<Task> TaskList = new BindingList<Task>();
      

        private void button1_Click(object sender, EventArgs e)
        {
            Stanlabel.Text = "";
            var mailcounter = 0;
            var taskcounter = 0;
            foreach (Task task in TaskList) {
                taskcounter++;
                Stanlabel.Text = "Proszę czekać...";
                this.Refresh();

                //logika
                try
                {
                    html.LoadHtml(task.Url);
                } 
                catch(UriFormatException msg)
                {
                    Stanlabel.Text = "Bład!\r\n";
                    Stanlabel.Text += "Sprobuj podac adres strony w postaci https://...";
                    this.Refresh();
                    Log.log("exception_caught: " + msg + ", email_not_sent", "HH:mm:ss");
                    return;
                }
                var attachmentURL = Searcher.SearchForSpecificString(task.Text, html.Doc);
                if (attachmentURL != "")
                {
                    mail = new Mail(task.Mail);
                    try
                    {
                        mail.SendEmail(attachmentURL);
                        Stanlabel.Text = "Gotowe!";
                        this.Refresh();
                        mailcounter++;
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
                } else
                {
                    Stanlabel.Text = "Nie znaleziono stringa :(";
                    this.Refresh();
                }            
            }

            Stanlabel.Text = Stanlabel.Text + " Wysłano maili: " + mailcounter.ToString();
            Stanlabel.Text += ". Liczba tasków: " + taskcounter.ToString();
            Stanlabel.Text += Stanlabel.Text + " \r\nSprawdź log dla dokładniejszych informacji :)";
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
            TaskList.Clear();
            Tasklistbox.DataSource = TaskList;            
        }

    }
}
