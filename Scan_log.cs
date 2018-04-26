using System.Collections.Generic;
using System.Windows.Forms;

namespace disk_cleaner
{
    public partial class Scan_log : Form
    {
        public Scan_log()
        {
            InitializeComponent();
        }

        public void OutputLog(List<string> text)
        {
            logBox.Clear();
            foreach (string line in text)
            {
                logBox.AppendText(line + "\r\n");
            }
        }
    }
}
