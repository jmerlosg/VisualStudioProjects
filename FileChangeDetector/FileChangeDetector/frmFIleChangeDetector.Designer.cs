namespace FileChangeDetector
{
    partial class frmFileChangeDetector
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
            this.tvOrigin = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginPath = new System.Windows.Forms.TextBox();
            this.cmdSearchOriginPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinyPath = new System.Windows.Forms.TextBox();
            this.btnSearchDestinyPath = new System.Windows.Forms.Button();
            this.fbPaths = new System.Windows.Forms.FolderBrowserDialog();
            this.tvDestiny = new System.Windows.Forms.TreeView();
            this.cmdMergeFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvOrigin
            // 
            this.tvOrigin.Location = new System.Drawing.Point(12, 124);
            this.tvOrigin.Name = "tvOrigin";
            this.tvOrigin.Size = new System.Drawing.Size(276, 393);
            this.tvOrigin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origin Path";
            // 
            // txtOriginPath
            // 
            this.txtOriginPath.Location = new System.Drawing.Point(12, 25);
            this.txtOriginPath.Name = "txtOriginPath";
            this.txtOriginPath.ReadOnly = true;
            this.txtOriginPath.Size = new System.Drawing.Size(649, 20);
            this.txtOriginPath.TabIndex = 2;
            // 
            // cmdSearchOriginPath
            // 
            this.cmdSearchOriginPath.Location = new System.Drawing.Point(667, 23);
            this.cmdSearchOriginPath.Name = "cmdSearchOriginPath";
            this.cmdSearchOriginPath.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchOriginPath.TabIndex = 3;
            this.cmdSearchOriginPath.Text = "Serach...";
            this.cmdSearchOriginPath.UseVisualStyleBackColor = true;
            this.cmdSearchOriginPath.Click += new System.EventHandler(this.cmdSearchOriginPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destiny Path";
            // 
            // txtDestinyPath
            // 
            this.txtDestinyPath.Location = new System.Drawing.Point(12, 74);
            this.txtDestinyPath.Name = "txtDestinyPath";
            this.txtDestinyPath.ReadOnly = true;
            this.txtDestinyPath.Size = new System.Drawing.Size(649, 20);
            this.txtDestinyPath.TabIndex = 5;
            // 
            // btnSearchDestinyPath
            // 
            this.btnSearchDestinyPath.Location = new System.Drawing.Point(667, 74);
            this.btnSearchDestinyPath.Name = "btnSearchDestinyPath";
            this.btnSearchDestinyPath.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDestinyPath.TabIndex = 6;
            this.btnSearchDestinyPath.Text = "Search...";
            this.btnSearchDestinyPath.UseVisualStyleBackColor = true;
            this.btnSearchDestinyPath.Click += new System.EventHandler(this.btnSearchDestinyPath_Click);
            // 
            // tvDestiny
            // 
            this.tvDestiny.Location = new System.Drawing.Point(466, 124);
            this.tvDestiny.Name = "tvDestiny";
            this.tvDestiny.Size = new System.Drawing.Size(276, 393);
            this.tvDestiny.TabIndex = 7;
            // 
            // cmdMergeFolders
            // 
            this.cmdMergeFolders.Enabled = false;
            this.cmdMergeFolders.Location = new System.Drawing.Point(294, 267);
            this.cmdMergeFolders.Name = "cmdMergeFolders";
            this.cmdMergeFolders.Size = new System.Drawing.Size(166, 51);
            this.cmdMergeFolders.TabIndex = 8;
            this.cmdMergeFolders.Text = "Merge";
            this.cmdMergeFolders.UseVisualStyleBackColor = true;
            // 
            // frmFileChangeDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 529);
            this.Controls.Add(this.cmdMergeFolders);
            this.Controls.Add(this.tvDestiny);
            this.Controls.Add(this.btnSearchDestinyPath);
            this.Controls.Add(this.txtDestinyPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSearchOriginPath);
            this.Controls.Add(this.txtOriginPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvOrigin);
            this.Name = "frmFileChangeDetector";
            this.Text = "File Change Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginPath;
        private System.Windows.Forms.Button cmdSearchOriginPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinyPath;
        private System.Windows.Forms.Button btnSearchDestinyPath;
        private System.Windows.Forms.FolderBrowserDialog fbPaths;
        private System.Windows.Forms.TreeView tvDestiny;
        private System.Windows.Forms.Button cmdMergeFolders;
    }
}

