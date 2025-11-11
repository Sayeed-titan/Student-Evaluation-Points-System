namespace StudentPointsSystem
{
      partial class BugBountyForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblFinder;
            private System.Windows.Forms.ComboBox cboFinder;
            private System.Windows.Forms.Label lblOwner;
            private System.Windows.Forms.ComboBox cboOwner;
            private System.Windows.Forms.Label lblPoints;
            private System.Windows.Forms.NumericUpDown nudPoints;
            private System.Windows.Forms.Label lblDate;
            private System.Windows.Forms.DateTimePicker dtpDate;
            private System.Windows.Forms.Label lblDescription;
            private System.Windows.Forms.TextBox txtDescription;
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
                  this . lblFinder = new System . Windows . Forms . Label ( );
                  this . cboFinder = new System . Windows . Forms . ComboBox ( );
                  this . lblOwner = new System . Windows . Forms . Label ( );
                  this . cboOwner = new System . Windows . Forms . ComboBox ( );
                  this . lblPoints = new System . Windows . Forms . Label ( );
                  this . nudPoints = new System . Windows . Forms . NumericUpDown ( );
                  this . lblDate = new System . Windows . Forms . Label ( );
                  this . dtpDate = new System . Windows . Forms . DateTimePicker ( );
                  this . lblDescription = new System . Windows . Forms . Label ( );
                  this . txtDescription = new System . Windows . Forms . TextBox ( );
                  this . btnSave = new System . Windows . Forms . Button ( );
                  this . btnCancel = new System . Windows . Forms . Button ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudPoints ) ) . BeginInit ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 16F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 201 , 30 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Record Bug Bounty";
                  // 
                  // lblFinder
                  // 
                  this . lblFinder . AutoSize = true;
                  this . lblFinder . Location = new System . Drawing . Point ( 20 , 80 );
                  this . lblFinder . Name = "lblFinder";
                  this . lblFinder . Size = new System . Drawing . Size ( 61 , 13 );
                  this . lblFinder . TabIndex = 1;
                  this . lblFinder . Text = "Bug Finder:";
                  // 
                  // cboFinder
                  // 
                  this . cboFinder . DropDownStyle = System . Windows . Forms . ComboBoxStyle . DropDownList;
                  this . cboFinder . FormattingEnabled = true;
                  this . cboFinder . Location = new System . Drawing . Point ( 160 , 77 );
                  this . cboFinder . Name = "cboFinder";
                  this . cboFinder . Size = new System . Drawing . Size ( 400 , 21 );
                  this . cboFinder . TabIndex = 2;
                  // 
                  // lblOwner
                  // 
                  this . lblOwner . AutoSize = true;
                  this . lblOwner . Location = new System . Drawing . Point ( 20 , 120 );
                  this . lblOwner . Name = "lblOwner";
                  this . lblOwner . Size = new System . Drawing . Size ( 70 , 13 );
                  this . lblOwner . TabIndex = 3;
                  this . lblOwner . Text = "Code Owner:";
                  // 
                  // cboOwner
                  // 
                  this . cboOwner . DropDownStyle = System . Windows . Forms . ComboBoxStyle . DropDownList;
                  this . cboOwner . FormattingEnabled = true;
                  this . cboOwner . Location = new System . Drawing . Point ( 160 , 117 );
                  this . cboOwner . Name = "cboOwner";
                  this . cboOwner . Size = new System . Drawing . Size ( 400 , 21 );
                  this . cboOwner . TabIndex = 4;
                  // 
                  // lblPoints
                  // 
                  this . lblPoints . AutoSize = true;
                  this . lblPoints . Location = new System . Drawing . Point ( 20 , 160 );
                  this . lblPoints . Name = "lblPoints";
                  this . lblPoints . Size = new System . Drawing . Size ( 83 , 13 );
                  this . lblPoints . TabIndex = 5;
                  this . lblPoints . Text = "Points Awarded:";
                  // 
                  // nudPoints
                  // 
                  this . nudPoints . Location = new System . Drawing . Point ( 160 , 157 );
                  this . nudPoints . Maximum = new decimal ( new int [ ] {
            20,
            0,
            0,
            0} );
                  this . nudPoints . Minimum = new decimal ( new int [ ] {
            1,
            0,
            0,
            0} );
                  this . nudPoints . Name = "nudPoints";
                  this . nudPoints . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudPoints . TabIndex = 6;
                  this . nudPoints . Value = new decimal ( new int [ ] {
            5,
            0,
            0,
            0} );
                  // 
                  // lblDate
                  // 
                  this . lblDate . AutoSize = true;
                  this . lblDate . Location = new System . Drawing . Point ( 20 , 200 );
                  this . lblDate . Name = "lblDate";
                  this . lblDate . Size = new System . Drawing . Size ( 67 , 13 );
                  this . lblDate . TabIndex = 7;
                  this . lblDate . Text = "Date Found:";
                  // 
                  // dtpDate
                  // 
                  this . dtpDate . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpDate . Location = new System . Drawing . Point ( 160 , 197 );
                  this . dtpDate . Name = "dtpDate";
                  this . dtpDate . Size = new System . Drawing . Size ( 400 , 20 );
                  this . dtpDate . TabIndex = 8;
                  // 
                  // lblDescription
                  // 
                  this . lblDescription . AutoSize = true;
                  this . lblDescription . Location = new System . Drawing . Point ( 20 , 240 );
                  this . lblDescription . Name = "lblDescription";
                  this . lblDescription . Size = new System . Drawing . Size ( 85 , 13 );
                  this . lblDescription . TabIndex = 9;
                  this . lblDescription . Text = "Bug Description:";
                  // 
                  // txtDescription
                  // 
                  this . txtDescription . Location = new System . Drawing . Point ( 160 , 237 );
                  this . txtDescription . Multiline = true;
                  this . txtDescription . Name = "txtDescription";
                  this . txtDescription . ScrollBars = System . Windows . Forms . ScrollBars . Vertical;
                  this . txtDescription . Size = new System . Drawing . Size ( 400 , 80 );
                  this . txtDescription . TabIndex = 10;
                  // 
                  // btnSave
                  // 
                  this . btnSave . Location = new System . Drawing . Point ( 310 , 340 );
                  this . btnSave . Name = "btnSave";
                  this . btnSave . Size = new System . Drawing . Size ( 120 , 40 );
                  this . btnSave . TabIndex = 11;
                  this . btnSave . Text = "Save";
                  this . btnSave . UseVisualStyleBackColor = true;
                  this . btnSave . Click += new System . EventHandler ( this . BtnSave_Click );
                  // 
                  // btnCancel
                  // 
                  this . btnCancel . DialogResult = System . Windows . Forms . DialogResult . Cancel;
                  this . btnCancel . Location = new System . Drawing . Point ( 450 , 340 );
                  this . btnCancel . Name = "btnCancel";
                  this . btnCancel . Size = new System . Drawing . Size ( 110 , 40 );
                  this . btnCancel . TabIndex = 12;
                  this . btnCancel . Text = "Cancel";
                  this . btnCancel . UseVisualStyleBackColor = true;
                  // 
                  // BugBountyForm
                  // 
                  this . AcceptButton = this . btnSave;
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . CancelButton = this . btnCancel;
                  this . ClientSize = new System . Drawing . Size ( 584 , 401 );
                  this . Controls . Add ( this . btnCancel );
                  this . Controls . Add ( this . btnSave );
                  this . Controls . Add ( this . txtDescription );
                  this . Controls . Add ( this . lblDescription );
                  this . Controls . Add ( this . dtpDate );
                  this . Controls . Add ( this . lblDate );
                  this . Controls . Add ( this . nudPoints );
                  this . Controls . Add ( this . lblPoints );
                  this . Controls . Add ( this . cboOwner );
                  this . Controls . Add ( this . lblOwner );
                  this . Controls . Add ( this . cboFinder );
                  this . Controls . Add ( this . lblFinder );
                  this . Controls . Add ( this . lblTitle );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedDialog;
                  this . MaximizeBox = false;
                  this . Name = "BugBountyForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Record Bug Bounty";
                  this . Load += new System . EventHandler ( this . BugBountyForm_Load );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudPoints ) ) . EndInit ( );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }
      }
}