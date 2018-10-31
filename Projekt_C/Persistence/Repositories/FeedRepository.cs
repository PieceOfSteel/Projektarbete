using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Repositories;
using Projekt_C.Core.Utilities;

namespace Projekt_C.Persistence.Repositories
{
    public class FeedRepository : IRepository<PodcastFeed>
    {
        public string Path { get; set; }

        public FeedRepository()
        {

        }

        public FeedRepository(string path)
        {
            Path = path;
        }

        public void Add(PodcastFeed obj)
        {
            if (!File.Exists(Path))
            {
                CreateFile();
            }

            if (IdExists(obj.Id))
            {
                Alert.IdTaken();
            }
            else
            {
                var filestream = new FileStream(Path, FileMode.Open);
                var doc = new XmlDocument();

                XmlNode feedNode = doc.CreateElement("PodcastFeed");

                XmlAttribute idAttribute = doc.CreateAttribute("Id");
                idAttribute.Value = obj.Id.ToString();
                feedNode.Attributes.Append(idAttribute);
                XmlNode feedsNode = doc.SelectSingleNode("PodcastFeeds");
                feedsNode.AppendChild(feedNode);

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.AppendChild(doc.CreateTextNode(obj.Name));
                feedNode.AppendChild(nameNode);

                XmlNode urlNode = doc.CreateElement("Url");
                urlNode.AppendChild(doc.CreateTextNode(obj.Url));

                doc.Save(filestream);
                filestream.Close();
            }
        }

        private void CreateFile()
        {
            var filestream = new FileStream(Path, FileMode.Create);
            var doc = new XmlDocument();

            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlNode feedsNode = doc.CreateElement("PodcastFeeds");
            doc.AppendChild(feedsNode);

            doc.Save(filestream);
            filestream.Close();
        }

        private bool IdExists(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            foreach(XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed"))
            {
                if (id.ToString() == element.Attribute("Id").ToString()) {
                    return true;
                }
            }

            return false;
        }

        public PodcastFeed Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PodcastFeed obj)
        {
            throw new NotImplementedException();
        }
    }
}
