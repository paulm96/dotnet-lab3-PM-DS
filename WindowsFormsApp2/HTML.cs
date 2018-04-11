//Autorzy Mordal Paweł, Damian Szczepański

using HtmlAgilityPack;

namespace WindowsFormsApp2
{
    class HTML
    {
        private HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        public void LoadHtml(string url) {
            var web = new HtmlWeb();
            doc = web.Load(url);
            Log.log("html_loaded: " + url, "HH:mm:ss");
        }

        public HtmlDocument Doc { get => doc; set => doc = value; }
    }
}
