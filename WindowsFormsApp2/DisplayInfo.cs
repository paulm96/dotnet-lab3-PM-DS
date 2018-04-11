using System.IO;
using System.Net;

namespace WindowsFormsApp2
{
    class DisplayInfo : IAction
    {
        public override void Do()
        {
            string url;
            string description;
            Info info = new Info();
            using (StreamReader sr = new StreamReader("./atturl.txt"))
            {
                url = sr.ReadLine();
                description = sr.ReadLine();
            }            
            new WebClient().DownloadFile(url, "./image.png");
            info.set(description, "./image.png");
            info.Show();
        }

        public override string ToString()
        {
            return string.Format("{0}",
                "Display");

        }


    }
}
