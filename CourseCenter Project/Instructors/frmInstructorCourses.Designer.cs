namespace CourseCenter_Project
{
    partial class frmInstructorCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructorCourses));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNumberOfCourses = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInstructorCourses = new System.Windows.Forms.DataGridView();
            this.cmsInstructorCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstructorCourses = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblInstructorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCourse = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorCourses)).BeginInit();
            this.cmsInstructorCourses.SuspendLayout();
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
            // lblNumberOfCourses
            // 
            this.lblNumberOfCourses.AutoSize = true;
            this.lblNumberOfCourses.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCourses.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfCourses.Location = new System.Drawing.Point(162, 492);
            this.lblNumberOfCourses.Name = "lblNumberOfCourses";
            this.lblNumberOfCourses.Size = new System.Drawing.Size(20, 19);
            this.lblNumberOfCourses.TabIndex = 31;
            this.lblNumberOfCourses.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "# Of Courses :";
            // 
            // dgvInstructorCourses
            // 
            this.dgvInstructorCourses.AllowUserToAddRows = false;
            this.dgvInstructorCourses.AllowUserToDeleteRows = false;
            this.dgvInstructorCourses.AllowUserToOrderColumns = true;
            this.dgvInstructorCourses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInstructorCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructorCourses.ContextMenuStrip = this.cmsInstructorCourses;
            this.dgvInstructorCourses.Location = new System.Drawing.Point(15, 124);
            this.dgvInstructorCourses.Name = "dgvInstructorCourses";
            this.dgvInstructorCourses.ReadOnly = true;
            this.dgvInstructorCourses.Size = new System.Drawing.Size(445, 349);
            this.dgvInstructorCourses.TabIndex = 29;
            // 
            // cmsInstructorCourses
            // 
            this.cmsInstructorCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsInstructorCourses.Name = "contextMenuStrip1";
            this.cmsInstructorCourses.Size = new System.Drawing.Size(159, 94);
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
            // lblInstructorCourses
            // 
            this.lblInstructorCourses.AutoSize = true;
            this.lblInstructorCourses.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorCourses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInstructorCourses.Location = new System.Drawing.Point(103, 41);
            this.lblInstructorCourses.Name = "lblInstructorCourses";
            this.lblInstructorCourses.Size = new System.Drawing.Size(279, 31);
            this.lblInstructorCourses.TabIndex = 32;
            this.lblInstructorCourses.Text = "Instructor Courses";
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
            this.btnClose.Location = new System.Drawing.Point(216, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(98, 33);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInstructorID
            // 
            this.lblInstructorID.AutoSize = true;
            this.lblInstructorID.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorID.ForeColor = System.Drawing.Color.White;
            this.lblInstructorID.Location = new System.Drawing.Point(165, 95);
            this.lblInstructorID.Name = "lblInstructorID";
            this.lblInstructorID.Size = new System.Drawing.Size(20, 19);
            this.lblInstructorID.TabIndex = 35;
            this.lblInstructorID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Instructor ID :";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddCourse.CheckedState.Parent = this.btnAddCourse;
            this.btnAddCourse.CustomImages.Parent = this.btnAddCourse;
            this.btnAddCourse.FillColor = System.Drawing.Color.Transparent;
            this.btnAddCourse.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.btnAddCourse.ForeColor = System.Drawing.Color.Black;
            this.btnAddCourse.HoverState.Parent = this.btnAddCourse;
            this.btnAddCourse.Image = global::CourseCenter_Project.Properties.Resources.add1;
            this.btnAddCourse.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddCourse.Location = new System.Drawing.Point(340, 490);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.ShadowDecoration.Parent = this.btnAddCourse;
            this.btnAddCourse.Size = new System.Drawing.Size(120, 33);
            this.btnAddCourse.TabIndex = 37;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // frmInstructorCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(478, 536);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblInstructorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInstructorCourses);
            this.Controls.Add(this.lblNumberOfCourses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvInstructorCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstructorCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInstructorCourses";
            this.Load += new System.EventHandler(this.frmInstructorCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorCourses)).EndInit();
            this.cmsInstructorCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblNumberOfCourses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInstructorCourses;
        private System.Windows.Forms.Label lblInstructorCourses;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblInstructorID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAddCourse;
        private System.Windows.Forms.ContextMenuStrip cmsInstructorCourses;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}