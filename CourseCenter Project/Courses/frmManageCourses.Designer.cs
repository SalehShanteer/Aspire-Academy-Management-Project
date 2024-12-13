namespace CourseCenter_Project
{
    partial class frmManageCourses
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
            this.btnDeleteCourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentsEnrolledInCourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnActiveStudentsInCoursesList = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewCourse = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCoursesList = new System.Windows.Forms.DataGridView();
            this.cmsCoursesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowActiveStudentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentsEnrolledInCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbDescending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAscending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbxCoursesSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.txtSearchByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfCourses = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumberOfStudentsAttend = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNumberOfInstructorsTeach = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesList)).BeginInit();
            this.cmsCoursesList.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Controls.Add(this.btnStudentsEnrolledInCourse);
            this.panel1.Controls.Add(this.btnActiveStudentsInCoursesList);
            this.panel1.Controls.Add(this.btnUpdateCourse);
            this.panel1.Controls.Add(this.btnAddNewCourse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 6;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteCourse.CheckedState.Parent = this.btnDeleteCourse;
            this.btnDeleteCourse.CustomImages.Parent = this.btnDeleteCourse;
            this.btnDeleteCourse.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.HoverState.Parent = this.btnDeleteCourse;
            this.btnDeleteCourse.Image = global::CourseCenter_Project.Properties.Resources.remove;
            this.btnDeleteCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteCourse.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteCourse.Location = new System.Drawing.Point(22, 469);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.ShadowDecoration.Parent = this.btnDeleteCourse;
            this.btnDeleteCourse.Size = new System.Drawing.Size(356, 48);
            this.btnDeleteCourse.TabIndex = 9;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnStudentsEnrolledInCourse
            // 
            this.btnStudentsEnrolledInCourse.BackColor = System.Drawing.Color.Teal;
            this.btnStudentsEnrolledInCourse.CheckedState.Parent = this.btnStudentsEnrolledInCourse;
            this.btnStudentsEnrolledInCourse.CustomImages.Parent = this.btnStudentsEnrolledInCourse;
            this.btnStudentsEnrolledInCourse.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnStudentsEnrolledInCourse.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudentsEnrolledInCourse.ForeColor = System.Drawing.Color.White;
            this.btnStudentsEnrolledInCourse.HoverState.Parent = this.btnStudentsEnrolledInCourse;
            this.btnStudentsEnrolledInCourse.Image = global::CourseCenter_Project.Properties.Resources.training;
            this.btnStudentsEnrolledInCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentsEnrolledInCourse.ImageSize = new System.Drawing.Size(45, 45);
            this.btnStudentsEnrolledInCourse.Location = new System.Drawing.Point(22, 615);
            this.btnStudentsEnrolledInCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStudentsEnrolledInCourse.Name = "btnStudentsEnrolledInCourse";
            this.btnStudentsEnrolledInCourse.ShadowDecoration.Parent = this.btnStudentsEnrolledInCourse;
            this.btnStudentsEnrolledInCourse.Size = new System.Drawing.Size(356, 48);
            this.btnStudentsEnrolledInCourse.TabIndex = 8;
            this.btnStudentsEnrolledInCourse.Text = "  Students Enrolled In Course";
            this.btnStudentsEnrolledInCourse.Click += new System.EventHandler(this.btnStudentsEnrolledInCourse_Click);
            // 
            // btnActiveStudentsInCoursesList
            // 
            this.btnActiveStudentsInCoursesList.BackColor = System.Drawing.Color.Teal;
            this.btnActiveStudentsInCoursesList.CheckedState.Parent = this.btnActiveStudentsInCoursesList;
            this.btnActiveStudentsInCoursesList.CustomImages.Parent = this.btnActiveStudentsInCoursesList;
            this.btnActiveStudentsInCoursesList.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnActiveStudentsInCoursesList.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnActiveStudentsInCoursesList.ForeColor = System.Drawing.Color.White;
            this.btnActiveStudentsInCoursesList.HoverState.Parent = this.btnActiveStudentsInCoursesList;
            this.btnActiveStudentsInCoursesList.Image = global::CourseCenter_Project.Properties.Resources.graduates;
            this.btnActiveStudentsInCoursesList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActiveStudentsInCoursesList.ImageSize = new System.Drawing.Size(38, 38);
            this.btnActiveStudentsInCoursesList.Location = new System.Drawing.Point(22, 540);
            this.btnActiveStudentsInCoursesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActiveStudentsInCoursesList.Name = "btnActiveStudentsInCoursesList";
            this.btnActiveStudentsInCoursesList.ShadowDecoration.Parent = this.btnActiveStudentsInCoursesList;
            this.btnActiveStudentsInCoursesList.Size = new System.Drawing.Size(356, 48);
            this.btnActiveStudentsInCoursesList.TabIndex = 7;
            this.btnActiveStudentsInCoursesList.Text = "Active Students in Courses List";
            this.btnActiveStudentsInCoursesList.Click += new System.EventHandler(this.btnActiveStudentsList_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateCourse.CheckedState.Parent = this.btnUpdateCourse;
            this.btnUpdateCourse.CustomImages.Parent = this.btnUpdateCourse;
            this.btnUpdateCourse.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.HoverState.Parent = this.btnUpdateCourse;
            this.btnUpdateCourse.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdateCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateCourse.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateCourse.Location = new System.Drawing.Point(22, 396);
            this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.ShadowDecoration.Parent = this.btnUpdateCourse;
            this.btnUpdateCourse.Size = new System.Drawing.Size(356, 48);
            this.btnUpdateCourse.TabIndex = 6;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewCourse.CheckedState.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.CustomImages.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewCourse.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCourse.HoverState.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewCourse.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewCourse.Location = new System.Drawing.Point(22, 320);
            this.btnAddNewCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.ShadowDecoration.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.Size = new System.Drawing.Size(356, 48);
            this.btnAddNewCourse.TabIndex = 5;
            this.btnAddNewCourse.Text = "Add New Course";
            this.btnAddNewCourse.Click += new System.EventHandler(this.btnAddNewCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.Courses;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Courses";
            // 
            // dgvCoursesList
            // 
            this.dgvCoursesList.AllowUserToAddRows = false;
            this.dgvCoursesList.AllowUserToDeleteRows = false;
            this.dgvCoursesList.AllowUserToOrderColumns = true;
            this.dgvCoursesList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCoursesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesList.ContextMenuStrip = this.cmsCoursesList;
            this.dgvCoursesList.Location = new System.Drawing.Point(412, 160);
            this.dgvCoursesList.Name = "dgvCoursesList";
            this.dgvCoursesList.ReadOnly = true;
            this.dgvCoursesList.Size = new System.Drawing.Size(508, 510);
            this.dgvCoursesList.TabIndex = 14;
            // 
            // cmsCoursesList
            // 
            this.cmsCoursesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.StudentsListToolStripMenuItem});
            this.cmsCoursesList.Name = "cmsCoursesList";
            this.cmsCoursesList.Size = new System.Drawing.Size(185, 124);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // StudentsListToolStripMenuItem
            // 
            this.StudentsListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowActiveStudentsListToolStripMenuItem,
            this.showStudentsEnrolledInCourseToolStripMenuItem});
            this.StudentsListToolStripMenuItem.Name = "StudentsListToolStripMenuItem";
            this.StudentsListToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.StudentsListToolStripMenuItem.Text = "Students List";
            // 
            // ShowActiveStudentsListToolStripMenuItem
            // 
            this.ShowActiveStudentsListToolStripMenuItem.Name = "ShowActiveStudentsListToolStripMenuItem";
            this.ShowActiveStudentsListToolStripMenuItem.Size = new System.Drawing.Size(351, 30);
            this.ShowActiveStudentsListToolStripMenuItem.Text = "Show Active Students list";
            this.ShowActiveStudentsListToolStripMenuItem.Click += new System.EventHandler(this.ShowActiveStudentsListToolStripMenuItem_Click);
            // 
            // showStudentsEnrolledInCourseToolStripMenuItem
            // 
            this.showStudentsEnrolledInCourseToolStripMenuItem.Name = "showStudentsEnrolledInCourseToolStripMenuItem";
            this.showStudentsEnrolledInCourseToolStripMenuItem.Size = new System.Drawing.Size(351, 30);
            this.showStudentsEnrolledInCourseToolStripMenuItem.Text = "Show Students Enrolled In Course";
            this.showStudentsEnrolledInCourseToolStripMenuItem.Click += new System.EventHandler(this.showStudentsEnrolledInCourseToolStripMenuItem_Click);
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDescending.CheckedState.BorderThickness = 0;
            this.rbDescending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDescending.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDescending.CheckedState.InnerOffset = -4;
            this.rbDescending.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.rbDescending.Location = new System.Drawing.Point(528, 96);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(103, 20);
            this.rbDescending.TabIndex = 30;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "Descending";
            this.rbDescending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDescending.UncheckedState.BorderThickness = 2;
            this.rbDescending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDescending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDescending.UseVisualStyleBackColor = true;
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAscending.CheckedState.BorderThickness = 0;
            this.rbAscending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAscending.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAscending.CheckedState.InnerOffset = -4;
            this.rbAscending.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.rbAscending.Location = new System.Drawing.Point(428, 96);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(94, 20);
            this.rbAscending.TabIndex = 29;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAscending.UncheckedState.BorderThickness = 2;
            this.rbAscending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAscending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // cbxCoursesSort
            // 
            this.cbxCoursesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoursesSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCoursesSort.FormattingEnabled = true;
            this.cbxCoursesSort.Items.AddRange(new object[] {
            "CourseID",
            "Name",
            "InstructorID",
            "CreditHours",
            "CourseFee"});
            this.cbxCoursesSort.Location = new System.Drawing.Point(521, 125);
            this.cbxCoursesSort.Name = "cbxCoursesSort";
            this.cbxCoursesSort.Size = new System.Drawing.Size(162, 23);
            this.cbxCoursesSort.TabIndex = 28;
            this.cbxCoursesSort.SelectedIndexChanged += new System.EventHandler(this.cbxCoursesSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(408, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sorted By :";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 31;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BorderRadius = 10;
            this.txtSearchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByName.DefaultText = "";
            this.txtSearchByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByName.DisabledState.Parent = this.txtSearchByName;
            this.txtSearchByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByName.FocusedState.Parent = this.txtSearchByName;
            this.txtSearchByName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByName.HoverState.Parent = this.txtSearchByName;
            this.txtSearchByName.Location = new System.Drawing.Point(706, 123);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.PasswordChar = '\0';
            this.txtSearchByName.PlaceholderText = "";
            this.txtSearchByName.SelectedText = "";
            this.txtSearchByName.ShadowDecoration.Parent = this.txtSearchByName;
            this.txtSearchByName.Size = new System.Drawing.Size(214, 27);
            this.txtSearchByName.TabIndex = 34;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // lblNumberOfCourses
            // 
            this.lblNumberOfCourses.AutoSize = true;
            this.lblNumberOfCourses.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCourses.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfCourses.Location = new System.Drawing.Point(247, 89);
            this.lblNumberOfCourses.Name = "lblNumberOfCourses";
            this.lblNumberOfCourses.Size = new System.Drawing.Size(22, 22);
            this.lblNumberOfCourses.TabIndex = 37;
            this.lblNumberOfCourses.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Number of courses :";
            // 
            // lblNumberOfStudentsAttend
            // 
            this.lblNumberOfStudentsAttend.AutoSize = true;
            this.lblNumberOfStudentsAttend.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfStudentsAttend.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfStudentsAttend.Location = new System.Drawing.Point(247, 156);
            this.lblNumberOfStudentsAttend.Name = "lblNumberOfStudentsAttend";
            this.lblNumberOfStudentsAttend.Size = new System.Drawing.Size(22, 22);
            this.lblNumberOfStudentsAttend.TabIndex = 39;
            this.lblNumberOfStudentsAttend.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 44);
            this.label4.TabIndex = 38;
            this.label4.Text = "Number of students \r\nattended to courses :";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNumberOfInstructorsTeach
            // 
            this.lblNumberOfInstructorsTeach.AutoSize = true;
            this.lblNumberOfInstructorsTeach.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInstructorsTeach.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfInstructorsTeach.Location = new System.Drawing.Point(247, 223);
            this.lblNumberOfInstructorsTeach.Name = "lblNumberOfInstructorsTeach";
            this.lblNumberOfInstructorsTeach.Size = new System.Drawing.Size(22, 22);
            this.lblNumberOfInstructorsTeach.TabIndex = 42;
            this.lblNumberOfInstructorsTeach.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 44);
            this.label6.TabIndex = 41;
            this.label6.Text = "Number of instructors \r\nteach courses :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Summary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblNumberOfCourses);
            this.panel2.Controls.Add(this.lblNumberOfInstructorsTeach);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNumberOfStudentsAttend);
            this.panel2.Location = new System.Drawing.Point(941, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 293);
            this.panel2.TabIndex = 44;
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
            this.btnBack.TabIndex = 45;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.rbDescending);
            this.Controls.Add(this.rbAscending);
            this.Controls.Add(this.cbxCoursesSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCoursesList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageCourses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageCourses_FormClosed);
            this.Load += new System.EventHandler(this.frmManageCourses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesList)).EndInit();
            this.cmsCoursesList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCoursesList;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCourse;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCourse;
        private Guna.UI2.WinForms.Guna2RadioButton rbDescending;
        private Guna.UI2.WinForms.Guna2RadioButton rbAscending;
        private System.Windows.Forms.ComboBox cbxCoursesSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeDate;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByName;
        private System.Windows.Forms.Label lblNumberOfCourses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumberOfStudentsAttend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsCoursesList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblNumberOfInstructorsTeach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnActiveStudentsInCoursesList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnStudentsEnrolledInCourse;
        private System.Windows.Forms.ToolStripMenuItem ShowActiveStudentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentsEnrolledInCourseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCourse;
    }
}