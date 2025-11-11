using System;
using System . Data;
using System . Data . SqlClient;
using System . Drawing;
using System . Windows . Forms;
using System . Windows . Forms . DataVisualization . Charting;


namespace StudentPointsSystem
{
      public partial class MainForm : Form
      {
            private string connectionString = "Server=localhost;Database=StudentPointsSystem;Integrated Security=true;";

            public MainForm ( )
            {
                  InitializeComponent ( );


                  // In each form with DataGridView:
                  dgvRecentActivities . BorderStyle = BorderStyle . None;
                  dgvRecentActivities . BackgroundColor = Color . White;
                  dgvRecentActivities . AlternatingRowsDefaultCellStyle . BackColor = Color . FromArgb ( 248 , 249 , 250 );

                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . BackColor = Color . DimGray;
                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . ForeColor = Color . White;

                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . Font = new Font ( "Segoe UI" , 10F , FontStyle . Bold );
                  dgvRecentActivities . ColumnHeadersHeight = 40;
                  dgvRecentActivities . EnableHeadersVisualStyles = false;
                  dgvRecentActivities . RowTemplate . Height = 35;
                  dgvRecentActivities . DefaultCellStyle . SelectionBackColor = Color . FromArgb ( 0 , 120 , 212 );
                  dgvRecentActivities . DefaultCellStyle . Font = new Font ( "Segoe UI" , 10F , FontStyle . Regular );
                  dgvRecentActivities . DefaultCellStyle . SelectionForeColor = Color . White;
                  dgvRecentActivities . CellBorderStyle = DataGridViewCellBorderStyle . SingleHorizontal;
                  dgvRecentActivities . GridColor = Color . FromArgb ( 230 , 230 , 230 );


            }

            public class RoundedPanel : Panel
            {
                  protected override void OnPaint ( PaintEventArgs e )
                  {
                        base . OnPaint ( e );
                        e . Graphics . SmoothingMode = System . Drawing . Drawing2D . SmoothingMode . AntiAlias;

                        using ( var path = GetRoundedRect ( this . ClientRectangle , 10 ) )
                        using ( var brush = new SolidBrush ( this . BackColor ) )
                        {
                              e . Graphics . FillPath ( brush , path );
                        }
                  }

                  private System . Drawing . Drawing2D . GraphicsPath GetRoundedRect ( Rectangle bounds , int radius )
                  {
                        var path = new System.Drawing.Drawing2D.GraphicsPath();
                        path . AddArc ( bounds . X , bounds . Y , radius , radius , 180 , 90 );
                        path . AddArc ( bounds . Right - radius , bounds . Y , radius , radius , 270 , 90 );
                        path . AddArc ( bounds . Right - radius , bounds . Bottom - radius , radius , radius , 0 , 90 );
                        path . AddArc ( bounds . X , bounds . Bottom - radius , radius , radius , 90 , 90 );
                        path . CloseFigure ( );
                        return path;
                  }
            }

            //private void AddDashboardChart ( )
            //{
            //      Chart chartStudentPoints = new Chart();
            //      chartStudentPoints . Location = new Point ( 20 , 650 );
            //      chartStudentPoints . Size = new Size ( 550 , 300 );
            //      chartStudentPoints . BackColor = Color . White;

            //      // Add Chart Area
            //      ChartArea chartArea = new ChartArea("MainArea");
            //      chartArea . BackColor = Color . White;
            //      chartStudentPoints . ChartAreas . Add ( chartArea );

            //      // Add Series
            //      Series series = new Series("Student Points");
            //      series . ChartType = SeriesChartType . Column;
            //      series . Color = Color . FromArgb ( 0 , 120 , 212 );
            //      series . IsValueShownAsLabel = true;
            //      chartStudentPoints . Series . Add ( series );

            //      // Add Title
            //      Title title = new Title("Top 3 Students This Week");
            //      title . Font = new Font ( "Segoe UI" , 14F , FontStyle . Bold );
            //      chartStudentPoints . Titles . Add ( title );

            //      // Load data from database
            //      LoadChartData ( chartStudentPoints );

            //      // Add to form
            //      dashboardPanel . Controls . Add ( chartStudentPoints );
            //}

            //private void LoadChartData ( Chart chart )
            //{
            //      try
            //      {
            //            using ( SqlConnection conn = new SqlConnection ( connectionString ) )
            //            {
            //                  conn . Open ( );
            //                  SqlCommand cmd = new SqlCommand(@"
            //    SELECT TOP 3 
            //        s.StudentName, 
            //        ISNULL(SUM(da.PointsEarned), 0) AS TotalPoints
            //    FROM Students s
            //    LEFT JOIN DailyActivities da ON s.StudentID = da.StudentID 
            //        AND da.ActivityDate >= DATEADD(DAY, -7, GETDATE())
            //        AND da.IsCalculated = 1
            //    WHERE s.IsActive = 1
            //    GROUP BY s.StudentID, s.StudentName
            //    ORDER BY TotalPoints DESC", conn);

            //                  SqlDataReader reader = cmd.ExecuteReader();
            //                  Series series = chart.Series[0];

            //                  while ( reader . Read ( ) )
            //                  {
            //                        string name = reader["StudentName"].ToString();
            //                        int points = Convert.ToInt32(reader["TotalPoints"]);
            //                        series . Points . AddXY ( name , points );
            //                  }

            //                  reader . Close ( );
            //            }
            //      }
            //      catch ( Exception ex )
            //      {
            //            MessageBox . Show ( $"Error loading chart: {ex . Message}" , "Error" ,
            //                MessageBoxButtons . OK , MessageBoxIcon . Error );
            //      }
            //}

            private void MainForm_Load ( object sender , EventArgs e )
            {
                  //ModernTheme . ApplyTheme ( this );

                  LoadDashboard ( );
                  //AddDashboardChart ( );



                  this . BackColor = Color . FromArgb ( 240 , 244 , 248 ); // Light gray-blue background

                  // For panels:
                  statsPanel . BackColor = Color . White;
                  actionsPanel . BackColor = Color . White;

                  // For buttons (primary actions):
                  btnAddStudent . BackColor = Color . FromArgb ( 0 , 120 , 212 ); // Microsoft Blue
                  btnAddStudent . ForeColor = Color . White;
                  btnAddStudent . FlatStyle = FlatStyle . Flat;
                  btnAddStudent . FlatAppearance . BorderSize = 0;

                  btnAddStudent . Image = new Bitmap ( Properties . Resources . add_user , new Size ( 48 , 48 ) );
                  btnAddStudent . ImageAlign = ContentAlignment . MiddleLeft;
                  btnAddStudent . TextAlign = ContentAlignment . MiddleCenter;
                  btnAddStudent . TextImageRelation = TextImageRelation . ImageBeforeText;

                  //btnAddStudent . Padding = new Padding (20 , 0 , 0 , 0 ); // Add 10px space between image and text
                  //btnAddStudent . Text = " Add Student"; // Leading spaces before text
                  //btnAddStudent . TextImageRelation = TextImageRelation . ImageBeforeText;
                  btnAddStudent . TextImageRelation = TextImageRelation . Overlay; // Text over image (no gap)

                  btnRecordActivity . Image = new Bitmap ( Properties . Resources . add_activityRecord , new Size ( 48 , 48 ) );
                  btnRecordActivity . ImageAlign = ContentAlignment . MiddleLeft;
                  btnRecordActivity . TextAlign = ContentAlignment . MiddleCenter;
                  btnRecordActivity . TextImageRelation = TextImageRelation . ImageBeforeText;
                  btnRecordActivity.TextImageRelation = TextImageRelation . Overlay;

                  btnCalculatePoints . Text = "   Calculate Daily Points";
                  btnCalculatePoints . Image = new Bitmap ( Properties . Resources . activity_calculation , new Size ( 48 , 48 ) );
                  btnCalculatePoints . ImageAlign = ContentAlignment . MiddleLeft;
                  btnCalculatePoints . TextAlign = ContentAlignment . MiddleCenter;
                  btnCalculatePoints . TextImageRelation = TextImageRelation . ImageBeforeText;
                  btnCalculatePoints . TextImageRelation = TextImageRelation . Overlay;

                  btnLeaderboard.Text = " View Leaderboard";
                  btnLeaderboard . Image = new Bitmap ( Properties . Resources . leaderboard , new Size ( 48 , 48 ) );
                  btnLeaderboard . ImageAlign = ContentAlignment . MiddleLeft;
                  btnLeaderboard . TextAlign = ContentAlignment . MiddleCenter;
                  btnLeaderboard . TextImageRelation = TextImageRelation . ImageBeforeText;
                  btnLeaderboard . TextImageRelation = TextImageRelation . Overlay;

                  // Install System.Windows.Forms (already included)
                  // Add shadow effect manually:

                  //statsPanel . BorderStyle = BorderStyle . None;
                  //statsPanel . BackColor = Color . White;

                  //// Add a custom paint event for shadow:
                  //statsPanel . Paint += ( s , pe ) => {
                  //      ControlPaint . DrawBorder ( pe . Graphics , statsPanel . ClientRectangle ,
                  //          Color . FromArgb ( 230 , 230 , 230 ) , 1 , ButtonBorderStyle . Solid ,
                  //          Color . FromArgb ( 230 , 230 , 230 ) , 1 , ButtonBorderStyle . Solid ,
                  //          Color . FromArgb ( 200 , 200 , 200 ) , 2 , ButtonBorderStyle . Solid ,
                  //          Color . FromArgb ( 200 , 200 , 200 ) , 2 , ButtonBorderStyle . Solid );
                  //};

                  RoundedPanel statsPanels = new RoundedPanel()
                  {
                        Width = 300,
                        Height = 150,
                        BackColor = Color.White,
                        Location = new Point(50, 50),
                        BorderStyle = BorderStyle.None // optional, since your custom paint handles edges
                  };

                  // Add it to the form (or a parent container)
                  this . Controls . Add ( statsPanels );

                  // Create the PictureBox (for your icon)
                  PictureBox iconBox = new PictureBox()
                  {
                        Size = new Size(256, 256), // icon size
                        Image = Properties.Resources.points_system2, // your resource image
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Anchor = AnchorStyles.Top | AnchorStyles.Right, // stick to the right side
                        Location = new Point(statsPanel.Width - 250), // position it inside the panel
                        BackColor = Color.Transparent
                  };

                  // Add the PictureBox to the custom panel
                  statsPanel . Controls . Add ( iconBox );


                  
            }

            private void LoadDashboard ( )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );

                              // Active Students Count
                              SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students WHERE IsActive = 1", conn);
                              int activeStudents = (int)cmd.ExecuteScalar();
                              lblActiveStudents . Text = $"Active Students: {activeStudents}";

                              // Today's Activities
                              cmd = new SqlCommand ( "SELECT COUNT(*) FROM DailyActivities WHERE ActivityDate = CAST(GETDATE() AS DATE)" , conn );
                              int todayActivities = (int)cmd.ExecuteScalar();
                              lblTodayActivities . Text = $"Today's Activities: {todayActivities}";

                              // Pending Calculations
                              cmd = new SqlCommand ( "SELECT COUNT(*) FROM DailyActivities WHERE IsCalculated = 0" , conn );
                              int pending = (int)cmd.ExecuteScalar();
                              lblPendingCalculation . Text = $"Pending Calculations: {pending}";

                              // Recent Activities
                              SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT TOP 10 
                            s.StudentName,
                            at.ActivityName,
                            da.PointsEarned,
                            da.ActivityDate,
                            CASE WHEN da.IsCalculated = 1 THEN 'Yes' ELSE 'No' END AS Calculated
                        FROM DailyActivities da
                        JOIN Students s ON da.StudentID = s.StudentID
                        JOIN ActivityTypes at ON da.ActivityTypeID = at.ActivityTypeID
                        ORDER BY da.CreatedDate DESC", conn);

                              DataTable dt = new DataTable();
                              adapter . Fill ( dt );
                              dgvRecentActivities . DataSource = dt;
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading dashboard: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }

            }

            private void AddStudent_Click ( object sender , EventArgs e )
            {
                  AddStudentForm form = new AddStudentForm(connectionString);
                  if ( form . ShowDialog ( ) == DialogResult . OK )
                  {
                        LoadDashboard ( );
                  }
            }

            private void ManageStudents_Click ( object sender , EventArgs e )
            {
                  ManageStudentsForm form = new ManageStudentsForm(connectionString);
                  form . ShowDialog ( );
                  LoadDashboard ( );
            }

            private void RecordActivity_Click ( object sender , EventArgs e )
            {
                  RecordActivityForm form = new RecordActivityForm(connectionString);
                  if ( form . ShowDialog ( ) == DialogResult . OK )
                  {
                        LoadDashboard ( );
                  }
            }

            private void RecordBugBounty_Click ( object sender , EventArgs e )
            {
                  BugBountyForm form = new BugBountyForm(connectionString);
                  if ( form . ShowDialog ( ) == DialogResult . OK )
                  {
                        LoadDashboard ( );
                  }
            }

            private void CalculateDailyPoints_Click ( object sender , EventArgs e )
            {
                  DateSelectionForm dateForm = new DateSelectionForm();
                  if ( dateForm . ShowDialog ( ) == DialogResult . OK )
                  {
                        try
                        {
                              using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                              {
                                    conn . Open ( );
                                    SqlCommand cmd = new SqlCommand("sp_CalculateDailyPoints", conn);
                                    cmd . CommandType = CommandType . StoredProcedure;
                                    cmd . Parameters . AddWithValue ( "@CalculationDate" , dateForm . SelectedDate );
                                    cmd . ExecuteNonQuery ( );

                                    MessageBox . Show ( $"Daily points calculated successfully for {dateForm . SelectedDate . ToShortDateString ( )}!" ,
                                        "Success" , MessageBoxButtons . OK , MessageBoxIcon . Information );
                                    LoadDashboard ( );
                              }
                        }
                        catch ( Exception ex )
                        {
                              MessageBox . Show ( $"Error calculating points: {ex . Message}" , "Error" ,
                                  MessageBoxButtons . OK , MessageBoxIcon . Error );
                        }
                  }
            }

            private void ShowLeaderboard_Click ( object sender , EventArgs e )
            {
                  LeaderboardForm form = new LeaderboardForm(connectionString);
                  form . ShowDialog ( );
            }

            private void ShowStudentPerformance_Click ( object sender , EventArgs e )
            {
                  StudentPerformanceForm form = new StudentPerformanceForm(connectionString);
                  form . ShowDialog ( );
            }

            private void AddProjectGrade_Click ( object sender , EventArgs e )
            {
                  ProjectGradeForm form = new ProjectGradeForm(connectionString);
                  if ( form . ShowDialog ( ) == DialogResult . OK )
                  {
                        MessageBox . Show ( "Project grade saved successfully!" , "Success" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Information );
                  }
            }

            private void ViewProjects_Click ( object sender , EventArgs e )
            {
                  ViewProjectsForm form = new ViewProjectsForm(connectionString);
                  form . ShowDialog ( );
            }

            private void BtnAddStudent_MouseEnter ( object sender , EventArgs e )
            {
                  btnAddStudent . BackColor = Color . FromArgb ( 0 , 99 , 177 ); // Darker blue
            }

            private void BtnAddStudent_MouseLeave ( object sender , EventArgs e )
            {
                  btnAddStudent . BackColor = Color . FromArgb ( 0 , 120 , 212 ); // Original blue
            }
      }
}