namespace StudentPointsSystem
{
      partial class DateSelectionForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblInstruction;
            private System.Windows.Forms.DateTimePicker dtpDate;
            private System.Windows.Forms.Button btnOk;
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
                  this . lblInstruction = new System . Windows . Forms . Label ( );
                  this . dtpDate = new System . Windows . Forms . DateTimePicker ( );
                  this . btnOk = new System . Windows . Forms . Button ( );
                  this . btnCancel = new System . Windows . Forms . Button ( );
                  this . SuspendLayout ( );
                  // 
                  // lblInstruction
                  // 
                  this . lblInstruction . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . lblInstruction . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblInstruction . Name = "lblInstruction";
                  this . lblInstruction . Size = new System . Drawing . Size ( 350 , 40 );
                  this . lblInstruction . TabIndex = 0;
                  this . lblInstruction . Text = "Select the date for daily points calculation:";
                  // 
                  // dtpDate
                  // 
                  this . dtpDate . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpDate . Location = new System . Drawing . Point ( 20 , 70 );
                  this . dtpDate . Name = "dtpDate";
                  this . dtpDate . Size = new System . Drawing . Size ( 340 , 20 );
                  this . dtpDate . TabIndex = 1;
                  // 
                  // btnOk
                  // 
                  this . btnOk . Location = new System . Drawing . Point ( 140 , 110 );
                  this . btnOk . Name = "btnOk";
                  this . btnOk . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnOk . TabIndex = 2;
                  this . btnOk . Text = "OK";
                  this . btnOk . UseVisualStyleBackColor = true;
                  this . btnOk . Click += new System . EventHandler ( this . BtnOk_Click );
                  // 
                  // btnCancel
                  // 
                  this . btnCancel . DialogResult = System . Windows . Forms . DialogResult . Cancel;
                  this . btnCancel . Location = new System . Drawing . Point ( 260 , 110 );
                  this . btnCancel . Name = "btnCancel";
                  this . btnCancel . Size = new System . Drawing . Size ( 100 , 35 );
                  this . btnCancel . TabIndex = 3;
                  this . btnCancel . Text = "Cancel";
                  this . btnCancel . UseVisualStyleBackColor = true;
                  // 
                  // DateSelectionForm
                  // 
                  this . AcceptButton = this . btnOk;
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . CancelButton = this . btnCancel;
                  this . ClientSize = new System . Drawing . Size ( 384 , 161 );
                  this . Controls . Add ( this . btnCancel );
                  this . Controls . Add ( this . btnOk );
                  this . Controls . Add ( this . dtpDate );
                  this . Controls . Add ( this . lblInstruction );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedDialog;
                  this . MaximizeBox = false;
                  this . MinimizeBox = false;
                  this . Name = "DateSelectionForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Select Date";
                  this . ResumeLayout ( false );
            }

            private void BtnOk_Click ( object sender , System . EventArgs e )
            {
                  this . DialogResult = System . Windows . Forms . DialogResult . OK;
            }
      }
}