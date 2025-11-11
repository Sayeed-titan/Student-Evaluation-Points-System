using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      // Manage Students Form
      public partial class ManageStudentsForm : Form
      {
            private string connectionString;

            public ManageStudentsForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
                  LoadStudents ( );
            }


            private void LoadStudents ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT StudentID, StudentName, Email, PhoneNumber, JoinDate, 
                               CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                        FROM Students
                        ORDER BY StudentName", conn);

                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );

                              DataGridView dgv = (DataGridView)this.Controls.Find("dgvStudents", true)[0];
                              dgv . DataSource = dt;

                              if ( dgv . Columns . Count > 0 )
                              {
                                    dgv . Columns [ "StudentID" ] . Visible = false;
                              }
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading students: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void BtnDeactivate_Click ( object sender , EventArgs e )
            {
                  UpdateStudentStatus ( false );
            }

            private void BtnActivate_Click ( object sender , EventArgs e )
            {
                  UpdateStudentStatus ( true );
            }

            private void UpdateStudentStatus ( bool isActive )
            {
                  DataGridView dgv = (DataGridView)this.Controls.Find("dgvStudents", true)[0];

                  if ( dgv . SelectedRows . Count == 0 )
                  {
                        MessageBox . Show ( "Please select a student." , "No Selection" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  int studentId = Convert.ToInt32(dgv.SelectedRows[0].Cells["StudentID"].Value);
                  string status = isActive ? "activate" : "deactivate";

                  var result = MessageBox.Show($"Are you sure you want to {status} this student?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if ( result == DialogResult . Yes )
                  {
                        try
                        {
                              using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                              {
                                    conn . Open ( );
                                    SqlCommand cmd = new SqlCommand(
                            "UPDATE Students SET IsActive = @IsActive WHERE StudentID = @StudentID", conn);
                                    cmd . Parameters . AddWithValue ( "@IsActive" , isActive );
                                    cmd . Parameters . AddWithValue ( "@StudentID" , studentId );
                                    cmd . ExecuteNonQuery ( );

                                    MessageBox . Show ( $"Student {status}d successfully!" , "Success" ,
                                        MessageBoxButtons . OK , MessageBoxIcon . Information );
                                    LoadStudents ( );
                              }
                        }
                        catch ( Exception ex )
                        {
                              MessageBox . Show ( $"Error updating student: {ex . Message}" , "Error" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Error );
                        }
                  }
            }
      }
}
