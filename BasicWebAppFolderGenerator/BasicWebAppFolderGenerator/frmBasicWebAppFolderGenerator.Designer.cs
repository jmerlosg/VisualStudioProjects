namespace BasicWebAppFolderGenerator
{
    partial class frmBasicWebAppFolderGenerator
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
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinyFolder = new System.Windows.Forms.TextBox();
            this.cmdSearchFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblGeneratedProjectName = new System.Windows.Forms.Label();
            this.gbInclude = new System.Windows.Forms.GroupBox();
            this.chkJQuery = new System.Windows.Forms.CheckBox();
            this.chkAngularJs = new System.Windows.Forms.CheckBox();
            this.chkBootstrap = new System.Windows.Forms.CheckBox();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.gbInclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination";
            // 
            // txtDestinyFolder
            // 
            this.txtDestinyFolder.Location = new System.Drawing.Point(16, 87);
            this.txtDestinyFolder.Name = "txtDestinyFolder";
            this.txtDestinyFolder.ReadOnly = true;
            this.txtDestinyFolder.Size = new System.Drawing.Size(466, 26);
            this.txtDestinyFolder.TabIndex = 1;
            this.txtDestinyFolder.TextChanged += new System.EventHandler(this.txtDestinyFolder_TextChanged);
            // 
            // cmdSearchFolder
            // 
            this.cmdSearchFolder.Location = new System.Drawing.Point(488, 81);
            this.cmdSearchFolder.Name = "cmdSearchFolder";
            this.cmdSearchFolder.Size = new System.Drawing.Size(85, 32);
            this.cmdSearchFolder.TabIndex = 2;
            this.cmdSearchFolder.Text = "Search..";
            this.cmdSearchFolder.UseVisualStyleBackColor = true;
            this.cmdSearchFolder.Click += new System.EventHandler(this.cmdSearchFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(16, 35);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(466, 26);
            this.txtProjectName.TabIndex = 4;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            this.txtProjectName.Leave += new System.EventHandler(this.txtProjectName_Leave);
            // 
            // lblGeneratedProjectName
            // 
            this.lblGeneratedProjectName.AutoSize = true;
            this.lblGeneratedProjectName.Location = new System.Drawing.Point(16, 122);
            this.lblGeneratedProjectName.Name = "lblGeneratedProjectName";
            this.lblGeneratedProjectName.Size = new System.Drawing.Size(0, 20);
            this.lblGeneratedProjectName.TabIndex = 5;
            // 
            // gbInclude
            // 
            this.gbInclude.Controls.Add(this.chkBootstrap);
            this.gbInclude.Controls.Add(this.chkAngularJs);
            this.gbInclude.Controls.Add(this.chkJQuery);
            this.gbInclude.Location = new System.Drawing.Point(20, 152);
            this.gbInclude.Name = "gbInclude";
            this.gbInclude.Size = new System.Drawing.Size(462, 82);
            this.gbInclude.TabIndex = 6;
            this.gbInclude.TabStop = false;
            this.gbInclude.Text = "Include";
            // 
            // chkJQuery
            // 
            this.chkJQuery.AutoSize = true;
            this.chkJQuery.Location = new System.Drawing.Point(6, 25);
            this.chkJQuery.Name = "chkJQuery";
            this.chkJQuery.Size = new System.Drawing.Size(78, 24);
            this.chkJQuery.TabIndex = 7;
            this.chkJQuery.Text = "JQuery";
            this.chkJQuery.UseVisualStyleBackColor = true;
            this.chkJQuery.CheckedChanged += new System.EventHandler(this.chkJQuery_CheckedChanged);
            // 
            // chkAngularJs
            // 
            this.chkAngularJs.AutoSize = true;
            this.chkAngularJs.Location = new System.Drawing.Point(90, 25);
            this.chkAngularJs.Name = "chkAngularJs";
            this.chkAngularJs.Size = new System.Drawing.Size(102, 24);
            this.chkAngularJs.TabIndex = 8;
            this.chkAngularJs.Text = "AngularJS";
            this.chkAngularJs.UseVisualStyleBackColor = true;
            this.chkAngularJs.CheckedChanged += new System.EventHandler(this.chkAngularJs_CheckedChanged);
            // 
            // chkBootstrap
            // 
            this.chkBootstrap.AutoSize = true;
            this.chkBootstrap.Location = new System.Drawing.Point(198, 25);
            this.chkBootstrap.Name = "chkBootstrap";
            this.chkBootstrap.Size = new System.Drawing.Size(98, 24);
            this.chkBootstrap.TabIndex = 9;
            this.chkBootstrap.Text = "Bootstrap";
            this.chkBootstrap.UseVisualStyleBackColor = true;
            this.chkBootstrap.CheckedChanged += new System.EventHandler(this.chkBootstrap_CheckedChanged);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Enabled = false;
            this.cmdGenerate.Location = new System.Drawing.Point(471, 240);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(102, 39);
            this.cmdGenerate.TabIndex = 10;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // frmBasicWebAppFolderGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 288);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.gbInclude);
            this.Controls.Add(this.lblGeneratedProjectName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSearchFolder);
            this.Controls.Add(this.txtDestinyFolder);
            this.Controls.Add(this.label1);
            this.Name = "frmBasicWebAppFolderGenerator";
            this.Text = "Basic Web App Folder Generator";
            this.Load += new System.EventHandler(this.frmBasicWebAppFolderGenerator_Load);
            this.gbInclude.ResumeLayout(false);
            this.gbInclude.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinyFolder;
        private System.Windows.Forms.Button cmdSearchFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblGeneratedProjectName;
        private System.Windows.Forms.GroupBox gbInclude;
        private System.Windows.Forms.CheckBox chkBootstrap;
        private System.Windows.Forms.CheckBox chkAngularJs;
        private System.Windows.Forms.CheckBox chkJQuery;
        private System.Windows.Forms.Button cmdGenerate;
    }
}

