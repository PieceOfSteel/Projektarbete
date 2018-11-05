using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    public class Category : EntityBase, IPersistent
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */
        public List<PodcastFeed> PodcastFeeds { get; }

        public Category()
        {
            PodcastFeeds = new List<PodcastFeed>();
        }

        public Category(int Id, string Name)
            : this()
        {
            this.Id = Id;
            this.Name = Name;
            
        }
    }
}
