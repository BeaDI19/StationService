
namespace StationService
{
    partial class Form3
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
            this.paveNumeric1 = new StationService.PaveNumeric();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // paveNumeric1
            // 
            this.paveNumeric1.Location = new System.Drawing.Point(85, 139);
            this.paveNumeric1.Name = "paveNumeric1";
            this.paveNumeric1.Size = new System.Drawing.Size(594, 299);
            this.paveNumeric1.TabIndex = 0;
            this.paveNumeric1.Load += new System.EventHandler(this.paveNumeric1_Load);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(304, 26);
            this.textBox3.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.paveNumeric1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaveNumeric paveNumeric1;
        private System.Windows.Forms.TextBox textBox3;
    }
}