using System;
using System . Drawing;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      /// <summary>
      /// Modern theme helper class - Apply modern styling to any form with one line of code!
      /// Usage: ModernTheme.ApplyTheme(this);
      /// </summary>
      public static class ModernTheme
      {
            // Color Palette
            public static class Colors
            {
                  // Primary Colors
                  public static Color Primary = Color.FromArgb(0, 120, 212);        // Microsoft Blue
                  public static Color PrimaryDark = Color.FromArgb(0, 99, 177);     // Hover state
                  public static Color Success = Color.FromArgb(76, 175, 80);        // Green
                  public static Color Danger = Color.FromArgb(244, 67, 54);         // Red
                  public static Color Warning = Color.FromArgb(255, 152, 0);        // Orange
                  public static Color Info = Color.FromArgb(33, 150, 243);          // Light Blue

                  // Neutral Colors
                  public static Color Background = Color.FromArgb(240, 244, 248);   // Light Gray-Blue
                  public static Color Surface = Color.White;                         // White
                  public static Color Border = Color.FromArgb(230, 230, 230);       // Light Gray
                  public static Color TextPrimary = Color.FromArgb(32, 32, 32);     // Dark Gray
                  public static Color TextSecondary = Color.FromArgb(96, 96, 96);   // Medium Gray

                  // DataGrid Colors
                  public static Color GridAlternate = Color.FromArgb(248, 249, 250);
                  public static Color GridHeader = Primary;
                  public static Color GridHeaderText = Color.White;
            }

            /// <summary>
            /// Apply modern theme to entire form
            /// </summary>
            public static void ApplyTheme ( Form form )
            {
                  form . BackColor = Colors . Background;
                  form . Font = new Font ( "Segoe UI" , 9F , FontStyle . Regular );

                  // Apply to all controls recursively
                  ApplyToControls ( form . Controls );
            }

            /// <summary>
            /// Apply styling to control collection
            /// </summary>
            private static void ApplyToControls ( Control . ControlCollection controls )
            {
                  foreach ( Control control in controls )
                  {
                        // Style based on control type
                        if ( control is Button btn )
                              StyleButton ( btn );
                        else if ( control is Label lbl )
                              StyleLabel ( lbl );
                        else if ( control is Panel panel )
                              StylePanel ( panel );
                        else if ( control is DataGridView dgv )
                              StyleDataGridView ( dgv );
                        else if ( control is TextBox txt )
                              StyleTextBox ( txt );
                        else if ( control is ComboBox cmb )
                              StyleComboBox ( cmb );
                        else if ( control is DateTimePicker dtp )
                              StyleDateTimePicker ( dtp );
                        else if ( control is NumericUpDown nud )
                              StyleNumericUpDown ( nud );

                        // Recurse into child controls
                        if ( control . HasChildren )
                              ApplyToControls ( control . Controls );
                  }
            }

            /// <summary>
            /// Style NumericUpDown
            /// </summary>
            public static void StyleNumericUpDown ( NumericUpDown nud )
            {
                  nud . Font = new Font ( "Segoe UI" , 10F );
                  nud . Height = Math . Max ( nud . Height , 30 );
            }

            /// <summary>
            /// Style buttons with modern flat design
            /// </summary>
            public static void StyleButton ( Button btn , ButtonStyle style = ButtonStyle . Primary )
            {
                  btn . FlatStyle = FlatStyle . Flat;
                  btn . FlatAppearance . BorderSize = 0;
                  btn . Font = new Font ( "Segoe UI" , 10F , FontStyle . Regular );
                  btn . Cursor = Cursors . Hand;
                  btn . Height = Math . Max ( btn . Height , 40 );
                  btn . Padding = new Padding ( 15 , 5 , 15 , 5 );

                  Color buttonColor = Colors.Primary;
                  Color hoverColor = Colors.PrimaryDark;

                  switch ( style )
                  {
                        case ButtonStyle . Primary:
                              buttonColor = Colors . Primary;
                              hoverColor = Colors . PrimaryDark;
                              btn . ForeColor = Color . White;
                              break;
                        case ButtonStyle . Success:
                              buttonColor = Colors . Success;
                              hoverColor = Color . FromArgb ( 67 , 160 , 71 );
                              btn . ForeColor = Color . White;
                              break;
                        case ButtonStyle . Danger:
                              buttonColor = Colors . Danger;
                              hoverColor = Color . FromArgb ( 229 , 57 , 53 );
                              btn . ForeColor = Color . White;
                              break;
                        case ButtonStyle . Secondary:
                              buttonColor = Color . FromArgb ( 243 , 242 , 241 );
                              hoverColor = Color . FromArgb ( 225 , 223 , 221 );
                              btn . ForeColor = Colors . TextPrimary;
                              break;
                  }

                  btn . BackColor = buttonColor;

                  // Add hover effects
                  btn . MouseEnter += ( s , e ) => btn . BackColor = hoverColor;
                  btn . MouseLeave += ( s , e ) => btn . BackColor = buttonColor;
            }

            /// <summary>
            /// Style labels based on size (title, header, or body)
            /// </summary>
            public static void StyleLabel ( Label lbl )
            {
                  // Detect label type by font size
                  if ( lbl . Font . Size >= 16 )
                  {
                        // Title label
                        lbl . Font = new Font ( "Segoe UI" , lbl . Font . Size , FontStyle . Bold );
                        lbl . ForeColor = Colors . TextPrimary;
                  }
                  else if ( lbl . Font . Size >= 12 )
                  {
                        // Header label
                        lbl . Font = new Font ( "Segoe UI" , lbl . Font . Size , FontStyle . Bold      );
                        lbl . ForeColor = Colors . TextPrimary;
                  }
                  else
                  {
                        // Body label
                        lbl . Font = new Font ( "Segoe UI" , 9F , FontStyle . Regular );
                        lbl . ForeColor = Colors . TextSecondary;
                  }
            }

            /// <summary>
            /// Style panels with card-like appearance
            /// </summary>
            public static void StylePanel ( Panel panel )
            {
                  panel . BackColor = Colors . Surface;
                  panel . Padding = new Padding ( 20 );

                  // Add subtle border if it has one
                  if ( panel . BorderStyle == BorderStyle . FixedSingle )
                  {
                        panel . BorderStyle = BorderStyle . None;
                        panel . Paint += ( s , e ) =>
                        {
                              ControlPaint . DrawBorder ( e . Graphics , panel . ClientRectangle ,
                                  Colors . Border , ButtonBorderStyle . Solid );
                        };
                  }
            }

            /// <summary>
            /// Style DataGridView with modern look
            /// </summary>
            public static void StyleDataGridView ( DataGridView dgv )
            {
                  dgv . BorderStyle = BorderStyle . None;
                  dgv . BackgroundColor = Colors . Surface;
                  dgv . AlternatingRowsDefaultCellStyle . BackColor = Colors . GridAlternate;
                  dgv . ColumnHeadersDefaultCellStyle . BackColor = Colors . GridHeader;
                  dgv . ColumnHeadersDefaultCellStyle . ForeColor = Colors . GridHeaderText;
                  dgv . ColumnHeadersDefaultCellStyle . Font = new Font ( "Segoe UI" , 10F , FontStyle . Bold );
                  dgv . ColumnHeadersDefaultCellStyle . Padding = new Padding ( 5 );
                  dgv . ColumnHeadersHeight = 40;
                  dgv . EnableHeadersVisualStyles = false;
                  dgv . RowTemplate . Height = 35;
                  dgv . DefaultCellStyle . SelectionBackColor = Colors . Primary;
                  dgv . DefaultCellStyle . SelectionForeColor = Color . White;
                  dgv . DefaultCellStyle . Font = new Font ( "Segoe UI" , 9F );
                  dgv . CellBorderStyle = DataGridViewCellBorderStyle . SingleHorizontal;
                  dgv . GridColor = Colors . Border;
                  dgv . RowHeadersVisible = false;
            }

            /// <summary>
            /// Style TextBox with modern border
            /// </summary>
            public static void StyleTextBox ( TextBox txt )
            {
                  txt . BorderStyle = BorderStyle . FixedSingle;
                  txt . Font = new Font ( "Segoe UI" , 10F );
                  txt . Height = Math . Max ( txt . Height , 30 );
            }

            /// <summary>
            /// Style ComboBox
            /// </summary>
            public static void StyleComboBox ( ComboBox cmb )
            {
                  cmb . FlatStyle = FlatStyle . Flat;
                  cmb . Font = new Font ( "Segoe UI" , 10F );
                  cmb . Height = Math . Max ( cmb . Height , 30 );
            }

            /// <summary>
            /// Style DateTimePicker
            /// </summary>
            public static void StyleDateTimePicker ( DateTimePicker dtp )
            {
                  dtp . Font = new Font ( "Segoe UI" , 10F );
                  dtp . Height = Math . Max ( dtp . Height , 30 );
            }


            /// <summary>
            /// Button style enumeration
            /// </summary>
            public enum ButtonStyle
            {
                  Primary,
                  Success,
                  Danger,
                  Secondary
            }

      }

}