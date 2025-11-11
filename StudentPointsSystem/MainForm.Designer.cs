using System . Drawing;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      partial class MainForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.MenuStrip menuStrip;
            private System.Windows.Forms.ToolStripMenuItem studentsMenu;
            private System.Windows.Forms.ToolStripMenuItem addStudentMenuItem;
            private System.Windows.Forms.ToolStripMenuItem manageStudentsMenuItem;
            private System.Windows.Forms.ToolStripMenuItem activitiesMenu;
            private System.Windows.Forms.ToolStripMenuItem recordActivityMenuItem;
            private System.Windows.Forms.ToolStripMenuItem recordBugBountyMenuItem;
            private System.Windows.Forms.ToolStripMenuItem calculateDailyPointsMenuItem;
            private System.Windows.Forms.ToolStripMenuItem reportsMenu;
            private System.Windows.Forms.ToolStripMenuItem weeklyLeaderboardMenuItem;
            private System.Windows.Forms.ToolStripMenuItem studentPerformanceMenuItem;
            private System.Windows.Forms.ToolStripMenuItem projectsMenu;
            private System.Windows.Forms.ToolStripMenuItem addProjectGradeMenuItem;
            private System.Windows.Forms.ToolStripMenuItem viewProjectsMenuItem;
            private System.Windows.Forms.Panel dashboardPanel;
            private System.Windows.Forms.Label titleLabel;
            private System.Windows.Forms.Panel statsPanel;
            private System.Windows.Forms.Label lblActiveStudents;
            private System.Windows.Forms.Label lblTodayActivities;
            private System.Windows.Forms.Label lblPendingCalculation;
            private System.Windows.Forms.Panel actionsPanel;
            private System.Windows.Forms.Label actionsTitle;
            private System.Windows.Forms.Button btnAddStudent;
            private System.Windows.Forms.Button btnRecordActivity;
            private System.Windows.Forms.Button btnCalculatePoints;
            private System.Windows.Forms.Button btnLeaderboard;
            private System.Windows.Forms.DataGridView dgvRecentActivities;

            protected override void Dispose ( bool disposing )
            {
                  if ( disposing && ( components != null ) )
                  {
                        components . Dispose ( );
                  }
                  base . Dispose ( disposing );
            }

            private void InitializeComponent ( )
            {
                  this.menuStrip = new System.Windows.Forms.MenuStrip();
                  this.studentsMenu = new System.Windows.Forms.ToolStripMenuItem();
                  this.addStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.manageStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.activitiesMenu = new System.Windows.Forms.ToolStripMenuItem();
                  this.recordActivityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.recordBugBountyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.calculateDailyPointsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
                  this.weeklyLeaderboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.studentPerformanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.projectsMenu = new System.Windows.Forms.ToolStripMenuItem();
                  this.addProjectGradeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.viewProjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.dashboardPanel = new System.Windows.Forms.Panel();
                  this.actionsPanel = new System.Windows.Forms.Panel();
                  this.dgvRecentActivities = new System.Windows.Forms.DataGridView();
                  this.btnLeaderboard = new System.Windows.Forms.Button();
                  this.btnCalculatePoints = new System.Windows.Forms.Button();
                  this.btnRecordActivity = new System.Windows.Forms.Button();
                  this.btnAddStudent = new System.Windows.Forms.Button();
                  this.actionsTitle = new System.Windows.Forms.Label();
                  this.statsPanel = new System.Windows.Forms.Panel();
                  this.lblPendingCalculation = new System.Windows.Forms.Label();
                  this.lblTodayActivities = new System.Windows.Forms.Label();
                  this.lblActiveStudents = new System.Windows.Forms.Label();
                  this.titleLabel = new System.Windows.Forms.Label();
                  this.menuStrip.SuspendLayout();
                  this.dashboardPanel.SuspendLayout();
                  this.actionsPanel.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).BeginInit();
                  this.statsPanel.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // menuStrip
                  // 
                  this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsMenu,
            this.activitiesMenu,
            this.reportsMenu,
            this.projectsMenu});
                  this.menuStrip.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip.Name = "menuStrip";
                  this.menuStrip.Size = new System.Drawing.Size(1200, 24);
                  this.menuStrip.TabIndex = 0;
                  this.menuStrip.Text = "menuStrip1";
                  // 
                  // studentsMenu
                  // 
                  this.studentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentMenuItem,
            this.manageStudentsMenuItem});
                  this.studentsMenu.Name = "studentsMenu";
                  this.studentsMenu.Size = new System.Drawing.Size(65, 20);
                  this.studentsMenu.Text = "Students";
                  // 
                  // addStudentMenuItem
                  // 
                  this.addStudentMenuItem.Name = "addStudentMenuItem";
                  this.addStudentMenuItem.Size = new System.Drawing.Size(167, 22);
                  this.addStudentMenuItem.Text = "Add New Student";
                  this.addStudentMenuItem.Click += new System.EventHandler(this.AddStudent_Click);
                  // 
                  // manageStudentsMenuItem
                  // 
                  this.manageStudentsMenuItem.Name = "manageStudentsMenuItem";
                  this.manageStudentsMenuItem.Size = new System.Drawing.Size(167, 22);
                  this.manageStudentsMenuItem.Text = "Manage Students";
                  this.manageStudentsMenuItem.Click += new System.EventHandler(this.ManageStudents_Click);
                  // 
                  // activitiesMenu
                  // 
                  this.activitiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordActivityMenuItem,
            this.recordBugBountyMenuItem,
            this.calculateDailyPointsMenuItem});
                  this.activitiesMenu.Name = "activitiesMenu";
                  this.activitiesMenu.Size = new System.Drawing.Size(67, 20);
                  this.activitiesMenu.Text = "Activities";
                  // 
                  // recordActivityMenuItem
                  // 
                  this.recordActivityMenuItem.Name = "recordActivityMenuItem";
                  this.recordActivityMenuItem.Size = new System.Drawing.Size(188, 22);
                  this.recordActivityMenuItem.Text = "Record Daily Activity";
                  this.recordActivityMenuItem.Click += new System.EventHandler(this.RecordActivity_Click);
                  // 
                  // recordBugBountyMenuItem
                  // 
                  this.recordBugBountyMenuItem.Name = "recordBugBountyMenuItem";
                  this.recordBugBountyMenuItem.Size = new System.Drawing.Size(188, 22);
                  this.recordBugBountyMenuItem.Text = "Record Bug Bounty";
                  this.recordBugBountyMenuItem.Click += new System.EventHandler(this.RecordBugBounty_Click);
                  // 
                  // calculateDailyPointsMenuItem
                  // 
                  this.calculateDailyPointsMenuItem.Name = "calculateDailyPointsMenuItem";
                  this.calculateDailyPointsMenuItem.Size = new System.Drawing.Size(188, 22);
                  this.calculateDailyPointsMenuItem.Text = "Calculate Daily Points";
                  this.calculateDailyPointsMenuItem.Click += new System.EventHandler(this.CalculateDailyPoints_Click);
                  // 
                  // reportsMenu
                  // 
                  this.reportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weeklyLeaderboardMenuItem,
            this.studentPerformanceMenuItem});
                  this.reportsMenu.Name = "reportsMenu";
                  this.reportsMenu.Size = new System.Drawing.Size(59, 20);
                  this.reportsMenu.Text = "Reports";
                  // 
                  // weeklyLeaderboardMenuItem
                  // 
                  this.weeklyLeaderboardMenuItem.Name = "weeklyLeaderboardMenuItem";
                  this.weeklyLeaderboardMenuItem.Size = new System.Drawing.Size(186, 22);
                  this.weeklyLeaderboardMenuItem.Text = "Weekly Leaderboard";
                  this.weeklyLeaderboardMenuItem.Click += new System.EventHandler(this.ShowLeaderboard_Click);
                  // 
                  // studentPerformanceMenuItem
                  // 
                  this.studentPerformanceMenuItem.Name = "studentPerformanceMenuItem";
                  this.studentPerformanceMenuItem.Size = new System.Drawing.Size(186, 22);
                  this.studentPerformanceMenuItem.Text = "Student Performance";
                  this.studentPerformanceMenuItem.Click += new System.EventHandler(this.ShowStudentPerformance_Click);
                  // 
                  // projectsMenu
                  // 
                  this.projectsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectGradeMenuItem,
            this.viewProjectsMenuItem});
                  this.projectsMenu.Name = "projectsMenu";
                  this.projectsMenu.Size = new System.Drawing.Size(61, 20);
                  this.projectsMenu.Text = "Projects";
                  // 
                  // addProjectGradeMenuItem
                  // 
                  this.addProjectGradeMenuItem.Name = "addProjectGradeMenuItem";
                  this.addProjectGradeMenuItem.Size = new System.Drawing.Size(170, 22);
                  this.addProjectGradeMenuItem.Text = "Add Project Grade";
                  this.addProjectGradeMenuItem.Click += new System.EventHandler(this.AddProjectGrade_Click);
                  // 
                  // viewProjectsMenuItem
                  // 
                  this.viewProjectsMenuItem.Name = "viewProjectsMenuItem";
                  this.viewProjectsMenuItem.Size = new System.Drawing.Size(170, 22);
                  this.viewProjectsMenuItem.Text = "View Projects";
                  this.viewProjectsMenuItem.Click += new System.EventHandler(this.ViewProjects_Click);
                  // 
                  // dashboardPanel
                  // 
                  this.dashboardPanel.Controls.Add(this.actionsPanel);
                  this.dashboardPanel.Controls.Add(this.statsPanel);
                  this.dashboardPanel.Controls.Add(this.titleLabel);
                  this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.dashboardPanel.Location = new System.Drawing.Point(0, 24);
                  this.dashboardPanel.Name = "dashboardPanel";
                  this.dashboardPanel.Padding = new System.Windows.Forms.Padding(20);
                  this.dashboardPanel.Size = new System.Drawing.Size(1200, 676);
                  this.dashboardPanel.TabIndex = 1;
                  // 
                  // actionsPanel
                  // 
                  this.actionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                  this.actionsPanel.Controls.Add(this.dgvRecentActivities);
                  this.actionsPanel.Controls.Add(this.btnLeaderboard);
                  this.actionsPanel.Controls.Add(this.btnCalculatePoints);
                  this.actionsPanel.Controls.Add(this.btnRecordActivity);
                  this.actionsPanel.Controls.Add(this.btnAddStudent);
                  this.actionsPanel.Controls.Add(this.actionsTitle);
                  this.actionsPanel.Location = new System.Drawing.Point(20, 270);
                  this.actionsPanel.Name = "actionsPanel";
                  this.actionsPanel.Size = new System.Drawing.Size(1140, 350);
                  this.actionsPanel.TabIndex = 2;
                  // 
                  // dgvRecentActivities
                  // 
                  this.dgvRecentActivities.AllowUserToAddRows = false;
                  this.dgvRecentActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                  this.dgvRecentActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.dgvRecentActivities.Location = new System.Drawing.Point(20, 120);
                  this.dgvRecentActivities.Name = "dgvRecentActivities";
                  this.dgvRecentActivities.ReadOnly = true;
                  this.dgvRecentActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.dgvRecentActivities.Size = new System.Drawing.Size(1100, 210);
                  this.dgvRecentActivities.TabIndex = 5;
                  // 
                  // btnLeaderboard
                  // 
                  this.btnLeaderboard.Font = new System.Drawing.Font("Segoe UI", 11F);
                  this.btnLeaderboard.Location = new System.Drawing.Point(830, 50);
                  this.btnLeaderboard.Name = "btnLeaderboard";
                  this.btnLeaderboard.Size = new System.Drawing.Size(250, 50);
                  this.btnLeaderboard.TabIndex = 4;
                  this.btnLeaderboard.Text = "View Leaderboard";
                  this.btnLeaderboard.UseVisualStyleBackColor = true;
                  this.btnLeaderboard.Click += new System.EventHandler(this.ShowLeaderboard_Click);
                  // 
                  // btnCalculatePoints
                  // 
                  this.btnCalculatePoints.Font = new System.Drawing.Font("Segoe UI", 11F);
                  this.btnCalculatePoints.Location = new System.Drawing.Point(560, 50);
                  this.btnCalculatePoints.Name = "btnCalculatePoints";
                  this.btnCalculatePoints.Size = new System.Drawing.Size(250, 50);
                  this.btnCalculatePoints.TabIndex = 3;
                  this.btnCalculatePoints.Text = "Calculate Daily Points";
                  this.btnCalculatePoints.UseVisualStyleBackColor = true;
                  this.btnCalculatePoints.Click += new System.EventHandler(this.CalculateDailyPoints_Click);
                  // 
                  // btnRecordActivity
                  // 
                  this.btnRecordActivity.Font = new System.Drawing.Font("Segoe UI", 11F);
                  this.btnRecordActivity.Location = new System.Drawing.Point(290, 50);
                  this.btnRecordActivity.Name = "btnRecordActivity";
                  this.btnRecordActivity.Size = new System.Drawing.Size(250, 50);
                  this.btnRecordActivity.TabIndex = 2;
                  this.btnRecordActivity.Text = "Record Daily Activity";
                  this.btnRecordActivity.UseVisualStyleBackColor = true;
                  this.btnRecordActivity.Click += new System.EventHandler(this.RecordActivity_Click);
                  // 
                  // btnAddStudent
                  // 
                  this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 11F);
                  this.btnAddStudent.Location = new System.Drawing.Point(20, 50);
                  this.btnAddStudent.Name = "btnAddStudent";
                  this.btnAddStudent.Size = new System.Drawing.Size(250, 50);
                  this.btnAddStudent.TabIndex = 1;
                  this.btnAddStudent.Text = "Add New Student";
                  this.btnAddStudent.UseVisualStyleBackColor = true;
                  this.btnAddStudent.Click += new System.EventHandler(this.AddStudent_Click);
                  // 
                  // actionsTitle
                  // 
                  this.actionsTitle.AutoSize = true;
                  this.actionsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                  this.actionsTitle.Location = new System.Drawing.Point(20, 10);
                  this.actionsTitle.Name = "actionsTitle";
                  this.actionsTitle.Size = new System.Drawing.Size(155, 30);
                  this.actionsTitle.TabIndex = 0;
                  this.actionsTitle.Text = "Quick Actions";
                  // 
                  // statsPanel
                  // 
                  this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                  this.statsPanel.Controls.Add(this.lblPendingCalculation);
                  this.statsPanel.Controls.Add(this.lblTodayActivities);
                  this.statsPanel.Controls.Add(this.lblActiveStudents);
                  this.statsPanel.Location = new System.Drawing.Point(20, 100);
                  this.statsPanel.Name = "statsPanel";
                  this.statsPanel.Size = new System.Drawing.Size(1140, 150);
                  this.statsPanel.TabIndex = 1;
                  // 
                  // lblPendingCalculation
                  // 
                  this.lblPendingCalculation.AutoSize = true;
                  this.lblPendingCalculation.Font = new System.Drawing.Font("Segoe UI", 14F);
                  this.lblPendingCalculation.Location = new System.Drawing.Point(20, 100);
                  this.lblPendingCalculation.Name = "lblPendingCalculation";
                  this.lblPendingCalculation.Size = new System.Drawing.Size(208, 25);
                  this.lblPendingCalculation.TabIndex = 2;
                  this.lblPendingCalculation.Text = "Pending Calculations: 0";
                  // 
                  // lblTodayActivities
                  // 
                  this.lblTodayActivities.AutoSize = true;
                  this.lblTodayActivities.Font = new System.Drawing.Font("Segoe UI", 14F);
                  this.lblTodayActivities.Location = new System.Drawing.Point(20, 60);
                  this.lblTodayActivities.Name = "lblTodayActivities";
                  this.lblTodayActivities.Size = new System.Drawing.Size(172, 25);
                  this.lblTodayActivities.TabIndex = 1;
                  this.lblTodayActivities.Text = "Today\'s Activities: 0";
                  // 
                  // lblActiveStudents
                  // 
                  this.lblActiveStudents.AutoSize = true;
                  this.lblActiveStudents.Font = new System.Drawing.Font("Segoe UI", 14F);
                  this.lblActiveStudents.Location = new System.Drawing.Point(20, 20);
                  this.lblActiveStudents.Name = "lblActiveStudents";
                  this.lblActiveStudents.Size = new System.Drawing.Size(159, 25);
                  this.lblActiveStudents.TabIndex = 0;
                  this.lblActiveStudents.Text = "Active Students: 0";
                  // 
                  // titleLabel
                  // 
                  this.titleLabel.AutoSize = true;
                  this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
                  this.titleLabel.Location = new System.Drawing.Point(20, 40);
                  this.titleLabel.Name = "titleLabel";
                  this.titleLabel.Size = new System.Drawing.Size(469, 32);
                  this.titleLabel.TabIndex = 0;
                  this.titleLabel.Text = "Student Points Management Dashboard";
                  // 
                  // MainForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1200, 700);
                  this.Controls.Add(this.dashboardPanel);
                  this.Controls.Add(this.menuStrip);
                  this.MainMenuStrip = this.menuStrip;
                  this.Name = "MainForm";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "Student Points Management System";
                  this.Load += new System.EventHandler(this.MainForm_Load);
                  this.menuStrip.ResumeLayout(false);
                  this.menuStrip.PerformLayout();
                  this.dashboardPanel.ResumeLayout(false);
                  this.dashboardPanel.PerformLayout();
                  this.actionsPanel.ResumeLayout(false);
                  this.actionsPanel.PerformLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).EndInit();
                  this.statsPanel.ResumeLayout(false);
                  this.statsPanel.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }
      }
}