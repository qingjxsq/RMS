namespace From
{
    partial class HomeFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrom));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理简历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddResume = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteResume = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateResume = new System.Windows.Forms.ToolStripMenuItem();
            this.QueResume = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddResume = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteResume = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeshower = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理简历ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理简历ToolStripMenuItem
            // 
            this.管理简历ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddResume,
            this.DeleteResume,
            this.UpdateResume,
            this.QueResume});
            this.管理简历ToolStripMenuItem.Name = "管理简历ToolStripMenuItem";
            this.管理简历ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理简历ToolStripMenuItem.Text = "管理简历";
            // 
            // AddResume
            // 
            this.AddResume.Name = "AddResume";
            this.AddResume.Size = new System.Drawing.Size(180, 22);
            this.AddResume.Text = "添加简历";
            this.AddResume.Click += new System.EventHandler(this.AddResume_Click);
            // 
            // DeleteResume
            // 
            this.DeleteResume.Name = "DeleteResume";
            this.DeleteResume.Size = new System.Drawing.Size(180, 22);
            this.DeleteResume.Text = "删除简历";
            this.DeleteResume.Click += new System.EventHandler(this.DeleteResume_Click);
            // 
            // UpdateResume
            // 
            this.UpdateResume.Name = "UpdateResume";
            this.UpdateResume.Size = new System.Drawing.Size(180, 22);
            this.UpdateResume.Text = "修改简历";
            this.UpdateResume.Click += new System.EventHandler(this.UpdateResume_Click);
            // 
            // QueResume
            // 
            this.QueResume.Name = "QueResume";
            this.QueResume.Size = new System.Drawing.Size(124, 22);
            this.QueResume.Text = "查询简历";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddResume,
            this.tsbDeleteResume,
            this.tsbUpdateResume,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddResume
            // 
            this.tsbAddResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddResume.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddResume.Image")));
            this.tsbAddResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddResume.Name = "tsbAddResume";
            this.tsbAddResume.Size = new System.Drawing.Size(23, 22);
            this.tsbAddResume.Text = "toolStripButton1";
            // 
            // tsbDeleteResume
            // 
            this.tsbDeleteResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteResume.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteResume.Image")));
            this.tsbDeleteResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteResume.Name = "tsbDeleteResume";
            this.tsbDeleteResume.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteResume.Text = "toolStripButton2";
            // 
            // tsbUpdateResume
            // 
            this.tsbUpdateResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateResume.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateResume.Image")));
            this.tsbUpdateResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateResume.Name = "tsbUpdateResume";
            this.tsbUpdateResume.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdateResume.Text = "toolStripButton3";
            this.tsbUpdateResume.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeshower});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeshower
            // 
            this.timeshower.Name = "timeshower";
            this.timeshower.Size = new System.Drawing.Size(754, 17);
            this.timeshower.Spring = true;
            this.timeshower.Text = "timeshow";
            this.timeshower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeFrom";
            this.Text = "主页";
            this.Load += new System.EventHandler(this.HomeFrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理简历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddResume;
        private System.Windows.Forms.ToolStripMenuItem DeleteResume;
        private System.Windows.Forms.ToolStripMenuItem UpdateResume;
        private System.Windows.Forms.ToolStripMenuItem QueResume;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddResume;
        private System.Windows.Forms.ToolStripButton tsbDeleteResume;
        private System.Windows.Forms.ToolStripButton tsbUpdateResume;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeshower;
        private System.Windows.Forms.Timer timer1;
    }
}