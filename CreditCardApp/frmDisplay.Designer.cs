
namespace CreditCardApp
{
    partial class frmDisplay
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
            this.BtnProcess = new System.Windows.Forms.Button();
            this.TxtProcessed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnProcess
            // 
            this.BtnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnProcess.Location = new System.Drawing.Point(12, 262);
            this.BtnProcess.MinimumSize = new System.Drawing.Size(80, 40);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(107, 41);
            this.BtnProcess.TabIndex = 0;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // TxtProcessed
            // 
            this.TxtProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProcessed.Location = new System.Drawing.Point(12, 12);
            this.TxtProcessed.Multiline = true;
            this.TxtProcessed.Name = "TxtProcessed";
            this.TxtProcessed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProcessed.Size = new System.Drawing.Size(403, 244);
            this.TxtProcessed.TabIndex = 1;
            this.TxtProcessed.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 311);
            this.Controls.Add(this.TxtProcessed);
            this.Controls.Add(this.BtnProcess);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.TextBox TxtProcessed;
    }
}

