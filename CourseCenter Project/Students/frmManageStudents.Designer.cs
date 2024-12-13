namespace CourseCenter_Project
{
    partial class frmManageStudents
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentEnrollments = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateLevel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewLevel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudentsList = new System.Windows.Forms.DataGridView();
            this.cmsStudentsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvLevelsList = new System.Windows.Forms.DataGridView();
            this.cmsLevelsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStudentsSort = new System.Windows.Forms.ComboBox();
            this.cbxLevelsSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).BeginInit();
            this.cmsStudentsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelsList)).BeginInit();
            this.cmsLevelsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnStudentEnrollments);
            this.panel1.Controls.Add(this.btnUpdateLevel);
            this.panel1.Controls.Add(this.btnAddNewLevel);
            this.panel1.Controls.Add(this.btnUpdateStudent);
            this.panel1.Controls.Add(this.btnAddNewStudent);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 4;
            // 
            // btnStudentEnrollments
            // 
            this.btnStudentEnrollments.BackColor = System.Drawing.Color.Teal;
            this.btnStudentEnrollments.CheckedState.Parent = this.btnStudentEnrollments;
            this.btnStudentEnrollments.CustomImages.Parent = this.btnStudentEnrollments;
            this.btnStudentEnrollments.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnStudentEnrollments.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEnrollments.ForeColor = System.Drawing.Color.White;
            this.btnStudentEnrollments.HoverState.Parent = this.btnStudentEnrollments;
            this.btnStudentEnrollments.Image = global::CourseCenter_Project.Properties.Resources.enroll;
            this.btnStudentEnrollments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentEnrollments.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStudentEnrollments.Location = new System.Drawing.Point(40, 466);
            this.btnStudentEnrollments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStudentEnrollments.Name = "btnStudentEnrollments";
            this.btnStudentEnrollments.ShadowDecoration.Parent = this.btnStudentEnrollments;
            this.btnStudentEnrollments.Size = new System.Drawing.Size(314, 48);
            this.btnStudentEnrollments.TabIndex = 9;
            this.btnStudentEnrollments.Text = "Student Enrollments";
            this.btnStudentEnrollments.Click += new System.EventHandler(this.btnStudentEnrollments_Click);
            // 
            // btnUpdateLevel
            // 
            this.btnUpdateLevel.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateLevel.CheckedState.Parent = this.btnUpdateLevel;
            this.btnUpdateLevel.CustomImages.Parent = this.btnUpdateLevel;
            this.btnUpdateLevel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateLevel.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLevel.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLevel.HoverState.Parent = this.btnUpdateLevel;
            this.btnUpdateLevel.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdateLevel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateLevel.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateLevel.Location = new System.Drawing.Point(40, 614);
            this.btnUpdateLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateLevel.Name = "btnUpdateLevel";
            this.btnUpdateLevel.ShadowDecoration.Parent = this.btnUpdateLevel;
            this.btnUpdateLevel.Size = new System.Drawing.Size(314, 48);
            this.btnUpdateLevel.TabIndex = 8;
            this.btnUpdateLevel.Text = "Update Level";
            this.btnUpdateLevel.Click += new System.EventHandler(this.btnUpdateLevel_Click);
            // 
            // btnAddNewLevel
            // 
            this.btnAddNewLevel.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewLevel.CheckedState.Parent = this.btnAddNewLevel;
            this.btnAddNewLevel.CustomImages.Parent = this.btnAddNewLevel;
            this.btnAddNewLevel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewLevel.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLevel.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLevel.HoverState.Parent = this.btnAddNewLevel;
            this.btnAddNewLevel.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewLevel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewLevel.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewLevel.Location = new System.Drawing.Point(40, 540);
            this.btnAddNewLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewLevel.Name = "btnAddNewLevel";
            this.btnAddNewLevel.ShadowDecoration.Parent = this.btnAddNewLevel;
            this.btnAddNewLevel.Size = new System.Drawing.Size(314, 48);
            this.btnAddNewLevel.TabIndex = 7;
            this.btnAddNewLevel.Text = "Add New Level";
            this.btnAddNewLevel.Click += new System.EventHandler(this.btnAddNewLevel_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateStudent.CheckedState.Parent = this.btnUpdateStudent;
            this.btnUpdateStudent.CustomImages.Parent = this.btnUpdateStudent;
            this.btnUpdateStudent.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.HoverState.Parent = this.btnUpdateStudent;
            this.btnUpdateStudent.Image = global::CourseCenter_Project.Properties.Resources.user_profile;
            this.btnUpdateStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateStudent.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateStudent.Location = new System.Drawing.Point(40, 398);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.ShadowDecoration.Parent = this.btnUpdateStudent;
            this.btnUpdateStudent.Size = new System.Drawing.Size(314, 48);
            this.btnUpdateStudent.TabIndex = 6;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewStudent.CheckedState.Parent = this.btnAddNewStudent;
            this.btnAddNewStudent.CustomImages.Parent = this.btnAddNewStudent;
            this.btnAddNewStudent.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewStudent.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewStudent.HoverState.Parent = this.btnAddNewStudent;
            this.btnAddNewStudent.Image = global::CourseCenter_Project.Properties.Resources.add_friend;
            this.btnAddNewStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewStudent.ImageSize = new System.Drawing.Size(37, 37);
            this.btnAddNewStudent.Location = new System.Drawing.Point(40, 322);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.ShadowDecoration.Parent = this.btnAddNewStudent;
            this.btnAddNewStudent.Size = new System.Drawing.Size(314, 48);
            this.btnAddNewStudent.TabIndex = 5;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.Students;
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Students";
            // 
            // dgvStudentsList
            // 
            this.dgvStudentsList.AllowUserToAddRows = false;
            this.dgvStudentsList.AllowUserToDeleteRows = false;
            this.dgvStudentsList.AllowUserToOrderColumns = true;
            this.dgvStudentsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsList.ContextMenuStrip = this.cmsStudentsList;
            this.dgvStudentsList.Location = new System.Drawing.Point(416, 128);
            this.dgvStudentsList.Name = "dgvStudentsList";
            this.dgvStudentsList.ReadOnly = true;
            this.dgvStudentsList.Size = new System.Drawing.Size(337, 578);
            this.dgvStudentsList.TabIndex = 5;
            // 
            // cmsStudentsList
            // 
            this.cmsStudentsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showStudentEnrollmentsToolStripMenuItem});
            this.cmsStudentsList.Name = "contextMenuStrip1";
            this.cmsStudentsList.Size = new System.Drawing.Size(293, 124);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showStudentEnrollmentsToolStripMenuItem
            // 
            this.showStudentEnrollmentsToolStripMenuItem.Name = "showStudentEnrollmentsToolStripMenuItem";
            this.showStudentEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.showStudentEnrollmentsToolStripMenuItem.Text = "Show Student Enrollments";
            this.showStudentEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.showStudentEnrollmentsToolStripMenuItem_Click);
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 10;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvLevelsList
            // 
            this.dgvLevelsList.AllowUserToAddRows = false;
            this.dgvLevelsList.AllowUserToDeleteRows = false;
            this.dgvLevelsList.AllowUserToOrderColumns = true;
            this.dgvLevelsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLevelsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevelsList.ContextMenuStrip = this.cmsLevelsList;
            this.dgvLevelsList.Location = new System.Drawing.Point(764, 128);
            this.dgvLevelsList.Name = "dgvLevelsList";
            this.dgvLevelsList.ReadOnly = true;
            this.dgvLevelsList.Size = new System.Drawing.Size(459, 578);
            this.dgvLevelsList.TabIndex = 11;
            // 
            // cmsLevelsList
            // 
            this.cmsLevelsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.cmsLevelsList.Name = "cmsLevelsList";
            this.cmsLevelsList.Size = new System.Drawing.Size(159, 94);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(158, 30);
            this.addNewToolStripMenuItem1.Text = "Add New";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(158, 30);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(158, 30);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(414, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sorted By :";
            // 
            // cbxStudentsSort
            // 
            this.cbxStudentsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudentsSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStudentsSort.FormattingEnabled = true;
            this.cbxStudentsSort.Items.AddRange(new object[] {
            "StudentID",
            "PersonID",
            "LevelID"});
            this.cbxStudentsSort.Location = new System.Drawing.Point(535, 99);
            this.cbxStudentsSort.Name = "cbxStudentsSort";
            this.cbxStudentsSort.Size = new System.Drawing.Size(128, 23);
            this.cbxStudentsSort.TabIndex = 14;
            this.cbxStudentsSort.SelectedIndexChanged += new System.EventHandler(this.cbxStudentsSort_SelectedIndexChanged);
            // 
            // cbxLevelsSort
            // 
            this.cbxLevelsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevelsSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLevelsSort.FormattingEnabled = true;
            this.cbxLevelsSort.Items.AddRange(new object[] {
            "LevelID",
            "Name"});
            this.cbxLevelsSort.Location = new System.Drawing.Point(888, 97);
            this.cbxLevelsSort.Name = "cbxLevelsSort";
            this.cbxLevelsSort.Size = new System.Drawing.Size(134, 23);
            this.cbxLevelsSort.TabIndex = 16;
            this.cbxLevelsSort.SelectedIndexChanged += new System.EventHandler(this.cbxLevelsSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label3.Location = new System.Drawing.Point(768, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sorted By :";
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::CourseCenter_Project.Properties.Resources.previous;
            this.btnBack.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Location = new System.Drawing.Point(408, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(46, 44);
            this.btnBack.TabIndex = 36;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxLevelsSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxStudentsSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLevelsList);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.dgvStudentsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageStudents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageStudents_FormClosed);
            this.Load += new System.EventHandler(this.frmManageStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).EndInit();
            this.cmsStudentsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelsList)).EndInit();
            this.cmsLevelsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudentsList;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvLevelsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLevelsSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxStudentsSort;
        private Guna.UI2.WinForms.Guna2Button btnUpdateLevel;
        private Guna.UI2.WinForms.Guna2Button btnAddNewLevel;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStudent;
        private Guna.UI2.WinForms.Guna2Button btnAddNewStudent;
        private System.Windows.Forms.ContextMenuStrip cmsStudentsList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLevelsList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnStudentEnrollments;
        private System.Windows.Forms.ToolStripMenuItem showStudentEnrollmentsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
    }
}