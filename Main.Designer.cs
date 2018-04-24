namespace disk_cleaner
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_file_exts = new System.Windows.Forms.TextBox();
            this.tb_file_names = new System.Windows.Forms.TextBox();
            this.cb_disk = new System.Windows.Forms.ComboBox();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_extension_info = new System.Windows.Forms.Button();
            this.btn_names_info = new System.Windows.Forms.Button();
            this.btn_disk_info = new System.Windows.Forms.Button();
            this.cb_show_log = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scheduler = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanDiskToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // scanDiskToolStripMenuItem
            // 
            this.scanDiskToolStripMenuItem.Name = "scanDiskToolStripMenuItem";
            this.scanDiskToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.scanDiskToolStripMenuItem.Text = "Scan disk";
            this.scanDiskToolStripMenuItem.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File extensions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File names:";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(103, 181);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(147, 23);
            this.btn_scan.TabIndex = 10;
            this.btn_scan.Text = "Scan disk";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disk:";
            // 
            // tb_file_exts
            // 
            this.tb_file_exts.Location = new System.Drawing.Point(109, 41);
            this.tb_file_exts.Name = "tb_file_exts";
            this.tb_file_exts.Size = new System.Drawing.Size(182, 20);
            this.tb_file_exts.TabIndex = 1;
            this.tb_file_exts.Leave += new System.EventHandler(this.tb_file_exts_Leave);
            // 
            // tb_file_names
            // 
            this.tb_file_names.Location = new System.Drawing.Point(109, 68);
            this.tb_file_names.Name = "tb_file_names";
            this.tb_file_names.Size = new System.Drawing.Size(182, 20);
            this.tb_file_names.TabIndex = 2;
            // 
            // cb_disk
            // 
            this.cb_disk.FormattingEnabled = true;
            this.cb_disk.Location = new System.Drawing.Point(109, 96);
            this.cb_disk.Name = "cb_disk";
            this.cb_disk.Size = new System.Drawing.Size(182, 21);
            this.cb_disk.TabIndex = 3;
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(103, 152);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(75, 23);
            this.btn_default.TabIndex = 8;
            this.btn_default.Text = "Clear";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(185, 152);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(65, 23);
            this.btn_settings.TabIndex = 9;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_extension_info
            // 
            this.btn_extension_info.Location = new System.Drawing.Point(297, 41);
            this.btn_extension_info.Name = "btn_extension_info";
            this.btn_extension_info.Size = new System.Drawing.Size(21, 20);
            this.btn_extension_info.TabIndex = 4;
            this.btn_extension_info.Text = "?4";
            this.btn_extension_info.UseVisualStyleBackColor = true;
            this.btn_extension_info.Click += new System.EventHandler(this.btn_extension_info_Click);
            // 
            // btn_names_info
            // 
            this.btn_names_info.Location = new System.Drawing.Point(297, 68);
            this.btn_names_info.Name = "btn_names_info";
            this.btn_names_info.Size = new System.Drawing.Size(21, 20);
            this.btn_names_info.TabIndex = 5;
            this.btn_names_info.Text = "?4";
            this.btn_names_info.UseVisualStyleBackColor = true;
            this.btn_names_info.Click += new System.EventHandler(this.btn_names_info_Click);
            // 
            // btn_disk_info
            // 
            this.btn_disk_info.Location = new System.Drawing.Point(297, 96);
            this.btn_disk_info.Name = "btn_disk_info";
            this.btn_disk_info.Size = new System.Drawing.Size(21, 20);
            this.btn_disk_info.TabIndex = 6;
            this.btn_disk_info.Text = "?4";
            this.btn_disk_info.UseVisualStyleBackColor = true;
            this.btn_disk_info.Click += new System.EventHandler(this.btn_disk_info_Click);
            // 
            // cb_show_log
            // 
            this.cb_show_log.AutoSize = true;
            this.cb_show_log.Location = new System.Drawing.Point(27, 130);
            this.cb_show_log.Name = "cb_show_log";
            this.cb_show_log.Size = new System.Drawing.Size(70, 17);
            this.cb_show_log.TabIndex = 7;
            this.cb_show_log.Text = "Show log";
            this.cb_show_log.UseVisualStyleBackColor = true;
            this.cb_show_log.Click += new System.EventHandler(this.cb_show_log_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // scheduler
            // 
            this.scheduler.Location = new System.Drawing.Point(256, 152);
            this.scheduler.Name = "scheduler";
            this.scheduler.Size = new System.Drawing.Size(62, 52);
            this.scheduler.TabIndex = 11;
            this.scheduler.Text = "Stop scheduler";
            this.scheduler.UseVisualStyleBackColor = true;
            this.scheduler.Click += new System.EventHandler(this.scheduler_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 214);
            this.Controls.Add(this.scheduler);
            this.Controls.Add(this.cb_show_log);
            this.Controls.Add(this.btn_disk_info);
            this.Controls.Add(this.btn_names_info);
            this.Controls.Add(this.btn_extension_info);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_default);
            this.Controls.Add(this.cb_disk);
            this.Controls.Add(this.tb_file_names);
            this.Controls.Add(this.tb_file_exts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Cleaner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_file_exts;
        private System.Windows.Forms.TextBox tb_file_names;
        private System.Windows.Forms.ComboBox cb_disk;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_extension_info;
        private System.Windows.Forms.Button btn_names_info;
        private System.Windows.Forms.Button btn_disk_info;
        private System.Windows.Forms.CheckBox cb_show_log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem scanDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button scheduler;
    }
}

