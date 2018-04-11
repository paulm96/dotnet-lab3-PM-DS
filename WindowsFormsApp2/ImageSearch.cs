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
            HTML html = new HTML();
            html.LoadHtml(TargetURL);
            Tuple<string, string> pair;                                
            pair = Searcher.SearchForSpecificString(SearchedText, html.Doc);                        
            File.WriteAllText(@"./atturl.txt", pair.Item1 + "\r\n" + pair.Item2);
            return true;
        }
    }
}
