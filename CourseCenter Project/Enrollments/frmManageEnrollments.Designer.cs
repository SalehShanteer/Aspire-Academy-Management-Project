namespace CourseCenter_Project
{
    partial class frmManageEnrollments
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteEnrollment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateEnrollment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewEnrollment = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEnrollmentsList = new System.Windows.Forms.DataGridView();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsEnrollmentsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxEnrollmentSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.rbDescending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAscending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentsList)).BeginInit();
            this.cmsEnrollmentsList.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDeleteEnrollment);
            this.panel1.Controls.Add(this.btnUpdateEnrollment);
            this.panel1.Controls.Add(this.btnAddNewEnrollment);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 7;
            // 
            // btnDeleteEnrollment
            // 
            this.btnDeleteEnrollment.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteEnrollment.CheckedState.Parent = this.btnDeleteEnrollment;
            this.btnDeleteEnrollment.CustomImages.Parent = this.btnDeleteEnrollment;
            this.btnDeleteEnrollment.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteEnrollment.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEnrollment.HoverState.Parent = this.btnDeleteEnrollment;
            this.btnDeleteEnrollment.Image = global::CourseCenter_Project.Properties.Resources.remove;
            this.btnDeleteEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteEnrollment.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteEnrollment.Location = new System.Drawing.Point(36, 517);
            this.btnDeleteEnrollment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            this.btnDeleteEnrollment.ShadowDecoration.Parent = this.btnDeleteEnrollment;
            this.btnDeleteEnrollment.Size = new System.Drawing.Size(314, 48);
            this.btnDeleteEnrollment.TabIndex = 12;
            this.btnDeleteEnrollment.Text = "Delete Enrollment";
            this.btnDeleteEnrollment.Click += new System.EventHandler(this.btnDeleteEnrollment_Click);
            // 
            // btnUpdateEnrollment
            // 
            this.btnUpdateEnrollment.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateEnrollment.CheckedState.Parent = this.btnUpdateEnrollment;
            this.btnUpdateEnrollment.CustomImages.Parent = this.btnUpdateEnrollment;
            this.btnUpdateEnrollment.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateEnrollment.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEnrollment.HoverState.Parent = this.btnUpdateEnrollment;
            this.btnUpdateEnrollment.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdateEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateEnrollment.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateEnrollment.Location = new System.Drawing.Point(36, 434);
            this.btnUpdateEnrollment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateEnrollment.Name = "btnUpdateEnrollment";
            this.btnUpdateEnrollment.ShadowDecoration.Parent = this.btnUpdateEnrollment;
            this.btnUpdateEnrollment.Size = new System.Drawing.Size(314, 48);
            this.btnUpdateEnrollment.TabIndex = 10;
            this.btnUpdateEnrollment.Text = "Update Enrollment";
            this.btnUpdateEnrollment.Click += new System.EventHandler(this.btnUpdateEnrollment_Click);
            // 
            // btnAddNewEnrollment
            // 
            this.btnAddNewEnrollment.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewEnrollment.CheckedState.Parent = this.btnAddNewEnrollment;
            this.btnAddNewEnrollment.CustomImages.Parent = this.btnAddNewEnrollment;
            this.btnAddNewEnrollment.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewEnrollment.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewEnrollment.HoverState.Parent = this.btnAddNewEnrollment;
            this.btnAddNewEnrollment.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewEnrollment.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewEnrollment.Location = new System.Drawing.Point(36, 352);
            this.btnAddNewEnrollment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewEnrollment.Name = "btnAddNewEnrollment";
            this.btnAddNewEnrollment.ShadowDecoration.Parent = this.btnAddNewEnrollment;
            this.btnAddNewEnrollment.Size = new System.Drawing.Size(314, 48);
            this.btnAddNewEnrollment.TabIndex = 9;
            this.btnAddNewEnrollment.Text = "Add New Enrollment";
            this.btnAddNewEnrollment.Click += new System.EventHandler(this.btnAddNewEnrollment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.checklist;
            this.pictureBox1.Location = new System.Drawing.Point(86, 21);
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
            this.label1.Location = new System.Drawing.Point(27, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Enrollments";
            // 
            // dgvEnrollmentsList
            // 
            this.dgvEnrollmentsList.AllowUserToAddRows = false;
            this.dgvEnrollmentsList.AllowUserToDeleteRows = false;
            this.dgvEnrollmentsList.AllowUserToOrderColumns = true;
            this.dgvEnrollmentsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEnrollmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollmentsList.Location = new System.Drawing.Point(462, 102);
            this.dgvEnrollmentsList.Name = "dgvEnrollmentsList";
            this.dgvEnrollmentsList.ReadOnly = true;
            this.dgvEnrollmentsList.Size = new System.Drawing.Size(707, 578);
            this.dgvEnrollmentsList.TabIndex = 14;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 24;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmsEnrollmentsList
            // 
            this.cmsEnrollmentsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsEnrollmentsList.Name = "cmsEnrollmentsList";
            this.cmsEnrollmentsList.Size = new System.Drawing.Size(159, 94);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbxEnrollmentSort
            // 
            this.cbxEnrollmentSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnrollmentSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnrollmentSort.FormattingEnabled = true;
            this.cbxEnrollmentSort.Items.AddRange(new object[] {
            "EnrollmentID",
            "StudentID",
            "CourseID",
            "StartDate",
            "EndDate",
            "Grade"});
            this.cbxEnrollmentSort.Location = new System.Drawing.Point(554, 70);
            this.cbxEnrollmentSort.Name = "cbxEnrollmentSort";
            this.cbxEnrollmentSort.Size = new System.Drawing.Size(131, 23);
            this.cbxEnrollmentSort.TabIndex = 28;
            this.cbxEnrollmentSort.SelectedIndexChanged += new System.EventHandler(this.cbxEnrollmentSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(463, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sort By :";
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
            this.btnBack.TabIndex = 31;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.rbDescending.Location = new System.Drawing.Point(806, 73);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(103, 20);
            this.rbDescending.TabIndex = 33;
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
            this.rbAscending.Location = new System.Drawing.Point(706, 73);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(94, 20);
            this.rbAscending.TabIndex = 32;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAscending.UncheckedState.BorderThickness = 2;
            this.rbAscending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAscending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmManageEnrollments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.ContextMenuStrip = this.cmsEnrollmentsList;
            this.Controls.Add(this.rbDescending);
            this.Controls.Add(this.rbAscending);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxEnrollmentSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.dgvEnrollmentsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageEnrollments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnrollmentList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageEnrollments_FormClosed);
            this.Load += new System.EventHandler(this.frmManageEnrollments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentsList)).EndInit();
            this.cmsEnrollmentsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEnrollmentsList;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEnrollment;
        private Guna.UI2.WinForms.Guna2Button btnUpdateEnrollment;
        private Guna.UI2.WinForms.Guna2Button btnAddNewEnrollment;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsEnrollmentsList;
        private System.Windows.Forms.ComboBox cbxEnrollmentSort;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2RadioButton rbDescending;
        private Guna.UI2.WinForms.Guna2RadioButton rbAscending;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}