//Autorzy Mordal Paweł, Damian Szczepański

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

        public static Tuple<string,string> SearchForSpecificString(string key, HtmlAgilityPack.HtmlDocument doc)
        {            
                var nodes = doc.DocumentNode.Descendants("img");

                foreach (var node in nodes)
                {
                    if (node.GetAttributeValue("alt", "").Contains(key))
                    {
                    
                        string attachmentURL = node.GetAttributeValue("src", "");
                        string description = node.GetAttributeValue("alt", "");
                        Tuple<string, string> pair = new Tuple<string, string>(attachmentURL, description);
                        Log.log("string_found: " + key + ", attachment url: " + attachmentURL, "HH:mm:ss");
                        return pair;
                    }
                }
           
            throw new ArgumentException("String not found", "arg");
        }
    }
}
