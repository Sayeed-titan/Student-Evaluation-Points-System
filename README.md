# 🎓 Student Points Management System

A comprehensive Windows Forms application built with .NET Framework 4.8 and SQL Server for tracking student activities, managing points, and evaluating project performance in educational settings.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2016+-orange)
![License](https://img.shields.io/badge/License-MIT-green)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey)

---

## 📋 Table of Contents

- [Features](#-features)
- [Screenshots](#-screenshots)
- [System Requirements](#-system-requirements)
- [Installation](#-installation)
- [Database Setup](#-database-setup)
- [Configuration](#-configuration)
- [Usage Guide](#-usage-guide)
- [Points System](#-points-system)
- [Project Grading Rubric](#-project-grading-rubric)
- [Project Structure](#-project-structure)
- [Technologies Used](#-technologies-used)
- [Contributing](#-contributing)
- [License](#-license)

---

## ✨ Features

### 📊 Dashboard
- Real-time statistics display
- Active students count
- Today's activities overview
- Pending calculations indicator
- Recent activities grid
- Weekly performance charts

### 👥 Student Management
- Add new students with details
- Activate/Deactivate students
- View all students with status
- Search and filter functionality

### 📝 Activity Tracking
- Record daily activities with points
- Multiple activity types supported
- Date-based activity logging
- Notes and comments support
- Bulk activity entry (Save & Add New)

### 🏆 Weekly Leaderboard
- Automatic ranking by total points
- Visual highlighting for top 3 performers
  - 🥇 Gold for 1st place
  - 🥈 Silver for 2nd place
  - 🥉 Bronze for 3rd place
- Week selection and filtering
- Save weekly summaries for history

### 🐛 Bug Bounty System
- Track bugs found in peer code reviews
- Award points to bug finders (+5 points)
- Penalty for code owners (-5 points)
- Encourages code quality and peer review

### 📋 Project Grading
- Comprehensive rubric-based evaluation
- Weighted scoring system:
  - Functionality: 40%
  - Code Quality: 30%
  - Database Design: 15%
  - UI/UX: 10%
  - Git Usage: 5%
- Automatic pass/fail calculation (70% threshold)
- Historical project tracking

### 📈 Reports & Analytics
- Individual student performance reports
- Weekly summaries
- Activity distribution charts
- Progress tracking over time

### 🎨 Modern UI
- Clean, professional interface
- Modern flat design
- Hover effects on buttons
- Card-style panels
- Toast notifications
- Responsive DataGridViews

---

## 📸 Screenshots

### Main Dashboard
```
┌────────────────────────────────────────────────────────────┐
│  Student Points Management Dashboard                        │
├────────────────────────────────────────────────────────────┤
│  ┌─────────────────────────────────────────────────────┐   │
│  │ Active Students: 15  │ Today's Activities: 23       │   │
│  │ Pending Calculations: 5                              │   │
│  └─────────────────────────────────────────────────────┘   │
│                                                             │
│  [Add Student] [Record Activity] [Calculate] [Leaderboard] │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │ Recent Activities                                    │   │
│  │ Student    │ Activity           │ Points │ Date     │   │
│  │ John Doe   │ Complete Homework  │ 20     │ 11/22    │   │
│  │ Jane Smith │ Help Peer          │ 15     │ 11/22    │   │
│  └─────────────────────────────────────────────────────┘   │
└────────────────────────────────────────────────────────────┘
```

### Weekly Leaderboard
```
┌────────────────────────────────────────────────────────────┐
│  Weekly Leaderboard                                         │
├────────────────────────────────────────────────────────────┤
│  Week Starting: [11/17/2024]  [Load] [Save Summary]        │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │ Rank │ Student Name      │ Total Points │ Week      │   │
│  │ 🥇 1 │ Alice Johnson     │ 85           │ Nov 17-23 │   │
│  │ 🥈 2 │ Bob Smith         │ 72           │ Nov 17-23 │   │
│  │ 🥉 3 │ Charlie Brown     │ 65           │ Nov 17-23 │   │
│  │   4  │ Diana Prince      │ 58           │ Nov 17-23 │   │
│  └─────────────────────────────────────────────────────┘   │
└────────────────────────────────────────────────────────────┘
```

---

## 💻 System Requirements

### Minimum Requirements
- **OS:** Windows 10 or later
- **RAM:** 4 GB
- **Storage:** 100 MB for application
- **Display:** 1280 x 720 resolution

### Software Requirements
- **.NET Framework:** 4.8 or later
- **SQL Server:** 2016 or later (Express Edition works)
- **Visual Studio:** 2019 or later (for development)

---

## 🚀 Installation

### Option 1: Clone Repository

```bash
git clone https://github.com/yourusername/StudentPointsSystem.git
cd StudentPointsSystem
```

### Option 2: Download ZIP

1. Download the repository as ZIP
2. Extract to your desired location
3. Open `StudentPointsSystem.sln` in Visual Studio

### Build & Run

1. Open solution in Visual Studio
2. Restore NuGet packages (if any)
3. Set `StudentPointsSystem` as startup project
4. Press `F5` to build and run

---

## 🗄️ Database Setup

### Step 1: Install SQL Server

Download and install [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (free)

### Step 2: Create Database

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Open a **New Query** window
4. Execute the following script:

```sql
-- Create Database
CREATE DATABASE StudentPointsSystem;
GO

USE StudentPointsSystem;
GO

-- Students Table
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20),
    JoinDate DATE NOT NULL DEFAULT GETDATE(),
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Activity Types Table
CREATE TABLE ActivityTypes (
    ActivityTypeID INT PRIMARY KEY IDENTITY(1,1),
    ActivityName NVARCHAR(100) NOT NULL,
    Points INT NOT NULL,
    Description NVARCHAR(255),
    IsActive BIT NOT NULL DEFAULT 1
);

-- Daily Activities Table
CREATE TABLE DailyActivities (
    ActivityID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    ActivityTypeID INT NOT NULL,
    ActivityDate DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    PointsEarned INT NOT NULL,
    Notes NVARCHAR(500),
    IsCalculated BIT NOT NULL DEFAULT 0,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ActivityTypeID) REFERENCES ActivityTypes(ActivityTypeID)
);

-- Bug Bounty Table
CREATE TABLE BugBounty (
    BugID INT PRIMARY KEY IDENTITY(1,1),
    FinderStudentID INT NOT NULL,
    OwnerStudentID INT NOT NULL,
    BugDescription NVARCHAR(500),
    PointsAwarded INT NOT NULL DEFAULT 5,
    DateFound DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    IsCalculated BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (FinderStudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (OwnerStudentID) REFERENCES Students(StudentID)
);

-- Weekly Points Summary Table
CREATE TABLE WeeklyPointsSummary (
    SummaryID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    WeekStartDate DATE NOT NULL,
    WeekEndDate DATE NOT NULL,
    TotalPoints INT NOT NULL DEFAULT 0,
    Rank INT,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

-- Projects Table
CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    ProjectName NVARCHAR(200) NOT NULL,
    SubmissionDate DATE,
    FunctionalityScore DECIMAL(5,2),
    CodeQualityScore DECIMAL(5,2),
    DatabaseDesignScore DECIMAL(5,2),
    UIUXScore DECIMAL(5,2),
    GitUsageScore DECIMAL(5,2),
    TotalScore AS (
        (FunctionalityScore * 0.40) + 
        (CodeQualityScore * 0.30) + 
        (DatabaseDesignScore * 0.15) + 
        (UIUXScore * 0.10) + 
        (GitUsageScore * 0.05)
    ) PERSISTED,
    IsPassed AS (CASE WHEN (
        (FunctionalityScore * 0.40) + 
        (CodeQualityScore * 0.30) + 
        (DatabaseDesignScore * 0.15) + 
        (UIUXScore * 0.10) + 
        (GitUsageScore * 0.05)
    ) >= 70 THEN 1 ELSE 0 END) PERSISTED,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

-- Pair Programming Table
CREATE TABLE PairProgramming (
    PairID INT PRIMARY KEY IDENTITY(1,1),
    Student1ID INT NOT NULL,
    Student2ID INT NOT NULL,
    WeekStartDate DATE NOT NULL,
    WeekEndDate DATE NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (Student1ID) REFERENCES Students(StudentID),
    FOREIGN KEY (Student2ID) REFERENCES Students(StudentID)
);

-- Insert Default Activity Types
INSERT INTO ActivityTypes (ActivityName, Points, Description)
VALUES 
    ('Attend Group Session On Time', 10, 'Attended the group session on time'),
    ('Complete Daily Homework', 20, 'Completed daily homework assignment'),
    ('Help Peer Solve Problem', 15, 'Helped another student solve a problem'),
    ('Ask Quality Question', 5, 'Asked a quality question during session'),
    ('Submit Extra Practice', 10, 'Submitted extra practice work'),
    ('Clean Code Bonus', 10, 'Code follows clean code principles');
GO

-- Stored Procedure: Calculate Daily Points
CREATE PROCEDURE sp_CalculateDailyPoints
    @CalculationDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE DailyActivities
    SET IsCalculated = 1
    WHERE ActivityDate = @CalculationDate
    AND IsCalculated = 0;
    
    UPDATE BugBounty
    SET IsCalculated = 1
    WHERE DateFound = @CalculationDate
    AND IsCalculated = 0;
    
    SELECT 'Daily points calculated successfully' AS Message;
END;
GO

-- Stored Procedure: Get Weekly Leaderboard
CREATE PROCEDURE sp_GetWeeklyLeaderboard
    @WeekStartDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @WeekEndDate DATE = DATEADD(DAY, 6, @WeekStartDate);
    
    SELECT 
        ROW_NUMBER() OVER (ORDER BY ISNULL(SUM(Points.TotalPoints), 0) DESC) AS Rank,
        s.StudentID,
        s.StudentName,
        ISNULL(SUM(Points.TotalPoints), 0) AS TotalPoints,
        @WeekStartDate AS WeekStartDate,
        @WeekEndDate AS WeekEndDate
    FROM Students s
    LEFT JOIN (
        SELECT StudentID, PointsEarned AS TotalPoints
        FROM DailyActivities
        WHERE ActivityDate BETWEEN @WeekStartDate AND @WeekEndDate
        AND IsCalculated = 1
        
        UNION ALL
        
        SELECT FinderStudentID AS StudentID, PointsAwarded AS TotalPoints
        FROM BugBounty
        WHERE DateFound BETWEEN @WeekStartDate AND @WeekEndDate
        AND IsCalculated = 1
        
        UNION ALL
        
        SELECT OwnerStudentID AS StudentID, -5 AS TotalPoints
        FROM BugBounty
        WHERE DateFound BETWEEN @WeekStartDate AND @WeekEndDate
        AND IsCalculated = 1
    ) AS Points ON s.StudentID = Points.StudentID
    WHERE s.IsActive = 1
    GROUP BY s.StudentID, s.StudentName
    ORDER BY TotalPoints DESC;
END;
GO

-- Stored Procedure: Save Weekly Summary
CREATE PROCEDURE sp_SaveWeeklySummary
    @WeekStartDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @WeekEndDate DATE = DATEADD(DAY, 6, @WeekStartDate);
    
    DELETE FROM WeeklyPointsSummary 
    WHERE WeekStartDate = @WeekStartDate;
    
    INSERT INTO WeeklyPointsSummary (StudentID, WeekStartDate, WeekEndDate, TotalPoints, Rank)
    SELECT 
        StudentID,
        @WeekStartDate,
        @WeekEndDate,
        TotalPoints,
        Rank
    FROM (
        SELECT 
            ROW_NUMBER() OVER (ORDER BY ISNULL(SUM(Points.TotalPoints), 0) DESC) AS Rank,
            s.StudentID,
            ISNULL(SUM(Points.TotalPoints), 0) AS TotalPoints
        FROM Students s
        LEFT JOIN (
            SELECT StudentID, PointsEarned AS TotalPoints
            FROM DailyActivities
            WHERE ActivityDate BETWEEN @WeekStartDate AND @WeekEndDate
            AND IsCalculated = 1
            
            UNION ALL
            
            SELECT FinderStudentID, PointsAwarded
            FROM BugBounty
            WHERE DateFound BETWEEN @WeekStartDate AND @WeekEndDate
            AND IsCalculated = 1
            
            UNION ALL
            
            SELECT OwnerStudentID, -5
            FROM BugBounty
            WHERE DateFound BETWEEN @WeekStartDate AND @WeekEndDate
            AND IsCalculated = 1
        ) AS Points ON s.StudentID = Points.StudentID
        WHERE s.IsActive = 1
        GROUP BY s.StudentID
    ) AS Summary;
    
    SELECT 'Weekly summary saved successfully' AS Message;
END;
GO
```

### Step 3: Verify Installation

```sql
USE StudentPointsSystem;
GO

-- Check tables
SELECT name FROM sys.tables;

-- Check activity types
SELECT * FROM ActivityTypes;

-- Check stored procedures
SELECT name FROM sys.procedures;
```

---

## ⚙️ Configuration

### Connection String

Update the connection string in `MainForm.cs` (line ~11):

```csharp
// For SQL Server Express (default)
private string connectionString = "Server=localhost\\SQLEXPRESS;Database=StudentPointsSystem;Integrated Security=true;";

// For full SQL Server
private string connectionString = "Server=localhost;Database=StudentPointsSystem;Integrated Security=true;";

// For named instance
private string connectionString = "Server=YOUR_PC_NAME\\INSTANCE_NAME;Database=StudentPointsSystem;Integrated Security=true;";

// With SQL Server Authentication
private string connectionString = "Server=localhost;Database=StudentPointsSystem;User Id=your_user;Password=your_password;";
```

---

## 📖 Usage Guide

### Daily Workflow

#### 1️⃣ Add Students (First Time)
```
Menu: Students → Add New Student
- Enter student name
- Enter email (required, unique)
- Enter phone number (optional)
- Select join date
- Click "Save Student"
```

#### 2️⃣ Record Daily Activities
```
Menu: Activities → Record Daily Activity
- Select student from dropdown
- Select activity type (points auto-fill)
- Verify/select date
- Add notes (optional)
- Click "Save Activity" or "Save & Add New"
```

#### 3️⃣ Calculate Daily Points (End of Day)
```
Menu: Activities → Calculate Daily Points
- Select the date to calculate
- Click OK
- Points are now marked as calculated
```

#### 4️⃣ View Weekly Leaderboard
```
Menu: Reports → Weekly Leaderboard
- Select week start date
- Click "Load Leaderboard"
- Top 3 students highlighted
- Click "Save Weekly Summary" to archive
```

### Weekly Workflow

#### Sunday Evening Review
1. **Calculate all pending points**
2. **Save weekly summary**
3. **Review leaderboard**
4. **Top performer chooses next week's project topic**
5. **Bottom performer prepares learnings presentation**

### Bug Bounty Recording
```
Menu: Activities → Record Bug Bounty
- Select bug finder (who found the bug)
- Select code owner (whose code had the bug)
- Enter bug description
- Adjust points if needed (default: 5)
- Click "Save"
```

### Project Grading
```
Menu: Projects → Add Project Grade
- Select student
- Enter project name
- Enter scores (0-100) for each category:
  • Functionality (40%)
  • Code Quality (30%)
  • Database Design (15%)
  • UI/UX (10%)
  • Git Usage (5%)
- Click "Calculate Total"
- Review PASS/FAIL status
- Click "Save Grade"
```

---

## 🏅 Points System

### Daily Activities

| Activity | Points | Description |
|----------|--------|-------------|
| Attend Group Session On Time | 10 | Present when session starts |
| Complete Daily Homework | 20 | Submit assigned homework |
| Help Peer Solve Problem | 15 | Assist another student |
| Ask Quality Question | 5 | Thoughtful, relevant question |
| Submit Extra Practice | 10 | Additional voluntary work |
| Clean Code Bonus | 10 | Follows best practices |

### Bug Bounty

| Action | Points |
|--------|--------|
| Find bug in peer's code | +5 |
| Bug found in your code | -5 |

### Weekly Rewards

| Position | Reward |
|----------|--------|
| 🥇 Top Performer | Chooses next week's mini-project topic |
| 🥈 2nd Place | Recognition |
| 🥉 3rd Place | Recognition |
| Bottom Performer | Presents learnings to the group |

---

## 📋 Project Grading Rubric

### Scoring Categories

| Category | Weight | Description |
|----------|--------|-------------|
| **Functionality** | 40% | Does it work as expected? |
| **Code Quality** | 30% | Clean, readable, follows conventions? |
| **Database Design** | 15% | Proper normalization, relationships? |
| **UI/UX** | 10% | User-friendly interface? |
| **Git Usage** | 5% | Proper commits, branching? |

### Grading Scale

| Score | Grade | Status |
|-------|-------|--------|
| 90-100 | A | ✅ Excellent |
| 80-89 | B | ✅ Good |
| 70-79 | C | ✅ Passing |
| 60-69 | D | ❌ Below Standard |
| 0-59 | F | ❌ Failing |

**Passing Score: 70/100**

---

## 📁 Project Structure

```
StudentPointsSystem/
│
├── 📄 Program.cs                    # Application entry point
│
├── 📋 Forms/
│   ├── MainForm.cs                  # Main dashboard
│   ├── MainForm.Designer.cs
│   ├── AddStudentForm.cs            # Add new students
│   ├── AddStudentForm.Designer.cs
│   ├── LeaderboardForm.cs           # Weekly leaderboard
│   ├── LeaderboardForm.Designer.cs
│   ├── RecordActivityForm.cs        # Record activities
│   ├── RecordActivityForm.Designer.cs
│   ├── ManageStudentsForm.cs        # Manage students
│   ├── ManageStudentsForm.Designer.cs
│   ├── DateSelectionForm.cs         # Date picker helper
│   ├── DateSelectionForm.Designer.cs
│   ├── BugBountyForm.cs             # Bug bounty tracking
│   ├── BugBountyForm.Designer.cs
│   ├── ProjectGradeForm.cs          # Project grading
│   ├── ProjectGradeForm.Designer.cs
│   ├── ViewProjectsForm.cs          # View all projects
│   ├── ViewProjectsForm.Designer.cs
│   ├── StudentPerformanceForm.cs    # Individual reports
│   └── StudentPerformanceForm.Designer.cs
│
├── 🎨 Theme/
│   └── ModernTheme.cs               # Modern UI styling
│
├── 📊 Database/
│   └── DatabaseSchema.sql           # SQL Server setup script
│
├── 📖 Documentation/
│   ├── README.md                    # This file
│   └── SetupGuide.md                # Detailed setup guide
│
└── 📦 Properties/
    └── AssemblyInfo.cs
```

---

## 🛠️ Technologies Used

- **Framework:** .NET Framework 4.8
- **Language:** C# 7.3
- **UI:** Windows Forms
- **Database:** SQL Server 2016+
- **Charts:** System.Windows.Forms.DataVisualization
- **IDE:** Visual Studio 2019/2022

---

## 🔧 Troubleshooting

### Common Issues

#### Connection Failed
```
Error: Cannot connect to SQL Server
Solution: 
1. Ensure SQL Server is running (Services → SQL Server)
2. Verify connection string matches your server name
3. Check Windows Firewall allows SQL Server
```

#### Designer Won't Open
```
Error: Could not load type 'FormName'
Solution:
1. Build → Clean Solution
2. Build → Rebuild Solution
3. Close and reopen Visual Studio
```

#### Leaderboard Empty
```
Issue: No data in leaderboard
Solution:
1. Add students
2. Record activities
3. **Calculate daily points** (required!)
4. Then view leaderboard
```

#### Points Not Showing
```
Issue: Activities recorded but no points in leaderboard
Solution: Run "Calculate Daily Points" for the relevant date
```

---

## 🚀 Future Enhancements

- [ ] Email notifications for weekly summaries
- [ ] Export reports to Excel/PDF
- [ ] Student login portal
- [ ] Mobile companion app
- [ ] Attendance tracking with QR codes
- [ ] Achievement badges system
- [ ] Team/group management
- [ ] Parent/mentor portal
- [ ] Integration with GitHub for Git usage tracking
- [ ] Automated backup system

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Coding Standards

- Follow C# naming conventions
- Use meaningful variable names
- Add XML comments for public methods
- Test thoroughly before submitting PR

---

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```
MIT License

Copyright (c) 2024 [Your Name]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 👨‍💻 Author

**Your Name**
- GitHub: [@yourusername](https://github.com/yourusername)
- LinkedIn: [Your LinkedIn](https://linkedin.com/in/yourprofile)
- Email: your.email@example.com

---

## 🙏 Acknowledgments

- Microsoft for .NET Framework and Windows Forms
- SQL Server team for the database engine
- All contributors and testers
- Educational institutions using this system

---

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Troubleshooting](#-troubleshooting) section
2. Search existing [Issues](https://github.com/yourusername/StudentPointsSystem/issues)
3. Create a new issue with detailed description
4. Contact: support@example.com

---

<p align="center">
  Made with ❤️ for educators and students
</p>

<p align="center">
  ⭐ Star this repository if you find it helpful!
</p>
