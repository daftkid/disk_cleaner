using System;
using Ini;
using System.Windows.Forms;

namespace configs
{
    public struct GlobalVars
    {
        public static string INI_PATH = ".\\config.ini";

        public static string file_names;
        public static string file_exts;
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

        public void LoadConfigs()
        {
            try
            {
                GlobalVars.file_names = ini.IniReadValue("Main", "FileNames");
                GlobalVars.file_exts = ini.IniReadValue("Main", "FileExtensions");
                GlobalVars.show_log = Convert.ToBoolean(ini.IniReadValue("Logs", "ShowLogs"));
                GlobalVars.run_number = Convert.ToInt32(ini.IniReadValue("Service", "RunNumber"));
                GlobalVars.save_logs = Convert.ToBoolean(ini.IniReadValue("Logs", "SaveToFile"));
                GlobalVars.log_path = ini.IniReadValue("Logs", "LogPath");
                GlobalVars.start_in_bg = Convert.ToBoolean(ini.IniReadValue("Automation", "StartInBG"));
                GlobalVars.time_step = Convert.ToInt32(ini.IniReadValue("Automation", "TimeStep"));
                GlobalVars.time_measure = ini.IniReadValue("Automation", "TimeMeasure");

            }
            catch
            {
                MessageBox.Show("Can not find ini from " + GlobalVars.INI_PATH + "file! File will be written after first run", "INI loading failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
