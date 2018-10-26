using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    class PodcastFeed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int UpdateInterval { get; set; }
        public List<PodcastEpisode> PodcastEpisodes { get; set; }
    }
}
