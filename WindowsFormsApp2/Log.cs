//Autorzy Mordal Paweł, Damian Szczepański

using System;
using System.IO;

namespace WindowsFormsApp2
{
    class Log
    {

        public static void log(string napis, string format)
        {
            DateTime localDate = DateTime.Now;
            File.AppendAllText(@"./log.txt", localDate.ToString(format) + " ");
            File.AppendAllText(@"./log.txt", napis + "  " + "\r\n");
            
            
        }

    }
}
