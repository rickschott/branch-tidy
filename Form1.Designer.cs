namespace branch_tidy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.txtConsumerSecret = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.cbRepos = new System.Windows.Forms.ComboBox();
            this.btnGetRepos = new System.Windows.Forms.Button();
            this.btnGetBranches = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlBranches = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.lblTotalRepos = new System.Windows.Forms.Label();
            this.lblTotalRepoTitle = new System.Windows.Forms.Label();
            this.lblTotalBranches = new System.Windows.Forms.Label();
            this.lblTotalBranchesTitle = new System.Windows.Forms.Label();
            this.cbShowOnlyMine = new System.Windows.Forms.CheckBox();
            this.lblBranchFIlterTitle = new System.Windows.Forms.Label();
            this.txtBranchFilters = new System.Windows.Forms.TextBox();
            this.lblTeamsTitle = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.btnGetTeams = new System.Windows.Forms.Button();
            this.lblReposTitle = new System.Windows.Forms.Label();
            this.dgBranches = new System.Windows.Forms.DataGridView();
            this.NameBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(107, 17);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.Size = new System.Drawing.Size(154, 20);
            this.txtConsumerKey.TabIndex = 1;
            // 
            // txtConsumerSecret
            // 
            this.txtConsumerSecret.Location = new System.Drawing.Point(107, 43);
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.Size = new System.Drawing.Size(154, 20);
            this.txtConsumerSecret.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(132, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.ForeColor = System.Drawing.Color.Lime;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(986, 126);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // cbRepos
            // 
            this.cbRepos.FormattingEnabled = true;
            this.cbRepos.Location = new System.Drawing.Point(92, 38);
            this.cbRepos.Name = "cbRepos";
            this.cbRepos.Size = new System.Drawing.Size(135, 21);
            this.cbRepos.TabIndex = 5;
            // 
            // btnGetRepos
            // 
            this.btnGetRepos.Enabled = false;
            this.btnGetRepos.Location = new System.Drawing.Point(233, 38);
            this.btnGetRepos.Name = "btnGetRepos";
            this.btnGetRepos.Size = new System.Drawing.Size(88, 23);
            this.btnGetRepos.TabIndex = 6;
            this.btnGetRepos.Text = "get repos";
            this.btnGetRepos.UseVisualStyleBackColor = true;
            this.btnGetRepos.Click += new System.EventHandler(this.btnGetRepos_Click);
            // 
            // btnGetBranches
            // 
            this.btnGetBranches.Enabled = false;
            this.btnGetBranches.Location = new System.Drawing.Point(122, 89);
            this.btnGetBranches.Name = "btnGetBranches";
            this.btnGetBranches.Size = new System.Drawing.Size(199, 65);
            this.btnGetBranches.TabIndex = 8;
            this.btnGetBranches.Text = "get branches";
            this.btnGetBranches.UseVisualStyleBackColor = true;
            this.btnGetBranches.Click += new System.EventHandler(this.btnGetBranches_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "User: ";
            // 
            // tsUserName
            // 
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(0, 17);
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.tabPage1);
            this.mainTabs.Controls.Add(this.tabPage2);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1000, 580);
            this.mainTabs.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtConsumerKey);
            this.pnlLogin.Controls.Add(this.txtConsumerSecret);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(3, 3);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(986, 548);
            this.pnlLogin.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bitbucket User:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(107, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consumer Secret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumer Key:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlBranches);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Branches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlBranches
            // 
            this.pnlBranches.Controls.Add(this.splitContainerMain);
            this.pnlBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBranches.Location = new System.Drawing.Point(3, 3);
            this.pnlBranches.Name = "pnlBranches";
            this.pnlBranches.Size = new System.Drawing.Size(986, 548);
            this.pnlBranches.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.txtOutput);
            this.splitContainerMain.Size = new System.Drawing.Size(986, 548);
            this.splitContainerMain.SplitterDistance = 418;
            this.splitContainerMain.TabIndex = 14;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.lblTotalRepos);
            this.splitContainerTop.Panel1.Controls.Add(this.lblTotalRepoTitle);
            this.splitContainerTop.Panel1.Controls.Add(this.lblTotalBranches);
            this.splitContainerTop.Panel1.Controls.Add(this.lblTotalBranchesTitle);
            this.splitContainerTop.Panel1.Controls.Add(this.cbShowOnlyMine);
            this.splitContainerTop.Panel1.Controls.Add(this.lblBranchFIlterTitle);
            this.splitContainerTop.Panel1.Controls.Add(this.txtBranchFilters);
            this.splitContainerTop.Panel1.Controls.Add(this.cbRepos);
            this.splitContainerTop.Panel1.Controls.Add(this.lblTeamsTitle);
            this.splitContainerTop.Panel1.Controls.Add(this.cbTeams);
            this.splitContainerTop.Panel1.Controls.Add(this.btnGetTeams);
            this.splitContainerTop.Panel1.Controls.Add(this.btnGetRepos);
            this.splitContainerTop.Panel1.Controls.Add(this.btnGetBranches);
            this.splitContainerTop.Panel1.Controls.Add(this.lblReposTitle);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.dgBranches);
            this.splitContainerTop.Size = new System.Drawing.Size(986, 418);
            this.splitContainerTop.SplitterDistance = 340;
            this.splitContainerTop.TabIndex = 14;
            // 
            // lblTotalRepos
            // 
            this.lblTotalRepos.AutoSize = true;
            this.lblTotalRepos.Location = new System.Drawing.Point(122, 203);
            this.lblTotalRepos.Name = "lblTotalRepos";
            this.lblTotalRepos.Size = new System.Drawing.Size(170, 13);
            this.lblTotalRepos.TabIndex = 20;
            this.lblTotalRepos.Text = "*will update after running get repos";
            // 
            // lblTotalRepoTitle
            // 
            this.lblTotalRepoTitle.AutoSize = true;
            this.lblTotalRepoTitle.Location = new System.Drawing.Point(11, 203);
            this.lblTotalRepoTitle.Name = "lblTotalRepoTitle";
            this.lblTotalRepoTitle.Size = new System.Drawing.Size(90, 13);
            this.lblTotalRepoTitle.TabIndex = 19;
            this.lblTotalRepoTitle.Text = "Total repositories:";
            // 
            // lblTotalBranches
            // 
            this.lblTotalBranches.AutoSize = true;
            this.lblTotalBranches.Location = new System.Drawing.Point(122, 226);
            this.lblTotalBranches.Name = "lblTotalBranches";
            this.lblTotalBranches.Size = new System.Drawing.Size(188, 13);
            this.lblTotalBranches.TabIndex = 18;
            this.lblTotalBranches.Text = "*will update after running get branches";
            // 
            // lblTotalBranchesTitle
            // 
            this.lblTotalBranchesTitle.AutoSize = true;
            this.lblTotalBranchesTitle.Location = new System.Drawing.Point(11, 226);
            this.lblTotalBranchesTitle.Name = "lblTotalBranchesTitle";
            this.lblTotalBranchesTitle.Size = new System.Drawing.Size(81, 13);
            this.lblTotalBranchesTitle.TabIndex = 17;
            this.lblTotalBranchesTitle.Text = "Total branches:";
            // 
            // cbShowOnlyMine
            // 
            this.cbShowOnlyMine.AutoSize = true;
            this.cbShowOnlyMine.Checked = true;
            this.cbShowOnlyMine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowOnlyMine.Location = new System.Drawing.Point(122, 71);
            this.cbShowOnlyMine.Name = "cbShowOnlyMine";
            this.cbShowOnlyMine.Size = new System.Drawing.Size(138, 17);
            this.cbShowOnlyMine.TabIndex = 16;
            this.cbShowOnlyMine.Text = "Only show my branches";
            this.cbShowOnlyMine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowOnlyMine.UseVisualStyleBackColor = true;
            // 
            // lblBranchFIlterTitle
            // 
            this.lblBranchFIlterTitle.AutoSize = true;
            this.lblBranchFIlterTitle.Location = new System.Drawing.Point(11, 173);
            this.lblBranchFIlterTitle.Name = "lblBranchFIlterTitle";
            this.lblBranchFIlterTitle.Size = new System.Drawing.Size(105, 13);
            this.lblBranchFIlterTitle.TabIndex = 15;
            this.lblBranchFIlterTitle.Text = "Filtered Repositories:";
            // 
            // txtBranchFilters
            // 
            this.txtBranchFilters.Location = new System.Drawing.Point(122, 170);
            this.txtBranchFilters.Name = "txtBranchFilters";
            this.txtBranchFilters.Size = new System.Drawing.Size(199, 20);
            this.txtBranchFilters.TabIndex = 14;
            // 
            // lblTeamsTitle
            // 
            this.lblTeamsTitle.AutoSize = true;
            this.lblTeamsTitle.Location = new System.Drawing.Point(11, 14);
            this.lblTeamsTitle.Name = "lblTeamsTitle";
            this.lblTeamsTitle.Size = new System.Drawing.Size(42, 13);
            this.lblTeamsTitle.TabIndex = 10;
            this.lblTeamsTitle.Text = "Teams:";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(92, 11);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(135, 21);
            this.cbTeams.TabIndex = 9;
            // 
            // btnGetTeams
            // 
            this.btnGetTeams.Location = new System.Drawing.Point(233, 9);
            this.btnGetTeams.Name = "btnGetTeams";
            this.btnGetTeams.Size = new System.Drawing.Size(88, 23);
            this.btnGetTeams.TabIndex = 13;
            this.btnGetTeams.Text = "get teams";
            this.btnGetTeams.UseVisualStyleBackColor = true;
            this.btnGetTeams.Click += new System.EventHandler(this.btnGetTeams_Click);
            // 
            // lblReposTitle
            // 
            this.lblReposTitle.AutoSize = true;
            this.lblReposTitle.Location = new System.Drawing.Point(11, 41);
            this.lblReposTitle.Name = "lblReposTitle";
            this.lblReposTitle.Size = new System.Drawing.Size(68, 13);
            this.lblReposTitle.TabIndex = 11;
            this.lblReposTitle.Text = "Repositories:";
            // 
            // dgBranches
            // 
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameBranch,
            this.BranchAuthor});
            this.dgBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBranches.Location = new System.Drawing.Point(0, 0);
            this.dgBranches.MultiSelect = false;
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBranches.Size = new System.Drawing.Size(642, 418);
            this.dgBranches.TabIndex = 0;
            this.dgBranches.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgBranches_MouseClick);
            // 
            // NameBranch
            // 
            this.NameBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameBranch.HeaderText = "Branch Name";
            this.NameBranch.MinimumWidth = 250;
            this.NameBranch.Name = "NameBranch";
            // 
            // BranchAuthor
            // 
            this.BranchAuthor.HeaderText = "First Commit By";
            this.BranchAuthor.Name = "BranchAuthor";
            this.BranchAuthor.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBranchToolStripMenuItem,
            this.deleteBranchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 48);
            // 
            // viewBranchToolStripMenuItem
            // 
            this.viewBranchToolStripMenuItem.Name = "viewBranchToolStripMenuItem";
            this.viewBranchToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewBranchToolStripMenuItem.Text = "View Branch";
            this.viewBranchToolStripMenuItem.Click += new System.EventHandler(this.viewBranchToolStripMenuItem_Click);
            // 
            // deleteBranchToolStripMenuItem
            // 
            this.deleteBranchToolStripMenuItem.Name = "deleteBranchToolStripMenuItem";
            this.deleteBranchToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteBranchToolStripMenuItem.Text = "Delete Branch";
            this.deleteBranchToolStripMenuItem.Click += new System.EventHandler(this.deleteBranchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 602);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "branch-tidy";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlBranches.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel1.PerformLayout();
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ComboBox cbRepos;
        private System.Windows.Forms.Button btnGetRepos;
        private System.Windows.Forms.Button btnGetBranches;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsUserName;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBranches;
        private System.Windows.Forms.Label lblReposTitle;
        private System.Windows.Forms.Label lblTeamsTitle;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnGetTeams;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.DataGridView dgBranches;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchAuthor;
        private System.Windows.Forms.Label lblBranchFIlterTitle;
        private System.Windows.Forms.TextBox txtBranchFilters;
        private System.Windows.Forms.CheckBox cbShowOnlyMine;
        private System.Windows.Forms.Label lblTotalBranches;
        private System.Windows.Forms.Label lblTotalBranchesTitle;
        private System.Windows.Forms.Label lblTotalRepos;
        private System.Windows.Forms.Label lblTotalRepoTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBranchToolStripMenuItem;
    }
}

