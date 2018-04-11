using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApp2
{
    class DisplayInfo : IAction
    {
        public override void Do()
        {
            //Application.Run(new Info());
            string url;
            string description;
            Info info = new Info();
            info.Show();
            using (StreamReader sr = new StreamReader("./atturl.txt"))
            {
                url = sr.ReadLine();
                description = sr.ReadLine();
            }            
            new WebClient().DownloadFile(url, "./image.png");
            info.set(description, "./image.png");
        }

        public override string ToString()
        {
            return string.Format("{0}",
                "Display");

        }


    }
}
