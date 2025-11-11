namespace StudentPointsSystem
{
      partial class ProjectGradeForm
      {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblStudent;
            private System.Windows.Forms.ComboBox cboStudent;
            private System.Windows.Forms.Label lblProjectName;
            private System.Windows.Forms.TextBox txtProjectName;
            private System.Windows.Forms.Label lblSubmissionDate;
            private System.Windows.Forms.DateTimePicker dtpSubmission;
            private System.Windows.Forms.Label lblFunctionality;
            private System.Windows.Forms.NumericUpDown nudFunctionality;
            private System.Windows.Forms.Label lblCodeQuality;
            private System.Windows.Forms.NumericUpDown nudCodeQuality;
            private System.Windows.Forms.Label lblDatabaseDesign;
            private System.Windows.Forms.NumericUpDown nudDatabaseDesign;
            private System.Windows.Forms.Label lblUIUX;
            private System.Windows.Forms.NumericUpDown nudUIUX;
            private System.Windows.Forms.Label lblGitUsage;
            private System.Windows.Forms.NumericUpDown nudGitUsage;
            private System.Windows.Forms.Button btnCalculate;
            private System.Windows.Forms.Label lblTotalScore;
            private System.Windows.Forms.Label lblTotalValue;
            private System.Windows.Forms.Label lblPassStatus;
            private System.Windows.Forms.Button btnSave;
            private System.Windows.Forms.Button btnCancel;
            private System.Windows.Forms.Panel panelScores;
            private System.Windows.Forms.Panel panelTotal;

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
                  this . lblProjectName = new System . Windows . Forms . Label ( );
                  this . txtProjectName = new System . Windows . Forms . TextBox ( );
                  this . lblSubmissionDate = new System . Windows . Forms . Label ( );
                  this . dtpSubmission = new System . Windows . Forms . DateTimePicker ( );
                  this . panelScores = new System . Windows . Forms . Panel ( );
                  this . lblGitUsage = new System . Windows . Forms . Label ( );
                  this . nudGitUsage = new System . Windows . Forms . NumericUpDown ( );
                  this . lblUIUX = new System . Windows . Forms . Label ( );
                  this . nudUIUX = new System . Windows . Forms . NumericUpDown ( );
                  this . lblDatabaseDesign = new System . Windows . Forms . Label ( );
                  this . nudDatabaseDesign = new System . Windows . Forms . NumericUpDown ( );
                  this . lblCodeQuality = new System . Windows . Forms . Label ( );
                  this . nudCodeQuality = new System . Windows . Forms . NumericUpDown ( );
                  this . lblFunctionality = new System . Windows . Forms . Label ( );
                  this . nudFunctionality = new System . Windows . Forms . NumericUpDown ( );
                  this . btnCalculate = new System . Windows . Forms . Button ( );
                  this . panelTotal = new System . Windows . Forms . Panel ( );
                  this . lblPassStatus = new System . Windows . Forms . Label ( );
                  this . lblTotalValue = new System . Windows . Forms . Label ( );
                  this . lblTotalScore = new System . Windows . Forms . Label ( );
                  this . btnSave = new System . Windows . Forms . Button ( );
                  this . btnCancel = new System . Windows . Forms . Button ( );
                  this . panelScores . SuspendLayout ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudGitUsage ) ) . BeginInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudUIUX ) ) . BeginInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudDatabaseDesign ) ) . BeginInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudCodeQuality ) ) . BeginInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudFunctionality ) ) . BeginInit ( );
                  this . panelTotal . SuspendLayout ( );
                  this . SuspendLayout ( );
                  // 
                  // lblTitle
                  // 
                  this . lblTitle . AutoSize = true;
                  this . lblTitle . Font = new System . Drawing . Font ( "Segoe UI" , 16F , System . Drawing . FontStyle . Bold );
                  this . lblTitle . Location = new System . Drawing . Point ( 20 , 20 );
                  this . lblTitle . Name = "lblTitle";
                  this . lblTitle . Size = new System . Drawing . Size ( 167 , 30 );
                  this . lblTitle . TabIndex = 0;
                  this . lblTitle . Text = "Project Grading";
                  // 
                  // lblStudent
                  // 
                  this . lblStudent . AutoSize = true;
                  this . lblStudent . Location = new System . Drawing . Point ( 20 , 70 );
                  this . lblStudent . Name = "lblStudent";
                  this . lblStudent . Size = new System . Drawing . Size ( 47 , 13 );
                  this . lblStudent . TabIndex = 1;
                  this . lblStudent . Text = "Student:";
                  // 
                  // cboStudent
                  // 
                  this . cboStudent . DropDownStyle = System . Windows . Forms . ComboBoxStyle . DropDownList;
                  this . cboStudent . FormattingEnabled = true;
                  this . cboStudent . Location = new System . Drawing . Point ( 180 , 67 );
                  this . cboStudent . Name = "cboStudent";
                  this . cboStudent . Size = new System . Drawing . Size ( 430 , 21 );
                  this . cboStudent . TabIndex = 2;
                  // 
                  // lblProjectName
                  // 
                  this . lblProjectName . AutoSize = true;
                  this . lblProjectName . Location = new System . Drawing . Point ( 20 , 110 );
                  this . lblProjectName . Name = "lblProjectName";
                  this . lblProjectName . Size = new System . Drawing . Size ( 74 , 13 );
                  this . lblProjectName . TabIndex = 3;
                  this . lblProjectName . Text = "Project Name:";
                  // 
                  // txtProjectName
                  // 
                  this . txtProjectName . Location = new System . Drawing . Point ( 180 , 107 );
                  this . txtProjectName . Name = "txtProjectName";
                  this . txtProjectName . Size = new System . Drawing . Size ( 430 , 20 );
                  this . txtProjectName . TabIndex = 4;
                  // 
                  // lblSubmissionDate
                  // 
                  this . lblSubmissionDate . AutoSize = true;
                  this . lblSubmissionDate . Location = new System . Drawing . Point ( 20 , 150 );
                  this . lblSubmissionDate . Name = "lblSubmissionDate";
                  this . lblSubmissionDate . Size = new System . Drawing . Size ( 90 , 13 );
                  this . lblSubmissionDate . TabIndex = 5;
                  this . lblSubmissionDate . Text = "Submission Date:";
                  // 
                  // dtpSubmission
                  // 
                  this . dtpSubmission . Format = System . Windows . Forms . DateTimePickerFormat . Short;
                  this . dtpSubmission . Location = new System . Drawing . Point ( 180 , 147 );
                  this . dtpSubmission . Name = "dtpSubmission";
                  this . dtpSubmission . Size = new System . Drawing . Size ( 430 , 20 );
                  this . dtpSubmission . TabIndex = 6;
                  // 
                  // panelScores
                  // 
                  this . panelScores . BorderStyle = System . Windows . Forms . BorderStyle . FixedSingle;
                  this . panelScores . Controls . Add ( this . lblGitUsage );
                  this . panelScores . Controls . Add ( this . nudGitUsage );
                  this . panelScores . Controls . Add ( this . lblUIUX );
                  this . panelScores . Controls . Add ( this . nudUIUX );
                  this . panelScores . Controls . Add ( this . lblDatabaseDesign );
                  this . panelScores . Controls . Add ( this . nudDatabaseDesign );
                  this . panelScores . Controls . Add ( this . lblCodeQuality );
                  this . panelScores . Controls . Add ( this . nudCodeQuality );
                  this . panelScores . Controls . Add ( this . lblFunctionality );
                  this . panelScores . Controls . Add ( this . nudFunctionality );
                  this . panelScores . Location = new System . Drawing . Point ( 20 , 190 );
                  this . panelScores . Name = "panelScores";
                  this . panelScores . Size = new System . Drawing . Size ( 590 , 210 );
                  this . panelScores . TabIndex = 7;
                  // 
                  // lblFunctionality
                  // 
                  this . lblFunctionality . AutoSize = true;
                  this . lblFunctionality . Font = new System . Drawing . Font ( "Segoe UI" , 9F );
                  this . lblFunctionality . Location = new System . Drawing . Point ( 15 , 20 );
                  this . lblFunctionality . Name = "lblFunctionality";
                  this . lblFunctionality . Size = new System . Drawing . Size ( 118 , 15 );
                  this . lblFunctionality . TabIndex = 0;
                  this . lblFunctionality . Text = "Functionality (40%):";
                  // 
                  // nudFunctionality
                  // 
                  this . nudFunctionality . DecimalPlaces = 2;
                  this . nudFunctionality . Location = new System . Drawing . Point ( 160 , 17 );
                  this . nudFunctionality . Name = "nudFunctionality";
                  this . nudFunctionality . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudFunctionality . TabIndex = 1;
                  // 
                  // lblCodeQuality
                  // 
                  this . lblCodeQuality . AutoSize = true;
                  this . lblCodeQuality . Font = new System . Drawing . Font ( "Segoe UI" , 9F );
                  this . lblCodeQuality . Location = new System . Drawing . Point ( 15 , 60 );
                  this . lblCodeQuality . Name = "lblCodeQuality";
                  this . lblCodeQuality . Size = new System . Drawing . Size ( 114 , 15 );
                  this . lblCodeQuality . TabIndex = 2;
                  this . lblCodeQuality . Text = "Code Quality (30%):";
                  // 
                  // nudCodeQuality
                  // 
                  this . nudCodeQuality . DecimalPlaces = 2;
                  this . nudCodeQuality . Location = new System . Drawing . Point ( 160 , 57 );
                  this . nudCodeQuality . Name = "nudCodeQuality";
                  this . nudCodeQuality . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudCodeQuality . TabIndex = 3;
                  // 
                  // lblDatabaseDesign
                  // 
                  this . lblDatabaseDesign . AutoSize = true;
                  this . lblDatabaseDesign . Font = new System . Drawing . Font ( "Segoe UI" , 9F );
                  this . lblDatabaseDesign . Location = new System . Drawing . Point ( 15 , 100 );
                  this . lblDatabaseDesign . Name = "lblDatabaseDesign";
                  this . lblDatabaseDesign . Size = new System . Drawing . Size ( 136 , 15 );
                  this . lblDatabaseDesign . TabIndex = 4;
                  this . lblDatabaseDesign . Text = "Database Design (15%):";
                  // 
                  // nudDatabaseDesign
                  // 
                  this . nudDatabaseDesign . DecimalPlaces = 2;
                  this . nudDatabaseDesign . Location = new System . Drawing . Point ( 160 , 97 );
                  this . nudDatabaseDesign . Name = "nudDatabaseDesign";
                  this . nudDatabaseDesign . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudDatabaseDesign . TabIndex = 5;
                  // 
                  // lblUIUX
                  // 
                  this . lblUIUX . AutoSize = true;
                  this . lblUIUX . Font = new System . Drawing . Font ( "Segoe UI" , 9F );
                  this . lblUIUX . Location = new System . Drawing . Point ( 15 , 140 );
                  this . lblUIUX . Name = "lblUIUX";
                  this . lblUIUX . Size = new System . Drawing . Size ( 70 , 15 );
                  this . lblUIUX . TabIndex = 6;
                  this . lblUIUX . Text = "UI/UX (10%):";
                  // 
                  // nudUIUX
                  // 
                  this . nudUIUX . DecimalPlaces = 2;
                  this . nudUIUX . Location = new System . Drawing . Point ( 160 , 137 );
                  this . nudUIUX . Name = "nudUIUX";
                  this . nudUIUX . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudUIUX . TabIndex = 7;
                  // 
                  // lblGitUsage
                  // 
                  this . lblGitUsage . AutoSize = true;
                  this . lblGitUsage . Font = new System . Drawing . Font ( "Segoe UI" , 9F );
                  this . lblGitUsage . Location = new System . Drawing . Point ( 15 , 180 );
                  this . lblGitUsage . Name = "lblGitUsage";
                  this . lblGitUsage . Size = new System . Drawing . Size ( 84 , 15 );
                  this . lblGitUsage . TabIndex = 8;
                  this . lblGitUsage . Text = "Git Usage (5%):";
                  // 
                  // nudGitUsage
                  // 
                  this . nudGitUsage . DecimalPlaces = 2;
                  this . nudGitUsage . Location = new System . Drawing . Point ( 160 , 177 );
                  this . nudGitUsage . Name = "nudGitUsage";
                  this . nudGitUsage . Size = new System . Drawing . Size ( 100 , 20 );
                  this . nudGitUsage . TabIndex = 9;
                  // 
                  // btnCalculate
                  // 
                  this . btnCalculate . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnCalculate . Location = new System . Drawing . Point ( 180 , 420 );
                  this . btnCalculate . Name = "btnCalculate";
                  this . btnCalculate . Size = new System . Drawing . Size ( 120 , 35 );
                  this . btnCalculate . TabIndex = 8;
                  this . btnCalculate . Text = "Calculate Total";
                  this . btnCalculate . UseVisualStyleBackColor = true;
                  this . btnCalculate . Click += new System . EventHandler ( this . BtnCalculate_Click );
                  // 
                  // panelTotal
                  // 
                  this . panelTotal . BorderStyle = System . Windows . Forms . BorderStyle . FixedSingle;
                  this . panelTotal . Controls . Add ( this . lblPassStatus );
                  this . panelTotal . Controls . Add ( this . lblTotalValue );
                  this . panelTotal . Controls . Add ( this . lblTotalScore );
                  this . panelTotal . Location = new System . Drawing . Point ( 320 , 415 );
                  this . panelTotal . Name = "panelTotal";
                  this . panelTotal . Size = new System . Drawing . Size ( 290 , 45 );
                  this . panelTotal . TabIndex = 9;
                  // 
                  // lblTotalScore
                  // 
                  this . lblTotalScore . AutoSize = true;
                  this . lblTotalScore . Font = new System . Drawing . Font ( "Segoe UI" , 11F , System . Drawing . FontStyle . Bold );
                  this . lblTotalScore . Location = new System . Drawing . Point ( 10 , 13 );
                  this . lblTotalScore . Name = "lblTotalScore";
                  this . lblTotalScore . Size = new System . Drawing . Size ( 93 , 20 );
                  this . lblTotalScore . TabIndex = 0;
                  this . lblTotalScore . Text = "Total Score:";
                  // 
                  // lblTotalValue
                  // 
                  this . lblTotalValue . AutoSize = true;
                  this . lblTotalValue . Font = new System . Drawing . Font ( "Segoe UI" , 11F , System . Drawing . FontStyle . Bold );
                  this . lblTotalValue . Location = new System . Drawing . Point ( 110 , 13 );
                  this . lblTotalValue . Name = "lblTotalValue";
                  this . lblTotalValue . Size = new System . Drawing . Size ( 40 , 20 );
                  this . lblTotalValue . TabIndex = 1;
                  this . lblTotalValue . Text = "0.00";
                  // 
                  // lblPassStatus
                  // 
                  this . lblPassStatus . AutoSize = true;
                  this . lblPassStatus . Font = new System . Drawing . Font ( "Segoe UI" , 11F , System . Drawing . FontStyle . Bold );
                  this . lblPassStatus . Location = new System . Drawing . Point ( 170 , 13 );
                  this . lblPassStatus . Name = "lblPassStatus";
                  this . lblPassStatus . Size = new System . Drawing . Size ( 0 , 20 );
                  this . lblPassStatus . TabIndex = 2;
                  // 
                  // btnSave
                  // 
                  this . btnSave . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnSave . Location = new System . Drawing . Point ( 370 , 480 );
                  this . btnSave . Name = "btnSave";
                  this . btnSave . Size = new System . Drawing . Size ( 120 , 40 );
                  this . btnSave . TabIndex = 10;
                  this . btnSave . Text = "Save Grade";
                  this . btnSave . UseVisualStyleBackColor = true;
                  this . btnSave . Click += new System . EventHandler ( this . BtnSave_Click );
                  // 
                  // btnCancel
                  // 
                  this . btnCancel . DialogResult = System . Windows . Forms . DialogResult . Cancel;
                  this . btnCancel . Font = new System . Drawing . Font ( "Segoe UI" , 10F );
                  this . btnCancel . Location = new System . Drawing . Point ( 510 , 480 );
                  this . btnCancel . Name = "btnCancel";
                  this . btnCancel . Size = new System . Drawing . Size ( 100 , 40 );
                  this . btnCancel . TabIndex = 11;
                  this . btnCancel . Text = "Cancel";
                  this . btnCancel . UseVisualStyleBackColor = true;
                  // 
                  // ProjectGradeForm
                  // 
                  this . AcceptButton = this . btnSave;
                  this . AutoScaleDimensions = new System . Drawing . SizeF ( 6F , 13F );
                  this . AutoScaleMode = System . Windows . Forms . AutoScaleMode . Font;
                  this . CancelButton = this . btnCancel;
                  this . ClientSize = new System . Drawing . Size ( 634 , 541 );
                  this . Controls . Add ( this . btnCancel );
                  this . Controls . Add ( this . btnSave );
                  this . Controls . Add ( this . panelTotal );
                  this . Controls . Add ( this . btnCalculate );
                  this . Controls . Add ( this . panelScores );
                  this . Controls . Add ( this . dtpSubmission );
                  this . Controls . Add ( this . lblSubmissionDate );
                  this . Controls . Add ( this . txtProjectName );
                  this . Controls . Add ( this . lblProjectName );
                  this . Controls . Add ( this . cboStudent );
                  this . Controls . Add ( this . lblStudent );
                  this . Controls . Add ( this . lblTitle );
                  this . FormBorderStyle = System . Windows . Forms . FormBorderStyle . FixedDialog;
                  this . MaximizeBox = false;
                  this . Name = "ProjectGradeForm";
                  this . StartPosition = System . Windows . Forms . FormStartPosition . CenterParent;
                  this . Text = "Add Project Grade";
                  this . Load += new System . EventHandler ( this . ProjectGradeForm_Load );
                  this . panelScores . ResumeLayout ( false );
                  this . panelScores . PerformLayout ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudGitUsage ) ) . EndInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudUIUX ) ) . EndInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudDatabaseDesign ) ) . EndInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudCodeQuality ) ) . EndInit ( );
                  ( ( System . ComponentModel . ISupportInitialize ) ( this . nudFunctionality ) ) . EndInit ( );
                  this . panelTotal . ResumeLayout ( false );
                  this . panelTotal . PerformLayout ( );
                  this . ResumeLayout ( false );
                  this . PerformLayout ( );
            }
      }
}