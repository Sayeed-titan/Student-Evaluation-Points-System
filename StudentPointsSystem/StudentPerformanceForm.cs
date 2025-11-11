using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class StudentPerformanceForm : Form
      {
            private string connectionString;

            public StudentPerformanceForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void StudentPerformanceForm_Load ( object sender , EventArgs e )
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

            private void BtnLoad_Click ( object sender , EventArgs e )
            {
                  if ( cboStudent . SelectedValue == null ) return;

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT 
                            at.ActivityName,
                            da.ActivityDate,
                            da.PointsEarned,
                            CASE WHEN da.IsCalculated = 1 THEN 'Yes' ELSE 'No' END AS Calculated
                        FROM DailyActivities da
                        JOIN ActivityTypes at ON da.ActivityTypeID = at.ActivityTypeID
                        WHERE da.StudentID = @StudentID
                        ORDER BY da.ActivityDate DESC", conn);

                              adapter . SelectCommand . Parameters . AddWithValue ( "@StudentID" , cboStudent . SelectedValue );

                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );

                              dgvPerformance . DataSource = dt;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading performance: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }
      }
}