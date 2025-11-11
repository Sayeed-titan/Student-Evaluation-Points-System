using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class ViewProjectsForm : Form
      {
            private string connectionString;

            public ViewProjectsForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void ViewProjectsForm_Load ( object sender , EventArgs e )
            {
                  LoadProjects ( );
            }

            private void LoadProjects ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT 
                            p.ProjectID,
                            s.StudentName,
                            p.ProjectName,
                            p.SubmissionDate,
                            p.FunctionalityScore,
                            p.CodeQualityScore,
                            p.DatabaseDesignScore,
                            p.UIUXScore,
                            p.GitUsageScore,
                            p.TotalScore,
                            CASE WHEN p.IsPassed = 1 THEN 'PASSED' ELSE 'FAILED' END AS Status
                        FROM Projects p
                        JOIN Students s ON p.StudentID = s.StudentID
                        ORDER BY p.SubmissionDate DESC", conn);

                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );

                              dgvProjects . DataSource = dt;

                              if ( dgvProjects . Columns . Count > 0 )
                              {
                                    dgvProjects . Columns [ "ProjectID" ] . Visible = false;

                                    // Format score columns
                                    foreach ( DataGridViewRow row in dgvProjects . Rows )
                                    {
                                          string status = row.Cells["Status"].Value.ToString();
                                          if ( status == "PASSED" )
                                                row . Cells [ "Status" ] . Style . ForeColor = System . Drawing . Color . Green;
                                          else
                                                row . Cells [ "Status" ] . Style . ForeColor = System . Drawing . Color . Red;
                                    }
                              }
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading projects: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }
      }
}