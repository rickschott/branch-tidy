using SharpBucket.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace branch_tidy
{
    public partial class Form1 : Form
    {
        private SharpBucketV2 _SharpBucket = new SharpBucketV2();
        private SharpBucket.V2.Pocos.User _UserProfile = null;
        private SharpBucket.V2.EndPoints.TeamsEndPoint _TeamsEndpoint = null;

        public Form1()
        {
            InitializeComponent();

            SetFormVals();
            DoLogin();

        }  
       
        #region events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SaveFormVals();
            DoLogin();

        }

        private void btnGetTeams_Click(object sender, EventArgs e)
        {
            //get teams
            AddToOutput("Getting teams..." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
            btnGetRepos.Enabled = false;
            btnGetBranches.Enabled = false;

            try
            {
                _TeamsEndpoint = _SharpBucket.TeamsEndPoint();

                var teams = _TeamsEndpoint.GetUserTeams();

                foreach (var team in teams)
                {
                    cbTeams.Items.Add(team.username);
                    AddToOutput(team.username + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
                    System.Windows.Forms.Application.DoEvents();

                }

                if (cbTeams.Items.Count > 0)
                {
                    cbTeams.SelectedIndex = 0;
                    btnGetRepos.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                AddToOutput("Error getting teams : " + ex.StackTrace + " - " + ex.Message + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_ERROR_COLOR);

            }

        }

        private void btnGetRepos_Click(object sender, EventArgs e)
        {
            SaveFormVals();

            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(backgroundWorker_getRepos);
            bgw.RunWorkerAsync();
           
        }

        public void backgroundWorker_getRepos(object sender, DoWorkEventArgs e)
        {
            //get teams
            AddToOutput("Getting repositories..." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
           
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                try
                {
                    cbRepos.Items.Clear();
                    System.Windows.Forms.Application.DoEvents();

                    btnGetBranches.Enabled = false;

                    var tr = _TeamsEndpoint.TeamResource(cbTeams.Text);

                    var teamrepo = tr.ListRepositories().OrderBy(t => t.name);

                    lblTotalRepos.Text = teamrepo.Count().ToString("N0");

                    System.Windows.Forms.Application.DoEvents();

                    foreach (var repo in teamrepo)
                    {
                        cbRepos.Items.Add(repo.name);
                        AddToOutput(repo.slug + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
                        System.Windows.Forms.Application.DoEvents();

                    }

                    if (cbRepos.Items.Count > 0)
                    {
                        cbRepos.SelectedIndex = 0;
                        btnGetBranches.Enabled = true;

                    }

                }
                catch (Exception ex)
                {
                    AddToOutput("Error getting repositories : " + ex.StackTrace + " - " + ex.Message + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_ERROR_COLOR);
                }

            });

        }

        private void btnGetBranches_Click(object sender, EventArgs e)
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(backgroundWorker_getBranches);
            bgw.RunWorkerAsync();

        }

        public void backgroundWorker_getBranches(object sender, DoWorkEventArgs e)
        {
            //get branches
            AddToOutput("Getting branches..." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
            
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                try
                {
                    dgBranches.Rows.Clear();
                    System.Windows.Forms.Application.DoEvents();

                    var rr = _TeamsEndpoint.TeamResource(cbTeams.Text).RepositoryResource(cbRepos.Text);
                    var branches = rr.BranchesResource.ListBranches();

                    lblTotalBranches.Text = branches.Count().ToString("N0");                  

                    List<string> branchesToFilter = null;
                   
                    branchesToFilter = txtBranchFilters.Text.ToLower().Split(',').ToList();

                    foreach (var b in branches)
                    {
                        //cbRepos.Items.Add(repo.name);
                        AddToOutput(b.name + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
                        System.Windows.Forms.Application.DoEvents();

                        bool filter = false;

                        //check branch name filter and short circuit if need be
                        foreach (string f in branchesToFilter)
                        {
                            if (f.Contains("*"))
                            {
                                //remove wilcard and filter by begins with
                                if (b.name.StartsWith(f.Replace("*", "")))
                                {
                                    filter = true;

                                }

                            }
                            else
                            {
                                if (b.name == f)
                                {
                                    filter = true;

                                }

                            }

                        }

                        if (!filter)
                        {
                            var firstCommit = rr.ListCommits(b.name, 1)[0];

                            if (cbShowOnlyMine.Checked)
                            {
                                filter = firstCommit.author.user == null || firstCommit.author.user.username != _UserProfile.username;

                            }

                            if (!filter)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dgBranches);
                                row.Cells[0].Value = b.name;
                                row.Cells[1].Value = firstCommit.author.user == null ? "N/A" : firstCommit.author.user.username;

                                dgBranches.Rows.Add(row);

                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    AddToOutput("Error getting branches : " + ex.StackTrace + " - " + ex.Message + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_ERROR_COLOR);

                }

            });

        }

        private void dgBranches_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgBranches.CurrentRow != null)
                {
                    contextMenuStrip1.Show(Cursor.Position);

                }

            }

        }

        private void viewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = $"https://bitbucket.org/{cbTeams.Text}/{cbRepos.Text}/branch/{dgBranches.SelectedRows[0].Cells[0].Value}";
            Process.Start(url);

        }

        private void deleteBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rr = _TeamsEndpoint.TeamResource(cbTeams.Text).RepositoryResource(cbRepos.Text);
            rr.DeleteBranch(dgBranches.SelectedRows[0].Cells[0].Value.ToString());

            //remove the branch from the row
            dgBranches.Rows.Remove(dgBranches.CurrentRow);

        } 

        #endregion             
        
        #region private helpers

        private void DoLogin()
        {
            AddToOutput("Logging in...." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);
            try
            {
                if (!string.IsNullOrWhiteSpace(txtConsumerKey.Text) && !string.IsNullOrWhiteSpace(txtConsumerSecret.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    _SharpBucket.OAuth2ClientCredentials(txtConsumerKey.Text, txtConsumerSecret.Text);

                    var userEndPoint = _SharpBucket.UsersEndPoint(Properties.Settings.Default.username);
                    _UserProfile = userEndPoint.GetProfile();
                    tsUserName.Text = _UserProfile.display_name + $" ({_UserProfile.username}) ";

                    mainTabs.SelectedIndex = 1;

                    AddToOutput("Login success." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_SUCCESS_COLOR);

                }
                else
                {
                    AddToOutput("Invalid login info." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_ERROR_COLOR);

                }

            }
            catch (Exception ex)
            {
                AddToOutput("Error during login : " + ex.StackTrace + " - " + ex.Message + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_ERROR_COLOR);

            }

        }       

        private void SetFormVals()
        {
            txtConsumerKey.Text = Properties.Settings.Default.clientid;
            txtConsumerSecret.Text = Properties.Settings.Default.secret;
            txtUsername.Text = Properties.Settings.Default.username;
            txtBranchFilters.Text = Properties.Settings.Default.repofilter;
            AddToOutput("Form values set." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);

        }

        private void SaveFormVals()
        {
            Properties.Settings.Default.clientid = txtConsumerKey.Text;
            Properties.Settings.Default.secret = txtConsumerSecret.Text;
            Properties.Settings.Default.username = txtUsername.Text;
            Properties.Settings.Default.repofilter = txtBranchFilters.Text;
            Properties.Settings.Default.Save();

            AddToOutput("Form values saved." + Environment.NewLine, false, GetTimeStamp(), _OUTPUT_COLOR);

        }

        private Color _OUTPUT_COLOR = Color.White;
        private Color _OUTPUT_ERROR_COLOR = Color.Red;
        private Color _OUTPUT_SUCCESS_COLOR = Color.Green;

        private void AddToOutput(string newText, bool addToAtc, string timestamp, Color? color = null)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {

                        if (txtOutput.Text.Length > 500000)
                        {
                            txtOutput.Text = "";
                        }
                        string output = timestamp + " - " + newText + Environment.NewLine;

                        txtOutput.SelectionStart = txtOutput.TextLength;
                        txtOutput.SelectionLength = 0;
                        txtOutput.SelectionColor = color ?? _OUTPUT_COLOR;

                        if (txtOutput.SelectionColor == Color.Red)
                        {
                            txtOutput.SelectionBackColor = Color.Black;
                        }

                        txtOutput.Text = txtOutput.Text.Insert(0, output);
                        txtOutput.SelectionColor = txtOutput.ForeColor;
                        txtOutput.SelectionBackColor = txtOutput.BackColor;
                        
                    });

                }
                else
                {
                    if (txtOutput.Text.Length > 500000)
                    {
                        txtOutput.Text = "";

                    }
                   
                    string output = timestamp + " - " + newText + Environment.NewLine;

                    txtOutput.SelectionStart = txtOutput.TextLength;
                    txtOutput.SelectionLength = 0;
                    txtOutput.SelectionColor = color ?? _OUTPUT_COLOR;

                    if (txtOutput.SelectionColor == Color.Red)
                    {
                        txtOutput.SelectionBackColor = Color.Black;

                    }

                    txtOutput.Text = txtOutput.Text.Insert(0, output);
                    txtOutput.SelectionColor = txtOutput.ForeColor;
                    txtOutput.SelectionBackColor = txtOutput.BackColor;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " - " + ex.StackTrace);
            }
        }

        private string GetTimeStamp()
        {
            return DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss.fff", CultureInfo.InvariantCulture);

        }

        #endregion

        private void exportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var headers = dgBranches.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgBranches.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));

            }

            using (System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog())
            {
                dialog.Filter = "csv files (*.csv)|*csv";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                dialog.FileName = string.Format("{0}_{1}.csv", _UserProfile.username, "branch-tidy-export");
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Can use dialog.FileName
                    System.IO.StreamWriter file = new System.IO.StreamWriter(dialog.FileName.ToString());
                    file.WriteLine(sb.ToString());
                    file.Close();
                }
            }
        }
    }

}
