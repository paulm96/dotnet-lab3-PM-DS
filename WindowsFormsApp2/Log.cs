//Autorzy Mordal Paweł, Damian Szczepański

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Log
    {

        public static void log(string napis, string format)
        {
            File.AppendAllText(@"./log.txt", napis + "  ");
            DateTime localDate = DateTime.Now;
            File.AppendAllText(@"./log.txt", localDate.ToString(format) + "\r\n");
        }

    }
}
