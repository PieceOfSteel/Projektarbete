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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            try
            {
                var reader = XmlReader.Create(txtBoxUrl.Text);
                var feed = SyndicationFeed.Load(reader);

                var feedTab = new TabPage(feed.Title.Text); //hämta från xml ist?

                tabCtrlFeeds.TabPages.Add(feedTab);

                var feedList = new ListBox();
                feedList.Dock = DockStyle.Fill;

                feedTab.Controls.Add(feedList);
                

                foreach (SyndicationItem feedItem in feed.Items)
                {
                    //spara till XMLfil?
                    feedList.Items.Add(feedItem.Title.Text);
                    
                }
            }
            catch (Exception)
            {

              
            }
           

           
        }
       

            
            
        }

}
