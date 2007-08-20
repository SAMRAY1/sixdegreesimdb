namespace SixDegrees {
    partial class SelectResult {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.choicesLB = new System.Windows.Forms.ListBox();
            this.chooseB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choicesLB
            // 
            this.choicesLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.choicesLB.FormattingEnabled = true;
            this.choicesLB.Location = new System.Drawing.Point(12, 12);
            this.choicesLB.Name = "choicesLB";
            this.choicesLB.Size = new System.Drawing.Size(229, 108);
            this.choicesLB.TabIndex = 0;
            // 
            // chooseB
            // 
            this.chooseB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseB.BackColor = System.Drawing.Color.LightGreen;
            this.chooseB.Location = new System.Drawing.Point(12, 127);
            this.chooseB.Name = "chooseB";
            this.chooseB.Size = new System.Drawing.Size(229, 40);
            this.chooseB.TabIndex = 1;
            this.chooseB.Text = "Choose";
            this.chooseB.UseVisualStyleBackColor = false;
            this.chooseB.Click += new System.EventHandler(this.chooseB_Click);
            // 
            // SelectResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 179);
            this.Controls.Add(this.chooseB);
            this.Controls.Add(this.choicesLB);
            this.Name = "SelectResult";
            this.Text = "w";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox choicesLB;
        private System.Windows.Forms.Button chooseB;
    }
}