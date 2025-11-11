using System;
using System . Data;
using System . Data . SqlClient;
using System . Windows . Forms;

namespace StudentPointsSystem
{
      // Date Selection Form for Daily Points Calculation
      public partial class DateSelectionForm : Form
      {
            public DateTime SelectedDate { get; private set; }

            public DateSelectionForm ( )
            {
                  InitializeComponent ( );
                  SelectedDate = DateTime . Now . Date;
            }


      }

}