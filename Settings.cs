﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using configs;

namespace disk_cleaner
{
    public partial class Settings : Form
    {
        public Main MainForm { get; set; }

        public Settings()
        {
            InitializeComponent();
            OutputConfigs();

            btn_apply.Enabled = false;
        }

        // write new values to INI file
        private void btn_apply_Click(object sender, EventArgs e)
        {
            MainForm.config.ini.IniWriteValue("Main", "FileExtensions", tb_file_exts.Text);
            MainForm.config.ini.IniWriteValue("Main", "FileNames", tb_file_names.Text);
            MainForm.config.ini.IniWriteValue("Logs", "ShowLogs", cb_show_log.Checked.ToString());

            MainForm.config.ini.IniWriteValue("Logs", "SaveToFile", cb_save_logs_to_file.Checked.ToString());
            MainForm.config.ini.IniWriteValue("Logs", "LogPath", tb_logs_path.Text);

            MainForm.config.ini.IniWriteValue("Automation", "StartInBG", cb_start_in_bg.Checked.ToString());
            MainForm.config.ini.IniWriteValue("Automation", "TimeStep", nud_time_step.Value.ToString());
            MainForm.config.ini.IniWriteValue("Automation", "TimeMeasure", cb_time_measure.Text);
            MainForm.config.ini.IniWriteValue("Automation", "AutoFileExtensions", tb_auto_ext.Text);
            MainForm.config.ini.IniWriteValue("Automation", "AutoFileNames", tb_auto_names.Text);

            foreach (DataGridViewRow row in dgv_disks_list.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check_disk"].Value))
                {
                    MainForm.config.ini.IniWriteValue("Disk", row.Cells["disk"].Value.ToString(), row.Cells["threshold"].Value.ToString());
                }
            }

            btn_apply.Enabled = false;
            
            // reload updated configs from INI file after writing
            MainForm.config.LoadConfigs();
            // renew fields on Main form after saving new configs

            MainForm.OutputConfigs();
            this.OutputConfigs();
            
        }

        // set default configs (from 'Default' section in INI file)
        private void btn_default_Click(object sender, EventArgs e)
        {
            MainForm.config.LoadConfigs();
            OutputConfigs();

            btn_discard.Enabled = false;
        }

        // write values from INI file to form's elements
        private void OutputConfigs()
        {
            tb_file_exts.Text = GlobalVars.file_exts;
            tb_file_names.Text = GlobalVars.file_names;
            cb_show_log.Checked = GlobalVars.show_log;

            cb_save_logs_to_file.Checked = GlobalVars.save_logs;
            tb_logs_path.Text = GlobalVars.log_path;

            cb_start_in_bg.Checked = GlobalVars.start_in_bg;
            cb_time_measure.Text = GlobalVars.time_measure;
            nud_time_step.Value = GlobalVars.time_step;

            tb_auto_ext.Text = GlobalVars.file_exts_auto;
            tb_auto_names.Text = GlobalVars.file_names_auto;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_apply_Click(sender, e);
            this.Close();
        }

        private void tb_file_exts_TextChanged(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;
            btn_discard.Enabled = true;
        }

        private void btn_discard_Click(object sender, EventArgs e)
        {
            OutputConfigs();
        }

        private void cb_save_logs_to_file_CheckedChanged(object sender, EventArgs e)
        {
            tb_file_exts_TextChanged(sender, e);

            if (cb_save_logs_to_file.Checked == true)
            {
                btn_browse.Enabled = true;
                tb_logs_path.Enabled = true;
            }
            else
            {
                btn_browse.Enabled = false;
                tb_logs_path.Enabled = false;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Log files (*.log) | *.log";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_logs_path.Text = saveFileDialog1.FileName;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Show();
            this.Hide();
            MainForm.SchedulerExecute();
            MainForm.is_settings = false;
        }

        private void cb_trigger_on_low_disk_space_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cb_start_in_bg_CheckedChanged(object sender, EventArgs e)
        {
            cb_time_measure.Enabled = cb_start_in_bg.Checked;
            nud_time_step.Enabled = cb_start_in_bg.Checked;

            tb_auto_ext.Enabled = cb_start_in_bg.Checked;
            tb_auto_names.Enabled = cb_start_in_bg.Checked;

            tb_file_exts_TextChanged(sender, e);

            dgv_disks_list.Rows.Clear();
            dgv_disks_list.Refresh();

            if (cb_start_in_bg.Checked)
            {
                // Get all available disk drives in system
                try
                {
                    foreach (var drive in DriveInfo.GetDrives())
                    {
                        double freeSpace = drive.TotalFreeSpace;
                        double totalSpace = drive.TotalSize / 1024.0 / 1024.0 / 1024.0;
                        double percentFree = (freeSpace / drive.TotalSize) * 100;

                        string threshold = "";

                        try
                        {
                            threshold = MainForm.config.ini.IniReadValue("Disk", drive.Name);
                        }
                        catch
                        {

                        }


                        bool check = false;

                        if (threshold.Length != 0)
                        {
                            check = true;
                        }

                        dgv_disks_list.Rows.Add(check, drive, totalSpace.ToString("0.00") + " GiB", percentFree.ToString("00.00") + "%", threshold);
                    }                  
                }
                catch (Exception err)
                {

                }
            }
        }

        private void dgv_disks_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_disks_list.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgv_disks_list_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_disks_list.Rows)
            {
                Regex not_num_period = new Regex("[^0-9.]");
                string result = not_num_period.Replace(row.Cells["threshold"].Value.ToString(), "");

                row.Cells["threshold"].Value = result;
            }
        }
    }
}
