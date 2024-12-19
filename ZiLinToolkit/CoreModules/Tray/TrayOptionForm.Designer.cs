namespace ZiLinToolkit.CoreModules.Tray
{
    partial class TrayOptionForm
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("節點0");
            TreeNode treeNode2 = new TreeNode("節點1");
            TreeNode treeNode3 = new TreeNode("節點2");
            TreeNode treeNode4 = new TreeNode("節點3");
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            treeView1 = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Padding = new Padding(10, 10, 5, 10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(664, 491);
            splitContainer1.SplitterDistance = 180;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(treeView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(165, 471);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "選單";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(10, 26);
            treeView1.Margin = new Padding(5);
            treeView1.Name = "treeView1";
            treeNode1.Name = "節點0";
            treeNode1.Text = "節點0";
            treeNode2.Name = "節點1";
            treeNode2.Text = "節點1";
            treeNode3.Name = "節點2";
            treeNode3.Text = "節點2";
            treeNode4.Name = "節點3";
            treeNode4.Text = "節點3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            treeView1.Size = new Size(145, 435);
            treeView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // TrayOptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 491);
            Controls.Add(splitContainer1);
            Name = "TrayOptionForm";
            Text = "TrayOptionForm";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ContextMenuStrip contextMenuStrip1;
        private TreeView treeView1;
        private GroupBox groupBox1;
    }
}