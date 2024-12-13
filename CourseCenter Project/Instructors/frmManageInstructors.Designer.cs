namespace CourseCenter_Project
{
    partial class frmManageInstructors
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInstructorCourses = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateSpecialization = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewSpecialization = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbxSpecializationsSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxInstructorsSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSpecializationsList = new System.Windows.Forms.DataGridView();
            this.cmsSpecializations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvInstructorsList = new System.Windows.Forms.DataGridView();
            this.cmsInstructors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInstructorCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbAscending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbDescending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializationsList)).BeginInit();
            this.cmsSpecializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorsList)).BeginInit();
            this.cmsInstructors.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnInstructorCourses);
            this.panel1.Controls.Add(this.btnUpdateSpecialization);
            this.panel1.Controls.Add(this.btnAddNewSpecialization);
            this.panel1.Controls.Add(this.btnUpdateInstructor);
            this.panel1.Controls.Add(this.btnAddNewInstructor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 5;
            // 
            // btnInstructorCourses
            // 
            this.btnInstructorCourses.BackColor = System.Drawing.Color.Teal;
            this.btnInstructorCourses.CheckedState.Parent = this.btnInstructorCourses;
            this.btnInstructorCourses.CustomImages.Parent = this.btnInstructorCourses;
            this.btnInstructorCourses.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnInstructorCourses.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnInstructorCourses.ForeColor = System.Drawing.Color.White;
            this.btnInstructorCourses.HoverState.Parent = this.btnInstructorCourses;
            this.btnInstructorCourses.Image = global::CourseCenter_Project.Properties.Resources.InstructorCourses;
            this.btnInstructorCourses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInstructorCourses.ImageSize = new System.Drawing.Size(45, 45);
            this.btnInstructorCourses.Location = new System.Drawing.Point(30, 476);
            this.btnInstructorCourses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInstructorCourses.Name = "btnInstructorCourses";
            this.btnInstructorCourses.ShadowDecoration.Parent = this.btnInstructorCourses;
            this.btnInstructorCourses.Size = new System.Drawing.Size(337, 48);
            this.btnInstructorCourses.TabIndex = 13;
            this.btnInstructorCourses.Text = "Instructor Courses";
            this.btnInstructorCourses.Click += new System.EventHandler(this.btnInstructorCourses_Click);
            // 
            // btnUpdateSpecialization
            // 
            this.btnUpdateSpecialization.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateSpecialization.CheckedState.Parent = this.btnUpdateSpecialization;
            this.btnUpdateSpecialization.CustomImages.Parent = this.btnUpdateSpecialization;
            this.btnUpdateSpecialization.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateSpecialization.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSpecialization.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSpecialization.HoverState.Parent = this.btnUpdateSpecialization;
            this.btnUpdateSpecialization.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdateSpecialization.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateSpecialization.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateSpecialization.Location = new System.Drawing.Point(30, 628);
            this.btnUpdateSpecialization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateSpecialization.Name = "btnUpdateSpecialization";
            this.btnUpdateSpecialization.ShadowDecoration.Parent = this.btnUpdateSpecialization;
            this.btnUpdateSpecialization.Size = new System.Drawing.Size(337, 48);
            this.btnUpdateSpecialization.TabIndex = 12;
            this.btnUpdateSpecialization.Text = "Update Specialization";
            this.btnUpdateSpecialization.Click += new System.EventHandler(this.btnUpdateSpecialization_Click);
            // 
            // btnAddNewSpecialization
            // 
            this.btnAddNewSpecialization.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewSpecialization.CheckedState.Parent = this.btnAddNewSpecialization;
            this.btnAddNewSpecialization.CustomImages.Parent = this.btnAddNewSpecialization;
            this.btnAddNewSpecialization.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewSpecialization.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSpecialization.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSpecialization.HoverState.Parent = this.btnAddNewSpecialization;
            this.btnAddNewSpecialization.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewSpecialization.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewSpecialization.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewSpecialization.Location = new System.Drawing.Point(30, 554);
            this.btnAddNewSpecialization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewSpecialization.Name = "btnAddNewSpecialization";
            this.btnAddNewSpecialization.ShadowDecoration.Parent = this.btnAddNewSpecialization;
            this.btnAddNewSpecialization.Size = new System.Drawing.Size(337, 48);
            this.btnAddNewSpecialization.TabIndex = 11;
            this.btnAddNewSpecialization.Text = "Add New Specialization";
            this.btnAddNewSpecialization.Click += new System.EventHandler(this.btnAddNewSpecialization_Click);
            // 
            // btnUpdateInstructor
            // 
            this.btnUpdateInstructor.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateInstructor.CheckedState.Parent = this.btnUpdateInstructor;
            this.btnUpdateInstructor.CustomImages.Parent = this.btnUpdateInstructor;
            this.btnUpdateInstructor.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateInstructor.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateInstructor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInstructor.HoverState.Parent = this.btnUpdateInstructor;
            this.btnUpdateInstructor.Image = global::CourseCenter_Project.Properties.Resources.user_profile;
            this.btnUpdateInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateInstructor.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateInstructor.Location = new System.Drawing.Point(30, 396);
            this.btnUpdateInstructor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.ShadowDecoration.Parent = this.btnUpdateInstructor;
            this.btnUpdateInstructor.Size = new System.Drawing.Size(337, 48);
            this.btnUpdateInstructor.TabIndex = 10;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.Click += new System.EventHandler(this.btnUpdateInstructor_Click);
            // 
            // btnAddNewInstructor
            // 
            this.btnAddNewInstructor.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewInstructor.CheckedState.Parent = this.btnAddNewInstructor;
            this.btnAddNewInstructor.CustomImages.Parent = this.btnAddNewInstructor;
            this.btnAddNewInstructor.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewInstructor.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddNewInstructor.HoverState.Parent = this.btnAddNewInstructor;
            this.btnAddNewInstructor.Image = global::CourseCenter_Project.Properties.Resources.add_friend;
            this.btnAddNewInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewInstructor.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewInstructor.Location = new System.Drawing.Point(30, 320);
            this.btnAddNewInstructor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewInstructor.Name = "btnAddNewInstructor";
            this.btnAddNewInstructor.ShadowDecoration.Parent = this.btnAddNewInstructor;
            this.btnAddNewInstructor.Size = new System.Drawing.Size(337, 48);
            this.btnAddNewInstructor.TabIndex = 9;
            this.btnAddNewInstructor.Text = "Add New Instructor";
            this.btnAddNewInstructor.Click += new System.EventHandler(this.btnAddNewInstructor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.Instructors;
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
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
            this.label1.Location = new System.Drawing.Point(23, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Instuctors";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbxSpecializationsSort
            // 
            this.cbxSpecializationsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecializationsSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSpecializationsSort.FormattingEnabled = true;
            this.cbxSpecializationsSort.Items.AddRange(new object[] {
            "SpecializationID",
            "Name"});
            this.cbxSpecializationsSort.Location = new System.Drawing.Point(990, 67);
            this.cbxSpecializationsSort.Name = "cbxSpecializationsSort";
            this.cbxSpecializationsSort.Size = new System.Drawing.Size(134, 23);
            this.cbxSpecializationsSort.TabIndex = 22;
            this.cbxSpecializationsSort.SelectedIndexChanged += new System.EventHandler(this.cbxSpecializationsSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label3.Location = new System.Drawing.Point(864, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sorted By :";
            // 
            // cbxInstructorsSort
            // 
            this.cbxInstructorsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInstructorsSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInstructorsSort.FormattingEnabled = true;
            this.cbxInstructorsSort.Items.AddRange(new object[] {
            "InstructorID",
            "PersonID",
            "SpecializationID",
            "Salary"});
            this.cbxInstructorsSort.Location = new System.Drawing.Point(520, 67);
            this.cbxInstructorsSort.Name = "cbxInstructorsSort";
            this.cbxInstructorsSort.Size = new System.Drawing.Size(128, 23);
            this.cbxInstructorsSort.TabIndex = 20;
            this.cbxInstructorsSort.SelectedValueChanged += new System.EventHandler(this.cbxInstructorsSort_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(414, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sorted By :";
            // 
            // dgvSpecializationsList
            // 
            this.dgvSpecializationsList.AllowUserToAddRows = false;
            this.dgvSpecializationsList.AllowUserToDeleteRows = false;
            this.dgvSpecializationsList.AllowUserToOrderColumns = true;
            this.dgvSpecializationsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSpecializationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecializationsList.ContextMenuStrip = this.cmsSpecializations;
            this.dgvSpecializationsList.Location = new System.Drawing.Point(856, 95);
            this.dgvSpecializationsList.Name = "dgvSpecializationsList";
            this.dgvSpecializationsList.ReadOnly = true;
            this.dgvSpecializationsList.Size = new System.Drawing.Size(367, 578);
            this.dgvSpecializationsList.TabIndex = 18;
            // 
            // cmsSpecializations
            // 
            this.cmsSpecializations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsSpecializations.Name = "contextMenuStrip2";
            this.cmsSpecializations.Size = new System.Drawing.Size(154, 94);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(153, 30);
            this.addNewToolStripMenuItem1.Text = "AddNew";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 30);
            this.toolStripMenuItem1.Text = "Edit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 30);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dgvInstructorsList
            // 
            this.dgvInstructorsList.AllowUserToAddRows = false;
            this.dgvInstructorsList.AllowUserToDeleteRows = false;
            this.dgvInstructorsList.AllowUserToOrderColumns = true;
            this.dgvInstructorsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInstructorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructorsList.ContextMenuStrip = this.cmsInstructors;
            this.dgvInstructorsList.Location = new System.Drawing.Point(416, 95);
            this.dgvInstructorsList.Name = "dgvInstructorsList";
            this.dgvInstructorsList.ReadOnly = true;
            this.dgvInstructorsList.Size = new System.Drawing.Size(434, 578);
            this.dgvInstructorsList.TabIndex = 17;
            // 
            // cmsInstructors
            // 
            this.cmsInstructors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showInstructorCoursesToolStripMenuItem});
            this.cmsInstructors.Name = "contextMenuStrip2";
            this.cmsInstructors.Size = new System.Drawing.Size(278, 124);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.addNewToolStripMenuItem.Text = "AddNew";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showInstructorCoursesToolStripMenuItem
            // 
            this.showInstructorCoursesToolStripMenuItem.Name = "showInstructorCoursesToolStripMenuItem";
            this.showInstructorCoursesToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.showInstructorCoursesToolStripMenuItem.Text = "Show Instructor Courses";
            this.showInstructorCoursesToolStripMenuItem.Click += new System.EventHandler(this.showInstructorCoursesToolStripMenuItem_Click);
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 23;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.rbAscending.Location = new System.Drawing.Point(658, 69);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(94, 20);
            this.rbAscending.TabIndex = 25;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAscending.UncheckedState.BorderThickness = 2;
            this.rbAscending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAscending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
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
            this.rbDescending.Location = new System.Drawing.Point(754, 68);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(103, 20);
            this.rbDescending.TabIndex = 26;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "Descending";
            this.rbDescending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDescending.UncheckedState.BorderThickness = 2;
            this.rbDescending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDescending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDescending.UseVisualStyleBackColor = true;
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
            this.btnBack.TabIndex = 32;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManageInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbDescending);
            this.Controls.Add(this.rbAscending);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.cbxSpecializationsSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxInstructorsSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSpecializationsList);
            this.Controls.Add(this.dgvInstructorsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInstructors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageInstructors_FormClosed);
            this.Load += new System.EventHandler(this.frmManageInstructors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializationsList)).EndInit();
            this.cmsSpecializations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorsList)).EndInit();
            this.cmsInstructors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox cbxSpecializationsSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxInstructorsSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSpecializationsList;
        private System.Windows.Forms.DataGridView dgvInstructorsList;
        private Guna.UI2.WinForms.Guna2Button btnUpdateSpecialization;
        private Guna.UI2.WinForms.Guna2Button btnAddNewSpecialization;
        private Guna.UI2.WinForms.Guna2Button btnUpdateInstructor;
        private Guna.UI2.WinForms.Guna2Button btnAddNewInstructor;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsInstructors;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSpecializations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Guna.UI2.WinForms.Guna2RadioButton rbAscending;
        private Guna.UI2.WinForms.Guna2RadioButton rbDescending;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnInstructorCourses;
        private System.Windows.Forms.ToolStripMenuItem showInstructorCoursesToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
    }
}