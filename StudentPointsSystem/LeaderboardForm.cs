using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class LeaderboardForm : Form
      {
            private string connectionString;

            public LeaderboardForm ( string connStr )
            {
                  connectionString = connStr;
                  InitializeComponent ( );
            }

            private void LeaderboardForm_Load ( object sender , EventArgs e )
            {
                  // Set to current week start
                  dtpWeekStart . Value = GetWeekStart ( DateTime . Now );
                  LoadLeaderboard ( );
            }

            private void LoadLeaderboard ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );

                              // Get the week start from SQL Server to ensure consistency
                              SqlCommand weekCmd = new SqlCommand(
                        "SELECT DATEADD(DAY, -(DATEPART(WEEKDAY, @SelectedDate) - 1), CAST(@SelectedDate AS DATE))",
                        conn);
                              weekCmd . Parameters . AddWithValue ( "@SelectedDate" , dtpWeekStart . Value . Date );
                              DateTime weekStart = (DateTime)weekCmd.ExecuteScalar();

                              // Update the date picker to show the calculated week start
                              dtpWeekStart . Value = weekStart;

                              SqlCommand cmd = new SqlCommand("sp_GetWeeklyLeaderboard", conn);
                              cmd . CommandType = CommandType . StoredProcedure;
                              cmd . Parameters . AddWithValue ( "@WeekStartDate" , weekStart );

                              SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );

                              dgvLeaderboard . DataSource = dt;

                              // Check if we have data
                              if ( dt . Rows . Count == 0 )
                              {
                                    MessageBox . Show ( $"No data found for the week starting {weekStart . ToShortDateString ( )}.\n\n" +
                                        "Make sure:\n" +
                                        "1. Students are added\n" +
                                        "2. Activities are recorded\n" +
                                        "3. Daily points are calculated" ,
                                        "No Data" , MessageBoxButtons . OK , MessageBoxIcon . Information );
                                    return;
                              }

                              // Format the grid only if columns exist
                              if ( dgvLeaderboard . Columns . Count > 0 && dgvLeaderboard . Columns . Contains ( "Rank" ) )
                              {
                                    dgvLeaderboard . Columns [ "Rank" ] . Width = 60;

                                    if ( dgvLeaderboard . Columns . Contains ( "StudentID" ) )
                                          dgvLeaderboard . Columns [ "StudentID" ] . Visible = false;

                                    if ( dgvLeaderboard . Columns . Contains ( "StudentName" ) )
                                          dgvLeaderboard . Columns [ "StudentName" ] . HeaderText = "Student Name";

                                    if ( dgvLeaderboard . Columns . Contains ( "TotalPoints" ) )
                                    {
                                          dgvLeaderboard . Columns [ "TotalPoints" ] . HeaderText = "Total Points";
                                          dgvLeaderboard . Columns [ "TotalPoints" ] . DefaultCellStyle . Alignment = DataGridViewContentAlignment . MiddleCenter;
                                    }

                                    if ( dgvLeaderboard . Columns . Contains ( "WeekStartDate" ) )
                                    {
                                          dgvLeaderboard . Columns [ "WeekStartDate" ] . HeaderText = "Week Start";
                                          dgvLeaderboard . Columns [ "WeekStartDate" ] . DefaultCellStyle . Format = "d";
                                    }

                                    if ( dgvLeaderboard . Columns . Contains ( "WeekEndDate" ) )
                                    {
                                          dgvLeaderboard . Columns [ "WeekEndDate" ] . HeaderText = "Week End";
                                          dgvLeaderboard . Columns [ "WeekEndDate" ] . DefaultCellStyle . Format = "d";
                                    }

                                    // Highlight top 3
                                    foreach ( DataGridViewRow row in dgvLeaderboard . Rows )
                                    {
                                          if ( row . Cells [ "Rank" ] . Value != null && row . Cells [ "Rank" ] . Value != DBNull . Value )
                                          {
                                                int rank = Convert.ToInt32(row.Cells["Rank"].Value);
                                                if ( rank == 1 )
                                                      row . DefaultCellStyle . BackColor = System . Drawing . Color . Gold;
                                                else if ( rank == 2 )
                                                      row . DefaultCellStyle . BackColor = System . Drawing . Color . Silver;
                                                else if ( rank == 3 )
                                                      row . DefaultCellStyle . BackColor = System . Drawing . Color . SandyBrown;
                                          }
                                    }

                                    MessageBox . Show ( $"Leaderboard loaded successfully!\n\n" +
                                        $"Week: {weekStart . ToShortDateString ( )} - {weekStart . AddDays ( 6 ) . ToShortDateString ( )}\n" +
                                        $"Total Students: {dt . Rows . Count}" ,
                                        "Success" , MessageBoxButtons . OK , MessageBoxIcon . Information );
                              }
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading leaderboard: {ex . Message}\n\nStack Trace: {ex . StackTrace}" ,
                            "Error" , MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private void BtnLoad_Click ( object sender , EventArgs e )
            {
                  LoadLeaderboard ( );
            }

            private void BtnSaveSummary_Click ( object sender , EventArgs e )
            {
                  DateTime weekStart = GetWeekStart(dtpWeekStart.Value);

                  var result = MessageBox.Show(
                $"Save weekly summary for week starting {weekStart.ToShortDateString()}?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                  if ( result == DialogResult . Yes )
                  {
                        try
                        {
                              using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                              {
                                    conn . Open ( );
                                    SqlCommand cmd = new SqlCommand("sp_SaveWeeklySummary", conn);
                                    cmd . CommandType = CommandType . StoredProcedure;
                                    cmd . Parameters . AddWithValue ( "@WeekStartDate" , weekStart );
                                    cmd . ExecuteNonQuery ( );

                                    MessageBox . Show ( "Weekly summary saved successfully!" , "Success" ,
                                        MessageBoxButtons . OK , MessageBoxIcon . Information );
                              }
                        }
                        catch ( Exception ex )
                        {
                              MessageBox . Show ( $"Error saving summary: {ex . Message}" , "Error" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Error );
                        }
                  }
            }

            private DateTime GetWeekStart ( DateTime date )
            {
                  // Match SQL Server's logic: Sunday = day 0
                  int daysSinceSunday = (int)date.DayOfWeek;
                  return date . AddDays ( -daysSinceSunday ) . Date;
            }
      }
}