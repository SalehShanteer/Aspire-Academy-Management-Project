namespace CourseCenter_Project
{
    partial class frmStudentEnrollments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentEnrollments));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgvStudentEnrollments = new System.Windows.Forms.DataGridView();
            this.cmsStudentEnrollments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unEnrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStudentEnrollments = new System.Windows.Forms.Label();
            this.lblNumberOfEnrollments = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUnenroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnroll = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEnrollments)).BeginInit();
            this.cmsStudentEnrollments.SuspendLayout();
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::CourseCenter_Project.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(19, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(108, 35);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStudentEnrollments
            // 
            this.dgvStudentEnrollments.AllowUserToAddRows = false;
            this.dgvStudentEnrollments.AllowUserToDeleteRows = false;
            this.dgvStudentEnrollments.AllowUserToOrderColumns = true;
            this.dgvStudentEnrollments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentEnrollments.ContextMenuStrip = this.cmsStudentEnrollments;
            this.dgvStudentEnrollments.Location = new System.Drawing.Point(19, 116);
            this.dgvStudentEnrollments.Name = "dgvStudentEnrollments";
            this.dgvStudentEnrollments.ReadOnly = true;
            this.dgvStudentEnrollments.Size = new System.Drawing.Size(486, 429);
            this.dgvStudentEnrollments.TabIndex = 25;
            // 
            // cmsStudentEnrollments
            // 
            this.cmsStudentEnrollments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollToolStripMenuItem,
            this.editToolStripMenuItem,
            this.unEnrollToolStripMenuItem});
            this.cmsStudentEnrollments.Name = "cmsStudentEnrollments";
            this.cmsStudentEnrollments.Size = new System.Drawing.Size(151, 94);
            // 
            // enrollToolStripMenuItem
            // 
            this.enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            this.enrollToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.enrollToolStripMenuItem.Text = "Enroll";
            this.enrollToolStripMenuItem.Click += new System.EventHandler(this.enrollToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // unEnrollToolStripMenuItem
            // 
            this.unEnrollToolStripMenuItem.Name = "unEnrollToolStripMenuItem";
            this.unEnrollToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.unEnrollToolStripMenuItem.Text = "Unenroll";
            this.unEnrollToolStripMenuItem.Click += new System.EventHandler(this.unEnrollToolStripMenuItem_Click);
            // 
            // lblStudentEnrollments
            // 
            this.lblStudentEnrollments.AutoSize = true;
            this.lblStudentEnrollments.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.lblStudentEnrollments.ForeColor = System.Drawing.Color.White;
            this.lblStudentEnrollments.Location = new System.Drawing.Point(96, 32);
            this.lblStudentEnrollments.Name = "lblStudentEnrollments";
            this.lblStudentEnrollments.Size = new System.Drawing.Size(351, 31);
            this.lblStudentEnrollments.TabIndex = 26;
            this.lblStudentEnrollments.Text = "Student (1) Enrollments";
            // 
            // lblNumberOfEnrollments
            // 
            this.lblNumberOfEnrollments.AutoSize = true;
            this.lblNumberOfEnrollments.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfEnrollments.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfEnrollments.Location = new System.Drawing.Point(183, 82);
            this.lblNumberOfEnrollments.Name = "lblNumberOfEnrollments";
            this.lblNumberOfEnrollments.Size = new System.Drawing.Size(20, 19);
            this.lblNumberOfEnrollments.TabIndex = 30;
            this.lblNumberOfEnrollments.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "# Of Enrollments :";
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUnenroll.CheckedState.Parent = this.btnUnenroll;
            this.btnUnenroll.CustomImages.Parent = this.btnUnenroll;
            this.btnUnenroll.FillColor = System.Drawing.Color.Transparent;
            this.btnUnenroll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenroll.ForeColor = System.Drawing.Color.Black;
            this.btnUnenroll.HoverState.Parent = this.btnUnenroll;
            this.btnUnenroll.Image = ((System.Drawing.Image)(resources.GetObject("btnUnenroll.Image")));
            this.btnUnenroll.ImageSize = new System.Drawing.Size(22, 22);
            this.btnUnenroll.Location = new System.Drawing.Point(302, 560);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.ShadowDecoration.Parent = this.btnUnenroll;
            this.btnUnenroll.Size = new System.Drawing.Size(93, 33);
            this.btnUnenroll.TabIndex = 33;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEnroll.CheckedState.Parent = this.btnEnroll;
            this.btnEnroll.CustomImages.Parent = this.btnEnroll;
            this.btnEnroll.FillColor = System.Drawing.Color.Transparent;
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.Black;
            this.btnEnroll.HoverState.Parent = this.btnEnroll;
            this.btnEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnEnroll.Image")));
            this.btnEnroll.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEnroll.Location = new System.Drawing.Point(412, 560);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.ShadowDecoration.Parent = this.btnEnroll;
            this.btnEnroll.Size = new System.Drawing.Size(93, 33);
            this.btnEnroll.TabIndex = 32;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmStudentEnrollments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(525, 603);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.lblNumberOfEnrollments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStudentEnrollments);
            this.Controls.Add(this.dgvStudentEnrollments);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentEnrollments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentEnrollments";
            this.Load += new System.EventHandler(this.frmStudentEnrollments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEnrollments)).EndInit();
            this.cmsStudentEnrollments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.DataGridView dgvStudentEnrollments;
        private System.Windows.Forms.Label lblStudentEnrollments;
        private System.Windows.Forms.Label lblNumberOfEnrollments;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnUnenroll;
        private Guna.UI2.WinForms.Guna2Button btnEnroll;
        private System.Windows.Forms.ContextMenuStrip cmsStudentEnrollments;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unEnrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}