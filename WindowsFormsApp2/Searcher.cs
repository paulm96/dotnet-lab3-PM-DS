﻿//Autorzy Mordal Paweł, Damian Szczepański

using System;
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
                        if (!attachmentURL.Contains("https"))
                            continue;
                        string description = node.GetAttributeValue("alt", "");
                        Tuple<string, string> pair = new Tuple<string, string>(attachmentURL, description);
                        Log.log("string_found: " + key + ", attachment url: " + attachmentURL, "HH:mm:ss");
                        return pair;
                    }
                }
           
            throw new ArgumentException("String '" + key + "' was not found", "arg");
        }
    }
}
