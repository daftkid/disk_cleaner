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

using configs;

namespace disk_cleaner
{
    public partial class Settings : Form
    {

        public Configs config = new Configs();

        public Settings()
        {
            InitializeComponent();

            config.LoadConfigs();
            OutputConfigs();

            // Get all available disk drives in system
            foreach (var drive in DriveInfo.GetDrives())
            {
                double freeSpace = drive.TotalFreeSpace;
                double totalSpace = drive.TotalSize / 1024.0 / 1024.0 / 1024.0;
                double percentFree = (freeSpace / drive.TotalSize) * 100;
                float num = (float)percentFree;

                dataGridView1.Rows.Add(false, drive, totalSpace.ToString("000.00") + " GiB", percentFree.ToString("00.00") + "%", 0);

            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            config.ini.IniWriteValue("Main", "FileExtensions", tb_file_exts.Text);
            config.ini.IniWriteValue("Main", "FileNames", tb_file_names.Text);
            config.ini.IniWriteValue("Logs", "ShowLogs", cb_show_log.Checked.ToString());
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            config.LoadConfigs(true);
            OutputConfigs();
        }

        private void OutputConfigs()
        {
            tb_file_exts.Text = GlobalVars.file_exts;
            tb_file_names.Text = GlobalVars.file_names;
            cb_show_log.Checked = GlobalVars.show_log;
        }
    }
}
