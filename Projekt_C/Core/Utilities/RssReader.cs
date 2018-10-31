using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Core.Domain;
using System.Xml;

using System.IO;

namespace Projekt_C.Core.Utilities
{
    public static class RssParser
    {
        private static string Path { get; }

        public static PodcastFeed GetPodcastFeed(Rss rss)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(rss.Content);

            string podcastFeedTitle;
            string episodeTitle;

            podcastFeedTitle = doc.SelectSingleNode("//channel").SelectSingleNode("//title").InnerText;

            foreach(XmlNode node in doc.SelectNodes("//item"))
            {
                doc.SelectSingleNode("//title").InnerText
            }
        }




        // Might not use this method
        private static void createXml()
        {
            string directory = @"..\..\Temporary";
            string path = @"..\..\Temporary\RssContent.xml";

            if(!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }


    }
}
