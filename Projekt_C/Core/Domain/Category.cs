﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PodcastFeed> PodcastFeeds { get; set; }
    }
}