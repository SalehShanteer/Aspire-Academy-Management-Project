namespace CourseCenter_Project
{
    partial class frmAddUpdatePaymentMethod
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblAddUpdatePaymentMethod = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMethodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.btnClose.Location = new System.Drawing.Point(200, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(101, 28);
            this.btnClose.TabIndex = 36;
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
            this.btnSave.Location = new System.Drawing.Point(345, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(101, 28);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddUpdatePaymentMethod
            // 
            this.lblAddUpdatePaymentMethod.AutoSize = true;
            this.lblAddUpdatePaymentMethod.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.lblAddUpdatePaymentMethod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddUpdatePaymentMethod.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddUpdatePaymentMethod.Location = new System.Drawing.Point(64, 48);
            this.lblAddUpdatePaymentMethod.Name = "lblAddUpdatePaymentMethod";
            this.lblAddUpdatePaymentMethod.Size = new System.Drawing.Size(390, 31);
            this.lblAddUpdatePaymentMethod.TabIndex = 37;
            this.lblAddUpdatePaymentMethod.Text = "Add New Payment Method";
            this.lblAddUpdatePaymentMethod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(176, 41);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(272, 25);
            this.txtID.TabIndex = 39;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID :";
            // 
            // txtMethodName
            // 
            this.txtMethodName.BorderRadius = 10;
            this.txtMethodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMethodName.DefaultText = "";
            this.txtMethodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMethodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMethodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMethodName.DisabledState.Parent = this.txtMethodName;
            this.txtMethodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMethodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMethodName.FocusedState.Parent = this.txtMethodName;
            this.txtMethodName.ForeColor = System.Drawing.Color.Black;
            this.txtMethodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMethodName.HoverState.Parent = this.txtMethodName;
            this.txtMethodName.Location = new System.Drawing.Point(176, 95);
            this.txtMethodName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.PasswordChar = '\0';
            this.txtMethodName.PlaceholderText = "";
            this.txtMethodName.SelectedText = "";
            this.txtMethodName.ShadowDecoration.Parent = this.txtMethodName;
            this.txtMethodName.Size = new System.Drawing.Size(272, 25);
            this.txtMethodName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "MethodName :";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Location = new System.Drawing.Point(176, 153);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(285, 64);
            this.rtxtDescription.TabIndex = 42;
            this.rtxtDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Description :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckbActive);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMethodName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 273);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Activation :";
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbActive.CheckedState.BorderRadius = 2;
            this.ckbActive.CheckedState.BorderThickness = 0;
            this.ckbActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbActive.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.ckbActive.ForeColor = System.Drawing.Color.Black;
            this.ckbActive.Location = new System.Drawing.Point(176, 242);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(85, 23);
            this.ckbActive.TabIndex = 46;
            this.ckbActive.Text = "Active";
            this.ckbActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbActive.UncheckedState.BorderRadius = 2;
            this.ckbActive.UncheckedState.BorderThickness = 1;
            this.ckbActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(520, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddUpdatePaymentMethod);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdatePaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdatePaymentMethod";
            this.Load += new System.EventHandler(this.frmAddUpdatePaymentMethod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblAddUpdatePaymentMethod;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMethodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox ckbActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}