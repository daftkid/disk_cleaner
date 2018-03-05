using System;
using Ini;
using System.Windows.Forms;

namespace configs
{
    public struct GlobalVars
    {
        public static string INI_PATH = "..\\..\\config.ini";

        public static string file_names;
        public static string file_exts;
        public static string disk;
        public static bool show_log;
        public static bool save_logs;
        public static string log_path;
        public static int run_number;
        public static bool start_in_bg;
        public static bool trigger_on_disk_space;
        public static int time_step;
        public static string time_measure;
    }

    public class Configs
    {

        public IniFile ini;

        public Configs()
        {
            ini = new IniFile(GlobalVars.INI_PATH);
        }

        public void LoadConfigs(bool default_options = false)
        {
            try
            {
                if (default_options)
                {
                    GlobalVars.file_names = ini.IniReadValue("Default", "FileNames");
                    GlobalVars.file_exts = ini.IniReadValue("Default", "FileExtensions");
                    GlobalVars.show_log = Convert.ToBoolean(ini.IniReadValue("Default", "ShowLogs"));
                    GlobalVars.save_logs = false;
                    GlobalVars.log_path = "";
                }
                else
                {
                    GlobalVars.file_names = ini.IniReadValue("Main", "FileNames");
                    GlobalVars.file_exts = ini.IniReadValue("Main", "FileExtensions");
                    GlobalVars.show_log = Convert.ToBoolean(ini.IniReadValue("Logs", "ShowLogs"));
                    GlobalVars.run_number = Convert.ToInt32(ini.IniReadValue("Service", "RunNumber"));
                    GlobalVars.save_logs = Convert.ToBoolean(ini.IniReadValue("Logs", "SaveToFile"));
                    GlobalVars.log_path = ini.IniReadValue("Logs", "LogPath");
                }

            }
            catch
            {
                MessageBox.Show("Can not load ini from " + GlobalVars.INI_PATH + "file!", "INI loading failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
