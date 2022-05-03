using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogCountryUniversity
{
    public partial class Form1 : Form
    {
        DataTable collegeTable;
        DataTable majorTable;
        DataTable studentTable;
        DataTable gradeTable;
        DataTable courseTable;
        DataTable termTable;
        bool hasData = false;
        string sql = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMainMenu()
        {
            mainPanel.Visible = true;
            studentPanel.Visible = false;
            gradesPanel.Visible = false;
            mainPanel.Dock = DockStyle.Fill;
        }

        private void ShowStudentMenu()
        {
            mainPanel.Visible = false;
            studentPanel.Visible = true;
            gradesPanel.Visible = false;
            studentPanel.Dock = DockStyle.Fill;
        }

        private void ShowGradeMenu()
        {
            mainPanel.Visible = false;
            studentPanel.Visible = false;
            gradesPanel.Visible = true;
            gradesPanel.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentMenu();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGradeMenu();
        }

        private void majorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //We first connect to the database
            MessageBox.Show(Walton_DB.OpenConnection().ToString());

            //Then, we show the Main Menu
            ShowMainMenu();

            //Populate college information
            sql = "SELECT CollegeID, College FROM tbl_Colleges order by College";
            hasData = Walton_DB.FillDataTable_ViaSql(ref collegeTable, sql);
            foreach (DataRow row in collegeTable.Rows)
            {
                collegeComboBox.Items.Add(row["College"]);
            }

            //Populate students information
            sql = "SELECT StudentID, StudentName FROM tbl_Students order by StudentName";
            hasData = Walton_DB.FillDataTable_ViaSql(ref studentTable, sql);
            foreach (DataRow row in studentTable.Rows)
            {
                studentComboBox.Items.Add(row["StudentName"]);
            }

            //Populate course information
            sql = "SELECT CourseID, Course FROM tbl_Courses order by Course";
            hasData = Walton_DB.FillDataTable_ViaSql(ref courseTable, sql);
            foreach (DataRow row in courseTable.Rows)
            {
                courseComboBox.Items.Add(row["Course"]);
            }

            //Populate term information
            sql = "SELECT TermID, Term FROM tbl_Terms order by Term";
            hasData = Walton_DB.FillDataTable_ViaSql(ref termTable, sql);
            foreach (DataRow row in termTable.Rows)
            {
                termComboBox.Items.Add(row["Term"]);
            }

            //Populate the students DataGridView           
            sql = "SELECT tbl_Students.StudentID, tbl_Students.StudentName, tbl_Colleges.College, tbl_Majors.Major FROM tbl_Students INNER JOIN tbl_Colleges ON tbl_Students.StudentCollege = tbl_Colleges.CollegeID INNER JOIN tbl_Majors ON tbl_Students.StudentMajor = tbl_Majors.MajorID";
            hasData = Walton_DB.FillDataTable_ViaSql(ref studentTable, sql);
            studentDataGridView.DataSource = studentTable;

            //Populate the grades DataGridView
            sql = "  SELECT tbl_Students.StudentName, tbl_Courses.Course, tbl_Terms.Term, tbl_Grades.Grade FROM tbl_Grades INNER JOIN tbl_Students ON tbl_Grades.Student = tbl_Students.StudentID INNER JOIN tbl_Courses ON tbl_Grades.Course = tbl_Courses.CourseID INNER JOIN tbl_Terms ON tbl_Grades.Term = tbl_Terms.TermID";
            hasData = Walton_DB.FillDataTable_ViaSql(ref gradeTable, sql);
            gradesDataGridView.DataSource = gradeTable;

        }

        private void collegeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //We need to get a college ID
            int collegeID = -1;
            object collegeObject = collegeComboBox.SelectedItem;
            string college = collegeObject.ToString();
            foreach (DataRow row in collegeTable.Rows)
            {
                if (college == row["College"].ToString())
                {
                    collegeID = Convert.ToInt32(row["CollegeID"]);
                }

            }

        
            //We have to look for the information for all majors depending on the college ID
            sql = "SELECT MajorID, Major FROM tbl_Majors where CollegeID = " + collegeID;
            Walton_DB.FillDataTable_ViaSql(ref majorTable, sql);

            //We have to get the combo box filled with the major information as well
            majorComboBox.Items.Clear();
            foreach (DataRow row in majorTable.Rows)
            {
                majorComboBox.Items.Add(row["Major"]);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //create SQL query to add student info
            int collegeID = -1;
            int majorID = -1;
            object collegeObject = collegeComboBox.SelectedItem;
            object majorObject = majorComboBox.SelectedItem;
            string college = collegeObject.ToString();
            string major = majorObject.ToString();

            // get college id
            foreach (DataRow row in collegeTable.Rows)
            {
                if (college == row["College"].ToString())
                {
                    collegeID = Convert.ToInt32(row["CollegeID"]);
                }
            }


            //get major
            foreach (DataRow row in majorTable.Rows)
            {
                if (major == row["Major"].ToString())
                {
                    majorID = Convert.ToInt32(row["MajorID"]);
                }
            }

            sql = "INSERT INTO tbl_Students (StudentName, StudentCollege, StudentMajor) VALUES ('" + nameTextBox.Text.Trim() + "'," + collegeID.ToString() + "," + majorID.ToString() + ")";
            //add student info
            hasData = Walton_DB.ExecSqlString(sql);
            //populate the DataGridView1
            sql = "SELECT tbl_Students.StudentID, tbl_Students.StudentName, tbl_Colleges.College, tbl_Majors.Major FROM tbl_Students INNER JOIN tbl_Colleges ON tbl_Students.StudentCollege = tbl_Colleges.CollegeID INNER JOIN tbl_Majors ON tbl_Students.StudentMajor = tbl_Majors.MajorID";
            hasData = Walton_DB.FillDataTable_ViaSql(ref studentTable, sql);
            studentDataGridView.DataSource = studentTable;

            // populate the DataGridView2
            sql = "SELECT tbl_Students.StudentName, tbl_Courses.Course, tbl_Terms.Term, tbl_Grades.Grade FROM tbl_Grades INNER JOIN tbl_Students ON tbl_Grades.Student = tbl_Students.StudentID INNER JOIN tbl_Courses ON tbl_Grades.Course = tbl_Courses.CourseID INNER JOIN tbl_Terms ON tbl_Grades.Term = tbl_Terms.TermID";
            hasData = Walton_DB.FillDataTable_ViaSql(ref gradeTable, sql);
            gradesDataGridView.DataSource = gradeTable;


        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
           
            int studentID = -1;
            int courseID = -1;
            int termID = -1;
            object studentObject = studentComboBox.SelectedItem;
            object courseObject = courseComboBox.SelectedItem;
            object termObject = termComboBox.SelectedItem;
            object gradeObject = gradeComboBox.SelectedItem;
            string student = studentObject.ToString();
            string course = courseObject.ToString();
            string term = termObject.ToString();
            string grade = gradeObject.ToString();

            // Getting the student ID
            foreach (DataRow row in studentTable.Rows)
            {
                if (student == row["StudentName"].ToString())
                {
                    studentID = Convert.ToInt32(row["StudentID"]);
                }
            }

            // Geting the course ID
            foreach (DataRow row in courseTable.Rows)
            {
                if (course == row["Course"].ToString())
                {
                    courseID = Convert.ToInt32(row["CourseID"]);
                }
            }

            //Getting the term ID 
            foreach (DataRow row in termTable.Rows)
            {
                if (term == row["Term"].ToString())
                {
                    termID = Convert.ToInt32(row["TermID"]);
                }
            }

            
            sql = "INSERT INTO tbl_Grades (Student, Course, Term, Grade) VALUES (" + studentID.ToString() + "," + courseID.ToString() + "," + termID.ToString() + ",'" + grade + "')";

            //Adding the student information into the database so that we can use it
            hasData = Walton_DB.ExecSqlString(sql);

            //Populate the grade DataGridView
            sql = "SELECT tbl_Students.StudentName, tbl_Courses.Course, tbl_Terms.Term, tbl_Grades.Grade FROM tbl_Grades INNER JOIN tbl_Students ON tbl_Grades.Student = tbl_Students.StudentID INNER JOIN tbl_Courses ON tbl_Grades.Course = tbl_Courses.CourseID INNER JOIN tbl_Terms ON tbl_Grades.Term = tbl_Terms.TermID";
            hasData = Walton_DB.FillDataTable_ViaSql(ref gradeTable, sql);
            gradesDataGridView.DataSource = gradeTable;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
