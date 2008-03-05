using System;
using System.Collections.Generic;
using System.Text;

namespace PodZooc
{
    public class PodInfo
    {
        private string m_title;
        private string m_enclosureUrl;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public string EnclosureUrl
        {
            get { return m_enclosureUrl; }
            set { m_enclosureUrl = value; }
        }

        public override string ToString()
        {
            return m_title;
        }
    }
}
