namespace BatchCompressionTool7zip
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton rbtnFolders;
        private System.Windows.Forms.RadioButton rbtnFiles;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblSelectedPath;
        private System.Windows.Forms.Button btnStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rbtnFolders = new System.Windows.Forms.RadioButton();
            this.rbtnFiles = new System.Windows.Forms.RadioButton();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSelectedPath = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnFolders
            // 
            this.rbtnFolders.AutoSize = true;
            this.rbtnFolders.Location = new System.Drawing.Point(12, 12);
            this.rbtnFolders.Name = "rbtnFolders";
            this.rbtnFolders.Size = new System.Drawing.Size(91, 17);
            this.rbtnFolders.TabIndex = 0;
            this.rbtnFolders.TabStop = true;
            this.rbtnFolders.Text = "Compress folders";
            this.rbtnFolders.UseVisualStyleBackColor = true;
            // 
            // rbtnFiles
            // 
            this.rbtnFiles.AutoSize = true;
            this.rbtnFiles.Location = new System.Drawing.Point(120, 12);
            this.rbtnFiles.Name = "rbtnFiles";
            this.rbtnFiles.Size = new System.Drawing.Size(85, 17);
            this.rbtnFiles.TabIndex = 1;
            this.rbtnFiles.TabStop = true;
            this.rbtnFiles.Text = "Compress files";
            this.rbtnFiles.UseVisualStyleBackColor = true;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(12, 40);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(193, 20);
            this.txtExtension.TabIndex = 2;
            this.txtExtension.Text = "file extension (eg: .gba)";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 70);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Folder";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelectedPath
            // 
            this.lblSelectedPath.AutoSize = true;
            this.lblSelectedPath.Location = new System.Drawing.Point(108, 75);
            this.lblSelectedPath.Name = "lblSelectedPath";
            this.lblSelectedPath.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPath.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(193, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Compression";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(220, 140);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSelectedPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.rbtnFiles);
            this.Controls.Add(this.rbtnFolders);
            this.Name = "MainForm";
            this.Text = "Batch Compression Tool for 7-zip";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
