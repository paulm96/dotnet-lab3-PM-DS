//Autorzy Mordal Paweł, Damian Szczepański

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Task
    {
        int id;
        string name;
        string url;
        string text;
        string mail;

        public Task(string _name, string _url, string _text, string _mail)
        {
            Name = _name;
            Url = _url;
            Text = _text;
            Mail = _mail;
        }

        public Task() {}
        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public string Text { get => text; set => text = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2} {3}",
                "Name task: " + this.Name, "URL: " + this.Url, "String: " + this.Text, "E-mail: " + this.Mail);
        }
    }
}
