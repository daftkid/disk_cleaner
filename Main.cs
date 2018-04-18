using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


using configs;

namespace disk_cleaner
{

    enum Scheduler
    {
        EveryMinutes,
        EveryHour,
        EveryDay,
        EveryWeek
    }

    public partial class Main : Form
    {
        // object for storing and manipulating configs from INI file
        // provide common way for reading and writing configs
        public Configs config = new Configs();

        // object for Logging form
        private Scan_log scan_log;

        // List of strings in log
        private List<string> log = new List<string>();

        public Main()
        {
            InitializeComponent();

            // crate form with logs
            scan_log = new Scan_log();

            scheduler.Visible = false;

            // load configs from ini to global object
            this.config.LoadConfigs();

            // write out configs to form's elements
            this.OutputConfigs();

            this.config.ini.IniWriteValue("Service", "RunNumber", (GlobalVars.run_number + 1).ToString());

            // load list of the available disks in system to a combo box
            foreach (var drive in DriveInfo.GetDrives())
            {
                cb_disk.Items.Add(drive);
                cb_disk.Text = drive.ToString();
            }

            SchedulerExecute();
        }

        // Action on button 'Scan' click
        private void btn_scan_Click(object sender, EventArgs e)
        {
            banner banner = new banner();
            banner.Show();

            Application.DoEvents();

            // find files
            Hashtable files_dict = new Hashtable();
            List<string> filters_list = new List<string>();

            this.Hide();


            // get all possible combination of extension regexp and name regexp
            string[] filters = this.GetFiltersFromInput(tb_file_exts.Text, tb_file_names.Text);

            // get list of all suitable files under all directories
            files_dict = this.GetListOfFiles(filters);

            //
            cb_show_log_Click(sender, e);

            // Show form with results of scanning
            Result res_form = new Result(files_dict);
            banner.Hide();
            this.Show();

            try
            {
                res_form.Show();
            }
            catch (InvalidOperationException)
            {
                res_form.Show();
            }

            if (GlobalVars.save_logs)
            {
                WriteLogsToFile(log, GlobalVars.log_path);
            }           
        }
        // Action on button 'Settings' click 
        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings
            {
                MainForm = this
            };
            settings_form.Show();

            this.OutputConfigs();

            // Hide main form and waiting for actions from user
            this.Hide();
        }
        // Action on button 'Clear' click
        // Load latest saved configs to main form
        private void btn_default_Click(object sender, EventArgs e)
        {
            this.OutputConfigs();
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
        // write out values from INI file to form's elements
        public void OutputConfigs()
        {
            tb_file_exts.Text = GlobalVars.file_exts;
            tb_file_names.Text = GlobalVars.file_names;
            cb_show_log.Checked = GlobalVars.show_log;

            if (GlobalVars.start_in_bg)
            {
                scheduler.Visible = true;
            }
            else
            {
                scheduler.Visible = false;
            }
        }
        // Search files matching particular pattern
        private Hashtable GetListOfFiles(string [] filters)
        {
            // dictionary in the following format:
            // "path_to_file": "size"
            Hashtable file_info = new Hashtable();
            List<string> dirs = new List<string>();

            // search all folders on selected drive recursively
            dirs = this.ShowAllFoldersOnDrive(cb_disk.Text);

            // loop thru all directories where we have access
            foreach (string dir in dirs)
            {
                // loop thru all search filters (patterns)
                foreach (string filter in filters)
                {
                    try
                    {
                        // get all files in particular dir
                        // dir - directory where we should perform search
                        // filter - search pattern
                        string[] files = System.IO.Directory.GetFiles(dir, filter);

                        // get information about all files in particular directory which suit pattern
                        foreach (string file in files)
                        {
                            FileInfo info = new FileInfo(file);
                            file_info.Add(file, info.Length);
                            
                            // add new line to log
                            log.Add(string.Format("{0:HH:mm:ss}", DateTime.Now) + " Filter: [" + filter + "] Found file: " + file);

                        }
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        log.Add(string.Format("{0:HH:mm:ss}", DateTime.Now) + " Filter: [" + filter + "] Error: " + e.Message);
                    }
                        

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

        private void WriteLogsToFile(List<string> logs, string path)
        {
            TextWriter tw = new StreamWriter(path);

            foreach (String s in logs)
                tw.WriteLine(s);

            tw.Close();
        }

        private List<string> ShowAllFoldersOnDrive(string path)
        {
            List<string> result = new List<string>();
            try
            {
                foreach (string folder in Directory.GetDirectories(path))
                {
                    result.Add(folder);
                    result.AddRange(ShowAllFoldersOnDrive(folder));
                }
            }
            catch (UnauthorizedAccessException e)
            {
            }

            return result;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: show about window
        }

        CancellationTokenSource m_ctSource;

        private void runCodeAt(DateTime date, Scheduler scheduler)
        {
            m_ctSource = new CancellationTokenSource();

            var dateNow = DateTime.Now;
            TimeSpan ts;
            if (date > dateNow)
                ts = date - dateNow;
            else
            {
                date = getNextDate(date, scheduler, GlobalVars.time_step);
                ts = date - dateNow;
            }

            //waits certan time and run the code, in meantime you can cancel the task at anty time
            Task.Delay(ts).ContinueWith((x) =>
            {
                //run the code at the time
                methodToCall(date);

                //setup call next day
                runCodeAt(getNextDate(date, scheduler, GlobalVars.time_step), scheduler);

            }, m_ctSource.Token);
        }

        private DateTime getNextDate(DateTime date, Scheduler scheduler, int step)
        {
            switch (scheduler)
            {
                case Scheduler.EveryMinutes:
                    return date.AddMinutes(step);
                case Scheduler.EveryHour:
                    return date.AddHours(step);
                case Scheduler.EveryDay:
                    return date.AddDays(step);
                case Scheduler.EveryWeek:
                    return date.AddDays(step);
                default:
                    throw new Exception("Invalid scheduler");
            }

        }

        private void methodToCall(DateTime time)
        {
            //setup next call
            var nextTimeToCall = getNextDate(time, getScheduler(), GlobalVars.time_step);

            MessageBox.Show(string.Format("Cleaning started at {0}. The next execution will be at {1}", time, nextTimeToCall));

            this.BeginInvoke((Action)(() =>
            {
                btn_scan.PerformClick();
            }));
        }

        private Scheduler getScheduler()
        {
            string time_measure = GlobalVars.time_measure;
            switch (time_measure)
            {
                case "Minutes":
                    return Scheduler.EveryMinutes;
                case "Hours":
                    return Scheduler.EveryHour;
                case "Days":
                    return Scheduler.EveryDay;
                case "Weeks":
                    return Scheduler.EveryWeek;
            }

            //default
            return Scheduler.EveryDay;
        }

        private void scheduler_Click(object sender, EventArgs e)
        {
            if (m_ctSource != null)
            {
                m_ctSource.Cancel();
                scheduler.Visible = false;
                MessageBox.Show("Scheduler has been stopped!");
                GlobalVars.start_in_bg = false;
                config.ini.IniWriteValue("Automation", "StartInBG", "False");
            }
        }

        public void SchedulerExecute()
        {
            if (GlobalVars.start_in_bg)
            {
                scheduler.Visible = true;
                var dateNow = DateTime.Now;
                var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.Hour, dateNow.Minute, 0);

                var nextDateValue = getNextDate(date, getScheduler(), GlobalVars.time_step);

                runCodeAt(nextDateValue, getScheduler());

                MessageBox.Show("Scheduler activated! Next clean will be performed at " + nextDateValue.ToString());
            }
        }
    }

}
