using System;
using System.Windows.Forms;

namespace disk_cleaner
{
    public partial class About : Form
    {
        string vk_link = "https://vk.com/alex_daft_kid_mykytenko";
        string tg_link = "https://t.me/daft_kiD";
        string linkedin_link = "https://www.linkedin.com/in/oleksandr-mykytenko/";

        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(vk_link);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(tg_link);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkedin_link);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
