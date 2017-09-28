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
            this.BTRase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTDraw
            // 
            this.BTDraw.Location = new System.Drawing.Point(197, 195);
            this.BTDraw.Name = "BTDraw";
            this.BTDraw.Size = new System.Drawing.Size(75, 23);
            this.BTDraw.TabIndex = 0;
            this.BTDraw.Text = "绘画";
            this.BTDraw.UseVisualStyleBackColor = true;
            this.BTDraw.Click += new System.EventHandler(this.BTDraw_Click);
            // 
            // BTRase
            // 
            this.BTRase.Location = new System.Drawing.Point(197, 224);
            this.BTRase.Name = "BTRase";
            this.BTRase.Size = new System.Drawing.Size(75, 23);
            this.BTRase.TabIndex = 1;
            this.BTRase.Text = "橡皮";
            this.BTRase.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTRase);
            this.Controls.Add(this.BTDraw);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTDraw;
        private System.Windows.Forms.Button BTRase;
    }
}