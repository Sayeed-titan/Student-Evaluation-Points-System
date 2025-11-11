namespace StudentPointsSystem
{
      partial class ViewProjectsForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.DataGridView dgvProjects;
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
                  this . dgvProjects = new System . Windows . Forms . DataGridView ( );
                  this . btnClose = new System . Windows . Forms . Button ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvProjects ) ) . BeginInit ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 18F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 167 , 32 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Project Grades";
                  // 
                  // dgvProjects
                  // 
                  this . dgvProjects . AllowUserToAddRows = false;
                  this . dgvProjects . AutoSizeColumnsMode = System . Windows . Forms . DataGridViewAutoSizeColumnsMode . Fill;
                  this . dgvProjects . ColumnHeadersHeightSizeMode = System . Windows . Forms . DataGridViewColumnHeadersHeightSizeMode . AutoSize;
                  this . dgvProjects . Location = new System . Drawing . Point ( 20 , 70 );
                  this . dgvProjects . Name = "dgvProjects";
                  this . dgvProjects . ReadOnly = true;
                  this . dgvProjects . SelectionMode = System . Windows . Forms . DataGridViewSelectionMode . FullRowSelect;
                  this . dgvProjects . Size = new System . Drawing . Size ( 1140 , 500 );
                  this . dgvProjects . TabIndex = 1;
                  // 
                  // btnClose
                  // 
                  this . btnClose . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnClose . Location = new System . Drawing . Point ( 1060 , 580 );
                  this . btnClose . Name = "btnClose";
                  this . btnClose . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnClose . TabIndex = 2;
                  this . btnClose . Text = "Close";
                  this . btnClose . UseVisualStyleBackColor = true;
                  this . btnClose . Click += new System . EventHandler ( this . BtnClose_Click );
                  // 
                  // ViewProjectsForm
                  // 
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . ClientSize = new System . Drawing . Size ( 1184 , 631 );
                  this . Controls . Add ( this . btnClose );
                  this . Controls . Add ( this . dgvProjects );
                  this . Controls . Add ( this . lblTitle );
                  this . Name = "ViewProjectsForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "View Projects";
                  this . Load += new System . EventHandler ( this . ViewProjectsForm_Load );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . dgvProjects ) ) . EndInit ( );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }

            private void BtnClose_Click ( object sender , System . EventArgs e )
            {
                  this . Close ( );
            }
      }
}