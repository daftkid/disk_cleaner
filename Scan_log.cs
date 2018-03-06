using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disk_cleaner
{
    public partial class Scan_log : Form
    {
        private string prepend = "==> Found: ";

        public Scan_log()
        {
            InitializeComponent();
        }

        public void OutputLog(List<string> text)
        {
            richTextBox1.Clear();
            foreach (string line in text)
            {
                richTextBox1.AppendText(prepend);
                richTextBox1.AppendText(line + "\r\n");
            }
        }
    }
}
