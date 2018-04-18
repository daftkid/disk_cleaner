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
        private int count_of_files = 0;
        private int sum_size = 0;

        Hashtable files;

        public Result(Hashtable files)
        {
            InitializeComponent();

            this.files = files;

            foreach (string file in files.Keys)
            {
                double size = (double)Convert.ToInt32(files[file]);
                dataGridView1.Rows.Add(true, file, ConvertFromBytes(size));
                count_of_files++;
                sum_size += Convert.ToInt32(files[file]);
            }

            if (count_of_files == 0)
            {
                l_nothing_found.Visible = true;
            }
            else
            {
                l_nothing_found.Visible = false;
            }

            l_files_count_total.Text = count_of_files.ToString();
            l_selected_files_count.Text = count_of_files.ToString();
            l_files_size_total.Text = ConvertFromBytes(sum_size).ToString();
            l_selected_files_size.Text = ConvertFromBytes(sum_size).ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int files_count = 0;
            int sum_size = 0;

            dataGridView1_CellContentClick(sender, e);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Check"].Value))
                {
                    files_count++;
                    sum_size += Convert.ToInt32(files[row.Cells["File_name"].Value]);
                }
            }

            l_selected_files_count.Text = files_count.ToString();
            l_selected_files_size.Text = ConvertFromBytes(sum_size).ToString();
        }

        private void l_selected_files_count_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(l_selected_files_count.Text) > 0)
            {
                btn_remove.Enabled = true;
            }
            else btn_remove.Enabled = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Check"].Value))
                {
                    System.IO.File.Delete(row.Cells["File_name"].Value.ToString());
                }
            }
            this.Close();
        }

        private string ConvertFromBytes(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
