namespace CourseCenter_Project
{
    partial class frmAddUpdateCourse
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
            this.lblAddUpdateCourse = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCourseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreditHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmountToIncrease = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourseFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llblEditInstructorInfo = new System.Windows.Forms.LinkLabel();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblInstructorID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFindByID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // lblAddUpdateCourse
            // 
            this.lblAddUpdateCourse.AutoSize = true;
            this.lblAddUpdateCourse.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold);
            this.lblAddUpdateCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddUpdateCourse.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddUpdateCourse.Location = new System.Drawing.Point(148, 29);
            this.lblAddUpdateCourse.Name = "lblAddUpdateCourse";
            this.lblAddUpdateCourse.Size = new System.Drawing.Size(287, 37);
            this.lblAddUpdateCourse.TabIndex = 21;
            this.lblAddUpdateCourse.Text = "Add New Course";
            this.lblAddUpdateCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.Color.White;
            this.lblCourseID.Location = new System.Drawing.Point(129, 90);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(36, 19);
            this.lblCourseID.TabIndex = 33;
            this.lblCourseID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Course ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtCourseName);
            this.groupBox3.Controls.Add(this.txtCreditHours);
            this.groupBox3.Controls.Add(this.lblAmountToIncrease);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCourseFee);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 155);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course Info";
            // 
            // txtCourseName
            // 
            this.txtCourseName.BorderRadius = 10;
            this.txtCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.DefaultText = "";
            this.txtCourseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCourseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseName.DisabledState.Parent = this.txtCourseName;
            this.txtCourseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseName.FocusedState.Parent = this.txtCourseName;
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCourseName.ForeColor = System.Drawing.Color.Black;
            this.txtCourseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseName.HoverState.Parent = this.txtCourseName;
            this.txtCourseName.Location = new System.Drawing.Point(187, 27);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.PlaceholderText = "";
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.ShadowDecoration.Parent = this.txtCourseName;
            this.txtCourseName.Size = new System.Drawing.Size(208, 27);
            this.txtCourseName.TabIndex = 36;
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.BorderRadius = 10;
            this.txtCreditHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditHours.DefaultText = "";
            this.txtCreditHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreditHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreditHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreditHours.DisabledState.Parent = this.txtCreditHours;
            this.txtCreditHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreditHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreditHours.FocusedState.Parent = this.txtCreditHours;
            this.txtCreditHours.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCreditHours.ForeColor = System.Drawing.Color.Black;
            this.txtCreditHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreditHours.HoverState.Parent = this.txtCreditHours;
            this.txtCreditHours.Location = new System.Drawing.Point(187, 111);
            this.txtCreditHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.PasswordChar = '\0';
            this.txtCreditHours.PlaceholderText = "";
            this.txtCreditHours.SelectedText = "";
            this.txtCreditHours.ShadowDecoration.Parent = this.txtCreditHours;
            this.txtCreditHours.Size = new System.Drawing.Size(208, 27);
            this.txtCreditHours.TabIndex = 34;
            this.txtCreditHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditHours_KeyPress);
            // 
            // lblAmountToIncrease
            // 
            this.lblAmountToIncrease.AutoSize = true;
            this.lblAmountToIncrease.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToIncrease.Location = new System.Drawing.Point(25, 116);
            this.lblAmountToIncrease.Name = "lblAmountToIncrease";
            this.lblAmountToIncrease.Size = new System.Drawing.Size(128, 19);
            this.lblAmountToIncrease.TabIndex = 35;
            this.lblAmountToIncrease.Text = "Credit Hours :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Course Name :";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.BorderRadius = 10;
            this.txtCourseFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseFee.DefaultText = "";
            this.txtCourseFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourseFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCourseFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseFee.DisabledState.Parent = this.txtCourseFee;
            this.txtCourseFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseFee.FocusedState.Parent = this.txtCourseFee;
            this.txtCourseFee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCourseFee.ForeColor = System.Drawing.Color.Black;
            this.txtCourseFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseFee.HoverState.Parent = this.txtCourseFee;
            this.txtCourseFee.Location = new System.Drawing.Point(187, 70);
            this.txtCourseFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.PasswordChar = '\0';
            this.txtCourseFee.PlaceholderText = "";
            this.txtCourseFee.SelectedText = "";
            this.txtCourseFee.ShadowDecoration.Parent = this.txtCourseFee;
            this.txtCourseFee.Size = new System.Drawing.Size(208, 27);
            this.txtCourseFee.TabIndex = 5;
            this.txtCourseFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCourseFee_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Course Fee :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.llblEditInstructorInfo);
            this.groupBox2.Controls.Add(this.lblSalary);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblCertificates);
            this.groupBox2.Controls.Add(this.lblSpecialization);
            this.groupBox2.Controls.Add(this.lblPersonID);
            this.groupBox2.Controls.Add(this.lblInstructorID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.groupBox2.Location = new System.Drawing.Point(25, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 246);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructor Info";
            // 
            // llblEditInstructorInfo
            // 
            this.llblEditInstructorInfo.AutoSize = true;
            this.llblEditInstructorInfo.Enabled = false;
            this.llblEditInstructorInfo.Location = new System.Drawing.Point(386, 38);
            this.llblEditInstructorInfo.Name = "llblEditInstructorInfo";
            this.llblEditInstructorInfo.Size = new System.Drawing.Size(147, 18);
            this.llblEditInstructorInfo.TabIndex = 29;
            this.llblEditInstructorInfo.TabStop = true;
            this.llblEditInstructorInfo.Text = "Edit Instructor Info";
            this.llblEditInstructorInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditInstructorInfo_LinkClicked);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(168, 165);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(45, 19);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "????";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 19);
            this.label18.TabIndex = 16;
            this.label18.Text = "Salary :";
            // 
            // lblCertificates
            // 
            this.lblCertificates.AutoSize = true;
            this.lblCertificates.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificates.Location = new System.Drawing.Point(168, 203);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(45, 19);
            this.lblCertificates.TabIndex = 15;
            this.lblCertificates.Text = "????";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(168, 126);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(45, 19);
            this.lblSpecialization.TabIndex = 13;
            this.lblSpecialization.Text = "????";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(168, 82);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(45, 19);
            this.lblPersonID.TabIndex = 12;
            this.lblPersonID.Text = "????";
            // 
            // lblInstructorID
            // 
            this.lblInstructorID.AutoSize = true;
            this.lblInstructorID.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorID.Location = new System.Drawing.Point(168, 38);
            this.lblInstructorID.Name = "lblInstructorID";
            this.lblInstructorID.Size = new System.Drawing.Size(45, 19);
            this.lblInstructorID.TabIndex = 11;
            this.lblInstructorID.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Certificates :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Specialization :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Person ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instructor ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtFindByID);
            this.groupBox1.Controls.Add(this.btnAddInstructor);
            this.groupBox1.Controls.Add(this.btnSearchInstructor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 64);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Instructor To Teach Course";
            // 
            // txtFindByID
            // 
            this.txtFindByID.BorderRadius = 10;
            this.txtFindByID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindByID.DefaultText = "";
            this.txtFindByID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindByID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindByID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByID.DisabledState.Parent = this.txtFindByID;
            this.txtFindByID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindByID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByID.FocusedState.Parent = this.txtFindByID;
            this.txtFindByID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFindByID.ForeColor = System.Drawing.Color.Black;
            this.txtFindByID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindByID.HoverState.Parent = this.txtFindByID;
            this.txtFindByID.Location = new System.Drawing.Point(155, 24);
            this.txtFindByID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.PasswordChar = '\0';
            this.txtFindByID.PlaceholderText = "";
            this.txtFindByID.SelectedText = "";
            this.txtFindByID.ShadowDecoration.Parent = this.txtFindByID;
            this.txtFindByID.Size = new System.Drawing.Size(213, 27);
            this.txtFindByID.TabIndex = 4;
            this.txtFindByID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindByID_KeyDown);
            this.txtFindByID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindByID_KeyPress);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BorderRadius = 7;
            this.btnAddInstructor.BorderThickness = 2;
            this.btnAddInstructor.CheckedState.Parent = this.btnAddInstructor;
            this.btnAddInstructor.CustomImages.Parent = this.btnAddInstructor;
            this.btnAddInstructor.FillColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.HoverState.Parent = this.btnAddInstructor;
            this.btnAddInstructor.Image = global::CourseCenter_Project.Properties.Resources.new_user;
            this.btnAddInstructor.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAddInstructor.Location = new System.Drawing.Point(460, 20);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.ShadowDecoration.Parent = this.btnAddInstructor;
            this.btnAddInstructor.Size = new System.Drawing.Size(50, 33);
            this.btnAddInstructor.TabIndex = 3;
            this.btnAddInstructor.Text = " ";
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // btnSearchInstructor
            // 
            this.btnSearchInstructor.BorderRadius = 7;
            this.btnSearchInstructor.BorderThickness = 2;
            this.btnSearchInstructor.CheckedState.Parent = this.btnSearchInstructor;
            this.btnSearchInstructor.CustomImages.Parent = this.btnSearchInstructor;
            this.btnSearchInstructor.FillColor = System.Drawing.Color.Transparent;
            this.btnSearchInstructor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchInstructor.ForeColor = System.Drawing.Color.White;
            this.btnSearchInstructor.HoverState.Parent = this.btnSearchInstructor;
            this.btnSearchInstructor.Image = global::CourseCenter_Project.Properties.Resources.find_person;
            this.btnSearchInstructor.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearchInstructor.Location = new System.Drawing.Point(395, 20);
            this.btnSearchInstructor.Name = "btnSearchInstructor";
            this.btnSearchInstructor.ShadowDecoration.Parent = this.btnSearchInstructor;
            this.btnSearchInstructor.Size = new System.Drawing.Size(50, 33);
            this.btnSearchInstructor.TabIndex = 2;
            this.btnSearchInstructor.Click += new System.EventHandler(this.btnSearchInstructor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::CourseCenter_Project.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(326, 629);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::CourseCenter_Project.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(471, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(109, 35);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 678);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddUpdateCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateCourse";
            this.Load += new System.EventHandler(this.frmAddUpdateCourse_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblAddUpdateCourse;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtCreditHours;
        private System.Windows.Forms.Label lblAmountToIncrease;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtCourseFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel llblEditInstructorInfo;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblInstructorID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindByID;
        private Guna.UI2.WinForms.Guna2Button btnAddInstructor;
        private Guna.UI2.WinForms.Guna2Button btnSearchInstructor;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCourseName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}