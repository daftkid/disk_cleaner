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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            string firstColum = "C:\\Users\\daft_kiD\\Desktop\\Mathcad\\test.xcmd";
            string secondColum = "1 Mb";
            dataGridView1.Rows.Add(true, firstColum,secondColum);

            firstColum = "C:\\Users\\daft_kiD\\Desktop\\Mathcad\\test1.xcmd";
            secondColum = "156 Kb";
            dataGridView1.Rows.Add(true, firstColum, secondColum);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
