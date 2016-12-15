namespace 网盘spi
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_all = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_one = new System.Windows.Forms.ToolStripProgressBar();
            this.checkBox_ifinfile = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_startuserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_clearout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_clearout);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.checkBox_ifinfile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_output);
            this.tabPage1.Controls.Add(this.comboBox_type);
            this.tabPage1.Controls.Add(this.button_start);
            this.tabPage1.Controls.Add(this.textBox_startuserid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "user抓取";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar_all,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar_one});
            this.statusStrip1.Location = new System.Drawing.Point(3, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "总体进度";
            // 
            // toolStripProgressBar_all
            // 
            this.toolStripProgressBar_all.Name = "toolStripProgressBar_all";
            this.toolStripProgressBar_all.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar_all.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel2.Text = "当前进度";
            // 
            // toolStripProgressBar_one
            // 
            this.toolStripProgressBar_one.Name = "toolStripProgressBar_one";
            this.toolStripProgressBar_one.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar_one.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // checkBox_ifinfile
            // 
            this.checkBox_ifinfile.AutoSize = true;
            this.checkBox_ifinfile.Checked = true;
            this.checkBox_ifinfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ifinfile.Location = new System.Drawing.Point(117, 104);
            this.checkBox_ifinfile.Name = "checkBox_ifinfile";
            this.checkBox_ifinfile.Size = new System.Drawing.Size(84, 16);
            this.checkBox_ifinfile.TabIndex = 8;
            this.checkBox_ifinfile.Text = "保存到文件";
            this.checkBox_ifinfile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "输出";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(209, 24);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(100, 315);
            this.textBox_output.TabIndex = 6;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "获取follow",
            "获取fans"});
            this.comboBox_type.Location = new System.Drawing.Point(116, 24);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(87, 20);
            this.comboBox_type.TabIndex = 5;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(116, 50);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(87, 47);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_startuserid
            // 
            this.textBox_startuserid.Location = new System.Drawing.Point(10, 24);
            this.textBox_startuserid.Multiline = true;
            this.textBox_startuserid.Name = "textBox_startuserid";
            this.textBox_startuserid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_startuserid.Size = new System.Drawing.Size(100, 344);
            this.textBox_startuserid.TabIndex = 1;
            this.textBox_startuserid.Text = "1881641340";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始用户id";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户分享抓取";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_clearout
            // 
            this.button_clearout.Location = new System.Drawing.Point(209, 345);
            this.button_clearout.Name = "button_clearout";
            this.button_clearout.Size = new System.Drawing.Size(100, 23);
            this.button_clearout.TabIndex = 10;
            this.button_clearout.Text = "清空";
            this.button_clearout.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 422);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "网盘spi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_startuserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.CheckBox checkBox_ifinfile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_all;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_one;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button_clearout;
    }
}

