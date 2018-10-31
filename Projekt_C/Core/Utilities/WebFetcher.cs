using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Projekt_C.Core.Domain;
using System.Xml;


namespace Projekt_C.Core.Utilities
{
    static class WebFetcher
    {
        private static HttpClient client = new HttpClient();

        private static async Task<Rss> FetchRss(string url)
        {
            var content = await client.GetStringAsync(url);
            return new Rss
            {
                Url = url,
                Content = content
            };
        }
    }
}
