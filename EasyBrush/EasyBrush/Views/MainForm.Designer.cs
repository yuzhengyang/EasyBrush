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
            this.label2 = new System.Windows.Forms.Label();
            this.BTClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PNColor = new System.Windows.Forms.Panel();
            this.BTDraw = new System.Windows.Forms.Button();
            this.NIMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘画ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBPenAlphaHigh = new System.Windows.Forms.RadioButton();
            this.RBPenAlphaMiddle = new System.Windows.Forms.RadioButton();
            this.RBPenAlphaNo = new System.Windows.Forms.RadioButton();
            this.RBPenAlphaLow = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBPenWidthLarge = new System.Windows.Forms.RadioButton();
            this.RBPenWidthMiddle = new System.Windows.Forms.RadioButton();
            this.RBPenWidthThin = new System.Windows.Forms.RadioButton();
            this.CmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "停止绘画：ESC";
            // 
            // BTClear
            // 
            this.BTClear.Location = new System.Drawing.Point(506, 28);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(75, 23);
            this.BTClear.TabIndex = 4;
            this.BTClear.Text = "清屏";
            this.BTClear.UseVisualStyleBackColor = true;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "开始绘画：Shift + A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "清空屏幕：Shift + C";
            // 
            // PNColor
            // 
            this.PNColor.AutoScroll = true;
            this.PNColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNColor.BackgroundImage")));
            this.PNColor.Location = new System.Drawing.Point(11, 28);
            this.PNColor.Name = "PNColor";
            this.PNColor.Size = new System.Drawing.Size(400, 250);
            this.PNColor.TabIndex = 7;
            this.PNColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PNColor_MouseClick);
            // 
            // BTDraw
            // 
            this.BTDraw.Location = new System.Drawing.Point(425, 28);
            this.BTDraw.Name = "BTDraw";
            this.BTDraw.Size = new System.Drawing.Size(75, 23);
            this.BTDraw.TabIndex = 8;
            this.BTDraw.Text = "绘画";
            this.BTDraw.UseVisualStyleBackColor = true;
            this.BTDraw.Click += new System.EventHandler(this.BTDraw_Click);
            // 
            // NIMain
            // 
            this.NIMain.ContextMenuStrip = this.CmsMain;
            this.NIMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NIMain.Icon")));
            this.NIMain.Text = "屏幕画板";
            this.NIMain.Visible = true;
            this.NIMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NIMain_MouseDoubleClick);
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(595, 25);
            this.MSMain.TabIndex = 9;
            this.MSMain.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绘画ToolStripMenuItem,
            this.清屏ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 绘画ToolStripMenuItem
            // 
            this.绘画ToolStripMenuItem.Name = "绘画ToolStripMenuItem";
            this.绘画ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.绘画ToolStripMenuItem.Text = "绘画";
            this.绘画ToolStripMenuItem.Click += new System.EventHandler(this.绘画ToolStripMenuItem_Click);
            // 
            // 清屏ToolStripMenuItem
            // 
            this.清屏ToolStripMenuItem.Name = "清屏ToolStripMenuItem";
            this.清屏ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清屏ToolStripMenuItem.Text = "清屏";
            this.清屏ToolStripMenuItem.Click += new System.EventHandler(this.清屏ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.发送反馈ToolStripMenuItem,
            this.技术支持ToolStripMenuItem,
            this.检查更新ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            // 
            // 技术支持ToolStripMenuItem
            // 
            this.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem";
            this.技术支持ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.技术支持ToolStripMenuItem.Text = "技术支持";
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 22);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBPenAlphaHigh);
            this.groupBox1.Controls.Add(this.RBPenAlphaMiddle);
            this.groupBox1.Controls.Add(this.RBPenAlphaNo);
            this.groupBox1.Controls.Add(this.RBPenAlphaLow);
            this.groupBox1.Location = new System.Drawing.Point(425, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "透明度";
            // 
            // RBPenAlphaHigh
            // 
            this.RBPenAlphaHigh.AutoSize = true;
            this.RBPenAlphaHigh.Location = new System.Drawing.Point(17, 86);
            this.RBPenAlphaHigh.Name = "RBPenAlphaHigh";
            this.RBPenAlphaHigh.Size = new System.Drawing.Size(77, 16);
            this.RBPenAlphaHigh.TabIndex = 6;
            this.RBPenAlphaHigh.Text = "高（60%）";
            this.RBPenAlphaHigh.UseVisualStyleBackColor = true;
            this.RBPenAlphaHigh.CheckedChanged += new System.EventHandler(this.RBPenAlphaHigh_CheckedChanged);
            // 
            // RBPenAlphaMiddle
            // 
            this.RBPenAlphaMiddle.AutoSize = true;
            this.RBPenAlphaMiddle.Location = new System.Drawing.Point(17, 64);
            this.RBPenAlphaMiddle.Name = "RBPenAlphaMiddle";
            this.RBPenAlphaMiddle.Size = new System.Drawing.Size(77, 16);
            this.RBPenAlphaMiddle.TabIndex = 5;
            this.RBPenAlphaMiddle.Text = "中（40%）";
            this.RBPenAlphaMiddle.UseVisualStyleBackColor = true;
            this.RBPenAlphaMiddle.CheckedChanged += new System.EventHandler(this.RBPenAlphaMiddle_CheckedChanged);
            // 
            // RBPenAlphaNo
            // 
            this.RBPenAlphaNo.AutoSize = true;
            this.RBPenAlphaNo.Checked = true;
            this.RBPenAlphaNo.Location = new System.Drawing.Point(17, 20);
            this.RBPenAlphaNo.Name = "RBPenAlphaNo";
            this.RBPenAlphaNo.Size = new System.Drawing.Size(59, 16);
            this.RBPenAlphaNo.TabIndex = 3;
            this.RBPenAlphaNo.TabStop = true;
            this.RBPenAlphaNo.Text = "不透明";
            this.RBPenAlphaNo.UseVisualStyleBackColor = true;
            this.RBPenAlphaNo.CheckedChanged += new System.EventHandler(this.RBPenAlphaNo_CheckedChanged);
            // 
            // RBPenAlphaLow
            // 
            this.RBPenAlphaLow.AutoSize = true;
            this.RBPenAlphaLow.Location = new System.Drawing.Point(17, 42);
            this.RBPenAlphaLow.Name = "RBPenAlphaLow";
            this.RBPenAlphaLow.Size = new System.Drawing.Size(77, 16);
            this.RBPenAlphaLow.TabIndex = 4;
            this.RBPenAlphaLow.Text = "轻（20%）";
            this.RBPenAlphaLow.UseVisualStyleBackColor = true;
            this.RBPenAlphaLow.CheckedChanged += new System.EventHandler(this.RBPenAlphaLow_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBPenWidthLarge);
            this.groupBox2.Controls.Add(this.RBPenWidthMiddle);
            this.groupBox2.Controls.Add(this.RBPenWidthThin);
            this.groupBox2.Location = new System.Drawing.Point(425, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 87);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "笔尖";
            // 
            // RBPenWidthLarge
            // 
            this.RBPenWidthLarge.AutoSize = true;
            this.RBPenWidthLarge.Location = new System.Drawing.Point(17, 64);
            this.RBPenWidthLarge.Name = "RBPenWidthLarge";
            this.RBPenWidthLarge.Size = new System.Drawing.Size(83, 16);
            this.RBPenWidthLarge.TabIndex = 2;
            this.RBPenWidthLarge.Text = "粗（15px）";
            this.RBPenWidthLarge.UseVisualStyleBackColor = true;
            this.RBPenWidthLarge.CheckedChanged += new System.EventHandler(this.RBPenWidthLarge_CheckedChanged);
            // 
            // RBPenWidthMiddle
            // 
            this.RBPenWidthMiddle.AutoSize = true;
            this.RBPenWidthMiddle.Location = new System.Drawing.Point(17, 42);
            this.RBPenWidthMiddle.Name = "RBPenWidthMiddle";
            this.RBPenWidthMiddle.Size = new System.Drawing.Size(83, 16);
            this.RBPenWidthMiddle.TabIndex = 1;
            this.RBPenWidthMiddle.Text = "中（10px）";
            this.RBPenWidthMiddle.UseVisualStyleBackColor = true;
            this.RBPenWidthMiddle.CheckedChanged += new System.EventHandler(this.RBPenWidthMiddle_CheckedChanged);
            // 
            // RBPenWidthThin
            // 
            this.RBPenWidthThin.AutoSize = true;
            this.RBPenWidthThin.Checked = true;
            this.RBPenWidthThin.Location = new System.Drawing.Point(17, 20);
            this.RBPenWidthThin.Name = "RBPenWidthThin";
            this.RBPenWidthThin.Size = new System.Drawing.Size(77, 16);
            this.RBPenWidthThin.TabIndex = 0;
            this.RBPenWidthThin.TabStop = true;
            this.RBPenWidthThin.Text = "细（5px）";
            this.RBPenWidthThin.UseVisualStyleBackColor = true;
            this.RBPenWidthThin.CheckedChanged += new System.EventHandler(this.RBPenWidthThin_CheckedChanged);
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
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(595, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTDraw);
            this.Controls.Add(this.PNColor);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.MSMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "屏幕画板 - 工具面板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel PNColor;
        private System.Windows.Forms.Button BTDraw;
        private System.Windows.Forms.NotifyIcon NIMain;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘画ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术支持ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 清屏ToolStripMenuItem;
        private System.Windows.Forms.RadioButton RBPenAlphaHigh;
        private System.Windows.Forms.RadioButton RBPenAlphaMiddle;
        private System.Windows.Forms.RadioButton RBPenAlphaNo;
        private System.Windows.Forms.RadioButton RBPenAlphaLow;
        private System.Windows.Forms.RadioButton RBPenWidthLarge;
        private System.Windows.Forms.RadioButton RBPenWidthMiddle;
        private System.Windows.Forms.RadioButton RBPenWidthThin;
        private System.Windows.Forms.ContextMenuStrip CmsMain;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}