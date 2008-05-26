using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;

namespace PodZooc
{
    /// <summary>
    /// 0.2.2.0: 26 May 2008: added reload button. changed loading config time to after form-shown. changed application icon from http://www.vistaicons.com/
    /// 0.2.1.0:  5 Mar 2008: changed old app name.
    /// 0.2.0.0:  5 Mar 2008: fixed non-readable feed problem.
    /// 0.1.0.0: initial verion
    /// </summary>
    public partial class FormMain : Form
    {
        private const string ConfigFile = "PodZooc.config";
        private string AppName;
        private const string AuthorName = "mio (yeoupooh 앳 gmail 닷 com)";

        public FormMain()
        {
            InitializeComponent();

            AppName = "PodZooc " + Application.ProductVersion.ToString();

            this.Text = AppName;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timerStartUp.Enabled = true;
        }

        private void AddFeed(string title, string url)
        {
            FeedInfo feed = new FeedInfo();
            feed.Title = title;
            feed.Url = url;
            listBoxFeeds.Items.Add(feed);
        }

        private void AddFeed(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                string xmlStr = wc.DownloadString(url);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.InnerXml = xmlStr;

                string title = xmlDoc.SelectSingleNode("/rss/channel/title").InnerText;

                FeedInfo feed = new FeedInfo();
                feed.Title = title;
                feed.Url = url;
                listBoxFeeds.Items.Add(feed);
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFeeds.SelectedItem != null && listBoxFeeds.SelectedItem is FeedInfo)
            {
                FeedInfo feed = listBoxFeeds.SelectedItem as FeedInfo;

                try
                {
                    WebClient wc = new WebClient();
                    wc.Encoding = Encoding.UTF8;
                    string xmlStr = wc.DownloadString(feed.Url);
                    textBoxDebug.Text = xmlStr;

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.InnerXml = xmlStr;

                    XmlNodeList xnItems = xmlDoc.SelectNodes("/rss/channel/item");

                    listBoxPods.Items.Clear();
                    foreach (XmlNode xnItem in xnItems)
                    {
                        PodInfo pod = new PodInfo();
                        pod.Title = xnItem.SelectSingleNode("title").InnerText;

                        // ref: http://www.codeproject.com/KB/cpp/myXPath.aspx
                        XmlNode enclosure = xnItem.SelectSingleNode("enclosure");
                        if (enclosure != null)
                        {
                            string url = enclosure.Attributes.GetNamedItem("url").Value;
                            if (url != null)
                            {
                                pod.EnclosureUrl = url;
                            }

                            listBoxPods.Items.Add(pod);
                        }
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (XmlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region Config

        private void LoadConfig()
        {
            listBoxFeeds.Items.Clear();
            listBoxPods.Items.Clear();

            using (StreamReader sr = new StreamReader(ConfigFile))
            {
                while (true)
                {
                    string url = sr.ReadLine();
                    if (url == null)
                    {
                        break;
                    }
                    AddFeed(url);
                }
            }
        }

        private void SaveConfig()
        {
            using (StreamWriter sw = new StreamWriter(ConfigFile))
            {
                foreach (FeedInfo feed in listBoxFeeds.Items)
                {
                    sw.WriteLine(feed.Url);
                }
            }
        }

        #endregion

        private void listBoxPods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPods.SelectedItem != null && listBoxPods.SelectedItem is PodInfo)
            {
                PodInfo pod = listBoxPods.SelectedItem as PodInfo;
                toolStripStatusLabelMessage.Text = pod.Title + " (" + pod.EnclosureUrl + ")";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormAddFeed dlg = new FormAddFeed())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    AddFeed(dlg.Url);
                    SaveConfig();
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxPods.SelectedItem != null && listBoxPods.SelectedItem is PodInfo)
            {
                PodInfo pod = listBoxPods.SelectedItem as PodInfo;
                axWindowsMediaPlayerMain.currentMedia = axWindowsMediaPlayerMain.newMedia(pod.EnclosureUrl);
                axWindowsMediaPlayerMain.Ctlcontrols.play();
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0} by {1}\rApplication Icon from http://www.vistaicons.com/.", AppName, AuthorName), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void timerStartUp_Tick(object sender, EventArgs e)
        {
            timerStartUp.Enabled = false;
            LoadConfig();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }
    }
}