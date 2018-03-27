using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace WindowsFormsApp2
{
    class Searcher
    {

        public static string SearchForSpecificString(string key, HtmlAgilityPack.HtmlDocument doc)
        {            
                var nodes = doc.DocumentNode.Descendants("img");

                foreach (var node in nodes)
                {
                    if (node.GetAttributeValue("alt", "").Contains(key))
                    {
                        string attachmentURL = node.GetAttributeValue("src", "");
                        Log.log("string_found: " + key, "HH:mm:ss");
                        return attachmentURL;
                    }
                }
           
            throw new ArgumentException("String not found", "arg");
        }
    }
}
