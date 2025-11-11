using System;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class AddStudentForm : Form
      {
            private string connectionString;

            public AddStudentForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void BtnSave_Click ( object sender , EventArgs e )
            {
                  if ( string . IsNullOrWhiteSpace ( txtName . Text ) )
                  {
                        MessageBox . Show ( "Please enter student name." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        txtName . Focus ( );
                        return;
                  }

                  if ( string . IsNullOrWhiteSpace ( txtEmail . Text ) )
                  {
                        MessageBox . Show ( "Please enter email address." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        txtEmail . Focus ( );
                        return;
                  }

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Students (StudentName, Email, PhoneNumber, JoinDate)
                        VALUES (@Name, @Email, @Phone, @JoinDate)", conn);

                              cmd . Parameters . AddWithValue ( "@Name" , txtName . Text . Trim ( ) );
                              cmd . Parameters . AddWithValue ( "@Email" , txtEmail . Text . Trim ( ) );
                              cmd . Parameters . AddWithValue ( "@Phone" , string . IsNullOrWhiteSpace ( txtPhone . Text ) ?
                                  ( object ) DBNull . Value : txtPhone . Text . Trim ( ) );
                              cmd . Parameters . AddWithValue ( "@JoinDate" , dtpJoinDate . Value . Date );

                              cmd . ExecuteNonQuery ( );

                              MessageBox . Show ( "Student added successfully!" , "Success" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Information );
                              this . DialogResult = DialogResult . OK;
                        }
                  }
                  catch ( SqlException ex ) when ( ex . Number == 2627 ) // Unique constraint violation
                  {
                        MessageBox . Show ( "A student with this email already exists." , "Duplicate Email" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error saving student: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }
      }
}