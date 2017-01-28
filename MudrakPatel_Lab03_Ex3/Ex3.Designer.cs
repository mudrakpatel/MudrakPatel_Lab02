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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("SETechnician");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("SET-IG");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HIT");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ICET", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("College", new System.Windows.Forms.TreeNode[] {
            treeNode11});
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
            treeNode7.Name = "seTechnicianChildNode";
            treeNode7.Text = "SETechnician";
            treeNode8.Name = "setChildNode";
            treeNode8.Text = "SET";
            treeNode9.Name = "setIgChildNode";
            treeNode9.Text = "SET-IG";
            treeNode10.Name = "hitChildNode";
            treeNode10.Text = "HIT";
            treeNode11.Name = "icetChildNode";
            treeNode11.Text = "ICET";
            treeNode12.Name = "collegeMaainNode";
            treeNode12.Text = "College";
            this.coursesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.coursesTreeView.Size = new System.Drawing.Size(192, 175);
            this.coursesTreeView.TabIndex = 0;
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
            this.coursesListView.Location = new System.Drawing.Point(4, 4);
            this.coursesListView.Name = "coursesListView";
            this.coursesListView.Size = new System.Drawing.Size(600, 175);
            this.coursesListView.TabIndex = 0;
            this.coursesListView.UseCompatibleStateImageBehavior = false;
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

