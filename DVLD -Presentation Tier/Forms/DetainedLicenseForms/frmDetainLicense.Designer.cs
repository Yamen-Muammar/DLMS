namespace DVLD__Presentation_Tier.Forms.DetainedLicenseForms
{
    partial class frmDetainLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindLicense = new System.Windows.Forms.Button();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfo1 = new DVLD__Presentation_Tier.Controls.LicenseControls.ctrlDriverLicenseInfo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetaindDate = new System.Windows.Forms.Label();
            this.lbDetainedID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindLicense);
            this.groupBox1.Controls.Add(this.tbLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 111);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License Finder";
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.Image = global::DVLD__Presentation_Tier.Properties.Resources.LicenseView32;
            this.btnFindLicense.Location = new System.Drawing.Point(529, 25);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.Size = new System.Drawing.Size(83, 61);
            this.btnFindLicense.TabIndex = 2;
            this.btnFindLicense.UseVisualStyleBackColor = true;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenseID.Location = new System.Drawing.Point(125, 52);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(315, 26);
            this.tbLicenseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID : ";
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(12, 158);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(877, 484);
            this.ctrlDriverLicenseInfo1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFineFees);
            this.groupBox2.Controls.Add(this.lblLocalLicenseID);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblDetaindDate);
            this.groupBox2.Controls.Add(this.lbDetainedID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 639);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 171);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFineFees.Location = new System.Drawing.Point(178, 120);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(513, 26);
            this.tbFineFees.TabIndex = 3;
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(646, 39);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(45, 20);
            this.lblLocalLicenseID.TabIndex = 2;
            this.lblLocalLicenseID.Text = "????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(646, 79);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(45, 20);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "????";
            // 
            // lblDetaindDate
            // 
            this.lblDetaindDate.AutoSize = true;
            this.lblDetaindDate.Location = new System.Drawing.Point(174, 78);
            this.lblDetaindDate.Name = "lblDetaindDate";
            this.lblDetaindDate.Size = new System.Drawing.Size(45, 20);
            this.lblDetaindDate.TabIndex = 2;
            this.lblDetaindDate.Text = "????";
            // 
            // lbDetainedID
            // 
            this.lbDetainedID.AutoSize = true;
            this.lbDetainedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedID.Location = new System.Drawing.Point(174, 38);
            this.lbDetainedID.Name = "lbDetainedID";
            this.lbDetainedID.Size = new System.Drawing.Size(39, 20);
            this.lbDetainedID.TabIndex = 1;
            this.lbDetainedID.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(510, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Created By : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "License ID : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("72 Condensed", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(44, 120);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(98, 23);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Fine Fees : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detained Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detained ID : ";
            // 
            // llblLicenseHistory
            // 
            this.llblLicenseHistory.AutoSize = true;
            this.llblLicenseHistory.Location = new System.Drawing.Point(23, 846);
            this.llblLicenseHistory.Name = "llblLicenseHistory";
            this.llblLicenseHistory.Size = new System.Drawing.Size(158, 20);
            this.llblLicenseHistory.TabIndex = 16;
            this.llblLicenseHistory.TabStop = true;
            this.llblLicenseHistory.Text = "show License History";
            this.llblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(205, 846);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(137, 20);
            this.llblShowLicenseInfo.TabIndex = 17;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(489, 829);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 54);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Enabled = false;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicense.Image = global::DVLD__Presentation_Tier.Properties.Resources.Detain64;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(696, 829);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(192, 54);
            this.btnDetainLicense.TabIndex = 15;
            this.btnDetainLicense.Text = "Detain";
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 894);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.llblLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.Label label2;
        private Controls.LicenseControls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetaindDate;
        private System.Windows.Forms.Label lbDetainedID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llblLicenseHistory;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetainLicense;
    }
}