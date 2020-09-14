namespace project
{
    partial class Test
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
            this.btnNext = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblmark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(396, 437);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(165, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(581, 360);
            this.panel.TabIndex = 1;
            // 
            // lblmark
            // 
            this.lblmark.AutoSize = true;
            this.lblmark.Location = new System.Drawing.Point(60, 124);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(46, 17);
            this.lblmark.TabIndex = 2;
            this.lblmark.Text = "label1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.lblmark);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNext);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblmark;
    }
}