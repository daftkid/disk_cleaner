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

        private void link_vk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(vk_link);
        }

        private void link_tg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(tg_link);
        }

        private void link_linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkedin_link);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
