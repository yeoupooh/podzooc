using System;
using System.Collections.Generic;
using System.Text;

namespace PodZooc
{
    public class FeedInfo
    {
        private string m_title;
        private string m_url;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        public override string ToString()
        {
            return m_title;
        }
    }
}
