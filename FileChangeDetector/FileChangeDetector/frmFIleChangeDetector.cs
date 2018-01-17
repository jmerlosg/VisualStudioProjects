using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChangeDetector
{
    public partial class frmFileChangeDetector : Form
    {
        public frmFileChangeDetector()
        {
            InitializeComponent();
        }

        private string OriginPath;
        private string DestinyPath;

        private void cmdSearchOriginPath_Click(object sender, EventArgs e)
        {
            DialogResult DR = fbPaths.ShowDialog();

            if(DR == DialogResult.OK)
            {
                txtOriginPath.Text = fbPaths.SelectedPath;
                OriginPath = txtOriginPath.Text;
                PopulateTreeview(tvOrigin, OriginPath);
            }
        }

        private void btnSearchDestinyPath_Click(object sender, EventArgs e)
        {
            DialogResult DR = fbPaths.ShowDialog();

            if (DR == DialogResult.OK)
            {
                txtDestinyPath.Text = fbPaths.SelectedPath;
                DestinyPath = txtDestinyPath.Text;
                PopulateTreeview(tvDestiny, DestinyPath);
            }
        }

        private void PopulateTreeview(TreeView TView, string Path)
        {

        }
    }
}
