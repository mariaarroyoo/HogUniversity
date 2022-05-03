
namespace HogCountryUniversity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.addStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.collegeComboBox = new System.Windows.Forms.ComboBox();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradesPanel = new System.Windows.Forms.Panel();
            this.gradeGroupBox = new System.Windows.Forms.GroupBox();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.addGradeGroupBox = new System.Windows.Forms.GroupBox();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.gradesLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.addStudentGroupBox.SuspendLayout();
            this.gradesPanel.SuspendLayout();
            this.gradeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.addGradeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Location = new System.Drawing.Point(222, 357);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(37, 20);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.studentGroupBox);
            this.studentPanel.Controls.Add(this.addStudentGroupBox);
            this.studentPanel.Controls.Add(this.label1);
            this.studentPanel.Location = new System.Drawing.Point(0, 27);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(352, 263);
            this.studentPanel.TabIndex = 2;
            this.studentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.studentDataGridView);
            this.studentGroupBox.Location = new System.Drawing.Point(13, 109);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(324, 145);
            this.studentGroupBox.TabIndex = 2;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Students";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(6, 18);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(310, 121);
            this.studentDataGridView.TabIndex = 0;
            // 
            // addStudentGroupBox
            // 
            this.addStudentGroupBox.Controls.Add(this.AddButton);
            this.addStudentGroupBox.Controls.Add(this.collegeComboBox);
            this.addStudentGroupBox.Controls.Add(this.majorComboBox);
            this.addStudentGroupBox.Controls.Add(this.nameTextBox);
            this.addStudentGroupBox.Controls.Add(this.majorLabel);
            this.addStudentGroupBox.Controls.Add(this.collegeLabel);
            this.addStudentGroupBox.Controls.Add(this.studentNameLabel);
            this.addStudentGroupBox.Location = new System.Drawing.Point(13, 32);
            this.addStudentGroupBox.Name = "addStudentGroupBox";
            this.addStudentGroupBox.Size = new System.Drawing.Size(324, 71);
            this.addStudentGroupBox.TabIndex = 1;
            this.addStudentGroupBox.TabStop = false;
            this.addStudentGroupBox.Text = "Add Student";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(261, 39);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(57, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // collegeComboBox
            // 
            this.collegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collegeComboBox.FormattingEnabled = true;
            this.collegeComboBox.Location = new System.Drawing.Point(48, 41);
            this.collegeComboBox.Name = "collegeComboBox";
            this.collegeComboBox.Size = new System.Drawing.Size(208, 21);
            this.collegeComboBox.TabIndex = 5;
            this.collegeComboBox.SelectedIndexChanged += new System.EventHandler(this.collegeComboBox_SelectedIndexChanged);
            // 
            // majorComboBox
            // 
            this.majorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(209, 16);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(108, 21);
            this.majorComboBox.TabIndex = 4;
            this.majorComboBox.SelectedIndexChanged += new System.EventHandler(this.majorComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(48, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(115, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(170, 20);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(33, 13);
            this.majorLabel.TabIndex = 2;
            this.majorLabel.Text = "Major";
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(7, 44);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(42, 13);
            this.collegeLabel.TabIndex = 1;
            this.collegeLabel.Text = "College";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(7, 20);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gradesPanel
            // 
            this.gradesPanel.Controls.Add(this.gradeGroupBox);
            this.gradesPanel.Controls.Add(this.addGradeGroupBox);
            this.gradesPanel.Controls.Add(this.gradesLabel);
            this.gradesPanel.Location = new System.Drawing.Point(358, 27);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.Size = new System.Drawing.Size(364, 263);
            this.gradesPanel.TabIndex = 3;
            // 
            // gradeGroupBox
            // 
            this.gradeGroupBox.Controls.Add(this.gradesDataGridView);
            this.gradeGroupBox.Location = new System.Drawing.Point(8, 109);
            this.gradeGroupBox.Name = "gradeGroupBox";
            this.gradeGroupBox.Size = new System.Drawing.Size(342, 145);
            this.gradeGroupBox.TabIndex = 2;
            this.gradeGroupBox.TabStop = false;
            this.gradeGroupBox.Text = "Grades";
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Location = new System.Drawing.Point(8, 18);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.Size = new System.Drawing.Size(328, 120);
            this.gradesDataGridView.TabIndex = 0;
            // 
            // addGradeGroupBox
            // 
            this.addGradeGroupBox.Controls.Add(this.addGradeButton);
            this.addGradeGroupBox.Controls.Add(this.termComboBox);
            this.addGradeGroupBox.Controls.Add(this.gradeComboBox);
            this.addGradeGroupBox.Controls.Add(this.courseComboBox);
            this.addGradeGroupBox.Controls.Add(this.studentComboBox);
            this.addGradeGroupBox.Controls.Add(this.termLabel);
            this.addGradeGroupBox.Controls.Add(this.gradeLabel);
            this.addGradeGroupBox.Controls.Add(this.courseLabel);
            this.addGradeGroupBox.Controls.Add(this.studentLabel);
            this.addGradeGroupBox.Location = new System.Drawing.Point(4, 38);
            this.addGradeGroupBox.Name = "addGradeGroupBox";
            this.addGradeGroupBox.Size = new System.Drawing.Size(346, 65);
            this.addGradeGroupBox.TabIndex = 1;
            this.addGradeGroupBox.TabStop = false;
            this.addGradeGroupBox.Text = "Add Grade";
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(287, 12);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(56, 49);
            this.addGradeButton.TabIndex = 11;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // termComboBox
            // 
            this.termComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Location = new System.Drawing.Point(217, 40);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(64, 21);
            this.termComboBox.TabIndex = 10;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.gradeComboBox.Location = new System.Drawing.Point(217, 14);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(64, 21);
            this.gradeComboBox.TabIndex = 9;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(51, 40);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(118, 21);
            this.courseComboBox.TabIndex = 8;
            // 
            // studentComboBox
            // 
            this.studentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(51, 14);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(118, 21);
            this.studentComboBox.TabIndex = 7;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(175, 43);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(31, 13);
            this.termLabel.TabIndex = 6;
            this.termLabel.Text = "Term";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(175, 16);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Grade";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(9, 43);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(40, 13);
            this.courseLabel.TabIndex = 4;
            this.courseLabel.Text = "Course";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(9, 16);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(44, 13);
            this.studentLabel.TabIndex = 3;
            this.studentLabel.Text = "Student";
            // 
            // gradesLabel
            // 
            this.gradesLabel.AutoSize = true;
            this.gradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesLabel.Location = new System.Drawing.Point(4, 10);
            this.gradesLabel.Name = "gradesLabel";
            this.gradesLabel.Size = new System.Drawing.Size(77, 24);
            this.gradesLabel.TabIndex = 0;
            this.gradesLabel.Text = "Grades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradesPanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.studentGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.addStudentGroupBox.ResumeLayout(false);
            this.addStudentGroupBox.PerformLayout();
            this.gradesPanel.ResumeLayout(false);
            this.gradesPanel.PerformLayout();
            this.gradeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.addGradeGroupBox.ResumeLayout(false);
            this.addGradeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Panel gradesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gradesLabel;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.GroupBox addStudentGroupBox;
        private System.Windows.Forms.GroupBox gradeGroupBox;
        private System.Windows.Forms.GroupBox addGradeGroupBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.ComboBox collegeComboBox;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.Button addGradeButton;
    }
}

