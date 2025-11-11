using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      // Manage Students Form with Full CRUD Operations
      public partial class ManageStudentsForm : Form
      {
            private string connectionString;
            //private DataGridView dgvStudents;

            public ManageStudentsForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );

                  AddSearchBox ( );
                  SetupDataGridView ( );
                  LoadStudents ( );
            }

            private void SetupDataGridView ( )
            {
                  dgvStudents = ( DataGridView ) this . Controls . Find ( "dgvStudents" , true ) [ 0 ];

                  // Enable editing on double-click
                  dgvStudents . ReadOnly = false;
                  dgvStudents . EditMode = DataGridViewEditMode . EditProgrammatically;

                  // Add double-click event for editing
                  dgvStudents . CellDoubleClick += DgvStudents_CellDoubleClick;

                  // Add key press event for Enter key
                  dgvStudents . KeyDown += DgvStudents_KeyDown;

                  // Add right-click context menu
                  CreateContextMenu ( );
            }

            private void CreateContextMenu ( )
            {
                  ContextMenuStrip contextMenu = new ContextMenuStrip();

                  ToolStripMenuItem editItem = new ToolStripMenuItem("Edit", null, ContextMenu_Edit);
                  editItem . Image = SystemIcons . Information . ToBitmap ( );

                  ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete", null, ContextMenu_Delete);
                  deleteItem . Image = SystemIcons . Error . ToBitmap ( );
                  deleteItem . ForeColor = Color . Red;

                  ToolStripSeparator separator = new ToolStripSeparator();

                  ToolStripMenuItem activateItem = new ToolStripMenuItem("Activate", null, (s, e) => UpdateStudentStatus(true));
                  ToolStripMenuItem deactivateItem = new ToolStripMenuItem("Deactivate", null, (s, e) => UpdateStudentStatus(false));

                  contextMenu . Items . Add ( editItem );
                  contextMenu . Items . Add ( deleteItem );
                  contextMenu . Items . Add ( separator );
                  contextMenu . Items . Add ( activateItem );
                  contextMenu . Items . Add ( deactivateItem );

                  dgvStudents . ContextMenuStrip = contextMenu;
            }

            private void DgvStudents_CellDoubleClick ( object sender , DataGridViewCellEventArgs e )
            {
                  if ( e . RowIndex < 0 ) return; // Ignore header clicks

                  DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                  int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                  ShowEditDialog ( studentId , row );
            }

            private void DgvStudents_KeyDown ( object sender , KeyEventArgs e )
            {
                  if ( e . KeyCode == Keys . Enter && dgvStudents . SelectedRows . Count > 0 )
                  {
                        e . Handled = true; // Prevent the beep sound
                        DataGridViewRow row = dgvStudents.SelectedRows[0];
                        int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                        ShowEditDialog ( studentId , row );
                  }
                  else if ( e . KeyCode == Keys . Delete && dgvStudents . SelectedRows . Count > 0 )
                  {
                        e . Handled = true;
                        DeleteStudent ( );
                  }
            }

            private void ContextMenu_Edit ( object sender , EventArgs e )
            {
                  if ( dgvStudents . SelectedRows . Count > 0 )
                  {
                        DataGridViewRow row = dgvStudents.SelectedRows[0];
                        int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                        ShowEditDialog ( studentId , row );
                  }
            }

            private void ContextMenu_Delete ( object sender , EventArgs e )
            {
                  DeleteStudent ( );
            }

            private void ShowEditDialog ( int studentId , DataGridViewRow row )
            {
                  // Create a custom dialog for editing
                  Form editForm = new Form
                  {
                        Text = "Edit Student",
                        Size = new Size(450, 350),
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false,
                        MinimizeBox = false
                  };

                  // Labels and TextBoxes
                  Label lblName = new Label { Text = "Name:", Location = new Point(20, 20), AutoSize = true };
                  TextBox txtName = new TextBox
                  {
                        Name = "txtName",
                        Location = new Point(20, 45),
                        Size = new Size(390, 25),
                        Text = row.Cells["StudentName"].Value.ToString()
                  };

                  Label lblEmail = new Label { Text = "Email:", Location = new Point(20, 80), AutoSize = true };
                  TextBox txtEmail = new TextBox
                  {
                        Name = "txtEmail",
                        Location = new Point(20, 105),
                        Size = new Size(390, 25),
                        Text = row.Cells["Email"].Value?.ToString() ?? ""
                  };

                  Label lblPhone = new Label { Text = "Phone:", Location = new Point(20, 140), AutoSize = true };
                  TextBox txtPhone = new TextBox
                  {
                        Name = "txtPhone",
                        Location = new Point(20, 165),
                        Size = new Size(390, 25),
                        Text = row.Cells["PhoneNumber"].Value?.ToString() ?? ""
                  };

                  Label lblStatus = new Label { Text = "Status:", Location = new Point(20, 200), AutoSize = true };
                  ComboBox cmbStatus = new ComboBox
                  {
                        Name = "cmbStatus",
                        Location = new Point(20, 225),
                        Size = new Size(390, 25),
                        DropDownStyle = ComboBoxStyle.DropDownList
                  };
                  cmbStatus . Items . AddRange ( new object [ ] { "Active" , "Inactive" } );
                  cmbStatus . SelectedItem = row . Cells [ "Status" ] . Value . ToString ( );

                  // Buttons
                  Button btnSave = new Button
                  {
                        Text = "Save",
                        Location = new Point(230, 270),
                        Size = new Size(90, 35),
                        DialogResult = DialogResult.OK,
                        BackColor = Color.FromArgb(0, 120, 212),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                  };
                  btnSave . FlatAppearance . BorderSize = 0;

                  Button btnCancel = new Button
                  {
                        Text = "Cancel",
                        Location = new Point(330, 270),
                        Size = new Size(90, 35),
                        DialogResult = DialogResult.Cancel,
                        BackColor = Color.Gray,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                  };
                  btnCancel . FlatAppearance . BorderSize = 0;

                  // Add controls to form
                  editForm . Controls . AddRange ( new Control [ ]
                  {
                lblName, txtName, lblEmail, txtEmail, lblPhone, txtPhone,
                lblStatus, cmbStatus, btnSave, btnCancel
                  } );

                  editForm . AcceptButton = btnSave;
                  editForm . CancelButton = btnCancel;

                  // Handle Enter key for save
                  txtName . KeyDown += ( s , e ) => { if ( e . KeyCode == Keys . Enter ) btnSave . PerformClick ( ); };
                  txtEmail . KeyDown += ( s , e ) => { if ( e . KeyCode == Keys . Enter ) btnSave . PerformClick ( ); };
                  txtPhone . KeyDown += ( s , e ) => { if ( e . KeyCode == Keys . Enter ) btnSave . PerformClick ( ); };

                  // Show dialog and save if OK
                  if ( editForm . ShowDialog ( ) == DialogResult . OK )
                  {
                        UpdateStudent ( studentId , txtName . Text , txtEmail . Text , txtPhone . Text ,
                            cmbStatus . SelectedItem . ToString ( ) == "Active" );
                  }
            }

            private void UpdateStudent ( int studentId , string name , string email , string phone , bool isActive )
            {
                  if ( string . IsNullOrWhiteSpace ( name ) )
                  {
                        MessageBox . Show ( "Student name is required." , "Validation Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                        UPDATE Students 
                        SET StudentName = @Name, 
                            Email = @Email, 
                            PhoneNumber = @Phone,
                            IsActive = @IsActive
                        WHERE StudentID = @StudentID", conn);

                              cmd . Parameters . AddWithValue ( "@Name" , name );
                              cmd . Parameters . AddWithValue ( "@Email" , string . IsNullOrWhiteSpace ( email ) ? ( object ) DBNull . Value : email );
                              cmd . Parameters . AddWithValue ( "@Phone" , string . IsNullOrWhiteSpace ( phone ) ? ( object ) DBNull . Value : phone );
                              cmd . Parameters . AddWithValue ( "@IsActive" , isActive );
                              cmd . Parameters . AddWithValue ( "@StudentID" , studentId );

                              cmd . ExecuteNonQuery ( );

                              MessageBox . Show ( "Student updated successfully!" , "Success" ,
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

            private void DeleteStudent ( )
            {
                  if ( dgvStudents . SelectedRows . Count == 0 )
                  {
                        MessageBox . Show ( "Please select a student to delete." , "No Selection" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  DataGridViewRow row = dgvStudents.SelectedRows[0];
                  int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                  string studentName = row.Cells["StudentName"].Value.ToString();

                  var result = MessageBox.Show(
                $"Are you sure you want to DELETE '{studentName}'?\n\nThis will also delete all associated activity records.\n\nThis action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                  if ( result == DialogResult . Yes )
                  {
                        try
                        {
                              using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                              {
                                    conn . Open ( );

                                    // Start transaction to ensure data integrity
                                    SqlTransaction transaction = conn.BeginTransaction();

                                    try
                                    {
                                          // Delete related daily activities first
                                          SqlCommand cmdActivities = new SqlCommand(
                                "DELETE FROM DailyActivities WHERE StudentID = @StudentID",
                                conn, transaction);
                                          cmdActivities . Parameters . AddWithValue ( "@StudentID" , studentId );
                                          cmdActivities . ExecuteNonQuery ( );

                                          // Delete the student
                                          SqlCommand cmdStudent = new SqlCommand(
                                "DELETE FROM Students WHERE StudentID = @StudentID",
                                conn, transaction);
                                          cmdStudent . Parameters . AddWithValue ( "@StudentID" , studentId );
                                          cmdStudent . ExecuteNonQuery ( );

                                          // Commit transaction
                                          transaction . Commit ( );

                                          MessageBox . Show ( "Student deleted successfully!" , "Success" ,
                                              MessageBoxButtons . OK , MessageBoxIcon . Information );
                                          LoadStudents ( );
                                    }
                                    catch
                                    {
                                          transaction . Rollback ( );
                                          throw;
                                    }
                              }
                        }
                        catch ( Exception ex )
                        {
                              MessageBox . Show ( $"Error deleting student: {ex . Message}" , "Error" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Error );
                        }
                  }
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

                              dgvStudents . DataSource = dt;

                              if ( dgvStudents . Columns . Count > 0 )
                              {
                                    dgvStudents . Columns [ "StudentID" ] . Visible = false;
                              }
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading students: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void AddSearchBox ( )
            {
                  // Create the search box
                  TextBox txtSearch = new TextBox
                  {
                        Name = "txtSearch",
                        Location = new Point(500, 40),
                        Size = new Size(300, 50),
                        ForeColor = Color.Gray,
                        Text = "Search students..."
                  };

                  // Placeholder behavior
                  txtSearch . GotFocus += ( s , e ) =>
                  {
                        if ( txtSearch . Text == "Search students..." )
                        {
                              txtSearch . Text = "";
                              txtSearch . ForeColor = Color . Black;
                        }
                  };
                  txtSearch . LostFocus += ( s , e ) =>
                  {
                        if ( string . IsNullOrWhiteSpace ( txtSearch . Text ) )
                        {
                              txtSearch . Text = "Search students...";
                              txtSearch . ForeColor = Color . Gray;
                        }
                  };

                  // Filter as user types
                  txtSearch . TextChanged += ( s , e ) =>
                  {
                        if ( txtSearch . Text == "Search students..." ) return;

                        if ( dgvStudents?.DataSource is DataTable dt )
                        {
                              dt . DefaultView . RowFilter = string . Format (
                                  "StudentName LIKE '%{0}%' OR Email LIKE '%{0}%'" ,
                                  txtSearch . Text . Replace ( "'" , "''" )
                              );
                        }
                  };

                  this . Controls . Add ( txtSearch );
                  txtSearch . BringToFront ( );
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
                  if ( dgvStudents . SelectedRows . Count == 0 )
                  {
                        MessageBox . Show ( "Please select a student." , "No Selection" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Warning );
                        return;
                  }

                  int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
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