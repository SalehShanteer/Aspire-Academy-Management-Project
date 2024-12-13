namespace CourseCenter_Project
{
    partial class frmActiveStudentsInCoursesList
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
            this.dgvActiveStudentsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblNumberOfActiveStudents = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudentsList)).BeginInit();
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
            // dgvActiveStudentsList
            // 
            this.dgvActiveStudentsList.AllowUserToAddRows = false;
            this.dgvActiveStudentsList.AllowUserToDeleteRows = false;
            this.dgvActiveStudentsList.AllowUserToOrderColumns = true;
            this.dgvActiveStudentsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvActiveStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveStudentsList.Location = new System.Drawing.Point(12, 128);
            this.dgvActiveStudentsList.Name = "dgvActiveStudentsList";
            this.dgvActiveStudentsList.ReadOnly = true;
            this.dgvActiveStudentsList.Size = new System.Drawing.Size(547, 465);
            this.dgvActiveStudentsList.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(125, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Active Student List";
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
            this.btnClose.Location = new System.Drawing.Point(425, 604);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberOfActiveStudents
            // 
            this.lblNumberOfActiveStudents.AutoSize = true;
            this.lblNumberOfActiveStudents.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfActiveStudents.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfActiveStudents.Location = new System.Drawing.Point(234, 98);
            this.lblNumberOfActiveStudents.Name = "lblNumberOfActiveStudents";
            this.lblNumberOfActiveStudents.Size = new System.Drawing.Size(20, 19);
            this.lblNumberOfActiveStudents.TabIndex = 32;
            this.lblNumberOfActiveStudents.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "# Of Active Students :";
            // 
            // frmActiveStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(571, 651);
            this.Controls.Add(this.lblNumberOfActiveStudents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActiveStudentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActiveStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActiveStudentsList";
            this.Load += new System.EventHandler(this.frmActiveStudentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataGridView dgvActiveStudentsList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblNumberOfActiveStudents;
        private System.Windows.Forms.Label label8;
    }
}