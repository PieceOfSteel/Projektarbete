using System;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;
using MetroFramework.Forms;

namespace Projekt_C
{
    public partial class Form1 : MetroForm
    {
        private TabPage feedTab;
        private SyndicationFeed feed;

        public Form1()
        {
            InitializeComponent();
            var reader = XmlReader.Create(txtBoxUrl.Text);
            feed = SyndicationFeed.Load(reader);
            feedTab = new TabPage(feed.Title.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tabCtrlFeeds.TabPages.Add(feedTab);
                CreateFeedList();
            }
            catch (Exception)
            {
              
            }
        }
        
        public void CreateFeedList()
        {
            var feedList = new ListBox();
            feedList.Dock = DockStyle.Fill;
            feedTab.Controls.Add(feedList);

            foreach (SyndicationItem feedItem in feed.Items)
            {
                //spara till XMLfil?
                feedList.Items.Add(feedItem.Title.Text);

            }d
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
          

