namespace CourseCenter_Project
{
    partial class frmAddUpdateSpecialization
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtSpecializationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblSpecializationID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddUpdateSpecialization = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.txtSpecializationName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.groupBox1.Location = new System.Drawing.Point(27, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 204);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specialization Info";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Location = new System.Drawing.Point(143, 83);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(298, 105);
            this.rtxtDescription.TabIndex = 26;
            this.rtxtDescription.Text = "";
            // 
            // txtSpecializationName
            // 
            this.txtSpecializationName.BorderRadius = 10;
            this.txtSpecializationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecializationName.DefaultText = "";
            this.txtSpecializationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSpecializationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSpecializationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpecializationName.DisabledState.Parent = this.txtSpecializationName;
            this.txtSpecializationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpecializationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecializationName.FocusedState.Parent = this.txtSpecializationName;
            this.txtSpecializationName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpecializationName.ForeColor = System.Drawing.Color.Black;
            this.txtSpecializationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecializationName.HoverState.Parent = this.txtSpecializationName;
            this.txtSpecializationName.Location = new System.Drawing.Point(143, 39);
            this.txtSpecializationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecializationName.Name = "txtSpecializationName";
            this.txtSpecializationName.PasswordChar = '\0';
            this.txtSpecializationName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSpecializationName.PlaceholderText = "";
            this.txtSpecializationName.SelectedText = "";
            this.txtSpecializationName.ShadowDecoration.Parent = this.txtSpecializationName;
            this.txtSpecializationName.Size = new System.Drawing.Size(298, 27);
            this.txtSpecializationName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name :";
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
            this.btnClose.Location = new System.Drawing.Point(248, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 28;
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
            this.btnSave.Location = new System.Drawing.Point(393, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(109, 35);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSpecializationID
            // 
            this.lblSpecializationID.AutoSize = true;
            this.lblSpecializationID.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecializationID.ForeColor = System.Drawing.Color.White;
            this.lblSpecializationID.Location = new System.Drawing.Point(202, 100);
            this.lblSpecializationID.Name = "lblSpecializationID";
            this.lblSpecializationID.Size = new System.Drawing.Size(36, 19);
            this.lblSpecializationID.TabIndex = 26;
            this.lblSpecializationID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Specialization ID :";
            // 
            // lblAddUpdateSpecialization
            // 
            this.lblAddUpdateSpecialization.AutoSize = true;
            this.lblAddUpdateSpecialization.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.lblAddUpdateSpecialization.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddUpdateSpecialization.Location = new System.Drawing.Point(86, 45);
            this.lblAddUpdateSpecialization.Name = "lblAddUpdateSpecialization";
            this.lblAddUpdateSpecialization.Size = new System.Drawing.Size(347, 31);
            this.lblAddUpdateSpecialization.TabIndex = 24;
            this.lblAddUpdateSpecialization.Text = "Add New Specialization";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(528, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSpecializationID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAddUpdateSpecialization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateSpecialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateSpecialization";
            this.Load += new System.EventHandler(this.frmAddUpdateSpecialization_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtSpecializationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblSpecializationID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddUpdateSpecialization;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}