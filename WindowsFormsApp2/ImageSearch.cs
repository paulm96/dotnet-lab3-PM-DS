using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    public class ImageSearch : ICondition
    {
        
        string targetURL;
        string searchedText;

        public override string ToString()
        {
            return string.Format("{0},{1}",
                this.TargetURL, this.SearchedText);
        }

        public ImageSearch(string _targetURL, string _searchedText)
        {
            TargetURL = _targetURL;
            SearchedText = _searchedText;
        }

        public string TargetURL { get => targetURL; set => targetURL = value; }
        public string SearchedText { get => searchedText; set => searchedText = value; }

        public override bool Check()
        {
            HTML html = new HTML();   //ona byla private tam wyzej jako zmienna klasy
            html.LoadHtml(TargetURL);
            string attachmentURL;
            try
            {
                attachmentURL = Searcher.SearchForSpecificString(SearchedText, html.Doc);
            }
            catch (ArgumentException msg)
            {
                return false;
            }
            //File.AppendAllText(@"./atturl.txt", attachmentURL);
            File.WriteAllText(@"./atturl.txt", attachmentURL + "\r\n" + "Znaleziono demota :)");
            return true;
        }
    }
}
