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
      // Bug Bounty Form
      public partial class BugBountyForm : Form
      {
            private string connectionString;

            public BugBountyForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
                  LoadStudents ( );
            }

            private void BugBountyForm_Load ( object sender , EventArgs e )
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

                              ComboBox cboFinder = (ComboBox)this.Controls.Find("cboFinder", true)[0];
                              ComboBox cboOwner = (ComboBox)this.Controls.Find("cboOwner", true)[0];

                              cboFinder . DisplayMember = "StudentName";
                              cboFinder . ValueMember = "StudentID";
                              cboFinder . DataSource = dt;

                              DataTable dt2 = dt.Copy();
                              cboOwner . DisplayMember = "StudentName";
                              cboOwner . ValueMember = "StudentID";
                              cboOwner . DataSource = dt2;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading students: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void BtnSave_Click ( object sender , EventArgs e )
            {
                  ComboBox cboFinder = (ComboBox)this.Controls.Find("cboFinder", true)[0];
                  ComboBox cboOwner = (ComboBox)this.Controls.Find("cboOwner", true)[0];

                  if ( cboFinder . SelectedValue . Equals ( cboOwner . SelectedValue ) )
                  {
                        MessageBox . Show ( "Bug finder and code owner cannot be the same person!" , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  NumericUpDown nudPoints = (NumericUpDown)this.Controls.Find("nudPoints", true)[0];
                  DateTimePicker dtpDate = (DateTimePicker)this.Controls.Find("dtpDate", true)[0];
                  TextBox txtDescription = (TextBox)this.Controls.Find("txtDescription", true)[0];

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO BugBounty (FinderStudentID, OwnerStudentID, BugDescription, PointsAwarded, DateFound)
                        VALUES (@FinderID, @OwnerID, @Description, @Points, @DateFound)", conn);

                              cmd . Parameters . AddWithValue ( "@FinderID" , cboFinder . SelectedValue );
                              cmd . Parameters . AddWithValue ( "@OwnerID" , cboOwner . SelectedValue );
                              cmd . Parameters . AddWithValue ( "@Description" , txtDescription . Text . Trim ( ) );
                              cmd . Parameters . AddWithValue ( "@Points" , ( int ) nudPoints . Value );
                              cmd . Parameters . AddWithValue ( "@DateFound" , dtpDate . Value . Date );

                              cmd . ExecuteNonQuery ( );

                              MessageBox . Show ( "Bug bounty recorded successfully!" , "Success" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Information );
                              this . DialogResult = DialogResult . OK;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error saving bug bounty: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }
      }
}
