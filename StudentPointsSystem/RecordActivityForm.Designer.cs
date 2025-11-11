namespace StudentPointsSystem
{
      partial class RecordActivityForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblStudent;
            private System.Windows.Forms.ComboBox cboStudent;
            private System.Windows.Forms.Label lblActivity;
            private System.Windows.Forms.ComboBox cboActivity;
            private System.Windows.Forms.Label lblPoints;
            private System.Windows.Forms.TextBox txtPoints;
            private System.Windows.Forms.Label lblDate;
            private System.Windows.Forms.DateTimePicker dtpDate;
            private System.Windows.Forms.Label lblNotes;
            private System.Windows.Forms.TextBox txtNotes;
            private System.Windows.Forms.Button btnSave;
            private System.Windows.Forms.Button btnSaveAndNew;
            private System.Windows.Forms.Button btnCancel;

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
                  this . lblStudent = new System . Windows . Forms . Label ( );
                  this . cboStudent = new System . Windows . Forms . ComboBox ( );
                  this . lblActivity = new System . Windows . Forms . Label ( );
                  this . cboActivity = new System . Windows . Forms . ComboBox ( );
                  this . lblPoints = new System . Windows . Forms . Label ( );
                  this . txtPoints = new System . Windows . Forms . TextBox ( );
                  this . lblDate = new System . Windows . Forms . Label ( );
                  this . dtpDate = new System . Windows . Forms . DateTimePicker ( );
                  this . lblNotes = new System . Windows . Forms . Label ( );
                  this . txtNotes = new System . Windows . Forms . TextBox ( );
                  this . btnSave = new System . Windows . Forms . Button ( );
                  this . btnSaveAndNew = new System . Windows . Forms . Button ( );
                  this . btnCancel = new System . Windows . Forms . Button ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 16F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 217 , 30 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Record Daily Activity";
                  // 
                  // lblStudent
                  // 
                  this . lblStudent . AutoSize = true;
                  this . lblStudent . Location = new System . Drawing . Point ( 20 , 80 );
                  this . lblStudent . Name = "lblStudent";
                  this . lblStudent . Size = new System . Drawing . Size ( 80 , 13 );
                  this . lblStudent . TabIndex = 1;
                  this . lblStudent . Text = "Select Student:";
                  // 
                  // cboStudent
                  // 
                  this . cboStudent . DropDownStyle = System . Windows . Forms . ComboBoxStyle . DropDownList;
                  this . cboStudent . FormattingEnabled = true;
                  this . cboStudent . Location = new System . Drawing . Point ( 160 , 77 );
                  this . cboStudent . Name = "cboStudent";
                  this . cboStudent . Size = new System . Drawing . Size ( 400 , 21 );
                  this . cboStudent . TabIndex = 2;
                  // 
                  // lblActivity
                  // 
                  this . lblActivity . AutoSize = true;
                  this . lblActivity . Location = new System . Drawing . Point ( 20 , 120 );
                  this . lblActivity . Name = "lblActivity";
                  this . lblActivity . Size = new System . Drawing . Size ( 73 , 13 );
                  this . lblActivity . TabIndex = 3;
                  this . lblActivity . Text = "Activity Type:";
                  // 
                  // cboActivity
                  // 
                  this . cboActivity . DropDownStyle = System . Windows . Forms . ComboBoxStyle . DropDownList;
                  this . cboActivity . FormattingEnabled = true;
                  this . cboActivity . Location = new System . Drawing . Point ( 160 , 117 );
                  this . cboActivity . Name = "cboActivity";
                  this . cboActivity . Size = new System . Drawing . Size ( 400 , 21 );
                  this . cboActivity . TabIndex = 4;
                  this . cboActivity . SelectedIndexChanged += new System . EventHandler ( this . CboActivity_SelectedIndexChanged );
                  // 
                  // lblPoints
                  // 
                  this . lblPoints . AutoSize = true;
                  this . lblPoints . Location = new System . Drawing . Point ( 20 , 160 );
                  this . lblPoints . Name = "lblPoints";
                  this . lblPoints . Size = new System . Drawing . Size ( 39 , 13 );
                  this . lblPoints . TabIndex = 5;
                  this . lblPoints . Text = "Points:";
                  // 
                  // txtPoints
                  // 
                  this . txtPoints . Location = new System . Drawing . Point ( 160 , 157 );
                  this . txtPoints . Name = "txtPoints";
                  this . txtPoints . ReadOnly = true;
                  this . txtPoints . Size = new System . Drawing . Size ( 100 , 20 );
                  this . txtPoints . TabIndex = 6;
                  // 
                  // lblDate
                  // 
                  this . lblDate . AutoSize = true;
                  this . lblDate . Location = new System . Drawing . Point ( 20 , 200 );
                  this . lblDate . Name = "lblDate";
                  this . lblDate . Size = new System . Drawing . Size ( 71 , 13 );
                  this . lblDate . TabIndex = 7;
                  this . lblDate . Text = "Activity Date:";
                  // 
                  // dtpDate
                  // 
                  this . dtpDate . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpDate . Location = new System . Drawing . Point ( 160 , 197 );
                  this . dtpDate . Name = "dtpDate";
                  this . dtpDate . Size = new System . Drawing . Size ( 400 , 20 );
                  this . dtpDate . TabIndex = 8;
                  // 
                  // lblNotes
                  // 
                  this . lblNotes . AutoSize = true;
                  this . lblNotes . Location = new System . Drawing . Point ( 20 , 240 );
                  this . lblNotes . Name = "lblNotes";
                  this . lblNotes . Size = new System . Drawing . Size ( 38 , 13 );
                  this . lblNotes . TabIndex = 9;
                  this . lblNotes . Text = "Notes:";
                  // 
                  // txtNotes
                  // 
                  this . txtNotes . Location = new System . Drawing . Point ( 160 , 237 );
                  this . txtNotes . Multiline = true;
                  this . txtNotes . Name = "txtNotes";
                  this . txtNotes . ScrollBars = System . Windows . Forms . ScrollBars . Vertical;
                  this . txtNotes . Size = new System . Drawing . Size ( 400 , 80 );
                  this . txtNotes . TabIndex = 10;
                  // 
                  // btnSave
                  // 
                  this . btnSave . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnSave . Location = new System . Drawing . Point ( 160 , 370 );
                  this . btnSave . Name = "btnSave";
                  this . btnSave . Size = new System . Drawing . Size ( 130 , 40 );
                  this . btnSave . TabIndex = 11;
                  this . btnSave . Text = "Save Activity";
                  this . btnSave . UseVisualStyleBackColor = true;
                  this . btnSave . Click += new System . EventHandler ( this . BtnSave_Click );
                  // 
                  // btnSaveAndNew
                  // 
                  this . btnSaveAndNew . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnSaveAndNew . Location = new System . Drawing . Point ( 310 , 370 );
                  this . btnSaveAndNew . Name = "btnSaveAndNew";
                  this . btnSaveAndNew . Size = new System . Drawing . Size ( 130 , 40 );
                  this . btnSaveAndNew . TabIndex = 12;
                  this . btnSaveAndNew . Text = "Save && Add New";
                  this . btnSaveAndNew . UseVisualStyleBackColor = true;
                  this . btnSaveAndNew . Click += new System . EventHandler ( this . BtnSaveAndNew_Click );
                  // 
                  // btnCancel
                  // 
                  this . btnCancel . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnCancel . Location = new System . Drawing . Point ( 460 , 370 );
                  this . btnCancel . Name = "btnCancel";
                  this . btnCancel . Size = new System . Drawing . Size ( 100 , 40 );
                  this . btnCancel . TabIndex = 13;
                  this . btnCancel . Text = "Close";
                  this . btnCancel . UseVisualStyleBackColor = true;
                  this . btnCancel . Click += new System . EventHandler ( this . BtnCancel_Click );
                  // 
                  // RecordActivityForm
                  // 
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . ClientSize = new System . Drawing . Size ( 584 , 441 );
                  this . Controls . Add ( this . btnCancel );
                  this . Controls . Add ( this . btnSaveAndNew );
                  this . Controls . Add ( this . btnSave );
                  this . Controls . Add ( this . txtNotes );
                  this . Controls . Add ( this . lblNotes );
                  this . Controls . Add ( this . dtpDate );
                  this . Controls . Add ( this . lblDate );
                  this . Controls . Add ( this . txtPoints );
                  this . Controls . Add ( this . lblPoints );
                  this . Controls . Add ( this . cboActivity );
                  this . Controls . Add ( this . lblActivity );
                  this . Controls . Add ( this . cboStudent );
                  this . Controls . Add ( this . lblStudent );
                  this . Controls . Add ( this . lblTitle );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedDialog;
                  this . MaximizeBox = false;
                  this . Name = "RecordActivityForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Record Daily Activity";
                  this . Load += new System . EventHandler ( this . RecordActivityForm_Load );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }

            private void BtnCancel_Click ( object sender , System . EventArgs e )
            {
                  this . Close ( );
            }
      }
}