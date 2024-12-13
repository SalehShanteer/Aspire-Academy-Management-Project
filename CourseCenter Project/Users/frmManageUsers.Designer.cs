namespace CourseCenter_Project
{
    partial class frmManageUsers
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsUsersList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.dgvRolesList = new System.Windows.Forms.DataGridView();
            this.cmsRolesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxSearchFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmsUsersList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesList)).BeginInit();
            this.cmsRolesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmsUsersList
            // 
            this.cmsUsersList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.cmsUsersList.Name = "contextMenuStrip1";
            this.cmsUsersList.Size = new System.Drawing.Size(159, 94);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.addNewUserToolStripMenuItem.Text = "Add New";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.editUserToolStripMenuItem.Text = "Edit";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editToolUserStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.deleteUserToolStripMenuItem.Text = "Delete";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteToolUserStripMenuItem_Click);
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 33;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDeleteRole);
            this.panel1.Controls.Add(this.btnUpdateRole);
            this.panel1.Controls.Add(this.btnAddNewRole);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToOrderColumns = true;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.cmsUsersList;
            this.dgvUsersList.Location = new System.Drawing.Point(420, 116);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.Size = new System.Drawing.Size(797, 425);
            this.dgvUsersList.TabIndex = 36;
            // 
            // dgvRolesList
            // 
            this.dgvRolesList.AllowUserToAddRows = false;
            this.dgvRolesList.AllowUserToDeleteRows = false;
            this.dgvRolesList.AllowUserToOrderColumns = true;
            this.dgvRolesList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRolesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesList.ContextMenuStrip = this.cmsRolesList;
            this.dgvRolesList.Location = new System.Drawing.Point(545, 558);
            this.dgvRolesList.Name = "dgvRolesList";
            this.dgvRolesList.ReadOnly = true;
            this.dgvRolesList.Size = new System.Drawing.Size(549, 148);
            this.dgvRolesList.TabIndex = 37;
            // 
            // cmsRolesList
            // 
            this.cmsRolesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRoleToolStripMenuItem,
            this.editRoleToolStripMenuItem,
            this.deleteRoleToolStripMenuItem});
            this.cmsRolesList.Name = "contextMenuStrip1";
            this.cmsRolesList.Size = new System.Drawing.Size(159, 94);
            // 
            // addNewRoleToolStripMenuItem
            // 
            this.addNewRoleToolStripMenuItem.Name = "addNewRoleToolStripMenuItem";
            this.addNewRoleToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.addNewRoleToolStripMenuItem.Text = "Add New";
            this.addNewRoleToolStripMenuItem.Click += new System.EventHandler(this.addNewRoleToolStripMenuItem_Click);
            // 
            // editRoleToolStripMenuItem
            // 
            this.editRoleToolStripMenuItem.Name = "editRoleToolStripMenuItem";
            this.editRoleToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.editRoleToolStripMenuItem.Text = "Edit";
            this.editRoleToolStripMenuItem.Click += new System.EventHandler(this.editRoleToolStripMenuItem_Click);
            // 
            // deleteRoleToolStripMenuItem
            // 
            this.deleteRoleToolStripMenuItem.Name = "deleteRoleToolStripMenuItem";
            this.deleteRoleToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.deleteRoleToolStripMenuItem.Text = "Delete";
            this.deleteRoleToolStripMenuItem.Click += new System.EventHandler(this.deleteRoleToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(714, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(214, 27);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbxSearchFilter
            // 
            this.cbxSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchFilter.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchFilter.FormattingEnabled = true;
            this.cbxSearchFilter.Items.AddRange(new object[] {
            "UserID",
            "PersonID",
            "Username"});
            this.cbxSearchFilter.Location = new System.Drawing.Point(529, 83);
            this.cbxSearchFilter.Name = "cbxSearchFilter";
            this.cbxSearchFilter.Size = new System.Drawing.Size(162, 23);
            this.cbxSearchFilter.TabIndex = 39;
            this.cbxSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSearchFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(416, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search By :";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteRole.CheckedState.Parent = this.btnDeleteRole;
            this.btnDeleteRole.CustomImages.Parent = this.btnDeleteRole;
            this.btnDeleteRole.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteRole.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.HoverState.Parent = this.btnDeleteRole;
            this.btnDeleteRole.Image = global::CourseCenter_Project.Properties.Resources.remove;
            this.btnDeleteRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteRole.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteRole.Location = new System.Drawing.Point(30, 625);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.ShadowDecoration.Parent = this.btnDeleteRole;
            this.btnDeleteRole.Size = new System.Drawing.Size(337, 48);
            this.btnDeleteRole.TabIndex = 16;
            this.btnDeleteRole.Text = "Delete Role";
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateRole.CheckedState.Parent = this.btnUpdateRole;
            this.btnUpdateRole.CustomImages.Parent = this.btnUpdateRole;
            this.btnUpdateRole.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateRole.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateRole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRole.HoverState.Parent = this.btnUpdateRole;
            this.btnUpdateRole.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdateRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateRole.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateRole.Location = new System.Drawing.Point(30, 558);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.ShadowDecoration.Parent = this.btnUpdateRole;
            this.btnUpdateRole.Size = new System.Drawing.Size(337, 48);
            this.btnUpdateRole.TabIndex = 15;
            this.btnUpdateRole.Text = "Update Role";
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewRole.CheckedState.Parent = this.btnAddNewRole;
            this.btnAddNewRole.CustomImages.Parent = this.btnAddNewRole;
            this.btnAddNewRole.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewRole.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewRole.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRole.HoverState.Parent = this.btnAddNewRole;
            this.btnAddNewRole.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRole.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewRole.Location = new System.Drawing.Point(30, 493);
            this.btnAddNewRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.ShadowDecoration.Parent = this.btnAddNewRole;
            this.btnAddNewRole.Size = new System.Drawing.Size(337, 48);
            this.btnAddNewRole.TabIndex = 14;
            this.btnAddNewRole.Text = "Add New Role";
            this.btnAddNewRole.Click += new System.EventHandler(this.btnAddNewRole_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteUser.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = global::CourseCenter_Project.Properties.Resources.delete;
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteUser.Location = new System.Drawing.Point(30, 425);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(337, 48);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateUser.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Image = global::CourseCenter_Project.Properties.Resources.user_profile;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateUser.Location = new System.Drawing.Point(30, 358);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(337, 48);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewUser.CheckedState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.CustomImages.Parent = this.btnAddNewUser;
            this.btnAddNewUser.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewUser.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Image = global::CourseCenter_Project.Properties.Resources.add_friend;
            this.btnAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewUser.Location = new System.Drawing.Point(30, 293);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.ShadowDecoration.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Size = new System.Drawing.Size(337, 48);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(72, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnBack.TabIndex = 34;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbxSearchFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRolesList);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTimeDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageUsers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageUsers_FormClosed);
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.cmsUsersList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesList)).EndInit();
            this.cmsRolesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsUsersList;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRole;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRole;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRole;
        private System.Windows.Forms.DataGridView dgvRolesList;
        private System.Windows.Forms.ContextMenuStrip cmsRolesList;
        private System.Windows.Forms.ToolStripMenuItem addNewRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoleToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxSearchFilter;
        private System.Windows.Forms.Label label2;
    }
}