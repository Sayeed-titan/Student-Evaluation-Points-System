using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class ProjectGradeForm : Form
      {
            private string connectionString;

            public ProjectGradeForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void ProjectGradeForm_Load ( object sender , EventArgs e )
            {
                  LoadStudents ( );
            }

            private void LoadStudents ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT StudentID, StudentName FROM Students WHERE IsActive = 1 ORDER BY StudentName", conn);
                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );

                              cboStudent . DisplayMember = "StudentName";
                              cboStudent . ValueMember = "StudentID";
                              cboStudent . DataSource = dt;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading students: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void BtnCalculate_Click ( object sender , EventArgs e )
            {
                  decimal total = (nudFunctionality.Value * 0.40m) + (nudCodeQuality.Value * 0.30m) +
                          (nudDatabaseDesign.Value * 0.15m) + (nudUIUX.Value * 0.10m) + (nudGitUsage.Value * 0.05m);

                  lblTotalValue . Text = total . ToString ( "F2" );

                  if ( total >= 70 )
                  {
                        lblPassStatus . Text = "PASSED";
                        lblPassStatus . ForeColor = System . Drawing . Color . Green;
                  }
                  else
                  {
                        lblPassStatus . Text = "FAILED";
                        lblPassStatus . ForeColor = System . Drawing . Color . Red;
                  }
            }

            private void BtnSave_Click ( object sender , EventArgs e )
            {
                  if ( cboStudent . SelectedValue == null || string . IsNullOrWhiteSpace ( txtProjectName . Text ) )
                  {
                        MessageBox . Show ( "Please select a student and enter project name." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Projects (StudentID, ProjectName, SubmissionDate, 
                                            FunctionalityScore, CodeQualityScore, DatabaseDesignScore, 
                                            UIUXScore, GitUsageScore)
                        VALUES (@StudentID, @ProjectName, @SubmissionDate, 
                                @Functionality, @CodeQuality, @DatabaseDesign, 
                                @UIUX, @GitUsage)", conn);

                              cmd . Parameters . AddWithValue ( "@StudentID" , cboStudent . SelectedValue );
                              cmd . Parameters . AddWithValue ( "@ProjectName" , txtProjectName . Text . Trim ( ) );
                              cmd . Parameters . AddWithValue ( "@SubmissionDate" , dtpSubmission . Value . Date );
                              cmd . Parameters . AddWithValue ( "@Functionality" , nudFunctionality . Value );
                              cmd . Parameters . AddWithValue ( "@CodeQuality" , nudCodeQuality . Value );
                              cmd . Parameters . AddWithValue ( "@DatabaseDesign" , nudDatabaseDesign . Value );
                              cmd . Parameters . AddWithValue ( "@UIUX" , nudUIUX . Value );
                              cmd . Parameters . AddWithValue ( "@GitUsage" , nudGitUsage . Value );

                              cmd . ExecuteNonQuery ( );

                              MessageBox . Show ( "Project grade saved successfully!" , "Success" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Information );
                              this . DialogResult = DialogResult . OK;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error saving project grade: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }
      }
}