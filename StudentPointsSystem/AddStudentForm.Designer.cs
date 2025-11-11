namespace StudentPointsSystem
{
      partial class AddStudentForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblName;
            private System.Windows.Forms.TextBox txtName;
            private System.Windows.Forms.Label lblEmail;
            private System.Windows.Forms.TextBox txtEmail;
            private System.Windows.Forms.Label lblPhone;
            private System.Windows.Forms.TextBox txtPhone;
            private System.Windows.Forms.Label lblJoinDate;
            private System.Windows.Forms.DateTimePicker dtpJoinDate;
            private System.Windows.Forms.Button btnSave;
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
                  this . lblName = new System . Windows . Forms . Label ( );
                  this . txtName = new System . Windows . Forms . TextBox ( );
                  this . lblEmail = new System . Windows . Forms . Label ( );
                  this . txtEmail = new System . Windows . Forms . TextBox ( );
                  this . lblPhone = new System . Windows . Forms . Label ( );
                  this . txtPhone = new System . Windows . Forms . TextBox ( );
                  this . lblJoinDate = new System . Windows . Forms . Label ( );
                  this . dtpJoinDate = new System . Windows . Forms . DateTimePicker ( );
                  this . btnSave = new System . Windows . Forms . Button ( );
                  this . btnCancel = new System . Windows . Forms . Button ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 16F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 172 , 30 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Add New Student";
                  // 
                  // lblName
                  // 
                  this . lblName . AutoSize = true;
                  this . lblName . Location = new System . Drawing . Point ( 20 , 80 );
                  this . lblName . Name = "lblName";
                  this . lblName . Size = new System . Drawing . Size ( 81 , 13 );
                  this . lblName . TabIndex = 1;
                  this . lblName . Text = "Student Name:";
                  // 
                  // txtName
                  // 
                  this . txtName . Location = new System . Drawing . Point ( 150 , 77 );
                  this . txtName . Name = "txtName";
                  this . txtName . Size = new System . Drawing . Size ( 300 , 20 );
                  this . txtName . TabIndex = 2;
                  // 
                  // lblEmail
                  // 
                  this . lblEmail . AutoSize = true;
                  this . lblEmail . Location = new System . Drawing . Point ( 20 , 120 );
                  this . lblEmail . Name = "lblEmail";
                  this . lblEmail . Size = new System . Drawing . Size ( 35 , 13 );
                  this . lblEmail . TabIndex = 3;
                  this . lblEmail . Text = "Email:";
                  // 
                  // txtEmail
                  // 
                  this . txtEmail . Location = new System . Drawing . Point ( 150 , 117 );
                  this . txtEmail . Name = "txtEmail";
                  this . txtEmail . Size = new System . Drawing . Size ( 300 , 20 );
                  this . txtEmail . TabIndex = 4;
                  // 
                  // lblPhone
                  // 
                  this . lblPhone . AutoSize = true;
                  this . lblPhone . Location = new System . Drawing . Point ( 20 , 160 );
                  this . lblPhone . Name = "lblPhone";
                  this . lblPhone . Size = new System . Drawing . Size ( 81 , 13 );
                  this . lblPhone . TabIndex = 5;
                  this . lblPhone . Text = "Phone Number:";
                  // 
                  // txtPhone
                  // 
                  this . txtPhone . Location = new System . Drawing . Point ( 150 , 157 );
                  this . txtPhone . Name = "txtPhone";
                  this . txtPhone . Size = new System . Drawing . Size ( 300 , 20 );
                  this . txtPhone . TabIndex = 6;
                  // 
                  // lblJoinDate
                  // 
                  this . lblJoinDate . AutoSize = true;
                  this . lblJoinDate . Location = new System . Drawing . Point ( 20 , 200 );
                  this . lblJoinDate . Name = "lblJoinDate";
                  this . lblJoinDate . Size = new System . Drawing . Size ( 56 , 13 );
                  this . lblJoinDate . TabIndex = 7;
                  this . lblJoinDate . Text = "Join Date:";
                  // 
                  // dtpJoinDate
                  // 
                  this . dtpJoinDate . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpJoinDate . Location = new System . Drawing . Point ( 150 , 197 );
                  this . dtpJoinDate . Name = "dtpJoinDate";
                  this . dtpJoinDate . Size = new System . Drawing . Size ( 300 , 20 );
                  this . dtpJoinDate . TabIndex = 8;
                  // 
                  // btnSave
                  // 
                  this . btnSave . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnSave . Location = new System . Drawing . Point ( 150 , 250 );
                  this . btnSave . Name = "btnSave";
                  this . btnSave . Size = new System . Drawing . Size ( 130 , 40 );
                  this . btnSave . TabIndex = 9;
                  this . btnSave . Text = "Save Student";
                  this . btnSave . UseVisualStyleBackColor = true;
                  this . btnSave . Click += new System . EventHandler ( this . BtnSave_Click );
                  // 
                  // btnCancel
                  // 
                  this . btnCancel . DialogResult = System . Windows . Forms . DialogResult . Cancel;
                  this . btnCancel . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnCancel . Location = new System . Drawing . Point ( 300 , 250 );
                  this . btnCancel . Name = "btnCancel";
                  this . btnCancel . Size = new System . Drawing . Size ( 130 , 40 );
                  this . btnCancel . TabIndex = 10;
                  this . btnCancel . Text = "Cancel";
                  this . btnCancel . UseVisualStyleBackColor = true;
                  // 
                  // AddStudentForm
                  // 
                  this . AcceptButton = this . btnSave;
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . CancelButton = this . btnCancel;
                  this . ClientSize = new System . Drawing . Size ( 484 , 321 );
                  this . Controls . Add ( this . btnCancel );
                  this . Controls . Add ( this . btnSave );
                  this . Controls . Add ( this . dtpJoinDate );
                  this . Controls . Add ( this . lblJoinDate );
                  this . Controls . Add ( this . txtPhone );
                  this . Controls . Add ( this . lblPhone );
                  this . Controls . Add ( this . txtEmail );
                  this . Controls . Add ( this . lblEmail );
                  this . Controls . Add ( this . txtName );
                  this . Controls . Add ( this . lblName );
                  this . Controls . Add ( this . lblTitle );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedDialog;
                  this . MaximizeBox = false;
                  this . MinimizeBox = false;
                  this . Name = "AddStudentForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Add New Student";
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }
      }
}