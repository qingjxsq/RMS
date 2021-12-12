namespace From
{
    partial class Loginfrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginfrom));
            this.label1 = new System.Windows.Forms.Label();
            this.wecome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(281, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用简历管理系统";
            // 
            // wecome
            // 
            this.wecome.BackColor = System.Drawing.Color.White;
            this.wecome.Location = new System.Drawing.Point(354, 281);
            this.wecome.Name = "wecome";
            this.wecome.Size = new System.Drawing.Size(75, 23);
            this.wecome.TabIndex = 1;
            this.wecome.Text = "进入系统";
            this.wecome.UseVisualStyleBackColor = false;
            this.wecome.Click += new System.EventHandler(this.wecome_Click);
            // 
            // Loginfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.wecome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Loginfrom";
            this.Text = "欢迎页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wecome;
    }
}

