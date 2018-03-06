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
using System.Collections;

using configs;

namespace disk_cleaner
{
    public partial class Main : Form
    {
        // object for storing and manipulating configs from INI file
        // provide common way for reading and writing configs
        public Configs config = new Configs();

        // object for Logging form
        public Scan_log scan_log;

        // List of strings in log
        public List<string> log = new List<string>();

        public Main()
        {
            InitializeComponent();

            scan_log = new Scan_log();

            config.LoadConfigs();

            OutputConfigs();

            config.ini.IniWriteValue("Service", "RunNumber", (GlobalVars.run_number + 1).ToString());

            // load list of the available disks in system to a combo box
            foreach (var drive in DriveInfo.GetDrives())
            {
                cb_disk.Items.Add(drive);
                cb_disk.Text = drive.ToString();
            }
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            // find files
            Hashtable hashtable = new Hashtable();
            List<string> filters_list = new List<string>();

            string[] filters = GetFiltersFromInput(tb_file_exts.Text, tb_file_names.Text);

            hashtable = GetListOfFiles(filters);

            cb_show_log_Click(sender, e);

            Result res_form = new Result(hashtable);
            res_form.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.MainForm = this;
            settings_form.Show();
            OutputConfigs();

            this.Hide();
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            tb_file_exts.Text = GlobalVars.file_exts;
            tb_file_names.Text = GlobalVars.file_names;
            cb_disk.Text = GlobalVars.disk;
            cb_show_log.Checked = GlobalVars.show_log;
        }

        // Info buttons executing
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

        // wrapper for MessageBox.Show() function
        private void ShowMsgBox(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // write values from INI file to form's elements
        public void OutputConfigs()
        {
            tb_file_exts.Text = GlobalVars.file_exts;
            tb_file_names.Text = GlobalVars.file_names;
            cb_show_log.Checked = GlobalVars.show_log;
        }

        private Hashtable GetListOfFiles(string [] filters)
        {
            Hashtable file_info = new Hashtable();


            foreach (string filter in filters)
            {
                try
                {
                    string[] files = System.IO.Directory.GetFiles("F:\\test_folder\\", filter, System.IO.SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        FileInfo info = new FileInfo(file);
                        file_info.Add(file, info.Length);

                        log.Add(file);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                }           
            }

            return file_info;
        }

        private string[] GetFiltersFromInput(string exts, string names)
        {
            string[] result = { };
            List<string> res = new List<string>();

            foreach (string name in names.Split(','))
            {
                foreach (string ext in exts.Split(','))
                {
                    res.Add(name + "." + ext);
                }
            }

            return res.ToArray();
        }

        private void cb_show_log_Click(object sender, EventArgs e)
        {
            if (cb_show_log.Checked)
            {
                try
                {
                    scan_log.OutputLog(log);
                    scan_log.Show();
                }
                catch (ObjectDisposedException)
                {
                    scan_log = new Scan_log();
                    scan_log.OutputLog(log);
                    scan_log.Show();
                }
                
            }
            else
            {
                try
                {
                    scan_log.Hide();
                }
                catch (ObjectDisposedException)
                { }            
                
            }
        }
    }

}
