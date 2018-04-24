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
            richTextBox1.Clear();
            foreach (string line in text)
            {
                richTextBox1.AppendText(line + "\r\n");
            }
        }
    }
}
