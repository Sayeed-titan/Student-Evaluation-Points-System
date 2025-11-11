using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      public partial class NotificationForm : Form
      {
            public NotificationForm ( string message , Color backgroundColor )
            {
                  this . FormBorderStyle = FormBorderStyle . None;
                  this . ShowInTaskbar = false;
                  this . StartPosition = FormStartPosition . Manual;
                  this . Size = new Size ( 300 , 80 );
                  this . BackColor = backgroundColor;

                  Label lblMessage = new Label
                  {
                        Text = message,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                  };
                  this . Controls . Add ( lblMessage );

                  // Position at bottom-right
                  var workingArea = Screen.PrimaryScreen.WorkingArea;
                  this . Location = new Point (
                      workingArea . Right - this . Width - 10 ,
                      workingArea . Bottom - this . Height - 10
                  );

                  // Auto-close after 3 seconds
                  Timer timer = new Timer { Interval = 3000 };
                  timer . Tick += ( s , e ) => { this . Close ( ); timer . Dispose ( ); };
                  timer . Start ( );
            }
      }
}
