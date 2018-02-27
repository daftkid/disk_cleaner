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

using Ini;

namespace disk_cleaner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // load INI file with saved settings
            if (!LoadINIFile())
            {
                return;
            }

            // load list of the available disks in system to a combo box
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

        private bool LoadINIFile()
        {
            try
            {
                IniFile ini;
                GlobalVars.ini = new IniFile(GlobalVars.INI_PATH);

                ini = GlobalVars.ini; 

                GlobalVars.file_names = ini.IniReadValue("Main", "FileNames");
                GlobalVars.file_exts = ini.IniReadValue("Main", "FileExtensions");           
            }
            catch
            {
                MessageBox.Show("Can not load ini from " + GlobalVars.INI_PATH + "file!", "INI loading failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        // class for storing gloabal variables and constants

    }

    public class GlobalVars
    {
        public static string INI_PATH = "..\\..\\config.ini";

        public static IniFile ini;

        public static string file_names;
        public static string file_exts;
    }
}
