namespace CourseCenter_Project
{
    partial class frmManagePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            this.cmsPeopleList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbDescending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAscending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbxPeopleSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAll1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdatePerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.cmsPeopleList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage People";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            this.dgvPeopleList.AllowUserToOrderColumns = true;
            this.dgvPeopleList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleList.ContextMenuStrip = this.cmsPeopleList;
            this.dgvPeopleList.Location = new System.Drawing.Point(416, 128);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.ReadOnly = true;
            this.dgvPeopleList.Size = new System.Drawing.Size(810, 578);
            this.dgvPeopleList.TabIndex = 1;
            // 
            // cmsPeopleList
            // 
            this.cmsPeopleList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsPeopleList.Name = "contextMenuStrip1";
            this.cmsPeopleList.Size = new System.Drawing.Size(159, 94);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDeletePerson);
            this.panel1.Controls.Add(this.btnShowAll1);
            this.panel1.Controls.Add(this.btnUpdatePerson);
            this.panel1.Controls.Add(this.btnAddNewPerson);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 3;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 9;
            this.lblTimeDate.Text = "TimeDate";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.txtSearch.Location = new System.Drawing.Point(902, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(241, 36);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            this.rbDescending.Location = new System.Drawing.Point(770, 99);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(103, 20);
            this.rbDescending.TabIndex = 34;
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
            this.rbAscending.Location = new System.Drawing.Point(770, 73);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(94, 20);
            this.rbAscending.TabIndex = 33;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAscending.UncheckedState.BorderThickness = 2;
            this.rbAscending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAscending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // cbxPeopleSort
            // 
            this.cbxPeopleSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeopleSort.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeopleSort.FormattingEnabled = true;
            this.cbxPeopleSort.Items.AddRange(new object[] {
            "PersonID",
            "FirstName",
            "LastName",
            "Gender",
            "DateOfBirth",
            "Email",
            "Phone",
            "Address"});
            this.cbxPeopleSort.Location = new System.Drawing.Point(587, 85);
            this.cbxPeopleSort.Name = "cbxPeopleSort";
            this.cbxPeopleSort.Size = new System.Drawing.Size(162, 23);
            this.cbxPeopleSort.TabIndex = 32;
            this.cbxPeopleSort.SelectedIndexChanged += new System.EventHandler(this.cbxPeopleSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Sorted By :";
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
            this.btnBack.TabIndex = 35;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BorderRadius = 10;
            this.btnShowAll.CheckedState.Parent = this.btnShowAll;
            this.btnShowAll.CustomImages.Parent = this.btnShowAll;
            this.btnShowAll.FillColor = System.Drawing.Color.Silver;
            this.btnShowAll.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.HoverState.Parent = this.btnShowAll;
            this.btnShowAll.Image = global::CourseCenter_Project.Properties.Resources.all;
            this.btnShowAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowAll.Location = new System.Drawing.Point(416, 76);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.ShadowDecoration.Parent = this.btnShowAll;
            this.btnShowAll.Size = new System.Drawing.Size(46, 36);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::CourseCenter_Project.Properties.Resources.loupe;
            this.btnSearch.Location = new System.Drawing.Point(1149, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(51, 36);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePerson.CheckedState.Parent = this.btnDeletePerson;
            this.btnDeletePerson.CustomImages.Parent = this.btnDeletePerson;
            this.btnDeletePerson.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletePerson.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.HoverState.Parent = this.btnDeletePerson;
            this.btnDeletePerson.Image = global::CourseCenter_Project.Properties.Resources.delete;
            this.btnDeletePerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeletePerson.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeletePerson.Location = new System.Drawing.Point(29, 589);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.ShadowDecoration.Parent = this.btnDeletePerson;
            this.btnDeletePerson.Size = new System.Drawing.Size(314, 48);
            this.btnDeletePerson.TabIndex = 6;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnShowAll1
            // 
            this.btnShowAll1.BackColor = System.Drawing.Color.Teal;
            this.btnShowAll1.CheckedState.Parent = this.btnShowAll1;
            this.btnShowAll1.CustomImages.Parent = this.btnShowAll1;
            this.btnShowAll1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowAll1.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnShowAll1.ForeColor = System.Drawing.Color.White;
            this.btnShowAll1.HoverState.Parent = this.btnShowAll1;
            this.btnShowAll1.Image = global::CourseCenter_Project.Properties.Resources.checklist1;
            this.btnShowAll1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowAll1.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowAll1.Location = new System.Drawing.Point(29, 335);
            this.btnShowAll1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll1.Name = "btnShowAll1";
            this.btnShowAll1.ShadowDecoration.Parent = this.btnShowAll1;
            this.btnShowAll1.Size = new System.Drawing.Size(314, 48);
            this.btnShowAll1.TabIndex = 5;
            this.btnShowAll1.Text = "Show All";
            this.btnShowAll1.Click += new System.EventHandler(this.btnShowAll1_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.BackColor = System.Drawing.Color.Teal;
            this.btnUpdatePerson.CheckedState.Parent = this.btnUpdatePerson;
            this.btnUpdatePerson.CustomImages.Parent = this.btnUpdatePerson;
            this.btnUpdatePerson.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdatePerson.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePerson.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePerson.HoverState.Parent = this.btnUpdatePerson;
            this.btnUpdatePerson.Image = global::CourseCenter_Project.Properties.Resources.user_profile;
            this.btnUpdatePerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdatePerson.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdatePerson.Location = new System.Drawing.Point(29, 508);
            this.btnUpdatePerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.ShadowDecoration.Parent = this.btnUpdatePerson;
            this.btnUpdatePerson.Size = new System.Drawing.Size(314, 48);
            this.btnUpdatePerson.TabIndex = 4;
            this.btnUpdatePerson.Text = "Update Person";
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewPerson.CheckedState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.CustomImages.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.HoverState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Image = global::CourseCenter_Project.Properties.Resources.add_friend;
            this.btnAddNewPerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(37, 37);
            this.btnAddNewPerson.Location = new System.Drawing.Point(29, 424);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Size = new System.Drawing.Size(314, 48);
            this.btnAddNewPerson.TabIndex = 3;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.People;
            this.pictureBox1.Location = new System.Drawing.Point(72, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbDescending);
            this.Controls.Add(this.rbAscending);
            this.Controls.Add(this.cbxPeopleSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPeopleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePeople";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManagePeople_FormClosed);
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.cmsPeopleList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dgvPeopleList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnShowAll;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePerson;
        private System.Windows.Forms.ContextMenuStrip cmsPeopleList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnShowAll1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2RadioButton rbDescending;
        private Guna.UI2.WinForms.Guna2RadioButton rbAscending;
        private System.Windows.Forms.ComboBox cbxPeopleSort;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDeletePerson;
    }
}