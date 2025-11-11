namespace StudentPointsSystem
{
      partial class ManageStudentsForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.DataGridView dgvStudents;
            private System.Windows.Forms.Button btnDeactivate;
            private System.Windows.Forms.Button btnActivate;
            private System.Windows.Forms.Button btnRefresh;
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
                  this . dgvStudents = new System . Windows . Forms . DataGridView ( );
                  this . btnDeactivate = new System . Windows . Forms . Button ( );
                  this . btnActivate = new System . Windows . Forms . Button ( );
                  this . btnRefresh = new System . Windows . Forms . Button ( );
                  this . btnClose = new System . Windows . Forms . Button ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvStudents ) ) . BeginInit ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 16F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 177 , 30 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Manage Students";
                  // 
                  // dgvStudents
                  // 
                  this . dgvStudents . AllowUserToAddRows = false;
                  this . dgvStudents . AutoSizeColumnsMode = System . Windows . Forms . DataGridViewAutoSizeColumnsMode . Fill;
                  this . dgvStudents . ColumnHeadersHeightSizeMode = System . Windows . Forms . DataGridViewColumnHeadersHeightSizeMode . AutoSize;
                  this . dgvStudents . Location = new System . Drawing . Point ( 20 , 70 );
                  this . dgvStudents . Name = "dgvStudents";
                  this . dgvStudents . ReadOnly = true;
                  this . dgvStudents . SelectionMode = System . Windows . Forms . DataGridViewSelectionMode . FullRowSelect;
                  this . dgvStudents . Size = new System . Drawing . Size ( 840 , 420 );
                  this . dgvStudents . TabIndex = 1;
                  // 
                  // btnDeactivate
                  // 
                  this . btnDeactivate . Location = new System . Drawing . Point ( 20 , 510 );
                  this . btnDeactivate . Name = "btnDeactivate";
                  this . btnDeactivate . Size = new System . Drawing . Size ( 150 , 35 );
                  this . btnDeactivate . TabIndex = 2;
                  this . btnDeactivate . Text = "Deactivate Selected";
                  this . btnDeactivate . UseVisualStyleBackColor = true;
                  this . btnDeactivate . Click += new System . EventHandler ( this . BtnDeactivate_Click );
                  // 
                  // btnActivate
                  // 
                  this . btnActivate . Location = new System . Drawing . Point ( 190 , 510 );
                  this . btnActivate . Name = "btnActivate";
                  this . btnActivate . Size = new System . Drawing . Size ( 150 , 35 );
                  this . btnActivate . TabIndex = 3;
                  this . btnActivate . Text = "Activate Selected";
                  this . btnActivate . UseVisualStyleBackColor = true;
                  this . btnActivate . Click += new System . EventHandler ( this . BtnActivate_Click );
                  // 
                  // btnRefresh
                  // 
                  this . btnRefresh . Location = new System . Drawing . Point ( 360 , 510 );
                  this . btnRefresh . Name = "btnRefresh";
                  this . btnRefresh . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnRefresh . TabIndex = 4;
                  this . btnRefresh . Text = "Refresh";
                  this . btnRefresh . UseVisualStyleBackColor = true;
                  this . btnRefresh . Click += new System . EventHandler ( this . BtnRefresh_Click );
                  // 
                  // btnClose
                  // 
                  this . btnClose . Location = new System . Drawing . Point ( 760 , 510 );
                  this . btnClose . Name = "btnClose";
                  this . btnClose . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnClose . TabIndex = 5;
                  this . btnClose . Text = "Close";
                  this . btnClose . UseVisualStyleBackColor = true;
                  this . btnClose . Click += new System . EventHandler ( this . BtnClose_Click );
                  // 
                  // ManageStudentsForm
                  // 
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . ClientSize = new System . Drawing . Size ( 884 , 561 );
                  this . Controls . Add ( this . btnClose );
                  this . Controls . Add ( this . btnRefresh );
                  this . Controls . Add ( this . btnActivate );
                  this . Controls . Add ( this . btnDeactivate );
                  this . Controls . Add ( this . dgvStudents );
                  this . Controls . Add ( this . lblTitle );
                  this . Name = "ManageStudentsForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Manage Students";
                  //this . Load += new System . EventHandler ( this . ManageStudentsForm_Load );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvStudents ) ) . EndInit ( );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }

            private void BtnClose_Click ( object sender , System . EventArgs e )
            {
                  this . Close ( );
            }

            private void BtnRefresh_Click ( object sender , System . EventArgs e )
            {
                  LoadStudents ( );
            }
      }
}
