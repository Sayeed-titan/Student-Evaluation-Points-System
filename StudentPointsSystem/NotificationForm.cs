using System;
using System . Drawing;
using System . Drawing . Drawing2D;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      // Enhanced notification types
      public enum NotificationType
      {
            Success,
            Error,
            Warning,
            Info
      }

      public partial class NotificationForm : Form
      {
            private Timer slideTimer;
            private Timer closeTimer;
            private int targetY;
            private int startY;
            private const int SLIDE_SPEED = 15;

            public NotificationForm ( string message , NotificationType type = NotificationType . Info )
            {
                  InitializeComponent ( );
                  SetupForm ( message , type );
                  AnimateSlideIn ( );
            }



            private void SetupForm ( string message , NotificationType type )
            {
                  // Set colors and icon based on type
                  Color bgColor, iconColor;
                  string iconText;

                  switch ( type )
                  {
                        case NotificationType . Success:
                              bgColor = Color . FromArgb ( 76 , 175 , 80 );
                              iconColor = Color . FromArgb ( 56 , 142 , 60 );
                              iconText = "✓";
                              break;
                        case NotificationType . Error:
                              bgColor = Color . FromArgb ( 244 , 67 , 54 );
                              iconColor = Color . FromArgb ( 198 , 40 , 40 );
                              iconText = "✕";
                              break;
                        case NotificationType . Warning:
                              bgColor = Color . FromArgb ( 255 , 152 , 0 );
                              iconColor = Color . FromArgb ( 245 , 124 , 0 );
                              iconText = "⚠";
                              break;
                        case NotificationType . Info:
                        default:
                              bgColor = Color . FromArgb ( 33 , 150 , 243 );
                              iconColor = Color . FromArgb ( 25 , 118 , 210 );
                              iconText = "ℹ";
                              break;
                  }

                  this . BackColor = bgColor;

                  // Create rounded corners
                  this . Region = CreateRoundedRectangle ( 0 , 0 , this . Width , this . Height , 10 );

                  // Icon Panel
                  Panel iconPanel = new Panel
                  {
                        Size = new Size(60, 90),
                        Location = new Point(0, 0),
                        BackColor = iconColor
                  };
                  iconPanel . Region = CreateRoundedRectangle ( 0 , 0 , 60 , 90 , 10 , true , false , false , true );

                  Label lblIcon = new Label
                  {
                        Text = iconText,
                        Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                  };
                  iconPanel . Controls . Add ( lblIcon );

                  // Message Label
                  Label lblMessage = new Label
                  {
                        Text = message,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10F),
                        Location = new Point(70, 15),
                        Size = new Size(260, 60),
                        AutoEllipsis = true
                  };

                  // Close Button
                  Label btnClose = new Label
                  {
                        Text = "×",
                        Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                        ForeColor = Color.White,
                        Size = new Size(20, 20),
                        Location = new Point(320, 5),
                        Cursor = Cursors.Hand,
                        TextAlign = ContentAlignment.MiddleCenter
                  };
                  btnClose . Click += ( s , e ) => this . Close ( );
                  btnClose . MouseEnter += ( s , e ) => btnClose . ForeColor = Color . FromArgb ( 230 , 230 , 230 );
                  btnClose . MouseLeave += ( s , e ) => btnClose . ForeColor = Color . White;

                  // Progress bar at bottom
                  Panel progressBar = new Panel
                  {
                        Size = new Size(this.Width, 3),
                        Location = new Point(0, 87),
                        BackColor = Color.FromArgb(100, 255, 255, 255)
                  };

                  this . Controls . AddRange ( new Control [ ] { iconPanel , lblMessage , btnClose , progressBar } );

                  // Position at bottom-right with margin
                  var workingArea = Screen.PrimaryScreen.WorkingArea;
                  targetY = workingArea . Bottom - this . Height - 20;
                  startY = workingArea . Bottom + this . Height;
                  this . Location = new Point ( workingArea . Right - this . Width - 20 , startY );

                  // Animate progress bar
                  AnimateProgressBar ( progressBar );

                  // Add shadow effect
                  this . Paint += ( s , e ) => DrawShadow ( e . Graphics );
            }

            private void AnimateSlideIn ( )
            {
                  slideTimer = new Timer { Interval = 10 };
                  slideTimer . Tick += ( s , e ) =>
                  {
                        if ( this . Top > targetY )
                        {
                              this . Top -= SLIDE_SPEED;
                        }
                        else
                        {
                              this . Top = targetY;
                              slideTimer . Stop ( );
                              slideTimer . Dispose ( );
                        }
                  };
                  slideTimer . Start ( );
            }

            private void AnimateProgressBar ( Panel progressBar )
            {
                  int duration = 3000; // 3 seconds
                  int steps = duration / 50;
                  int currentStep = 0;
                  int originalWidth = progressBar.Width;

                  Timer progressTimer = new Timer { Interval = 50 };
                  progressTimer . Tick += ( s , e ) =>
                  {
                        currentStep++;
                        progressBar . Width = originalWidth - ( originalWidth * currentStep / steps );

                        if ( currentStep >= steps )
                        {
                              progressTimer . Stop ( );
                              progressTimer . Dispose ( );
                              AnimateSlideOut ( );
                        }
                  };
                  progressTimer . Start ( );
            }

            private void AnimateSlideOut ( )
            {
                  closeTimer = new Timer { Interval = 10 };
                  closeTimer . Tick += ( s , e ) =>
                  {
                        if ( this . Top < startY )
                        {
                              this . Top += SLIDE_SPEED;
                              this . Opacity -= 0.05;
                        }
                        else
                        {
                              closeTimer . Stop ( );
                              closeTimer . Dispose ( );
                              this . Close ( );
                        }
                  };
                  closeTimer . Start ( );
            }

            private Region CreateRoundedRectangle ( int x , int y , int width , int height , int radius ,
                bool roundTopLeft = true , bool roundTopRight = true ,
                bool roundBottomRight = true , bool roundBottomLeft = true )
            {
                  GraphicsPath path = new GraphicsPath();

                  if ( roundTopLeft )
                        path . AddArc ( x , y , radius * 2 , radius * 2 , 180 , 90 );
                  else
                        path . AddLine ( x , y , x , y );

                  if ( roundTopRight )
                        path . AddArc ( x + width - radius * 2 , y , radius * 2 , radius * 2 , 270 , 90 );
                  else
                        path . AddLine ( x + width , y , x + width , y );

                  if ( roundBottomRight )
                        path . AddArc ( x + width - radius * 2 , y + height - radius * 2 , radius * 2 , radius * 2 , 0 , 90 );
                  else
                        path . AddLine ( x + width , y + height , x + width , y + height );

                  if ( roundBottomLeft )
                        path . AddArc ( x , y + height - radius * 2 , radius * 2 , radius * 2 , 90 , 90 );
                  else
                        path . AddLine ( x , y + height , x , y + height );

                  path . CloseFigure ( );
                  return new Region ( path );
            }

            private void DrawShadow ( Graphics g )
            {
                  // Simple shadow effect
                  using ( Pen shadowPen = new Pen ( Color . FromArgb ( 50 , 0 , 0 , 0 ) , 5 ) )
                  {
                        g . DrawRectangle ( shadowPen , 2 , 2 , this . Width - 4 , this . Height - 4 );
                  }
            }

            //protected override void Dispose ( bool disposing )
            //{
            //      if ( disposing )
            //      {
            //            slideTimer?.Dispose ( );
            //            closeTimer?.Dispose ( );
            //      }
            //      base . Dispose ( disposing );
            //}
      }

      // Helper class for easy notification usage
      public static class NotificationHelper
      {
            private static int notificationCount = 0;
            private const int NOTIFICATION_SPACING = 100;

            public static void ShowSuccess ( string message )
            {
                  Show ( message , NotificationType . Success );
            }

            public static void ShowError ( string message )
            {
                  Show ( message , NotificationType . Error );
            }

            public static void ShowWarning ( string message )
            {
                  Show ( message , NotificationType . Warning );
            }

            public static void ShowInfo ( string message )
            {
                  Show ( message , NotificationType . Info );
            }

            private static void Show ( string message , NotificationType type )
            {
                  NotificationForm notification = new NotificationForm(message, type);

                  // Stack multiple notifications
                  var workingArea = Screen.PrimaryScreen.WorkingArea;
                  int yOffset = notificationCount * NOTIFICATION_SPACING;
                  notification . Location = new Point (
                      workingArea . Right - notification . Width - 20 ,
                      workingArea . Bottom + notification . Height
                  );

                  notificationCount++;
                  notification . FormClosed += ( s , e ) => notificationCount--;

                  notification . Show ( );
            }
      }
}