namespace EasyBrush.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.NIMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存屏幕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBPenAlpha = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBPenWidth = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSLDraw = new System.Windows.Forms.ToolStripLabel();
            this.TSLClean = new System.Windows.Forms.ToolStripLabel();
            this.PNColor = new System.Windows.Forms.Panel();
            this.CmsMain.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NIMain
            // 
            this.NIMain.ContextMenuStrip = this.CmsMain;
            this.NIMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NIMain.Icon")));
            this.NIMain.Text = "屏幕画板";
            this.NIMain.Visible = true;
            this.NIMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NIMain_MouseDoubleClick);
            // 
            // CmsMain
            // 
            this.CmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.CmsMain.Name = "CmsMain";
            this.CmsMain.Size = new System.Drawing.Size(113, 48);
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(112, 25);
            this.MSMain.TabIndex = 9;
            this.MSMain.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存屏幕ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存屏幕ToolStripMenuItem
            // 
            this.保存屏幕ToolStripMenuItem.Name = "保存屏幕ToolStripMenuItem";
            this.保存屏幕ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存屏幕ToolStripMenuItem.Text = "保存屏幕";
            this.保存屏幕ToolStripMenuItem.Click += new System.EventHandler(this.保存屏幕ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.发送反馈ToolStripMenuItem,
            this.检查更新ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助ToolStripMenuItem_Click);
            // 
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            this.发送反馈ToolStripMenuItem.Click += new System.EventHandler(this.发送反馈ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBPenAlpha);
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "透明度";
            // 
            // CBPenAlpha
            // 
            this.CBPenAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPenAlpha.FormattingEnabled = true;
            this.CBPenAlpha.Items.AddRange(new object[] {
            "不透明",
            "轻（20%）",
            "中（40%）",
            "高（60%）"});
            this.CBPenAlpha.Location = new System.Drawing.Point(6, 20);
            this.CBPenAlpha.Name = "CBPenAlpha";
            this.CBPenAlpha.Size = new System.Drawing.Size(100, 20);
            this.CBPenAlpha.TabIndex = 16;
            this.CBPenAlpha.SelectedIndexChanged += new System.EventHandler(this.CBPenAlpha_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBPenWidth);
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 47);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "笔尖";
            // 
            // CBPenWidth
            // 
            this.CBPenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPenWidth.FormattingEnabled = true;
            this.CBPenWidth.Items.AddRange(new object[] {
            "细（5px）",
            "中（10px）",
            "粗（15px）"});
            this.CBPenWidth.Location = new System.Drawing.Point(6, 20);
            this.CBPenWidth.Name = "CBPenWidth";
            this.CBPenWidth.Size = new System.Drawing.Size(100, 20);
            this.CBPenWidth.TabIndex = 15;
            this.CBPenWidth.SelectedIndexChanged += new System.EventHandler(this.CBPenWidth_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLDraw,
            this.TSLClean});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(112, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSLDraw
            // 
            this.TSLDraw.Name = "TSLDraw";
            this.TSLDraw.Size = new System.Drawing.Size(40, 22);
            this.TSLDraw.Text = " 绘画 ";
            this.TSLDraw.Click += new System.EventHandler(this.TSLDraw_Click);
            // 
            // TSLClean
            // 
            this.TSLClean.Name = "TSLClean";
            this.TSLClean.Size = new System.Drawing.Size(40, 22);
            this.TSLClean.Text = " 清屏 ";
            this.TSLClean.Click += new System.EventHandler(this.TSLClean_Click);
            // 
            // PNColor
            // 
            this.PNColor.AutoScroll = true;
            this.PNColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNColor.BackgroundImage")));
            this.PNColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PNColor.Location = new System.Drawing.Point(0, 161);
            this.PNColor.Name = "PNColor";
            this.PNColor.Size = new System.Drawing.Size(112, 155);
            this.PNColor.TabIndex = 7;
            this.PNColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PNColor_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(112, 322);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PNColor);
            this.Controls.Add(this.MSMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "屏幕画板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CmsMain.ResumeLayout(false);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel PNColor;
        private System.Windows.Forms.NotifyIcon NIMain;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip CmsMain;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ComboBox CBPenWidth;
        private System.Windows.Forms.ComboBox CBPenAlpha;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TSLDraw;
        private System.Windows.Forms.ToolStripLabel TSLClean;
        private System.Windows.Forms.ToolStripMenuItem 保存屏幕ToolStripMenuItem;
    }
}