using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Projekt_C.Core;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Repositories;

namespace Projekt_C.Persistence.Repositories
{
    class CategoryRepository : IRepository<Category>
    {
        public string Path { get; set; }

        public CategoryRepository(string path)
        {
            Path = path;
        }

        public void Add(Category obj)
        {
            Category category = obj;

            XmlDocument doc = new XmlDocument();
            doc.Load(Path);



            throw new NotImplementedException();
            
        }

        public Category Get(int id)
        {
            var searchId = id.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load(Path);

            foreach (XmlNode node in doc.DocumentElement)
            {
                var elementId = node.Attributes[0].InnerText;
                var elementName = node.ChildNodes[0].InnerText;
                if (elementId == searchId)
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(elementId);
                    category.Name = elementName;

                    return category;
                }
            }

            return null;
        }

        public void Remove(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
