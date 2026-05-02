namespace DVLD__Presentation_Tier.Forms.DetainedLicenseForms
{
    partial class frmManageDeainedLicense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.relaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilterOn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbFilterInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewLDApplication = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.dgvDetainedLicense = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(141, 983);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(24, 25);
            this.lblRecordsCount.TabIndex = 21;
            this.lblRecordsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 980);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "# Records :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.relaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(288, 74);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showLicenseDataToolStripMenuItem
            // 
            this.showLicenseDataToolStripMenuItem.Image = global::DVLD__Presentation_Tier.Properties.Resources.DriverLicense48;
            this.showLicenseDataToolStripMenuItem.Name = "showLicenseDataToolStripMenuItem";
            this.showLicenseDataToolStripMenuItem.Size = new System.Drawing.Size(287, 32);
            this.showLicenseDataToolStripMenuItem.Text = "Show License Data";
            this.showLicenseDataToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // relaseLicenseToolStripMenuItem
            // 
            this.relaseLicenseToolStripMenuItem.Image = global::DVLD__Presentation_Tier.Properties.Resources.ReleaseDetainedLicense32;
            this.relaseLicenseToolStripMenuItem.Name = "relaseLicenseToolStripMenuItem";
            this.relaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(287, 32);
            this.relaseLicenseToolStripMenuItem.Text = "Release Detained License";
            this.relaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(649, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD__Presentation_Tier.Properties.Resources.Detain64;
            this.pictureBox1.Location = new System.Drawing.Point(775, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // cbFilterOn
            // 
            this.cbFilterOn.AutoRoundedCorners = true;
            this.cbFilterOn.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterOn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterOn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterOn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterOn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterOn.ItemHeight = 30;
            this.cbFilterOn.Location = new System.Drawing.Point(137, 246);
            this.cbFilterOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilterOn.Name = "cbFilterOn";
            this.cbFilterOn.Size = new System.Drawing.Size(373, 36);
            this.cbFilterOn.TabIndex = 31;
            // 
            // tbFilterInput
            // 
            this.tbFilterInput.AutoRoundedCorners = true;
            this.tbFilterInput.BorderRadius = 26;
            this.tbFilterInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilterInput.DefaultText = "";
            this.tbFilterInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilterInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilterInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFilterInput.ForeColor = System.Drawing.Color.Black;
            this.tbFilterInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterInput.Location = new System.Drawing.Point(536, 237);
            this.tbFilterInput.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbFilterInput.Name = "tbFilterInput";
            this.tbFilterInput.PlaceholderText = "serach";
            this.tbFilterInput.SelectedText = "";
            this.tbFilterInput.Size = new System.Drawing.Size(356, 55);
            this.tbFilterInput.TabIndex = 30;
            this.tbFilterInput.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddNewLDApplication
            // 
            this.btnAddNewLDApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewLDApplication.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAddNewLDApplication.BorderThickness = 1;
            this.btnAddNewLDApplication.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLDApplication.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLDApplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewLDApplication.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewLDApplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewLDApplication.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewLDApplication.FillColor2 = System.Drawing.Color.SteelBlue;
            this.btnAddNewLDApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewLDApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLDApplication.Image = global::DVLD__Presentation_Tier.Properties.Resources.NewApplication64;
            this.btnAddNewLDApplication.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewLDApplication.Location = new System.Drawing.Point(1442, 204);
            this.btnAddNewLDApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewLDApplication.Name = "btnAddNewLDApplication";
            this.btnAddNewLDApplication.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewLDApplication.Size = new System.Drawing.Size(108, 106);
            this.btnAddNewLDApplication.TabIndex = 29;
            this.btnAddNewLDApplication.UseTransparentBackground = true;
            this.btnAddNewLDApplication.Click += new System.EventHandler(this.btnAddDeateinLicense_Click);
            // 
            // dgvDetainedLicense
            // 
            this.dgvDetainedLicense.AllowUserToAddRows = false;
            this.dgvDetainedLicense.AllowUserToDeleteRows = false;
            this.dgvDetainedLicense.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetainedLicense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicense.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicense.ColumnHeadersHeight = 71;
            this.dgvDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetainedLicense.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicense.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicense.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicense.Location = new System.Drawing.Point(18, 318);
            this.dgvDetainedLicense.Name = "dgvDetainedLicense";
            this.dgvDetainedLicense.ReadOnly = true;
            this.dgvDetainedLicense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetainedLicense.RowHeadersVisible = false;
            this.dgvDetainedLicense.RowHeadersWidth = 62;
            this.dgvDetainedLicense.RowTemplate.Height = 44;
            this.dgvDetainedLicense.Size = new System.Drawing.Size(1557, 649);
            this.dgvDetainedLicense.TabIndex = 28;
            this.dgvDetainedLicense.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicense.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetainedLicense.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetainedLicense.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicense.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetainedLicense.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.dgvDetainedLicense.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetainedLicense.ThemeStyle.HeaderStyle.Height = 71;
            this.dgvDetainedLicense.ThemeStyle.ReadOnly = true;
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.Height = 44;
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicense.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Filter By :";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvDetainedLicense;
            // 
            // frmManageDeainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1607, 1025);
            this.Controls.Add(this.cbFilterOn);
            this.Controls.Add(this.tbFilterInput);
            this.Controls.Add(this.btnAddNewLDApplication);
            this.Controls.Add(this.dgvDetainedLicense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDeainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDeainedLicense";
            this.Load += new System.EventHandler(this.frmManageDeainedLicense_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem relaseLicenseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterOn;
        private Guna.UI2.WinForms.Guna2TextBox tbFilterInput;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddNewLDApplication;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainedLicense;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}