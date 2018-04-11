using System;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp2
{
    public partial class Pogoda : Form
    {
        public Pogoda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stream = new WebClient().DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={textBox1.Text}&APPID=742070efe45d2e97d12202fbc91af4f7");
            var welcome = Welcome.FromJson(stream);
            textBox2.Text = (welcome.Main.Temp - 273.15).ToString();
            var url = $"http://openweathermap.org/img/w/{welcome.Weather[0].Icon}.png";
            new WebClient().DownloadFile(url, "./image.png");
            pictureBox1.ImageLocation = "./image.png";
            this.Refresh();
        }
    }
}
