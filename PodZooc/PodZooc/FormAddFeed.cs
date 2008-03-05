using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PodZooc
{
    public partial class FormAddFeed : Form
    {
        public string Url
        {
            get { return textBoxUrl.Text; }
        }

        public FormAddFeed()
        {
            InitializeComponent();
        }
    }
}