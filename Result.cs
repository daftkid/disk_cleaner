using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace disk_cleaner
{
    public partial class Result : Form
    {
        public Result(Hashtable files)
        {
            InitializeComponent();

            int count_of_files = 0;
            int sum_size = 0;

            foreach (string file in files.Keys)
            {
                dataGridView1.Rows.Add(true, file, files[file]);
                count_of_files++;
                sum_size += Convert.ToInt32(files[file]);
            }

            l_files_count_total.Text = count_of_files.ToString();
            l_files_size_total.Text = sum_size.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_select_all_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Check"].Value = cb_select_all.Checked;
            }
        }
    }
}
