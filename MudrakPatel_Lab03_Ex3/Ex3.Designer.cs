namespace MudrakPatel_Lab03_Ex3
{
    partial class Ex3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SETechnician");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SET-IG");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("HIT");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ICET", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("College", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.courserPanel = new System.Windows.Forms.Panel();
            this.coursesTreeView = new System.Windows.Forms.TreeView();
            this.courserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courserPanel
            // 
            this.courserPanel.AutoScroll = true;
            this.courserPanel.Controls.Add(this.coursesTreeView);
            this.courserPanel.Location = new System.Drawing.Point(13, 13);
            this.courserPanel.Name = "courserPanel";
            this.courserPanel.Size = new System.Drawing.Size(199, 182);
            this.courserPanel.TabIndex = 0;
            // 
            // coursesTreeView
            // 
            this.coursesTreeView.Location = new System.Drawing.Point(4, 4);
            this.coursesTreeView.Name = "coursesTreeView";
            treeNode1.Name = "seTechnicianChildNode";
            treeNode1.Text = "SETechnician";
            treeNode2.Name = "setChildNode";
            treeNode2.Text = "SET";
            treeNode3.Name = "setIgChildNode";
            treeNode3.Text = "SET-IG";
            treeNode4.Name = "hitChildNode";
            treeNode4.Text = "HIT";
            treeNode5.Name = "icetChildNode";
            treeNode5.Text = "ICET";
            treeNode6.Name = "collegeMaainNode";
            treeNode6.Text = "College";
            this.coursesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.coursesTreeView.Size = new System.Drawing.Size(192, 175);
            this.coursesTreeView.TabIndex = 0;
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 296);
            this.Controls.Add(this.courserPanel);
            this.Name = "Ex3";
            this.Text = "Course explorer";
            this.courserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel courserPanel;
        private System.Windows.Forms.TreeView coursesTreeView;
    }
}

