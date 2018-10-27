﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    class Category : EntityBase
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */
        public List<PodcastFeed> PodcastFeeds { get; }

        public Category(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            PodcastFeeds = new List<PodcastFeed>();
        }
    }
}
