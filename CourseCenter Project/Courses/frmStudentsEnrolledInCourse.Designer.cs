namespace CourseCenter_Project
{
    partial class frmStudentsEnrolledInCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentsEnrolledInCourse));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvStudentsEnrolledInCourse = new System.Windows.Forms.DataGridView();
            this.cmsStudentEnrollInCourse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enrollStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentEnrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbEditGrade = new System.Windows.Forms.GroupBox();
            this.ckbNoGrade = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseEditGrade = new Guna.UI2.WinForms.Guna2Button();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditEditGrade = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnenrollStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnrollStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsEnrolledInCourse)).BeginInit();
            this.cmsStudentEnrollInCourse.SuspendLayout();
            this.gbEditGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvStudentsEnrolledInCourse
            // 
            this.dgvStudentsEnrolledInCourse.AllowUserToAddRows = false;
            this.dgvStudentsEnrolledInCourse.AllowUserToDeleteRows = false;
            this.dgvStudentsEnrolledInCourse.AllowUserToOrderColumns = true;
            this.dgvStudentsEnrolledInCourse.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentsEnrolledInCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsEnrolledInCourse.ContextMenuStrip = this.cmsStudentEnrollInCourse;
            this.dgvStudentsEnrolledInCourse.Location = new System.Drawing.Point(18, 128);
            this.dgvStudentsEnrolledInCourse.Name = "dgvStudentsEnrolledInCourse";
            this.dgvStudentsEnrolledInCourse.ReadOnly = true;
            this.dgvStudentsEnrolledInCourse.Size = new System.Drawing.Size(556, 356);
            this.dgvStudentsEnrolledInCourse.TabIndex = 24;
            // 
            // cmsStudentEnrollInCourse
            // 
            this.cmsStudentEnrollInCourse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollStudentToolStripMenuItem,
            this.deleteStudentEnrollmentToolStripMenuItem,
            this.editStudentInfoToolStripMenuItem,
            this.editGradeToolStripMenuItem,
            this.completeToolStripMenuItem});
            this.cmsStudentEnrollInCourse.Name = "cmsStudentEnrollInCourse";
            this.cmsStudentEnrollInCourse.Size = new System.Drawing.Size(218, 154);
            // 
            // enrollStudentToolStripMenuItem
            // 
            this.enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            this.enrollStudentToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.enrollStudentToolStripMenuItem.Text = "Enroll Student";
            this.enrollStudentToolStripMenuItem.Click += new System.EventHandler(this.enrollStudentToolStripMenuItem_Click);
            // 
            // deleteStudentEnrollmentToolStripMenuItem
            // 
            this.deleteStudentEnrollmentToolStripMenuItem.Name = "deleteStudentEnrollmentToolStripMenuItem";
            this.deleteStudentEnrollmentToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.deleteStudentEnrollmentToolStripMenuItem.Text = "Unenroll Student";
            this.deleteStudentEnrollmentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentEnrollmentToolStripMenuItem_Click);
            // 
            // editStudentInfoToolStripMenuItem
            // 
            this.editStudentInfoToolStripMenuItem.Name = "editStudentInfoToolStripMenuItem";
            this.editStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.editStudentInfoToolStripMenuItem.Text = "Edit Student Info";
            this.editStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.editStudentInfoToolStripMenuItem_Click);
            // 
            // editGradeToolStripMenuItem
            // 
            this.editGradeToolStripMenuItem.Name = "editGradeToolStripMenuItem";
            this.editGradeToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.editGradeToolStripMenuItem.Text = "Edit Grade";
            this.editGradeToolStripMenuItem.Click += new System.EventHandler(this.editGradeToolStripMenuItem_Click);
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.completeToolStripMenuItem.Text = "Complete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "# Of Students :";
            // 
            // lblNumberOfStudents
            // 
            this.lblNumberOfStudents.AutoSize = true;
            this.lblNumberOfStudents.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfStudents.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfStudents.Location = new System.Drawing.Point(169, 95);
            this.lblNumberOfStudents.Name = "lblNumberOfStudents";
            this.lblNumberOfStudents.Size = new System.Drawing.Size(20, 19);
            this.lblNumberOfStudents.TabIndex = 28;
            this.lblNumberOfStudents.Text = "0";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCourseName.Location = new System.Drawing.Point(198, 34);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(220, 27);
            this.lblCourseName.TabIndex = 32;
            this.lblCourseName.Text = "CourseName (ID)";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gbEditGrade
            // 
            this.gbEditGrade.BackColor = System.Drawing.SystemColors.Control;
            this.gbEditGrade.Controls.Add(this.ckbNoGrade);
            this.gbEditGrade.Controls.Add(this.txtGrade);
            this.gbEditGrade.Controls.Add(this.btnSave);
            this.gbEditGrade.Controls.Add(this.btnCloseEditGrade);
            this.gbEditGrade.Controls.Add(this.lblStudentGrade);
            this.gbEditGrade.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditGrade.Location = new System.Drawing.Point(18, 498);
            this.gbEditGrade.Name = "gbEditGrade";
            this.gbEditGrade.Size = new System.Drawing.Size(556, 64);
            this.gbEditGrade.TabIndex = 35;
            this.gbEditGrade.TabStop = false;
            this.gbEditGrade.Text = "Edit Student Grade";
            this.gbEditGrade.Visible = false;
            // 
            // ckbNoGrade
            // 
            this.ckbNoGrade.AutoSize = true;
            this.ckbNoGrade.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbNoGrade.CheckedState.BorderRadius = 2;
            this.ckbNoGrade.CheckedState.BorderThickness = 0;
            this.ckbNoGrade.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbNoGrade.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.ckbNoGrade.ForeColor = System.Drawing.Color.Black;
            this.ckbNoGrade.Location = new System.Drawing.Point(292, 27);
            this.ckbNoGrade.Name = "ckbNoGrade";
            this.ckbNoGrade.Size = new System.Drawing.Size(92, 20);
            this.ckbNoGrade.TabIndex = 47;
            this.ckbNoGrade.Text = "No Grade";
            this.ckbNoGrade.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbNoGrade.UncheckedState.BorderRadius = 2;
            this.ckbNoGrade.UncheckedState.BorderThickness = 1;
            this.ckbNoGrade.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbNoGrade.UseVisualStyleBackColor = true;
            this.ckbNoGrade.CheckedChanged += new System.EventHandler(this.ckbNoGrade_CheckedChanged);
            // 
            // txtGrade
            // 
            this.txtGrade.BorderRadius = 10;
            this.txtGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrade.DefaultText = "";
            this.txtGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.DisabledState.Parent = this.txtGrade;
            this.txtGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.FocusedState.Parent = this.txtGrade;
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGrade.ForeColor = System.Drawing.Color.Black;
            this.txtGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.HoverState.Parent = this.txtGrade;
            this.txtGrade.Location = new System.Drawing.Point(223, 22);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PasswordChar = '\0';
            this.txtGrade.PlaceholderText = "";
            this.txtGrade.SelectedText = "";
            this.txtGrade.ShadowDecoration.Parent = this.txtGrade;
            this.txtGrade.Size = new System.Drawing.Size(54, 27);
            this.txtGrade.TabIndex = 4;
            this.txtGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrade_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::CourseCenter_Project.Properties.Resources.diskette;
            this.btnSave.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSave.Location = new System.Drawing.Point(492, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(50, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = " ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseEditGrade
            // 
            this.btnCloseEditGrade.BorderRadius = 7;
            this.btnCloseEditGrade.BorderThickness = 2;
            this.btnCloseEditGrade.CheckedState.Parent = this.btnCloseEditGrade;
            this.btnCloseEditGrade.CustomImages.Parent = this.btnCloseEditGrade;
            this.btnCloseEditGrade.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseEditGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseEditGrade.ForeColor = System.Drawing.Color.White;
            this.btnCloseEditGrade.HoverState.Parent = this.btnCloseEditGrade;
            this.btnCloseEditGrade.Image = global::CourseCenter_Project.Properties.Resources.close;
            this.btnCloseEditGrade.ImageSize = new System.Drawing.Size(27, 27);
            this.btnCloseEditGrade.Location = new System.Drawing.Point(427, 20);
            this.btnCloseEditGrade.Name = "btnCloseEditGrade";
            this.btnCloseEditGrade.ShadowDecoration.Parent = this.btnCloseEditGrade;
            this.btnCloseEditGrade.Size = new System.Drawing.Size(50, 33);
            this.btnCloseEditGrade.TabIndex = 2;
            this.btnCloseEditGrade.Click += new System.EventHandler(this.btnCloseEditGrade_Click);
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGrade.Location = new System.Drawing.Point(25, 26);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(172, 19);
            this.lblStudentGrade.TabIndex = 0;
            this.lblStudentGrade.Text = "Student (1) Grade :";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComplete.BorderThickness = 1;
            this.btnComplete.CheckedState.Parent = this.btnComplete;
            this.btnComplete.CustomImages.Parent = this.btnComplete;
            this.btnComplete.FillColor = System.Drawing.Color.Transparent;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.Black;
            this.btnComplete.HoverState.Parent = this.btnComplete;
            this.btnComplete.Image = global::CourseCenter_Project.Properties.Resources.check_mark;
            this.btnComplete.ImageSize = new System.Drawing.Size(22, 22);
            this.btnComplete.Location = new System.Drawing.Point(352, 95);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.ShadowDecoration.Parent = this.btnComplete;
            this.btnComplete.Size = new System.Drawing.Size(100, 27);
            this.btnComplete.TabIndex = 36;
            this.btnComplete.Text = "Complete";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnEditEditGrade
            // 
            this.btnEditEditGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditEditGrade.BorderThickness = 1;
            this.btnEditEditGrade.CheckedState.Parent = this.btnEditEditGrade;
            this.btnEditEditGrade.CustomImages.Parent = this.btnEditEditGrade;
            this.btnEditEditGrade.FillColor = System.Drawing.Color.Transparent;
            this.btnEditEditGrade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEditGrade.ForeColor = System.Drawing.Color.Black;
            this.btnEditEditGrade.HoverState.Parent = this.btnEditEditGrade;
            this.btnEditEditGrade.Image = global::CourseCenter_Project.Properties.Resources.add1;
            this.btnEditEditGrade.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEditEditGrade.Location = new System.Drawing.Point(474, 95);
            this.btnEditEditGrade.Name = "btnEditEditGrade";
            this.btnEditEditGrade.ShadowDecoration.Parent = this.btnEditEditGrade;
            this.btnEditEditGrade.Size = new System.Drawing.Size(100, 27);
            this.btnEditEditGrade.TabIndex = 33;
            this.btnEditEditGrade.Text = "Edit Grade";
            this.btnEditEditGrade.Click += new System.EventHandler(this.btnEditEditGrade_Click);
            // 
            // btnUnenrollStudent
            // 
            this.btnUnenrollStudent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUnenrollStudent.CheckedState.Parent = this.btnUnenrollStudent;
            this.btnUnenrollStudent.CustomImages.Parent = this.btnUnenrollStudent;
            this.btnUnenrollStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnUnenrollStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenrollStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUnenrollStudent.HoverState.Parent = this.btnUnenrollStudent;
            this.btnUnenrollStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnUnenrollStudent.Image")));
            this.btnUnenrollStudent.ImageSize = new System.Drawing.Size(22, 22);
            this.btnUnenrollStudent.Location = new System.Drawing.Point(291, 575);
            this.btnUnenrollStudent.Name = "btnUnenrollStudent";
            this.btnUnenrollStudent.ShadowDecoration.Parent = this.btnUnenrollStudent;
            this.btnUnenrollStudent.Size = new System.Drawing.Size(137, 33);
            this.btnUnenrollStudent.TabIndex = 31;
            this.btnUnenrollStudent.Text = "Unenroll Student";
            this.btnUnenrollStudent.Click += new System.EventHandler(this.btnUnenrollStudent_Click);
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEnrollStudent.CheckedState.Parent = this.btnEnrollStudent;
            this.btnEnrollStudent.CustomImages.Parent = this.btnEnrollStudent;
            this.btnEnrollStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnEnrollStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollStudent.ForeColor = System.Drawing.Color.Black;
            this.btnEnrollStudent.HoverState.Parent = this.btnEnrollStudent;
            this.btnEnrollStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrollStudent.Image")));
            this.btnEnrollStudent.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEnrollStudent.Location = new System.Drawing.Point(445, 575);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.ShadowDecoration.Parent = this.btnEnrollStudent;
            this.btnEnrollStudent.Size = new System.Drawing.Size(130, 33);
            this.btnEnrollStudent.TabIndex = 29;
            this.btnEnrollStudent.Text = "Enroll Student";
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnEnrollStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(17, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(109, 33);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStudentsEnrolledInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(591, 626);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.gbEditGrade);
            this.Controls.Add(this.btnEditEditGrade);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnUnenrollStudent);
            this.Controls.Add(this.btnEnrollStudent);
            this.Controls.Add(this.lblNumberOfStudents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStudentsEnrolledInCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentsEnrolledInCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowStudentsEnrolledInCourse";
            this.Load += new System.EventHandler(this.ShowStudentsEnrolledInCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsEnrolledInCourse)).EndInit();
            this.cmsStudentEnrollInCourse.ResumeLayout(false);
            this.gbEditGrade.ResumeLayout(false);
            this.gbEditGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.DataGridView dgvStudentsEnrolledInCourse;
        private System.Windows.Forms.Label lblNumberOfStudents;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnEnrollStudent;
        private System.Windows.Forms.ContextMenuStrip cmsStudentEnrollInCourse;
        private System.Windows.Forms.ToolStripMenuItem enrollStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentEnrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentInfoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnUnenrollStudent;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2Button btnEditEditGrade;
        private System.Windows.Forms.GroupBox gbEditGrade;
        private Guna.UI2.WinForms.Guna2TextBox txtGrade;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCloseEditGrade;
        private System.Windows.Forms.Label lblStudentGrade;
        private Guna.UI2.WinForms.Guna2CheckBox ckbNoGrade;
        private System.Windows.Forms.ToolStripMenuItem editGradeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
    }
}