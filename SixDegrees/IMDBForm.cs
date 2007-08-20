using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace SixDegrees
{
    public enum PanelAnimationType
    {
        Expand = 1,
        Collapse = 2
    }

    public partial class IMDBForm : Form
    {

        private TreeNode _selectedNode;
        private bool _isName, _browserHidden;

        public IMDBForm()
        {
            InitializeComponent();

            imdbTV.Nodes.Add("DUMMY");
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            waitP.Visible = true;
            _isName = nameRB.Checked;
            _selectedNode = null;
            imdbBW.RunWorkerAsync(searchTB.Text);
        }

        private void imdbTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _selectedNode = imdbTV.SelectedNode;
            imdbTV.SelectedImageKey = (string)_selectedNode.Tag;
        }

        private void imdbTV_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (_selectedNode == null || expandBW.IsBusy) return;

            //imdbWB.Navigate(((string)_selectedNode.Tag == "name" ? IMDBTools.URL_NAME_PAGE : IMDBTools.URL_TITLE_PAGE) + _selectedNode.Name);
            waitP.Visible = true;

            expandBW.RunWorkerAsync(_selectedNode);
        }

        private void imdbTV_MouseDown(object sender, MouseEventArgs e)
        {
            _selectedNode = imdbTV.GetNodeAt(e.Location);
            imdbTV.SelectedNode = _selectedNode;
        }

        private void waitP_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush b = new SolidBrush(Color.FromArgb(150, 170, 170, 250));
            g.FillRectangle(b, waitP.ClientRectangle);
        }

        private void imdbBW_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isName = _isName;
            string searchText = (string)e.Argument;

            string code = null;

            try
            {
                if (isName)
                {
                    code = IMDBTools.GetNameCode(searchText);
                }
                else
                {
                    code = IMDBTools.GetMovieCode(searchText);
                }
            }
            catch (System.Net.WebException ex)
            {
                e.Cancel = true;
                return;
            }

            if (code == null)
            {
                e.Result = null;
                return;
            }

            imdbBW.ReportProgress(0, code);

            Hashtable results = null;
            if (isName)
            {
                results = IMDBTools.GetMovies(code);
            }
            else
            {
                results = IMDBTools.GetCast(code);
            }

            if (results == null)
            {
                //TODO: No listings found.
                e.Result = null;
                return;
            }

            e.Result = results;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                //imdbWB.Navigate((_isName ? IMDBTools.URL_NAME_PAGE : IMDBTools.URL_TITLE_PAGE) + (string)e.UserState);
            }
        }

        private void imdbBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                UpdateStatus("Connection error.", true);
                return;
            }
            if (e.Result == null)
            {
                UpdateStatus("No results.", true);
                return;
            }

            Hashtable results = (Hashtable)e.Result;

            imdbTV.Nodes.Clear();
            TreeNode rootTN = imdbTV.Nodes.Add(searchTB.Text);
            rootTN.ImageKey = _isName ? "name" : "title";

            foreach (string key in results.Keys)
            {
                TreeNode node = new TreeNode((string)results[key]);
                node.Name = key;
                node.Tag = _isName ? "title" : "name";
                //node.BackColor = (string)node.Tag == "name" ? Color.Bisque : Color.BlanchedAlmond;
                node.ImageKey = (string)node.Tag;

                rootTN.Nodes.Add(node);
            }

            imdbTV.ExpandAll();

            foreach (TreeNode node in rootTN.Nodes)
            {
                //Dummy child node to force display of +/-.
                node.Nodes.Add("DUMMY");
            }

            waitP.Visible = false;
        }

        public delegate void StatusUpdater(string status, bool visible);
        private void UpdateStatus(string status, bool visible)
        {
            if (InvokeRequired)
            {
                Invoke(new StatusUpdater(UpdateStatus), new object[] { status, visible });
                return;
            }

            statusL.Text = status;
            statusL.Visible = visible;
            waitP.Visible = false;
        }

        private void expandBW_DoWork(object sender, DoWorkEventArgs e)
        {
            TreeNode selNode = (TreeNode)e.Argument;

            Hashtable results = null;
            switch ((string)selNode.Tag)
            {
                case "name":
                    results = IMDBTools.GetMovies(selNode.Name);
                    break;
                case "title":
                    results = IMDBTools.GetCast(selNode.Name);
                    break;
            }

            if (results == null)
            {
                //TODO: No cast found.
                e.Cancel = true;
                return;
            }

            e.Result = results;
        }

        private void expandBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Hashtable results = (Hashtable)e.Result;

            imdbTV.SelectedNode.Nodes.Clear();
            foreach (string key in results.Keys)
            {
                TreeNode child = new TreeNode((string)results[key]);
                child.Name = key;
                child.Tag = (string)_selectedNode.Tag == "name" ? "title" : "name";
                //child.BackColor = (string)_selectedNode.Tag == "name" ? Color.BlanchedAlmond : Color.Bisque;
                child.ImageKey = (string)_selectedNode.Tag == "name" ? "title" : "name";

                //Dummy child node to force display of +/-.
                child.Nodes.Add("DUMMY");

                imdbTV.SelectedNode.Nodes.Add(child);
            }

            waitP.Visible = false;
        }

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            ((SplitContainer)sender).SplitterDistance = !_browserHidden
                ? this.Width - ((SplitContainer)sender).SplitterWidth
                : ((SplitContainer)sender).Panel1MinSize;
            _browserHidden = !_browserHidden;
        }

        #region Animation

        private void AnimatePanel(PanelAnimationType type)
        {
            Thread t = new Thread(new ParameterizedThreadStart(DoAnimation));
            t.Start(type);
        }

        public delegate void AniUpdater(int amt);
        private void AniUp(int amt)
        {
            if (InvokeRequired)
            {
                Invoke(new AniUpdater(AniUp), new object[] { amt });
                return;
            }
            actionP.Height += amt;
            Invalidate(true);
        }

        public delegate void VisibilitySetter(Control control, bool visible);
        private void SetVisibility(Control control, bool visible)
        {
            if (InvokeRequired)
            {
                Invoke(new VisibilitySetter(SetVisibility), new object[] { control, visible });
                return;
            }
            control.Visible = visible;
        }

        private void DoAnimation(object type)
        {
            for (int i = 0; i < 7; i++)
            {
                AniUp((PanelAnimationType)type == PanelAnimationType.Expand ? 10 : -10);
            }
            SetVisibility(groupBox2, (PanelAnimationType)type == PanelAnimationType.Expand);
        }

        private void sixDegreesModeB_Click(object sender, EventArgs e)
        {
            AnimatePanel(PanelAnimationType.Expand);
            ((Button)sender).Enabled = false;
            imdbModeB.Enabled = true;
        }

        private void imdbModeB_Click(object sender, EventArgs e)
        {
            AnimatePanel(PanelAnimationType.Collapse);
            ((Button)sender).Enabled = false;
            sixDegreesModeB.Enabled = true;

        }

        #endregion
    }
}