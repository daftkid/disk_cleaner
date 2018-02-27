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

namespace disk_cleaner
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            // Get all available disk drives in system
            foreach (var drive in DriveInfo.GetDrives())
            {
                double freeSpace = drive.TotalFreeSpace;
                double totalSpace = drive.TotalSize / 1024.0 / 1024.0 / 1024.0;
                double percentFree = (freeSpace / drive.TotalSize) * 100;
                float num = (float)percentFree;

                dataGridView1.Rows.Add(false, drive, totalSpace.ToString("000.00") + " GiB", percentFree.ToString("00.00") + "%", 0);

            }
        }
    }
}
