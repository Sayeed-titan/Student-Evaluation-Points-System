namespace StudentPointsSystem
{
      partial class LeaderboardForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblWeekStart;
            private System.Windows.Forms.DateTimePicker dtpWeekStart;
            private System.Windows.Forms.Button btnLoad;
            private System.Windows.Forms.Button btnSaveSummary;
            private System.Windows.Forms.DataGridView dgvLeaderboard;
            private System.Windows.Forms.Button btnClose;

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
                  this . lblTitle = new System . Windows . Forms . Label ( );
                  this . lblWeekStart = new System . Windows . Forms . Label ( );
                  this . dtpWeekStart = new System . Windows . Forms . DateTimePicker ( );
                  this . btnLoad = new System . Windows . Forms . Button ( );
                  this . btnSaveSummary = new System . Windows . Forms . Button ( );
                  this . dgvLeaderboard = new System . Windows . Forms . DataGridView ( );
                  this . btnClose = new System . Windows . Forms . Button ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvLeaderboard ) ) . BeginInit ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 18F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 218 , 32 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Weekly Leaderboard";
                  // 
                  // lblWeekStart
                  // 
                  this . lblWeekStart . AutoSize = true;
                  this . lblWeekStart . Location = new System . Drawing . Point ( 20 , 70 );
                  this . lblWeekStart . Name = "lblWeekStart";
                  this . lblWeekStart . Size = new System . Drawing . Size ( 76 , 13 );
                  this . lblWeekStart . TabIndex = 1;
                  this . lblWeekStart . Text = "Week Starting:";
                  // 
                  // dtpWeekStart
                  // 
                  this . dtpWeekStart . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpWeekStart . Location = new System . Drawing . Point ( 130 , 67 );
                  this . dtpWeekStart . Name = "dtpWeekStart";
                  this . dtpWeekStart . Size = new System . Drawing . Size ( 200 , 20 );
                  this . dtpWeekStart . TabIndex = 2;
                  // 
                  // btnLoad
                  // 
                  this . btnLoad . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnLoad . Location = new System . Drawing . Point ( 350 , 60 );
                  this . btnLoad . Name = "btnLoad";
                  this . btnLoad . Size = new System . Drawing . Size ( 140 , 35 );
                  this . btnLoad . TabIndex = 3;
                  this . btnLoad . Text = "Load Leaderboard";
                  this . btnLoad . UseVisualStyleBackColor = true;
                  this . btnLoad . Click += new System . EventHandler ( this . BtnLoad_Click );
                  // 
                  // btnSaveSummary
                  // 
                  this . btnSaveSummary . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnSaveSummary . Location = new System . Drawing . Point ( 510 , 60 );
                  this . btnSaveSummary . Name = "btnSaveSummary";
                  this . btnSaveSummary . Size = new System . Drawing . Size ( 160 , 35 );
                  this . btnSaveSummary . TabIndex = 4;
                  this . btnSaveSummary . Text = "Save Weekly Summary";
                  this . btnSaveSummary . UseVisualStyleBackColor = true;
                  this . btnSaveSummary . Click += new System . EventHandler ( this . BtnSaveSummary_Click );
                  // 
                  // dgvLeaderboard
                  // 
                  this . dgvLeaderboard . AllowUserToAddRows = false;
                  this . dgvLeaderboard . AutoSizeColumnsMode = System . Windows . Forms . DataGridViewAutoSizeColumnsMode . Fill;
                  this . dgvLeaderboard . ColumnHeadersHeightSizeMode = System . Windows . Forms . DataGridViewColumnHeadersHeightSizeMode . AutoSize;
                  this . dgvLeaderboard . Location = new System . Drawing . Point ( 20 , 120 );
                  this . dgvLeaderboard . Name = "dgvLeaderboard";
                  this . dgvLeaderboard . ReadOnly = true;
                  this . dgvLeaderboard . SelectionMode = System . Windows . Forms . DataGridViewSelectionMode . FullRowSelect;
                  this . dgvLeaderboard . Size = new System . Drawing . Size ( 840 , 450 );
                  this . dgvLeaderboard . TabIndex = 5;
                  // 
                  // btnClose
                  // 
                  this . btnClose . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnClose . Location = new System . Drawing . Point ( 760 , 580 );
                  this . btnClose . Name = "btnClose";
                  this . btnClose . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnClose . TabIndex = 6;
                  this . btnClose . Text = "Close";
                  this . btnClose . UseVisualStyleBackColor = true;
                  this . btnClose . Click += new System . EventHandler ( this . BtnClose_Click );
                  // 
                  // LeaderboardForm
                  // 
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . ClientSize = new System . Drawing . Size ( 884 , 631 );
                  this . Controls . Add ( this . btnClose );
                  this . Controls . Add ( this . dgvLeaderboard );
                  this . Controls . Add ( this . btnSaveSummary );
                  this . Controls . Add ( this . btnLoad );
                  this . Controls . Add ( this . dtpWeekStart );
                  this . Controls . Add ( this . lblWeekStart );
                  this . Controls . Add ( this . lblTitle );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedSingle;
                  this . MaximizeBox = false;
                  this . Name = "LeaderboardForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Weekly Leaderboard";
                  this . Load += new System . EventHandler ( this . LeaderboardForm_Load );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvLeaderboard ) ) . EndInit ( );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }

            private void BtnClose_Click ( object sender , System . EventArgs e )
            {
                  this . Close ( );
            }
      }
}