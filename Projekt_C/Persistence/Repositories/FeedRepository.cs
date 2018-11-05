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
                return;
            }

            if (obj.Id == 0)
            {
                obj.Id = GetFreeId();
            }
            
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

            XmlNode categoryNode = doc.CreateElement("Category");
            categoryNode.AppendChild(doc.CreateTextNode(obj.Category.Name));
            feedNode.AppendChild(categoryNode);

            XmlNode frequencyNode = doc.CreateElement("UpdateInterval");
            frequencyNode.AppendChild(doc.CreateTextNode(obj.UpdateInterval.ToString()));
            feedNode.AppendChild(frequencyNode);


            doc.Save(filestream);
            filestream.Close();
            
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

        public void Replace(PodcastFeed obj)
        {
            Remove(obj);
            Add(obj);
        }

        public PodcastFeed Get(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);
            
            var feed = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                       where element.Attribute("Id").ToString() == id.ToString()
                       select element;

            var podcastFeed = new PodcastFeed();
            podcastFeed.Id = Convert.ToInt32(feed.Attributes("Id"));
            podcastFeed.Name = feed.Descendants("Name").ToString();
            podcastFeed.Url = feed.Descendants("Url").ToString();
            podcastFeed.Category = new Category { Name = feed.Descendants("Category").ToString() };
            podcastFeed.UpdateInterval = Convert.ToInt32(feed.Descendants("UpdateInterval"));
            
            filestream.Close();
            return podcastFeed;
        }

        public PodcastFeed getByName(string name)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var feedElement = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                              where element.Element("Name").ToString() == name
                              select element;
            
            if (feedElement == null)
            {
                throw new NullReferenceException();
            }

            var podcastFeed = new PodcastFeed();
            podcastFeed.Id = Convert.ToInt32(feedElement.Attributes("Id"));
            podcastFeed.Name = feedElement.Descendants("Name").ToString();
            podcastFeed.Url = feedElement.Descendants("Url").ToString();
            podcastFeed.Category = new Category { Name = feedElement.Descendants("Category").ToString() };
            podcastFeed.UpdateInterval = Convert.ToInt32(feedElement.Descendants("UpdateInterval"));
            return podcastFeed;
        }

        public void Remove(PodcastFeed obj)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var feed = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                       where element.Attribute("Id").ToString() == obj.Id.ToString()
                       select element;

            feed.Remove();
            doc.Save(filestream);
            filestream.Close();
        }

        public int GetFreeId()
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var everyId = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                          orderby Convert.ToInt32(element.Attribute("Id"))
                          select Convert.ToInt32(element.Attribute("Id"));
            
            int newId = 1;
            foreach(int usedId in everyId)
            {
                if (newId == usedId)
                {
                    newId += 1;
                }
                else
                {
                    break;
                }
            }

            filestream.Close();
            return newId;
        }
    }
}
