using System;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Utilities;
using Projekt_C.Persistence;

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
            //Old implementation:
            /*
            try
            {
                tabCtrlFeeds.TabPages.Add(feedTab);
                CreateFeedList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

            //New implementation:
            var inputName = txtBoxNameOfFeed.Text;
            var inputUrl = txtBoxUrl.Text;
            var inputFreqency = txtBoxFrequency.Text;
            var inputCategory = comboBoxCategories.Text;

            bool allFieldsFilled;

            if (
                inputName       == ""   ||
                inputUrl        == ""   ||
                inputFreqency   == ""   ||
                inputCategory   == ""
                )
            {
                allFieldsFilled = false;
                Alert.FieldsNotFilled();
            } else
            {
                allFieldsFilled = true;
            }

            if(allFieldsFilled) {
                var podcastFeed = new PodcastFeed
                {
                    Name = txtBoxNameOfFeed.Text,
                    Url = txtBoxUrl.Text,
                    UpdateInterval = Convert.ToInt32(txtBoxFrequency.Text),
                    Category = UnitOfWork.Category.getByName(comboBoxCategories.Text)
                };
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

        private void button1_Click(object sender, EventArgs e)
        {
            //btnAddCategory



            var category = new Category();
            category.Name = txtBoxNewCategory.Text;
            UnitOfWork.Category.Add(category);

            Alert.CategoryAdded();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
          

