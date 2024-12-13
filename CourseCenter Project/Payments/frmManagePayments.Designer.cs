namespace CourseCenter_Project
{
    partial class frmManagePayments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePaymentMethod = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdatePaymentMethod = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPaymentMethod = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaymentPortal = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPaymentsList = new System.Windows.Forms.DataGridView();
            this.cmsPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxSearchFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPaymentMethodsList = new System.Windows.Forms.DataGridView();
            this.cmsPaymentMethods = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPaymentsAmount = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsList)).BeginInit();
            this.cmsPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethodsList)).BeginInit();
            this.cmsPaymentMethods.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDeletePaymentMethod);
            this.panel1.Controls.Add(this.btnUpdatePaymentMethod);
            this.panel1.Controls.Add(this.btnAddNewPaymentMethod);
            this.panel1.Controls.Add(this.btnPaymentPortal);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 718);
            this.panel1.TabIndex = 8;
            // 
            // btnDeletePaymentMethod
            // 
            this.btnDeletePaymentMethod.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePaymentMethod.CheckedState.Parent = this.btnDeletePaymentMethod;
            this.btnDeletePaymentMethod.CustomImages.Parent = this.btnDeletePaymentMethod;
            this.btnDeletePaymentMethod.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletePaymentMethod.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnDeletePaymentMethod.HoverState.Parent = this.btnDeletePaymentMethod;
            this.btnDeletePaymentMethod.Image = global::CourseCenter_Project.Properties.Resources.remove;
            this.btnDeletePaymentMethod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeletePaymentMethod.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeletePaymentMethod.Location = new System.Drawing.Point(37, 573);
            this.btnDeletePaymentMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePaymentMethod.Name = "btnDeletePaymentMethod";
            this.btnDeletePaymentMethod.ShadowDecoration.Parent = this.btnDeletePaymentMethod;
            this.btnDeletePaymentMethod.Size = new System.Drawing.Size(314, 48);
            this.btnDeletePaymentMethod.TabIndex = 17;
            this.btnDeletePaymentMethod.Text = "Delete Payment Method";
            this.btnDeletePaymentMethod.Click += new System.EventHandler(this.btnDeletePaymentMethod_Click);
            // 
            // btnUpdatePaymentMethod
            // 
            this.btnUpdatePaymentMethod.BackColor = System.Drawing.Color.Teal;
            this.btnUpdatePaymentMethod.CheckedState.Parent = this.btnUpdatePaymentMethod;
            this.btnUpdatePaymentMethod.CustomImages.Parent = this.btnUpdatePaymentMethod;
            this.btnUpdatePaymentMethod.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdatePaymentMethod.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePaymentMethod.HoverState.Parent = this.btnUpdatePaymentMethod;
            this.btnUpdatePaymentMethod.Image = global::CourseCenter_Project.Properties.Resources.update;
            this.btnUpdatePaymentMethod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdatePaymentMethod.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUpdatePaymentMethod.Location = new System.Drawing.Point(37, 496);
            this.btnUpdatePaymentMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePaymentMethod.Name = "btnUpdatePaymentMethod";
            this.btnUpdatePaymentMethod.ShadowDecoration.Parent = this.btnUpdatePaymentMethod;
            this.btnUpdatePaymentMethod.Size = new System.Drawing.Size(314, 48);
            this.btnUpdatePaymentMethod.TabIndex = 16;
            this.btnUpdatePaymentMethod.Text = "Update Payment Method";
            this.btnUpdatePaymentMethod.Click += new System.EventHandler(this.btnUpdatePaymentMethod_Click);
            // 
            // btnAddNewPaymentMethod
            // 
            this.btnAddNewPaymentMethod.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewPaymentMethod.CheckedState.Parent = this.btnAddNewPaymentMethod;
            this.btnAddNewPaymentMethod.CustomImages.Parent = this.btnAddNewPaymentMethod;
            this.btnAddNewPaymentMethod.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewPaymentMethod.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPaymentMethod.HoverState.Parent = this.btnAddNewPaymentMethod;
            this.btnAddNewPaymentMethod.Image = global::CourseCenter_Project.Properties.Resources.plus;
            this.btnAddNewPaymentMethod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewPaymentMethod.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewPaymentMethod.Location = new System.Drawing.Point(37, 419);
            this.btnAddNewPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewPaymentMethod.Name = "btnAddNewPaymentMethod";
            this.btnAddNewPaymentMethod.ShadowDecoration.Parent = this.btnAddNewPaymentMethod;
            this.btnAddNewPaymentMethod.Size = new System.Drawing.Size(314, 48);
            this.btnAddNewPaymentMethod.TabIndex = 15;
            this.btnAddNewPaymentMethod.Text = "  Add New Payment Method";
            this.btnAddNewPaymentMethod.Click += new System.EventHandler(this.btnAddNewPaymentMethod_Click);
            // 
            // btnPaymentPortal
            // 
            this.btnPaymentPortal.BackColor = System.Drawing.Color.Teal;
            this.btnPaymentPortal.CheckedState.Parent = this.btnPaymentPortal;
            this.btnPaymentPortal.CustomImages.Parent = this.btnPaymentPortal;
            this.btnPaymentPortal.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnPaymentPortal.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentPortal.ForeColor = System.Drawing.Color.White;
            this.btnPaymentPortal.HoverState.Parent = this.btnPaymentPortal;
            this.btnPaymentPortal.Image = global::CourseCenter_Project.Properties.Resources.credit_card;
            this.btnPaymentPortal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPaymentPortal.ImageSize = new System.Drawing.Size(38, 38);
            this.btnPaymentPortal.Location = new System.Drawing.Point(37, 341);
            this.btnPaymentPortal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPaymentPortal.Name = "btnPaymentPortal";
            this.btnPaymentPortal.ShadowDecoration.Parent = this.btnPaymentPortal;
            this.btnPaymentPortal.Size = new System.Drawing.Size(314, 48);
            this.btnPaymentPortal.TabIndex = 14;
            this.btnPaymentPortal.Text = "Pay Portal";
            this.btnPaymentPortal.Click += new System.EventHandler(this.btnPaymentPortal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseCenter_Project.Properties.Resources.wallet;
            this.pictureBox1.Location = new System.Drawing.Point(78, 21);
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
            this.label1.Location = new System.Drawing.Point(39, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Payments";
            // 
            // dgvPaymentsList
            // 
            this.dgvPaymentsList.AllowUserToAddRows = false;
            this.dgvPaymentsList.AllowUserToDeleteRows = false;
            this.dgvPaymentsList.AllowUserToOrderColumns = true;
            this.dgvPaymentsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPaymentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentsList.ContextMenuStrip = this.cmsPayments;
            this.dgvPaymentsList.Location = new System.Drawing.Point(408, 101);
            this.dgvPaymentsList.Name = "dgvPaymentsList";
            this.dgvPaymentsList.ReadOnly = true;
            this.dgvPaymentsList.Size = new System.Drawing.Size(820, 431);
            this.dgvPaymentsList.TabIndex = 16;
            // 
            // cmsPayments
            // 
            this.cmsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem});
            this.cmsPayments.Name = "cmsPayments";
            this.cmsPayments.Size = new System.Drawing.Size(112, 34);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.Location = new System.Drawing.Point(951, 19);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(115, 23);
            this.lblTimeDate.TabIndex = 32;
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
            this.txtSearch.Location = new System.Drawing.Point(717, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(214, 27);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbxSearchFilter
            // 
            this.cbxSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchFilter.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchFilter.FormattingEnabled = true;
            this.cbxSearchFilter.Items.AddRange(new object[] {
            "PaymentID",
            "StudentID",
            "EnrollmentID"});
            this.cbxSearchFilter.Location = new System.Drawing.Point(532, 71);
            this.cbxSearchFilter.Name = "cbxSearchFilter";
            this.cbxSearchFilter.Size = new System.Drawing.Size(162, 23);
            this.cbxSearchFilter.TabIndex = 36;
            this.cbxSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSearchFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(419, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search By :";
            // 
            // dgvPaymentMethodsList
            // 
            this.dgvPaymentMethodsList.AllowUserToAddRows = false;
            this.dgvPaymentMethodsList.AllowUserToDeleteRows = false;
            this.dgvPaymentMethodsList.AllowUserToOrderColumns = true;
            this.dgvPaymentMethodsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPaymentMethodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentMethodsList.ContextMenuStrip = this.cmsPaymentMethods;
            this.dgvPaymentMethodsList.Location = new System.Drawing.Point(408, 538);
            this.dgvPaymentMethodsList.Name = "dgvPaymentMethodsList";
            this.dgvPaymentMethodsList.ReadOnly = true;
            this.dgvPaymentMethodsList.Size = new System.Drawing.Size(459, 168);
            this.dgvPaymentMethodsList.TabIndex = 38;
            // 
            // cmsPaymentMethods
            // 
            this.cmsPaymentMethods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsPaymentMethods.Name = "cmsPaymentsList";
            this.cmsPaymentMethods.Size = new System.Drawing.Size(164, 94);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.addNewToolStripMenuItem.Text = " Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTotalPaymentsAmount);
            this.panel2.Location = new System.Drawing.Point(894, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 168);
            this.panel2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Total Payments Amount :";
            // 
            // lblTotalPaymentsAmount
            // 
            this.lblTotalPaymentsAmount.AutoSize = true;
            this.lblTotalPaymentsAmount.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentsAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalPaymentsAmount.Location = new System.Drawing.Point(120, 93);
            this.lblTotalPaymentsAmount.Name = "lblTotalPaymentsAmount";
            this.lblTotalPaymentsAmount.Size = new System.Drawing.Size(31, 31);
            this.lblTotalPaymentsAmount.TabIndex = 37;
            this.lblTotalPaymentsAmount.Text = "0";
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
            this.btnBack.TabIndex = 33;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPaymentMethodsList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbxSearchFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.dgvPaymentsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePayments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManagePayments_FormClosed);
            this.Load += new System.EventHandler(this.frmManagePayments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsList)).EndInit();
            this.cmsPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethodsList)).EndInit();
            this.cmsPaymentMethods.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPaymentsList;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPaymentMethod;
        private Guna.UI2.WinForms.Guna2Button btnPaymentPortal;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxSearchFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPaymentMethodsList;
        private System.Windows.Forms.ContextMenuStrip cmsPaymentMethods;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPayments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPaymentsAmount;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePaymentMethod;
        private Guna.UI2.WinForms.Guna2Button btnDeletePaymentMethod;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
    }
}