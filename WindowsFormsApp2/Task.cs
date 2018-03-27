using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Task
    {
        string name;
        string url;
        string text;
        string mail;
        public Task(string _name, string _url, string _text, string _mail)
        {            
            name = _name;
            url = _url;
            text = _text;
            mail = _mail;
        }

    }
}
