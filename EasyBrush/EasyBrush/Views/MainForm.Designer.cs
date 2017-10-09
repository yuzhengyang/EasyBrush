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
            this.BTDraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PBColorBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BTDraw
            // 
            this.BTDraw.Location = new System.Drawing.Point(294, 12);
            this.BTDraw.Name = "BTDraw";
            this.BTDraw.Size = new System.Drawing.Size(75, 23);
            this.BTDraw.TabIndex = 0;
            this.BTDraw.Text = "绘画";
            this.BTDraw.UseVisualStyleBackColor = true;
            this.BTDraw.Click += new System.EventHandler(this.BTDraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "停止绘画：ESC";
            // 
            // BTClear
            // 
            this.BTClear.Location = new System.Drawing.Point(294, 42);
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
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "开始绘画：Shift + A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "清空屏幕：Shift + C";
            // 
            // PBColorBox
            // 
            this.PBColorBox.BackColor = System.Drawing.Color.Red;
            this.PBColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBColorBox.Location = new System.Drawing.Point(107, 12);
            this.PBColorBox.Name = "PBColorBox";
            this.PBColorBox.Size = new System.Drawing.Size(55, 26);
            this.PBColorBox.TabIndex = 7;
            this.PBColorBox.TabStop = false;
            this.PBColorBox.Click += new System.EventHandler(this.PBColorBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "设置画笔颜色：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 112);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBColorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "工具面板";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox PBColorBox;
        private System.Windows.Forms.Label label4;
    }
}