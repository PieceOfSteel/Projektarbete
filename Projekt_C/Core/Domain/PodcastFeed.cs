using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    public class PodcastFeed : EntityBase, IPersistent
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */
        public string Url { get; set; }
        public int UpdateInterval { get; set; }
        public List<PodcastEpisode> PodcastEpisodes { get; set; }

        public PodcastFeed(int Id, string Name, string Url)
        {
            this.Id = Id;
            this.Name = Name;
            this.Url = Url;
            PodcastEpisodes = new List<PodcastEpisode>();

        }

        public override string GetInfo(string sep = "\t")
        {
            string info = base.GetInfo(sep) + "Url: " + sep + Url;
            return info;
        }
    
    }
}
