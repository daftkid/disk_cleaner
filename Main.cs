using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace disk_cleaner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            foreach (var drive in DriveInfo.GetDrives())
            {
                cb_disk.Items.Add(drive);
                cb_disk.Text = drive.ToString();
            }
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            Result res_form = new Result();
            res_form.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.Show();
        }

        private void btn_default_Click(object sender, EventArgs e)
        {

        }

        private void btn_disk_info_Click(object sender, EventArgs e)
        {
            ShowMsgBox("Please choose a disk for scanning.\nPlease note that there are specified only currently available disks in your system.", "Choose disk");
        }

        private void btn_names_info_Click(object sender, EventArgs e)
        {
            ShowMsgBox("Please provide names of files which should be searched.\nUse comma as a delimiter.", "File names");
        }

        private void btn_extension_info_Click(object sender, EventArgs e)
        {
            ShowMsgBox("Please provide extensions for files to be searched\nDo not use dots or regular expressions.\nUse comma as a delimiter.", "File extensions");
        }

        private void ShowMsgBox(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
