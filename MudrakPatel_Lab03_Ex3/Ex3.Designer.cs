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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("SETechnician");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("SET-IG");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("HIT");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("ICET", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("College", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.courserPanel = new System.Windows.Forms.Panel();
            this.coursesTreeView = new System.Windows.Forms.TreeView();
            this.coursesListPanel = new System.Windows.Forms.Panel();
            this.coursesListView = new System.Windows.Forms.ListView();
            this.semesterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course1Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course2Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course3Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course4Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course5Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course6Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courserPanel.SuspendLayout();
            this.coursesListPanel.SuspendLayout();
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
            treeNode13.Name = "seTechnicianChildNode";
            treeNode13.Text = "SETechnician";
            treeNode14.Name = "setChildNode";
            treeNode14.Text = "SET";
            treeNode15.Name = "setIgChildNode";
            treeNode15.Text = "SET-IG";
            treeNode16.Name = "hitChildNode";
            treeNode16.Text = "HIT";
            treeNode17.Name = "icetChildNode";
            treeNode17.Text = "ICET";
            treeNode18.Name = "collegeMaainNode";
            treeNode18.Text = "College";
            this.coursesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.coursesTreeView.Size = new System.Drawing.Size(192, 175);
            this.coursesTreeView.TabIndex = 0;
            this.coursesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.coursesTreeView_AfterSelect);
            // 
            // coursesListPanel
            // 
            this.coursesListPanel.AutoScroll = true;
            this.coursesListPanel.Controls.Add(this.coursesListView);
            this.coursesListPanel.Location = new System.Drawing.Point(219, 13);
            this.coursesListPanel.Name = "coursesListPanel";
            this.coursesListPanel.Size = new System.Drawing.Size(607, 182);
            this.coursesListPanel.TabIndex = 1;
            // 
            // coursesListView
            // 
            this.coursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semesterColumnHeader,
            this.course1Header,
            this.course2Header,
            this.course3Header,
            this.course4Header,
            this.course5Header,
            this.course6Header});
            this.coursesListView.GridLines = true;
            this.coursesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.coursesListView.Location = new System.Drawing.Point(7, 4);
            this.coursesListView.Name = "coursesListView";
            this.coursesListView.Size = new System.Drawing.Size(600, 175);
            this.coursesListView.TabIndex = 0;
            this.coursesListView.UseCompatibleStateImageBehavior = false;
            this.coursesListView.View = System.Windows.Forms.View.Details;
            // 
            // semesterColumnHeader
            // 
            this.semesterColumnHeader.Text = "Semester";
            // 
            // course1Header
            // 
            this.course1Header.Text = "1";
            // 
            // course2Header
            // 
            this.course2Header.Text = "2";
            // 
            // course3Header
            // 
            this.course3Header.Text = "3";
            // 
            // course4Header
            // 
            this.course4Header.Text = "4";
            // 
            // course5Header
            // 
            this.course5Header.Text = "5";
            // 
            // course6Header
            // 
            this.course6Header.Text = "6";
            this.course6Header.Width = 61;
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 296);
            this.Controls.Add(this.coursesListPanel);
            this.Controls.Add(this.courserPanel);
            this.Name = "Ex3";
            this.Text = "Course explorer";
            this.courserPanel.ResumeLayout(false);
            this.coursesListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel courserPanel;
        private System.Windows.Forms.TreeView coursesTreeView;
        private System.Windows.Forms.Panel coursesListPanel;
        private System.Windows.Forms.ListView coursesListView;
        private System.Windows.Forms.ColumnHeader semesterColumnHeader;
        private System.Windows.Forms.ColumnHeader course1Header;
        private System.Windows.Forms.ColumnHeader course2Header;
        private System.Windows.Forms.ColumnHeader course3Header;
        private System.Windows.Forms.ColumnHeader course4Header;
        private System.Windows.Forms.ColumnHeader course5Header;
        private System.Windows.Forms.ColumnHeader course6Header;
    }
}

