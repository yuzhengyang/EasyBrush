namespace EasyBrush.Views
{
    partial class DrawForm
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
            this.SuspendLayout();
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawForm";
            this.Text = "绘图中......";
            this.Load += new System.EventHandler(this.DrawForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrawForm_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}