
namespace DoanLTDT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteLastestEdge = new System.Windows.Forms.Button();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnClearEdge = new System.Windows.Forms.Button();
            this.btnChangeNodeColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.chkUndirectedGrapth = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.graphUI2 = new DoanLTDT.GraphUI();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Floyd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteLastestEdge
            // 
            this.btnDeleteLastestEdge.AutoSize = true;
            this.btnDeleteLastestEdge.Location = new System.Drawing.Point(40, 156);
            this.btnDeleteLastestEdge.Name = "btnDeleteLastestEdge";
            this.btnDeleteLastestEdge.Size = new System.Drawing.Size(106, 32);
            this.btnDeleteLastestEdge.TabIndex = 2;
            this.btnDeleteLastestEdge.Text = "Xóa cạnh mới nhất";
            this.btnDeleteLastestEdge.UseVisualStyleBackColor = true;
            this.btnDeleteLastestEdge.Click += new System.EventHandler(this.btnDeleteLastestEdge_Click);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(51, 27);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(69, 32);
            this.btnDeleteNode.TabIndex = 3;
            this.btnDeleteNode.Text = "Xóa đỉnh";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // btnClearEdge
            // 
            this.btnClearEdge.Location = new System.Drawing.Point(57, 194);
            this.btnClearEdge.Name = "btnClearEdge";
            this.btnClearEdge.Size = new System.Drawing.Size(69, 32);
            this.btnClearEdge.TabIndex = 4;
            this.btnClearEdge.Text = "Xóa Cạnh";
            this.btnClearEdge.UseVisualStyleBackColor = true;
            this.btnClearEdge.Click += new System.EventHandler(this.btnClearEdge_Click);
            // 
            // btnChangeNodeColor
            // 
            this.btnChangeNodeColor.Location = new System.Drawing.Point(51, 65);
            this.btnChangeNodeColor.Name = "btnChangeNodeColor";
            this.btnChangeNodeColor.Size = new System.Drawing.Size(69, 32);
            this.btnChangeNodeColor.TabIndex = 5;
            this.btnChangeNodeColor.Text = "Đổi màu";
            this.btnChangeNodeColor.UseVisualStyleBackColor = true;
            this.btnChangeNodeColor.Click += new System.EventHandler(this.btnChangeNodeColor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.chkUndirectedGrapth);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboTo);
            this.panel1.Controls.Add(this.cboFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnClearEdge);
            this.panel1.Controls.Add(this.btnDeleteLastestEdge);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 424);
            this.panel1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Krusal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkUndirectedGrapth
            // 
            this.chkUndirectedGrapth.AutoSize = true;
            this.chkUndirectedGrapth.Location = new System.Drawing.Point(40, 273);
            this.chkUndirectedGrapth.Name = "chkUndirectedGrapth";
            this.chkUndirectedGrapth.Size = new System.Drawing.Size(102, 17);
            this.chkUndirectedGrapth.TabIndex = 13;
            this.chkUndirectedGrapth.Text = "Đồ thị vô hướng";
            this.chkUndirectedGrapth.UseVisualStyleBackColor = true;
            this.chkUndirectedGrapth.CheckedChanged += new System.EventHandler(this.chkUndirectedGrapth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteNode);
            this.groupBox1.Controls.Add(this.btnChangeNodeColor);
            this.groupBox1.Location = new System.Drawing.Point(6, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 104);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập đỉnh";
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(74, 50);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(83, 21);
            this.cboTo.TabIndex = 11;
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(74, 17);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(83, 21);
            this.cboFrom.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(216, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 63);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Tag = "0";
            this.toolStripButton1.Text = "Di chuyển";
            this.toolStripButton1.ToolTipText = "Di chuyển";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Tag = "1";
            this.toolStripButton2.Text = "Đỉnh";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton3.Tag = "2";
            this.toolStripButton3.Text = "Cạnh";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(31, 22);
            this.toolStripButton4.Tag = "3";
            this.toolStripButton4.Text = "Xóa";
            // 
            // graphUI2
            // 
            this.graphUI2.BackColor = System.Drawing.Color.White;
            this.graphUI2.IsUndirectedGraph = false;
            this.graphUI2.Location = new System.Drawing.Point(219, 22);
            this.graphUI2.Name = "graphUI2";
            this.graphUI2.Size = new System.Drawing.Size(566, 346);
            this.graphUI2.TabIndex = 11;
            this.graphUI2.ContentChanged += new System.EventHandler(this.graphUI2_ContentChanged);
            this.graphUI2.SelectedNodeChanged += new System.EventHandler(this.graphUI2_SelectedNodeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphUI2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion

        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteLastestEdge;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnClearEdge;
        private System.Windows.Forms.Button btnChangeNodeColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.CheckBox chkUndirectedGrapth;
        private GraphUI graphUI2;
        private System.Windows.Forms.Button button3;
    }
}

