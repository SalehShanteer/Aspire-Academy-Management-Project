namespace CourseCenter_Project
{
    partial class frmLoginScreen
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowHidePassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lable15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.timerRemaining = new System.Windows.Forms.Timer(this.components);
            this.lblRemainingAndTimer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 30F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2ControlBox1.Location = new System.Drawing.Point(804, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(41, 38);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 511);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(87, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 62);
            this.label1.TabIndex = 16;
            this.label1.Text = "The Right Way\r\nTo Learn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Aspire Academy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.online_course;
            this.pictureBox1.Location = new System.Drawing.Point(46, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(541, 245);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(255, 27);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(541, 309);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(255, 27);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.CheckedState.Parent = this.btnShowHidePassword;
            this.btnShowHidePassword.HoverState.Parent = this.btnShowHidePassword;
            this.btnShowHidePassword.Image = global::CourseCenter_Project.Properties.Resources.hide;
            this.btnShowHidePassword.ImageSize = new System.Drawing.Size(22, 22);
            this.btnShowHidePassword.Location = new System.Drawing.Point(807, 309);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.PressedState.Parent = this.btnShowHidePassword;
            this.btnShowHidePassword.Size = new System.Drawing.Size(29, 23);
            this.btnShowHidePassword.TabIndex = 12;
            this.btnShowHidePassword.Tag = "Hide";
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // lable15
            // 
            this.lable15.AutoSize = true;
            this.lable15.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable15.Location = new System.Drawing.Point(426, 312);
            this.lable15.Name = "lable15";
            this.lable15.Size = new System.Drawing.Size(93, 19);
            this.lable15.TabIndex = 14;
            this.lable15.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 35F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(569, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 54);
            this.label2.TabIndex = 15;
            this.label2.Text = "Login";
            // 
            // ckbRememberMe
            // 
            this.ckbRememberMe.AutoSize = true;
            this.ckbRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbRememberMe.CheckedState.BorderRadius = 2;
            this.ckbRememberMe.CheckedState.BorderThickness = 0;
            this.ckbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbRememberMe.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.ckbRememberMe.ForeColor = System.Drawing.Color.Black;
            this.ckbRememberMe.Location = new System.Drawing.Point(547, 353);
            this.ckbRememberMe.Name = "ckbRememberMe";
            this.ckbRememberMe.Size = new System.Drawing.Size(127, 20);
            this.ckbRememberMe.TabIndex = 48;
            this.ckbRememberMe.Text = "Remember me";
            this.ckbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbRememberMe.UncheckedState.BorderRadius = 2;
            this.ckbRememberMe.UncheckedState.BorderThickness = 1;
            this.ckbRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(544, 440);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 35);
            this.btnLogin.TabIndex = 49;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timerRemaining
            // 
            this.timerRemaining.Interval = 10;
            this.timerRemaining.Tick += new System.EventHandler(this.timerRemaining_Tick);
            // 
            // lblRemainingAndTimer
            // 
            this.lblRemainingAndTimer.AutoSize = true;
            this.lblRemainingAndTimer.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemainingAndTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRemainingAndTimer.Location = new System.Drawing.Point(577, 384);
            this.lblRemainingAndTimer.Name = "lblRemainingAndTimer";
            this.lblRemainingAndTimer.Size = new System.Drawing.Size(139, 16);
            this.lblRemainingAndTimer.TabIndex = 50;
            this.lblRemainingAndTimer.Text = "Remaining + Timer";
            this.lblRemainingAndTimer.Visible = false;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 511);
            this.Controls.Add(this.lblRemainingAndTimer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ckbRememberMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowHidePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginScreen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowHidePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable15;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox ckbRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Timer timerRemaining;
        private System.Windows.Forms.Label lblRemainingAndTimer;
    }
}