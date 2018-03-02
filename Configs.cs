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
                }
                else
                {
                    GlobalVars.file_names = ini.IniReadValue("Main", "FileNames");
                    GlobalVars.file_exts = ini.IniReadValue("Main", "FileExtensions");
                    GlobalVars.show_log = Convert.ToBoolean(ini.IniReadValue("Logs", "ShowLogs"));
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
