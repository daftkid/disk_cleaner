namespace disk_cleaner
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richinfo = new System.Windows.Forms.RichTextBox();
            this.link_vk = new System.Windows.Forms.LinkLabel();
            this.link_tg = new System.Windows.Forms.LinkLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.link_linkedin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disk Cleaner INFO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richinfo
            // 
            this.richinfo.Location = new System.Drawing.Point(127, 34);
            this.richinfo.Name = "richinfo";
            this.richinfo.ReadOnly = true;
            this.richinfo.Size = new System.Drawing.Size(232, 136);
            this.richinfo.TabIndex = 2;
            this.richinfo.Text = "Disk Cleaner - it is a tool for cleaning disks from unnecessary files. You consid" +
    "er which files\nshould be get rid of! Enjoy ;)\n\nAuthor: Oleksandr Mykytenko\nst. g" +
    "r. 156mp KhAI\n\nKharkiv, 2018";
            // 
            // link_vk
            // 
            this.link_vk.AutoSize = true;
            this.link_vk.Location = new System.Drawing.Point(12, 157);
            this.link_vk.Name = "link_vk";
            this.link_vk.Size = new System.Drawing.Size(72, 13);
            this.link_vk.TabIndex = 1;
            this.link_vk.TabStop = true;
            this.link_vk.Text = "Find me in VK";
            this.link_vk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_vk_LinkClicked);
            // 
            // link_tg
            // 
            this.link_tg.AutoSize = true;
            this.link_tg.Location = new System.Drawing.Point(12, 182);
            this.link_tg.Name = "link_tg";
            this.link_tg.Size = new System.Drawing.Size(102, 13);
            this.link_tg.TabIndex = 2;
            this.link_tg.TabStop = true;
            this.link_tg.Text = "Find me in Telegram";
            this.link_tg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_tg_LinkClicked);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(210, 192);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // link_linkedin
            // 
            this.link_linkedin.AutoSize = true;
            this.link_linkedin.Location = new System.Drawing.Point(12, 205);
            this.link_linkedin.Name = "link_linkedin";
            this.link_linkedin.Size = new System.Drawing.Size(79, 13);
            this.link_linkedin.TabIndex = 3;
            this.link_linkedin.TabStop = true;
            this.link_linkedin.Text = "LinkedIn profile";
            this.link_linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_linkedin_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 227);
            this.Controls.Add(this.link_linkedin);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.link_tg);
            this.Controls.Add(this.link_vk);
            this.Controls.Add(this.richinfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Disk Cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richinfo;
        private System.Windows.Forms.LinkLabel link_vk;
        private System.Windows.Forms.LinkLabel link_tg;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel link_linkedin;
    }
}