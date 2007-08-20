namespace SixDegrees {
    partial class IMDBForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMDBForm));
            this.actionP = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.sixDegreesGoB = new System.Windows.Forms.Button();
            this.statusL = new System.Windows.Forms.Label();
            this.sixDegreesModeB = new System.Windows.Forms.Button();
            this.imdbModeB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.titleRB = new System.Windows.Forms.RadioButton();
            this.searchB = new System.Windows.Forms.Button();
            this.nameRB = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imdbTV = new System.Windows.Forms.TreeView();
            this.treeIL = new System.Windows.Forms.ImageList(this.components);
            this.imdbWB = new System.Windows.Forms.WebBrowser();
            this.imdbBW = new System.ComponentModel.BackgroundWorker();
            this.expandBW = new System.ComponentModel.BackgroundWorker();
            this.waitP = new SixDegrees.TransparentPanel();
            this.waitPB = new System.Windows.Forms.ProgressBar();
            this.actionP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.waitP.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionP
            // 
            this.actionP.BackColor = System.Drawing.Color.Gray;
            this.actionP.Controls.Add(this.groupBox2);
            this.actionP.Controls.Add(this.statusL);
            this.actionP.Controls.Add(this.sixDegreesModeB);
            this.actionP.Controls.Add(this.imdbModeB);
            this.actionP.Controls.Add(this.groupBox1);
            this.actionP.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionP.Location = new System.Drawing.Point(0, 0);
            this.actionP.Name = "actionP";
            this.actionP.Size = new System.Drawing.Size(742, 67);
            this.actionP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.toTB);
            this.groupBox2.Controls.Add(this.fromTB);
            this.groupBox2.Controls.Add(this.sixDegreesGoB);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(93, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect Actors";
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "and";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(264, 20);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(209, 20);
            this.toTB.TabIndex = 2;
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(18, 20);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(209, 20);
            this.fromTB.TabIndex = 0;
            // 
            // sixDegreesGoB
            // 
            this.sixDegreesGoB.ForeColor = System.Drawing.Color.Black;
            this.sixDegreesGoB.Location = new System.Drawing.Point(479, 18);
            this.sixDegreesGoB.Name = "sixDegreesGoB";
            this.sixDegreesGoB.Size = new System.Drawing.Size(40, 23);
            this.sixDegreesGoB.TabIndex = 1;
            this.sixDegreesGoB.Text = "Go";
            this.sixDegreesGoB.UseVisualStyleBackColor = true;
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusL.ForeColor = System.Drawing.Color.Red;
            this.statusL.Location = new System.Drawing.Point(174, 23);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(50, 19);
            this.statusL.TabIndex = 4;
            this.statusL.Text = "status";
            this.statusL.Visible = false;
            // 
            // sixDegreesModeB
            // 
            this.sixDegreesModeB.Location = new System.Drawing.Point(93, 20);
            this.sixDegreesModeB.Name = "sixDegreesModeB";
            this.sixDegreesModeB.Size = new System.Drawing.Size(75, 23);
            this.sixDegreesModeB.TabIndex = 3;
            this.sixDegreesModeB.Text = "Six Degrees";
            this.sixDegreesModeB.UseVisualStyleBackColor = true;
            this.sixDegreesModeB.Click += new System.EventHandler(this.sixDegreesModeB_Click);
            // 
            // imdbModeB
            // 
            this.imdbModeB.Enabled = false;
            this.imdbModeB.Location = new System.Drawing.Point(12, 20);
            this.imdbModeB.Name = "imdbModeB";
            this.imdbModeB.Size = new System.Drawing.Size(75, 23);
            this.imdbModeB.TabIndex = 2;
            this.imdbModeB.Text = "IMDb";
            this.imdbModeB.UseVisualStyleBackColor = true;
            this.imdbModeB.Click += new System.EventHandler(this.imdbModeB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.Controls.Add(this.titleRB);
            this.groupBox1.Controls.Add(this.searchB);
            this.groupBox1.Controls.Add(this.nameRB);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(314, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(116, 19);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(209, 20);
            this.searchTB.TabIndex = 0;
            // 
            // titleRB
            // 
            this.titleRB.AutoSize = true;
            this.titleRB.Location = new System.Drawing.Point(65, 20);
            this.titleRB.Name = "titleRB";
            this.titleRB.Size = new System.Drawing.Size(45, 17);
            this.titleRB.TabIndex = 3;
            this.titleRB.Text = "Title";
            this.titleRB.UseVisualStyleBackColor = true;
            // 
            // searchB
            // 
            this.searchB.ForeColor = System.Drawing.Color.Black;
            this.searchB.Location = new System.Drawing.Point(331, 17);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 1;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // nameRB
            // 
            this.nameRB.AutoSize = true;
            this.nameRB.Checked = true;
            this.nameRB.Location = new System.Drawing.Point(6, 20);
            this.nameRB.Name = "nameRB";
            this.nameRB.Size = new System.Drawing.Size(53, 17);
            this.nameRB.TabIndex = 2;
            this.nameRB.TabStop = true;
            this.nameRB.Text = "Name";
            this.nameRB.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.waitP);
            this.splitContainer1.Panel1.Controls.Add(this.imdbTV);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imdbWB);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(742, 499);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.DoubleClick += new System.EventHandler(this.splitContainer1_DoubleClick);
            // 
            // imdbTV
            // 
            this.imdbTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imdbTV.ImageIndex = 0;
            this.imdbTV.ImageList = this.treeIL;
            this.imdbTV.Location = new System.Drawing.Point(0, 0);
            this.imdbTV.Name = "imdbTV";
            this.imdbTV.SelectedImageIndex = 0;
            this.imdbTV.Size = new System.Drawing.Size(304, 499);
            this.imdbTV.TabIndex = 0;
            this.imdbTV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imdbTV_MouseDown);
            this.imdbTV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.imdbTV_NodeMouseClick);
            this.imdbTV.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.imdbTV_AfterExpand);
            // 
            // treeIL
            // 
            this.treeIL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeIL.ImageStream")));
            this.treeIL.TransparentColor = System.Drawing.Color.Transparent;
            this.treeIL.Images.SetKeyName(0, "title");
            this.treeIL.Images.SetKeyName(1, "name");
            // 
            // imdbWB
            // 
            this.imdbWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imdbWB.Location = new System.Drawing.Point(0, 0);
            this.imdbWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.imdbWB.Name = "imdbWB";
            this.imdbWB.Size = new System.Drawing.Size(433, 499);
            this.imdbWB.TabIndex = 0;
            this.imdbWB.TabStop = false;
            // 
            // imdbBW
            // 
            this.imdbBW.WorkerReportsProgress = true;
            this.imdbBW.WorkerSupportsCancellation = true;
            this.imdbBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.imdbBW_DoWork);
            this.imdbBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.imdbBW_RunWorkerCompleted);
            this.imdbBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            // 
            // expandBW
            // 
            this.expandBW.WorkerReportsProgress = true;
            this.expandBW.WorkerSupportsCancellation = true;
            this.expandBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.expandBW_DoWork);
            this.expandBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.expandBW_RunWorkerCompleted);
            this.expandBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            // 
            // waitP
            // 
            this.waitP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.waitP.Controls.Add(this.waitPB);
            this.waitP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitP.Location = new System.Drawing.Point(0, 0);
            this.waitP.Name = "waitP";
            this.waitP.Size = new System.Drawing.Size(304, 499);
            this.waitP.TabIndex = 0;
            this.waitP.Visible = false;
            this.waitP.Paint += new System.Windows.Forms.PaintEventHandler(this.waitP_Paint);
            // 
            // waitPB
            // 
            this.waitPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waitPB.Location = new System.Drawing.Point(3, 166);
            this.waitPB.Name = "waitPB";
            this.waitPB.Size = new System.Drawing.Size(298, 130);
            this.waitPB.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.waitPB.TabIndex = 0;
            // 
            // IMDBForm
            // 
            this.AcceptButton = this.searchB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.actionP);
            this.MinimumSize = new System.Drawing.Size(750, 34);
            this.Name = "IMDBForm";
            this.Text = "IMDBForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.actionP.ResumeLayout(false);
            this.actionP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.waitP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.RadioButton titleRB;
        private System.Windows.Forms.RadioButton nameRB;
        private System.Windows.Forms.Button sixDegreesModeB;
        private System.Windows.Forms.Button imdbModeB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView imdbTV;
        private System.Windows.Forms.ProgressBar waitPB;
        private System.ComponentModel.BackgroundWorker imdbBW;
        private TransparentPanel waitP;
        private System.ComponentModel.BackgroundWorker expandBW;
        private System.Windows.Forms.ImageList treeIL;
        private System.Windows.Forms.WebBrowser imdbWB;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Button sixDegreesGoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTB;
    }
}