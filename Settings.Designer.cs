﻿namespace disk_cleaner
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_file_names = new System.Windows.Forms.TextBox();
            this.tb_file_exts = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_save_logs_to_file = new System.Windows.Forms.CheckBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_logs_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_show_log = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_auto_names = new System.Windows.Forms.TextBox();
            this.tb_auto_ext = new System.Windows.Forms.TextBox();
            this.dgv_disks_list = new System.Windows.Forms.DataGridView();
            this.check_disk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_time_measure = new System.Windows.Forms.ComboBox();
            this.nud_time_step = new System.Windows.Forms.NumericUpDown();
            this.cb_start_in_bg = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_discard = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disks_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_time_step)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File extensions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File names:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_file_names);
            this.groupBox1.Controls.Add(this.tb_file_exts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File names and extensions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please specify which files have to be deleted by default";
            // 
            // tb_file_names
            // 
            this.tb_file_names.Location = new System.Drawing.Point(91, 80);
            this.tb_file_names.Name = "tb_file_names";
            this.tb_file_names.Size = new System.Drawing.Size(272, 20);
            this.tb_file_names.TabIndex = 2;
            this.tb_file_names.TextChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // tb_file_exts
            // 
            this.tb_file_exts.Location = new System.Drawing.Point(91, 51);
            this.tb_file_exts.Name = "tb_file_exts";
            this.tb_file_exts.Size = new System.Drawing.Size(272, 20);
            this.tb_file_exts.TabIndex = 1;
            this.tb_file_exts.TextChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_save_logs_to_file);
            this.groupBox2.Controls.Add(this.btn_browse);
            this.groupBox2.Controls.Add(this.tb_logs_path);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_show_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // cb_save_logs_to_file
            // 
            this.cb_save_logs_to_file.AutoSize = true;
            this.cb_save_logs_to_file.Location = new System.Drawing.Point(141, 29);
            this.cb_save_logs_to_file.Name = "cb_save_logs_to_file";
            this.cb_save_logs_to_file.Size = new System.Drawing.Size(101, 17);
            this.cb_save_logs_to_file.TabIndex = 4;
            this.cb_save_logs_to_file.Text = "Save logs to file";
            this.cb_save_logs_to_file.UseVisualStyleBackColor = true;
            this.cb_save_logs_to_file.CheckedChanged += new System.EventHandler(this.cb_save_logs_to_file_CheckedChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Enabled = false;
            this.btn_browse.Location = new System.Drawing.Point(305, 60);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(58, 23);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse..";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_logs_path
            // 
            this.tb_logs_path.Enabled = false;
            this.tb_logs_path.Location = new System.Drawing.Point(80, 61);
            this.tb_logs_path.Name = "tb_logs_path";
            this.tb_logs_path.Size = new System.Drawing.Size(219, 20);
            this.tb_logs_path.TabIndex = 5;
            this.tb_logs_path.TextChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Log file path:";
            // 
            // cb_show_log
            // 
            this.cb_show_log.AutoSize = true;
            this.cb_show_log.Checked = true;
            this.cb_show_log.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_show_log.Location = new System.Drawing.Point(9, 29);
            this.cb_show_log.Name = "cb_show_log";
            this.cb_show_log.Size = new System.Drawing.Size(124, 17);
            this.cb_show_log.TabIndex = 3;
            this.cb_show_log.Text = "Show logs by default";
            this.cb_show_log.UseVisualStyleBackColor = true;
            this.cb_show_log.CheckedChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_auto_names);
            this.groupBox3.Controls.Add(this.tb_auto_ext);
            this.groupBox3.Controls.Add(this.dgv_disks_list);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_time_measure);
            this.groupBox3.Controls.Add(this.nud_time_step);
            this.groupBox3.Controls.Add(this.cb_start_in_bg);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 245);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Please specify extensions and files\' names for automatic deletion";
            // 
            // tb_auto_names
            // 
            this.tb_auto_names.Location = new System.Drawing.Point(91, 96);
            this.tb_auto_names.Name = "tb_auto_names";
            this.tb_auto_names.Size = new System.Drawing.Size(272, 20);
            this.tb_auto_names.TabIndex = 11;
            // 
            // tb_auto_ext
            // 
            this.tb_auto_ext.Location = new System.Drawing.Point(91, 67);
            this.tb_auto_ext.Name = "tb_auto_ext";
            this.tb_auto_ext.Size = new System.Drawing.Size(272, 20);
            this.tb_auto_ext.TabIndex = 10;
            // 
            // dgv_disks_list
            // 
            this.dgv_disks_list.AllowUserToAddRows = false;
            this.dgv_disks_list.AllowUserToDeleteRows = false;
            this.dgv_disks_list.AllowUserToResizeRows = false;
            this.dgv_disks_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disks_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_disk,
            this.disk,
            this.total_size,
            this.free_space,
            this.threshold});
            this.dgv_disks_list.Location = new System.Drawing.Point(9, 141);
            this.dgv_disks_list.Name = "dgv_disks_list";
            this.dgv_disks_list.Size = new System.Drawing.Size(354, 96);
            this.dgv_disks_list.TabIndex = 12;
            this.dgv_disks_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_disks_list_CellContentClick);
            this.dgv_disks_list.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_disks_list_CellValueChanged);
            // 
            // check_disk
            // 
            this.check_disk.HeaderText = "";
            this.check_disk.Name = "check_disk";
            this.check_disk.Width = 20;
            // 
            // disk
            // 
            this.disk.HeaderText = "Disk";
            this.disk.Name = "disk";
            this.disk.ReadOnly = true;
            this.disk.Width = 45;
            // 
            // total_size
            // 
            this.total_size.HeaderText = "Total";
            this.total_size.Name = "total_size";
            this.total_size.ReadOnly = true;
            this.total_size.Width = 65;
            // 
            // free_space
            // 
            this.free_space.HeaderText = "Free";
            this.free_space.Name = "free_space";
            this.free_space.ReadOnly = true;
            this.free_space.Width = 60;
            // 
            // threshold
            // 
            this.threshold.HeaderText = "Threshold (%)";
            this.threshold.Name = "threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "File names:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "File extensions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select disk(s):";
            // 
            // cb_time_measure
            // 
            this.cb_time_measure.Enabled = false;
            this.cb_time_measure.FormattingEnabled = true;
            this.cb_time_measure.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days",
            "Weeks"});
            this.cb_time_measure.Location = new System.Drawing.Point(269, 22);
            this.cb_time_measure.Name = "cb_time_measure";
            this.cb_time_measure.Size = new System.Drawing.Size(94, 21);
            this.cb_time_measure.TabIndex = 9;
            this.cb_time_measure.Text = "Minutes";
            this.cb_time_measure.TextChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // nud_time_step
            // 
            this.nud_time_step.Enabled = false;
            this.nud_time_step.Location = new System.Drawing.Point(193, 23);
            this.nud_time_step.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_time_step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_time_step.Name = "nud_time_step";
            this.nud_time_step.Size = new System.Drawing.Size(60, 20);
            this.nud_time_step.TabIndex = 8;
            this.nud_time_step.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_time_step.ValueChanged += new System.EventHandler(this.tb_file_exts_TextChanged);
            // 
            // cb_start_in_bg
            // 
            this.cb_start_in_bg.AutoSize = true;
            this.cb_start_in_bg.Location = new System.Drawing.Point(9, 25);
            this.cb_start_in_bg.Name = "cb_start_in_bg";
            this.cb_start_in_bg.Size = new System.Drawing.Size(151, 17);
            this.cb_start_in_bg.TabIndex = 7;
            this.cb_start_in_bg.Text = "Start in background every:";
            this.cb_start_in_bg.UseVisualStyleBackColor = true;
            this.cb_start_in_bg.CheckedChanged += new System.EventHandler(this.cb_start_in_bg_CheckedChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(28, 492);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 13;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_discard
            // 
            this.btn_discard.Location = new System.Drawing.Point(109, 492);
            this.btn_discard.Name = "btn_discard";
            this.btn_discard.Size = new System.Drawing.Size(75, 23);
            this.btn_discard.TabIndex = 14;
            this.btn_discard.Text = "Discard";
            this.btn_discard.UseVisualStyleBackColor = true;
            this.btn_discard.Click += new System.EventHandler(this.btn_discard_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(302, 492);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 15;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 525);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_discard);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Disk Cleaner Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disks_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_time_step)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_file_names;
        private System.Windows.Forms.TextBox tb_file_exts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_save_logs_to_file;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_logs_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_show_log;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_time_measure;
        private System.Windows.Forms.NumericUpDown nud_time_step;
        private System.Windows.Forms.CheckBox cb_start_in_bg;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_discard;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv_disks_list;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_auto_names;
        private System.Windows.Forms.TextBox tb_auto_ext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_disk;
        private System.Windows.Forms.DataGridViewTextBoxColumn disk;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_space;
        private System.Windows.Forms.DataGridViewTextBoxColumn threshold;
    }
}