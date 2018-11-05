using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Projekt_C.Core;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Repositories;
using Projekt_C.Core.Utilities;
using System.IO;
using System.Xml.Linq;

namespace Projekt_C.Persistence.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public string Path { get; set; }

        public CategoryRepository()
        {

        }

        public CategoryRepository(string path)
        {
            Path = path;
        }

        public void Add(Category obj)
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

            XmlNode categoryNode = doc.CreateElement("Category");

            XmlAttribute idAttribute = doc.CreateAttribute("Id");
            idAttribute.Value = obj.Id.ToString();
            categoryNode.Attributes.Append(idAttribute);
            XmlNode categoriesNode = doc.SelectSingleNode("Categories");
            categoriesNode.AppendChild(categoryNode);

            XmlNode nameNode = doc.CreateElement("Name");
            nameNode.AppendChild(doc.CreateTextNode(obj.Name));
            categoryNode.AppendChild(nameNode);
            
            doc.Save(filestream);
            filestream.Close();

        }

        public Category Get(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var categoryElement = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                       where element.Attribute("Id").ToString() == id.ToString()
                       select element;

            var category = new Category();
            category.Id = Convert.ToInt32(categoryElement.Attributes("Id"));
            category.Name = categoryElement.Descendants("Name").ToString();

            filestream.Close();
            return category;
        }

        public Category getByName(string name)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var categoryElement = from XElement element in doc.Descendants("Categories").Elements("Category")
                              where element.Element("Name").ToString() == name
                              select element;

            if (categoryElement == null)
            {
                throw new NullReferenceException();
            }

            var category = new Category();
            category.Id = Convert.ToInt32(categoryElement.Attributes("Id"));
            category.Name = categoryElement.Descendants("Name").ToString();
            return category;
        }

        public void Remove(Category obj)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var categoryElement = from XElement element in doc.Descendants("PodcastFeeds").Elements("PodcastFeed")
                       where element.Attribute("Id").ToString() == obj.Id.ToString()
                       select element;

            categoryElement.Remove();
            doc.Save(filestream);
            filestream.Close();
        }

        public void Replace(Category obj)
        {
            Remove(obj);
            Add(obj);
        }

        private void CreateFile()
        {
            var filestream = new FileStream(Path, FileMode.Create);
            var doc = new XmlDocument();

            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlNode feedsNode = doc.CreateElement("Categories");
            doc.AppendChild(feedsNode);

            doc.Save(filestream);
            filestream.Close();
        }

        private bool IdExists(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            foreach (XElement element in doc.Descendants("Categories").Elements("Category"))
            {
                if (id.ToString() == element.Attribute("Id").ToString())
                {
                    return true;
                }
            }

            return false;
        }

        public int GetFreeId()
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var everyId = from XElement element in doc.Descendants("Categories").Elements("Category")
                          orderby Convert.ToInt32(element.Attribute("Id"))
                          select Convert.ToInt32(element.Attribute("Id"));

            int newId = 1;
            foreach (int usedId in everyId)
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
