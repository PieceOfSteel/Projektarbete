using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Utilities;

namespace Projekt_C
{
    public partial class Form1 : MetroForm
    {
        private TabPage feedTab;

        public Form1()
        {
            InitializeComponent();
            feedTab = new TabPage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tabCtrlFeeds.TabPages.Add(feedTab);
                CreateFeedList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void CreateFeedList()
         {
            var feedList = new ListBox();
            feedList.Dock = DockStyle.Fill;
            feedTab.Controls.Add(feedList);
            
            var rss = WebFetcher.FetchRss(txtBoxUrl.Text);
            var feed = RssParser.GetPodcastFeed(rss);
            feedTab.Text = feed.Name;

            foreach (PodcastEpisode podcast in feed.PodcastEpisodes)
            {
                feedList.Items.Add(podcast.Name);
            }
        }

        private void btnChangeFeed_Click(object sender, EventArgs e)
        {
            var form = new UIChangeFeed();
            form.Show(this); 
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            var form = new UIchangeCategory();
            form.Show(this);
        }
    }
}
          

