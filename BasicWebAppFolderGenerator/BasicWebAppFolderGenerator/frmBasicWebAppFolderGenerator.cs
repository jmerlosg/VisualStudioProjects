using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWebAppFolderGenerator
{
    public partial class frmBasicWebAppFolderGenerator : Form
    {
        private bool includeJQuery = false;
        private bool includeAngularJs = false;
        private bool includeBootstrap = false;

        public frmBasicWebAppFolderGenerator()
        {
            InitializeComponent();
        }

        private void cmdSearchFolder_Click(object sender, EventArgs e)
        {
            DialogResult DRes = fbDialog.ShowDialog(this);

            if(DRes == DialogResult.OK)
            {
                string Name = txtProjectName.Text.Trim();
                lblGeneratedProjectName.Text = fbDialog.SelectedPath + "\\" + Name;
                txtDestinyFolder.Text = fbDialog.SelectedPath;
            }

        }

        private void frmBasicWebAppFolderGenerator_Load(object sender, EventArgs e)
        {

        }

        private void chkJQuery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJQuery.Checked)
            {
                includeJQuery = true;
            } else
            {
                includeJQuery = false;
            }
        }

        private void chkAngularJs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAngularJs.Checked)
            {
                includeAngularJs = true;
            }
            else
            {
                includeAngularJs = false;
            }
        }

        private void chkBootstrap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBootstrap.Checked)
            {
                includeBootstrap = true;
            }
            else
            {
                includeBootstrap = false;
            }
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            bool ok = true;
            StreamReader reader = null;
            StreamWriter writer = null;
            LockControls();
            if (!Directory.Exists(lblGeneratedProjectName.Text))
            {
                try
                {
                    Directory.CreateDirectory(lblGeneratedProjectName.Text);

                    string ImageDir = lblGeneratedProjectName.Text + "\\imgs";
                    string CssDir = lblGeneratedProjectName.Text + "\\css";
                    string JavaScriptDir = lblGeneratedProjectName.Text + "\\js";
                    string libdir = string.Empty;
                    
                    Directory.CreateDirectory(ImageDir);
                    Directory.CreateDirectory(CssDir);
                    Directory.CreateDirectory(JavaScriptDir);

                    if (includeAngularJs || includeJQuery || includeBootstrap)
                    {
                        libdir = JavaScriptDir + "\\lib";
                        Directory.CreateDirectory(libdir);

                        if (includeBootstrap)
                        {
                            File.Copy("codes\\bootstrap.js", libdir + "\\bootstrap.js");
                            File.Copy("codes\\bootstrap.css", CssDir + "\\bootstrap.css");
                        }

                        if (includeAngularJs)
                        {
                            File.Copy("codes\\angular.js", libdir + "\\angular.js");
                        }

                        if (includeJQuery)
                        {
                            File.Copy("codes\\jquery.js", libdir + "\\jquery.js");
                            File.Copy("codes\\jquery-ui.js", libdir + "\\jquery-ui.js");
                            File.Copy("codes\\jquery-ui.css", CssDir + "\\jquery-ui.css");
                            File.Copy("codes\\jquery-ui.structure.css", CssDir + "\\jquery-ui.structure.css");
                            File.Copy("codes\\jquery-ui.theme.css", CssDir + "\\jquery-ui.theme.css");
                        }
                    }

                    File.Copy("codes\\animate.css", CssDir + "\\animate.css");
                    File.Copy("codes\\index.html", lblGeneratedProjectName.Text + "\\index.html");

                    reader = new StreamReader(lblGeneratedProjectName.Text + "\\index.html");
                    string HTML = reader.ReadToEnd();

                    reader.Close();

                    HTML = HTML.Replace("||REPLACE IF BOOSTRAPCSS||", "<link rel=\"stylesheet\" href=\"css/bootstrap.css\">" + Environment.NewLine);
                    HTML = HTML.Replace("||REPLACE IF JQUERYCSS||", "<link rel=\"stylesheet\" href=\"css/jquery-ui.css\">"+Environment.NewLine+"<link rel=\"stylesheet\" href=\"css/jquery-ui.structure.css\">" + Environment.NewLine + "<link rel=\"stylesheet\" href=\"css/jquery-ui.theme.css\">" + Environment.NewLine);
                    HTML = HTML.Replace("||REPLACE IF JQUERYJS||", "<script src=\"js/lib/jquery.js\"></script>" + Environment.NewLine + "<script src=\"js/lib/jquery-ui.js\"></script>" + Environment.NewLine);
                    HTML = HTML.Replace("||REPLACE IF BOOSTRAPJS||", "<script src=\"js/lib/bootstrap.js\"></script>" + Environment.NewLine);
                    HTML = HTML.Replace("||REPLACE IF ANGULARJS||", "<script src=\"js/lib/angular.js\"></script>" + Environment.NewLine);
                    
                    writer = new StreamWriter(lblGeneratedProjectName.Text + "\\index.html");
                    writer.Write(HTML);
                    writer.Close();

                }
                catch (Exception ex)
                {
                    ok = false;
                    MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                    writer.Close();

                    if (ok)
                    {
                        MessageBox.Show(this, "Project " + txtProjectName.Text + " generated.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(this,"The project already exists.",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UnlockControls();
        }

        private void txtProjectName_Leave(object sender, EventArgs e)
        {
            if(lblGeneratedProjectName.Text.Length > 0)
            {
                lblGeneratedProjectName.Text = string.Empty;
                string Name = txtProjectName.Text.Trim();
                lblGeneratedProjectName.Text = txtDestinyFolder.Text + "\\" + Name;

            }
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void LockControls()
        {
            txtProjectName.Enabled = false;
            gbInclude.Enabled = false;
            cmdGenerate.Enabled = false;
            cmdSearchFolder.Enabled = false;
        }

        private void UnlockControls()
        {
            txtProjectName.Enabled = true;
            gbInclude.Enabled = true;
            cmdGenerate.Enabled = true;
            cmdSearchFolder.Enabled = true;
        }

        private void ValidateFields()
        {
            if (!txtProjectName.Text.Equals(string.Empty) && !txtDestinyFolder.Text.Equals(string.Empty))
            {
                cmdGenerate.Enabled = true;
            }
            else
            {
                cmdGenerate.Enabled = false;
            }
        }

        private void txtDestinyFolder_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
    }
}
