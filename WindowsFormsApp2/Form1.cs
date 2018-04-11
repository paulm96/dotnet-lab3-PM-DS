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
        private BindingList<ITask> TaskList = new BindingList<ITask>();

        public void LogFctn(string description)
        {
            DateTime localDate = DateTime.Now;                        
            textBox3.AppendText(localDate.ToString("yyyy.MM.dd HH:mm:ss") + "  " + description + Environment.NewLine);
        }

        public Form1()
        {
            InitializeComponent();
            LogFctn("Program starts");
            Log.log("Program starts ", "HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogFctn("Please wait...");
            this.Enabled = false;
            this.Refresh();
            int counter = 0;
            foreach (ITask task in TaskList)
            {
                try
                {
                    task.Do();                           
                    LogFctn("Done! Task: " + task.ToString());
                    counter++;                    
                }
                catch(Exception msg)
                {
                    Log.log(msg.ToString(), "HH:mm:ss");
                    LogFctn("Something went wrong with task: " + task.ToString());
                    LogFctn("Check file log to more details.");
                }
            }

            LogFctn(counter.ToString() + " of " + TaskList.Count.ToString() + " tasks have been done!");
            this.Enabled = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IAction action;
            ICondition condition;
            ITask itask;
            if (tabControl1.TabPages[0] == tabControl1.SelectedTab)                
                condition = new ImageSearch(URLTextbox.Text, TextTextbox.Text);                    
            else                
                condition = new WeatherChecker(textBox1.Text, textBox2.Text);

            if (tabControl2.TabPages[0] == tabControl2.SelectedTab)
                action = new SendEmail(MailTextbox.Text);
            else
                action = new DisplayInfo();

            itask = new ITask(Nazwatextbox.Text, action, condition);
                
                
            TaskList.Add(itask);
            Tasklistbox.DataSource = TaskList;
        }

        private void Czyscbutton_Click(object sender, EventArgs e)
        {
            TaskList.Clear();
            Tasklistbox.DataSource = TaskList;            
        }
    }
}
