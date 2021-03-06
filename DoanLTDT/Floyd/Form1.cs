using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoanLTDT
{
    public partial class Form1 : Form
    {
        private const string FILENAME = "data.bin";
        public Form1()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " " + Application.ProductVersion;

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.Click += new EventHandler(toolStripButton_Click);
            }
            toolStripButton_Click(toolStripButton2, null);
        }

        protected override void OnLoad(EventArgs e)
        {
            GraphData data = graphUI2.LoadGraph(FILENAME);
            //cboFrom.SelectedIndex = data.FormNode;
            //cboTo.SelectedIndex = data.ToNode;
            //chkUndirectedGrapth.Checked = data.IsUndirectedGraph;
            //base.OnShown(e);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            graphUI2.SaveGraph(FILENAME, cboFrom.SelectedIndex, cboTo.SelectedIndex);
            base.OnClosing(e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Delete:
                    graphUI2.DeleteSelectedNode();
                    break;
                case Keys.D1:
                    toolStripButton_Click(toolStripButton1, null);
                    break;
                case Keys.D2:
                    toolStripButton_Click(toolStripButton2, null);
                    break;
                case Keys.D3:
                    toolStripButton_Click(toolStripButton3, null);
                    break;
                case Keys.D4:
                    toolStripButton_Click(toolStripButton4, null);
                    break;
                default:
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void txtMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboFrom.Text) && !String.IsNullOrEmpty(cboTo.Text))
                graphUI2.FindShortestPath(cboFrom.Text[0] - 'A', cboTo.Text[0] - 'A');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphUI2.Reset();
        }

        private void chkUndirectedGrapth_CheckedChanged(object sender, EventArgs e)
        {
            graphUI2.IsUndirectedGraph = chkUndirectedGrapth.Checked;
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            graphUI2.DeleteSelectedNode();
        }

        private void btnChangeNodeColor_Click(object sender, EventArgs e)
        {
            Node node = graphUI2.SelectedNode;
            if (node == null)
                return;
            ColorDialog dlg = new ColorDialog();
            dlg.Color = node.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color c = dlg.Color;
                //MessageBox.Show(Color.Black.GetBrightness().ToString()+"      " + Color.White.GetBrightness().ToString());

                node.BackColor = c;
                node.ForeColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

                if (Math.Abs(c.ToArgb() - node.ForeColor.ToArgb()) < 100000)
                {

                    node.ForeColor = Color.Black;
                }

            }   
        }

        private void btnDeleteLastestEdge_Click(object sender, EventArgs e)
        {
            graphUI2.DeleteLastestEdge();
        }

        private void btnClearEdge_Click(object sender, EventArgs e)
        {
            graphUI2.ClearEdges();
        }

        private void graphUI2_SelectedNodeChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = sender != null;
        }

        private void graphUI2_ContentChanged(object sender, EventArgs e)
        {
            int f = cboFrom.SelectedIndex;
            int t = cboTo.SelectedIndex;

            cboFrom.DataSource = graphUI2.NodeNames;
            cboTo.DataSource = graphUI2.NodeNames;

            if (cboFrom.Items.Count > f)
                cboFrom.SelectedIndex = f;
            if (cboTo.Items.Count > t)
                cboTo.SelectedIndex = t;
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            DrawingTools tool = (DrawingTools)(int.Parse(btn.Tag.ToString()));
            graphUI2.Tool = tool;

            foreach (ToolStripButton item in toolStrip1.Items)
            {
                item.Checked = false;
            }

            btn.Checked = true;
        }

        private void matrix1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Krusal open_form2 = new Krusal();
            open_form2.ShowDialog();
        }
    }
}
