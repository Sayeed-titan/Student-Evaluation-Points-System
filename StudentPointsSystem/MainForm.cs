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

                  this . DoubleBuffered = true;
                  this . SetStyle ( ControlStyles . OptimizedDoubleBuffer |
                                ControlStyles . AllPaintingInWmPaint |
                                ControlStyles . UserPaint , true );
                  this . UpdateStyles ( );


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

            private void ApplyModernTheme ( )
            {
                  // Main form
                  this . BackColor = Color . FromArgb ( 240 , 244 , 248 );

                  // Title
                  titleLabel . Font = new Font ( "Segoe UI" , 22F , FontStyle . Bold );
                  titleLabel . ForeColor = Color . FromArgb ( 32 , 32 , 32 );

                  // Stats Panel
                  statsPanel . BackColor = Color . White;
                  statsPanel . Padding = new Padding ( 25 );
                  lblActiveStudents . Font = new Font ( "Segoe UI" , 12F );
                  lblTodayActivities . Font = new Font ( "Segoe UI" , 12F );
                  lblPendingCalculation . Font = new Font ( "Segoe UI" , 12F );

                  // Actions Panel
                  actionsPanel . BackColor = Color . White;
                  actionsPanel . Padding = new Padding ( 25 );
                  actionsTitle . Font = new Font ( "Segoe UI" , 16F , FontStyle . Bold );

                  // Buttons - Primary
                  Color primaryBlue = Color.FromArgb(0, 120, 212);
                  foreach ( Control ctrl in actionsPanel . Controls )
                  {
                        if ( ctrl is Button btn )
                        {
                              btn . BackColor = primaryBlue;
                              btn . ForeColor = Color . White;
                              btn . FlatStyle = FlatStyle . Flat;
                              btn . FlatAppearance . BorderSize = 0;
                              btn . Font = new Font ( "Segoe UI" , 10F );
                              btn . Cursor = Cursors . Hand;
                              btn . Height = 45;

                              // Add hover effect
                              btn . MouseEnter += ( s , e ) => btn . BackColor = Color . FromArgb ( 0 , 99 , 177 );
                              btn . MouseLeave += ( s , e ) => btn . BackColor = primaryBlue;
                        }
                  }

                  // DataGridView
                  dgvRecentActivities . BorderStyle = BorderStyle . None;
                  dgvRecentActivities . BackgroundColor = Color . White;
                  dgvRecentActivities . AlternatingRowsDefaultCellStyle . BackColor = Color . FromArgb ( 248 , 249 , 250 );
                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . BackColor = primaryBlue;
                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . ForeColor = Color . White;
                  dgvRecentActivities . ColumnHeadersDefaultCellStyle . Font = new Font ( "Segoe UI" , 10F , FontStyle . Bold );
                  dgvRecentActivities . ColumnHeadersHeight = 40;
                  dgvRecentActivities . EnableHeadersVisualStyles = false;
                  dgvRecentActivities . RowTemplate . Height = 35;
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

            private void AddAllCharts ( )
            {
                  int leftMargin = 20;
                  int horizontalSpacing = 20;
                  int verticalSpacing = 30;

                  // Start below the data table (676px height + some spacing)
                  int currentY = 676 + 40;

                  // Calculate chart dimensions - 2 charts per row
                  // Total width: 1200 - margins - spacing = 1160
                  int chartWidth = (1200 - (leftMargin * 2) - horizontalSpacing) / 2;
                  int chartHeight = 350;

                  // Row 1: Top Students (Column) and Activity Distribution (Pie)
                  Chart chartTopStudents = CreateTopStudentsChart();
                  chartTopStudents . Location = new Point ( leftMargin , currentY );
                  chartTopStudents . Size = new Size ( chartWidth , chartHeight );
                  dashboardPanel . Controls . Add ( chartTopStudents );

                  Chart chartPie = CreateActivityPieChart();
                  chartPie . Location = new Point ( leftMargin + chartWidth + horizontalSpacing , currentY );
                  chartPie . Size = new Size ( chartWidth , chartHeight );
                  dashboardPanel . Controls . Add ( chartPie );

                  currentY += chartHeight + verticalSpacing;

                  // Row 2: Weekly Points Distribution and Points Trend
                  Chart chartWeekly = CreateWeeklyPointsChart();
                  chartWeekly . Location = new Point ( leftMargin , currentY );
                  chartWeekly . Size = new Size ( chartWidth , chartHeight );
                  dashboardPanel . Controls . Add ( chartWeekly );

                  Chart chartProgress = CreateProgressChart();
                  chartProgress . Location = new Point ( leftMargin + chartWidth + horizontalSpacing , currentY );
                  chartProgress . Size = new Size ( chartWidth , chartHeight );
                  dashboardPanel . Controls . Add ( chartProgress );

                  currentY += chartHeight + verticalSpacing;

                  // Set minimum size for panel to enable scrolling
                  dashboardPanel . AutoScrollMinSize = new Size ( 1200 , currentY );
            }

            private Chart CreateTopStudentsChart ( )
            {
                  Chart chart = new Chart();
                  chart . BackColor = Color . White;

                  // Chart Area
                  ChartArea chartArea = new ChartArea("MainArea");
                  chartArea . BackColor = Color . White;
                  chartArea . AxisX . MajorGrid . Enabled = false;
                  chartArea . AxisY . MajorGrid . LineColor = Color . LightGray;
                  chartArea . AxisX . LabelStyle . Angle = -45;
                  chart . ChartAreas . Add ( chartArea );

                  // Series
                  Series series = new Series("Student Points");
                  series . ChartType = SeriesChartType . Column;
                  series . Color = Color . FromArgb ( 0 , 120 , 212 );
                  series . IsValueShownAsLabel = true;
                  series . Font = new Font ( "Segoe UI" , 9F , FontStyle . Bold );
                  chart . Series . Add ( series );

                  // Title
                  Title title = new Title("Top 3 Students This Week");
                  title . Font = new Font ( "Segoe UI" , 14F , FontStyle . Bold );
                  chart . Titles . Add ( title );

                  // Load data
                  LoadTopStudentsData ( chart );

                  return chart;
            }

            private void LoadTopStudentsData ( Chart chart )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 3 
                    s.StudentName, 
                    ISNULL(SUM(da.PointsEarned), 0) AS TotalPoints
                FROM Students s
                LEFT JOIN DailyActivities da ON s.StudentID = da.StudentID 
                    AND da.ActivityDate >= DATEADD(DAY, -7, GETDATE())
                    AND da.IsCalculated = 1
                WHERE s.IsActive = 1
                GROUP BY s.StudentID, s.StudentName
                ORDER BY TotalPoints DESC", conn);

                              SqlDataReader reader = cmd.ExecuteReader();
                              Series series = chart.Series[0];

                              while ( reader . Read ( ) )
                              {
                                    string name = reader["StudentName"].ToString();
                                    int points = Convert.ToInt32(reader["TotalPoints"]);
                                    series . Points . AddXY ( name , points );
                              }

                              reader . Close ( );
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading chart: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private Chart CreateWeeklyPointsChart ( )
            {
                  Chart chart = new Chart();
                  chart . BackColor = Color . White;

                  // Chart Area
                  ChartArea area = new ChartArea();
                  area . AxisX . LabelStyle . Angle = -45;
                  area . AxisX . MajorGrid . Enabled = false;
                  area . AxisY . MajorGrid . LineColor = Color . LightGray;
                  chart . ChartAreas . Add ( area );

                  // Series
                  Series series = new Series("Points");
                  series . ChartType = SeriesChartType . Column;
                  series . Color = Color . FromArgb ( 0 , 120 , 212 );
                  series . IsValueShownAsLabel = true;
                  series . Font = new Font ( "Segoe UI" , 9F , FontStyle . Bold );
                  chart . Series . Add ( series );

                  // Title
                  chart . Titles . Add ( new Title ( "Weekly Points Distribution" ,
                      Docking . Top , new Font ( "Segoe UI" , 14F , FontStyle . Bold ) , Color . Black ) );

                  return chart;
            }

            private Chart CreateProgressChart ( )
            {
                  Chart chart = new Chart();
                  chart . BackColor = Color . White;

                  ChartArea area = new ChartArea();
                  area . AxisX . Title = "Date";
                  area . AxisY . Title = "Points";
                  area . AxisX . MajorGrid . LineColor = Color . LightGray;
                  area . AxisY . MajorGrid . LineColor = Color . LightGray;
                  area . AxisX . LabelStyle . Angle = -45;
                  chart . ChartAreas . Add ( area );

                  Series series = new Series("Progress");
                  series . ChartType = SeriesChartType . Line;
                  series . Color = Color . FromArgb ( 76 , 175 , 80 );
                  series . BorderWidth = 3;
                  series . MarkerStyle = MarkerStyle . Circle;
                  series . MarkerSize = 8;
                  series . MarkerColor = Color . FromArgb ( 76 , 175 , 80 );
                  chart . Series . Add ( series );

                  chart . Titles . Add ( new Title ( "Points Trend (Last 7 Days)" ,
                      Docking . Top , new Font ( "Segoe UI" , 14F , FontStyle . Bold ) , Color . Black ) );

                  // Load data
                  LoadProgressData ( chart );

                  return chart;
            }

            private void LoadProgressData ( Chart chart )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    da.ActivityDate,
                    SUM(da.PointsEarned) AS DailyTotal
                FROM DailyActivities da
                WHERE da.ActivityDate >= DATEADD(DAY, -7, GETDATE())
                AND da.IsCalculated = 1
                GROUP BY da.ActivityDate
                ORDER BY da.ActivityDate", conn);

                              SqlDataReader reader = cmd.ExecuteReader();
                              Series series = chart.Series[0];

                              while ( reader . Read ( ) )
                              {
                                    DateTime date = Convert.ToDateTime(reader["ActivityDate"]);
                                    int points = Convert.ToInt32(reader["DailyTotal"]);
                                    series . Points . AddXY ( date . ToShortDateString ( ) , points );
                              }

                              reader . Close ( );
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading progress chart: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }

            private Chart CreateActivityPieChart ( )
            {
                  Chart chart = new Chart();
                  chart . BackColor = Color . White;

                  ChartArea area = new ChartArea();
                  area . BackColor = Color . White;
                  chart . ChartAreas . Add ( area );

                  Series series = new Series("Activities");
                  series . ChartType = SeriesChartType . Pie;

                  // Show percentage on the pie slices
                  series . IsValueShownAsLabel = true;
                  series . Label = "#PERCENT{P1}"; // Show percentage with 1 decimal
                  series [ "PieLabelStyle" ] = "Outside"; // Place labels outside pie

                  // CRITICAL: This makes the legend show activity names
                  series . LegendText = "#VALX (#VALY)"; // Shows "Activity Name (Count)"

                  chart . Series . Add ( series );

                  // Add Legend
                  Legend legend = new Legend();
                  legend . Docking = Docking . Right;
                  legend . Font = new Font ( "Segoe UI" , 9F );
                  legend . Title = "Activities";
                  legend . TitleFont = new Font ( "Segoe UI" , 10F , FontStyle . Bold );
                  chart . Legends . Add ( legend );

                  // Title
                  Title title = new Title("Activity Type Distribution");
                  title . Font = new Font ( "Segoe UI" , 14F , FontStyle . Bold );
                  title . Docking = Docking . Top;
                  chart . Titles . Add ( title );

                  // Load data
                  LoadActivityPieData ( chart );

                  return chart;
            }

            private void LoadActivityPieData ( Chart chart )
            {
                  try
                  {
                        using ( SqlConnection conn = new SqlConnection ( connectionString ) )
                        {
                              conn . Open ( );
                              SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    at.ActivityName,
                    COUNT(*) AS ActivityCount
                FROM DailyActivities da
                JOIN ActivityTypes at ON da.ActivityTypeID = at.ActivityTypeID
                WHERE da.IsCalculated = 1
                GROUP BY at.ActivityName
                ORDER BY ActivityCount DESC", conn);

                              SqlDataReader reader = cmd.ExecuteReader();
                              Series series = chart.Series[0];

                              // Modern, distinct color palette
                              Color[] colors = new Color[] {
                Color.FromArgb(0, 120, 212),    // Blue
                Color.FromArgb(76, 175, 80),    // Green
                Color.FromArgb(255, 152, 0),    // Orange
                Color.FromArgb(244, 67, 54),    // Red
                Color.FromArgb(156, 39, 176),   // Purple
                Color.FromArgb(33, 150, 243),   // Light Blue
                Color.FromArgb(255, 193, 7),    // Amber
                Color.FromArgb(96, 125, 139)    // Blue Grey
            };

                              int colorIndex = 0;
                              bool hasData = false;

                              while ( reader . Read ( ) )
                              {
                                    hasData = true;
                                    string name = reader["ActivityName"].ToString();
                                    int count = Convert.ToInt32(reader["ActivityCount"]);

                                    // Create data point with name as X value
                                    DataPoint point = new DataPoint();
                                    point . SetValueXY ( name , count );
                                    point . Color = colors [ colorIndex % colors . Length ];

                                    // Add border for better visibility
                                    point . BorderColor = Color . White;
                                    point . BorderWidth = 2;

                                    // Custom label for this specific point (optional)
                                    point . Label = "#PERCENT{P1}";
                                    point . LegendText = name + " (" + count + ")";

                                    series . Points . Add ( point );
                                    colorIndex++;
                              }

                              reader . Close ( );

                              // Show message if no data
                              if ( !hasData )
                              {
                                    series . Points . AddXY ( "No Data" , 1 );
                                    series . Points [ 0 ] . Color = Color . LightGray;
                                    series . Points [ 0 ] . Label = "No activities found";
                              }
                        }
                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading pie chart: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );
                  }
            }


            private void MainForm_Load ( object sender , EventArgs e )
            {
                  //ModernTheme . ApplyTheme ( this );

                  // Set form size
                  Size = new Size ( 1220 , 700 );
                  StartPosition = FormStartPosition . CenterScreen;

                  // Configure dashboard panel for scrolling
                  dashboardPanel . AutoScroll = true;
                  dashboardPanel . Dock = DockStyle . Fill;
                  dashboardPanel . Padding = new Padding ( 20 );

                  // Load dashboard data first
                  LoadDashboard ( );

                  // Add all charts with optimized layout
                  AddAllCharts ( );

                  this . MinimumSize = new Size ( 1200 , 700 );

                  // Anchor controls for resizing:
                  dgvRecentActivities . Anchor = AnchorStyles . Top | AnchorStyles . Bottom |
                                                AnchorStyles . Left | AnchorStyles . Right;

                  dashboardPanel . Anchor = AnchorStyles . Top | AnchorStyles . Bottom |
                                          AnchorStyles . Left | AnchorStyles . Right;

                  NotificationHelper . ShowInfo ( "Welcome to Student Points System!" );


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

                        NotificationHelper . ShowSuccess ( "Dashboard loaded successfully!" );

                  }
                  catch ( Exception ex )
                  {
                        MessageBox . Show ( $"Error loading dashboard: {ex . Message}" , "Error" ,
                            MessageBoxButtons . OK , MessageBoxIcon . Error );

                        NotificationHelper . ShowError ( $"Failed to load dashboard: {ex . Message}" );

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