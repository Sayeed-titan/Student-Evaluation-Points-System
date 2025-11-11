using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class RecordActivityForm : Form
      {
            private string connectionString;

            public RecordActivityForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void RecordActivityForm_Load ( object sender , EventArgs e )
            {
                  LoadData ( );
            }

            private void LoadData ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );

                              // Load Students
                              SqlDataAdapter studentAdapter = new SqlDataAdapter(
                        "SELECT StudentID, StudentName FROM Students WHERE IsActive = 1 ORDER BY StudentName", conn);
                              DataTable studentDt = new DataTable();
                              studentAdapter . Fill ( studentDt );

                              cboStudent . DisplayMember = "StudentName";
                              cboStudent . ValueMember = "StudentID";
                              cboStudent . DataSource = studentDt;

                              // Load Activity Types
                              SqlDataAdapter activityAdapter = new SqlDataAdapter(
                        "SELECT ActivityTypeID, ActivityName, Points FROM ActivityTypes WHERE IsActive = 1 ORDER BY ActivityName", conn);
                              DataTable activityDt = new DataTable();
                              activityAdapter . Fill ( activityDt );

                              cboActivity . DisplayMember = "ActivityName";
                              cboActivity . ValueMember = "ActivityTypeID";
                              cboActivity . DataSource = activityDt;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading data: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void CboActivity_SelectedIndexChanged ( object sender , EventArgs e )
            {
                  if ( cboActivity . SelectedValue != null )
                  {
                        DataRowView row = (DataRowView)cboActivity.SelectedItem;
                        txtPoints . Text = row [ "Points" ] . ToString ( );
                  }
            }

            private void BtnSave_Click ( object sender , EventArgs e )
            {
                  if ( SaveActivity ( ) )
                  {
                        this . DialogResult = DialogResult . OK;
                  }
            }

            private void BtnSaveAndNew_Click ( object sender , EventArgs e )
            {
                  if ( SaveActivity ( ) )
                  {
                        ClearForm ( );
                  }
            }

            private bool SaveActivity ( )
            {
                  if ( cboStudent . SelectedValue == null )
                  {
                        MessageBox . Show ( "Please select a student." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return false;
                  }

                  if ( cboActivity . SelectedValue == null )
                  {
                        MessageBox . Show ( "Please select an activity type." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return false;
                  }

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO DailyActivities (StudentID, ActivityTypeID, ActivityDate, PointsEarned, Notes)
                        VALUES (@StudentID, @ActivityTypeID, @ActivityDate, @Points, @Notes)", conn);

                              cmd . Parameters . AddWithValue ( "@StudentID" , cboStudent . SelectedValue );
                              cmd . Parameters . AddWithValue ( "@ActivityTypeID" , cboActivity . SelectedValue );
                              cmd . Parameters . AddWithValue ( "@ActivityDate" , dtpDate . Value . Date );
                              cmd . Parameters . AddWithValue ( "@Points" , int . Parse ( txtPoints . Text ) );
                              cmd . Parameters . AddWithValue ( "@Notes" , string . IsNullOrWhiteSpace ( txtNotes . Text ) ?
                                  ( object ) DBNull . Value : txtNotes . Text . Trim ( ) );

                              cmd . ExecuteNonQuery ( );

                              MessageBox . Show ( "Activity recorded successfully!" , "Success" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Information );
                              return true;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error saving activity: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                        return false;
                  }
            }

            private void ClearForm ( )
            {
                  if ( cboStudent . Items . Count > 0 ) cboStudent . SelectedIndex = 0;
                  if ( cboActivity . Items . Count > 0 ) cboActivity . SelectedIndex = 0;
                  txtNotes . Clear ( );
                  dtpDate . Value = DateTime . Now;
            }
      }
}