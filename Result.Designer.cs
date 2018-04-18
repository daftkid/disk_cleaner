namespace disk_cleaner
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_nothing_found = new System.Windows.Forms.Label();
            this.cb_select_all = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.File_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.l_files_count_total = new System.Windows.Forms.Label();
            this.l_files_size_total = new System.Windows.Forms.Label();
            this.l_selected_files_size = new System.Windows.Forms.Label();
            this.l_selected_files_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total files count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total files size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_nothing_found);
            this.groupBox1.Controls.Add(this.cb_select_all);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose files for removing";
            // 
            // l_nothing_found
            // 
            this.l_nothing_found.AutoSize = true;
            this.l_nothing_found.Location = new System.Drawing.Point(159, 113);
            this.l_nothing_found.Name = "l_nothing_found";
            this.l_nothing_found.Size = new System.Drawing.Size(98, 13);
            this.l_nothing_found.TabIndex = 2;
            this.l_nothing_found.Text = "NOTHING FOUND";
            this.l_nothing_found.Visible = false;
            // 
            // cb_select_all
            // 
            this.cb_select_all.AutoSize = true;
            this.cb_select_all.Checked = true;
            this.cb_select_all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_select_all.Location = new System.Drawing.Point(6, 21);
            this.cb_select_all.Name = "cb_select_all";
            this.cb_select_all.Size = new System.Drawing.Size(189, 17);
            this.cb_select_all.TabIndex = 1;
            this.cb_select_all.Text = "Select all (might be slow operation)";
            this.cb_select_all.UseVisualStyleBackColor = true;
            this.cb_select_all.CheckedChanged += new System.EventHandler(this.cb_select_all_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.File_Name,
            this.File_size});
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Check
            // 
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // File_Name
            // 
            this.File_Name.FillWeight = 200F;
            this.File_Name.HeaderText = "File name";
            this.File_Name.Name = "File_Name";
            this.File_Name.ReadOnly = true;
            // 
            // File_size
            // 
            this.File_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.File_size.HeaderText = "File size";
            this.File_size.Name = "File_size";
            this.File_size.ReadOnly = true;
            this.File_size.Width = 69;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(153, 313);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(84, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(248, 313);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back to scan";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // l_files_count_total
            // 
            this.l_files_count_total.AutoSize = true;
            this.l_files_count_total.Location = new System.Drawing.Point(115, 30);
            this.l_files_count_total.Name = "l_files_count_total";
            this.l_files_count_total.Size = new System.Drawing.Size(25, 13);
            this.l_files_count_total.TabIndex = 5;
            this.l_files_count_total.Text = "256";
            // 
            // l_files_size_total
            // 
            this.l_files_size_total.AutoSize = true;
            this.l_files_size_total.Location = new System.Drawing.Point(115, 57);
            this.l_files_size_total.Name = "l_files_size_total";
            this.l_files_size_total.Size = new System.Drawing.Size(43, 13);
            this.l_files_size_total.TabIndex = 6;
            this.l_files_size_total.Text = "144 Mb";
            // 
            // l_selected_files_size
            // 
            this.l_selected_files_size.AutoSize = true;
            this.l_selected_files_size.Location = new System.Drawing.Point(336, 57);
            this.l_selected_files_size.Name = "l_selected_files_size";
            this.l_selected_files_size.Size = new System.Drawing.Size(43, 13);
            this.l_selected_files_size.TabIndex = 10;
            this.l_selected_files_size.Text = "144 Mb";
            // 
            // l_selected_files_count
            // 
            this.l_selected_files_count.AutoSize = true;
            this.l_selected_files_count.Location = new System.Drawing.Point(339, 30);
            this.l_selected_files_count.Name = "l_selected_files_count";
            this.l_selected_files_count.Size = new System.Drawing.Size(25, 13);
            this.l_selected_files_count.TabIndex = 9;
            this.l_selected_files_count.Text = "256";
            this.l_selected_files_count.TextChanged += new System.EventHandler(this.l_selected_files_count_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Selected files size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Selected files count:";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 355);
            this.Controls.Add(this.l_selected_files_size);
            this.Controls.Add(this.l_selected_files_count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l_files_size_total);
            this.Controls.Add(this.l_files_count_total);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Disk Cleaner Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Result_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cb_select_all;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label l_files_count_total;
        private System.Windows.Forms.Label l_files_size_total;
        private System.Windows.Forms.Label l_selected_files_size;
        private System.Windows.Forms.Label l_selected_files_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_size;
        private System.Windows.Forms.Label l_nothing_found;
    }
}