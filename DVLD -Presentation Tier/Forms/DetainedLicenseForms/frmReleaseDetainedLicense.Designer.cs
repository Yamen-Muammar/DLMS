namespace DVLD__Presentation_Tier.Forms.DetainedLicenseForms
{
    partial class frmReleaseDetainedLicense
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
            this.gbFinder = new System.Windows.Forms.GroupBox();
            this.btnFindLicense = new System.Windows.Forms.Button();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblDetaindDate = new System.Windows.Forms.Label();
            this.lblDetainedID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfo1 = new DVLD__Presentation_Tier.Controls.LicenseControls.ctrlDriverLicenseInfo();
            this.gbFinder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFinder
            // 
            this.gbFinder.Controls.Add(this.btnFindLicense);
            this.gbFinder.Controls.Add(this.tbLicenseID);
            this.gbFinder.Controls.Add(this.label2);
            this.gbFinder.Location = new System.Drawing.Point(8, 109);
            this.gbFinder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFinder.Name = "gbFinder";
            this.gbFinder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFinder.Size = new System.Drawing.Size(507, 72);
            this.gbFinder.TabIndex = 12;
            this.gbFinder.TabStop = false;
            this.gbFinder.Text = "License Finder";
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.Image = global::DVLD__Presentation_Tier.Properties.Resources.LicenseView32;
            this.btnFindLicense.Location = new System.Drawing.Point(353, 16);
            this.btnFindLicense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.Size = new System.Drawing.Size(55, 40);
            this.btnFindLicense.TabIndex = 2;
            this.btnFindLicense.UseVisualStyleBackColor = true;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenseID.Location = new System.Drawing.Point(83, 34);
            this.tbLicenseID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(211, 20);
            this.tbLicenseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID : ";
            // 
            // llblLicenseHistory
            // 
            this.llblLicenseHistory.AutoSize = true;
            this.llblLicenseHistory.Location = new System.Drawing.Point(16, 702);
            this.llblLicenseHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblLicenseHistory.Name = "llblLicenseHistory";
            this.llblLicenseHistory.Size = new System.Drawing.Size(107, 13);
            this.llblLicenseHistory.TabIndex = 17;
            this.llblLicenseHistory.TabStop = true;
            this.llblLicenseHistory.Text = "show License History";
            this.llblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(137, 702);
            this.llblShowLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(93, 13);
            this.llblShowLicenseInfo.TabIndex = 18;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(327, 691);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Image = global::DVLD__Presentation_Tier.Properties.Resources.ReleaseDetainedLicense32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(465, 691);
            this.btnRelease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(128, 35);
            this.btnRelease.TabIndex = 16;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLocalLicenseID);
            this.groupBox2.Controls.Add(this.lblFineFees);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblTotalFees);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.lblDetaindDate);
            this.groupBox2.Controls.Add(this.lblDetainedID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 503);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(585, 174);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(431, 25);
            this.lblLocalLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(31, 13);
            this.lblLocalLicenseID.TabIndex = 2;
            this.lblLocalLicenseID.Text = "????";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Location = new System.Drawing.Point(431, 92);
            this.lblFineFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(31, 13);
            this.lblFineFees.TabIndex = 2;
            this.lblFineFees.Text = "????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(431, 51);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(31, 13);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "????";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(116, 122);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(31, 13);
            this.lblTotalFees.TabIndex = 2;
            this.lblTotalFees.Text = "????";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Location = new System.Drawing.Point(116, 90);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(31, 13);
            this.lblApplicationDate.TabIndex = 2;
            this.lblApplicationDate.Text = "????";
            this.lblApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetaindDate
            // 
            this.lblDetaindDate.AutoSize = true;
            this.lblDetaindDate.Location = new System.Drawing.Point(116, 51);
            this.lblDetaindDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetaindDate.Name = "lblDetaindDate";
            this.lblDetaindDate.Size = new System.Drawing.Size(31, 13);
            this.lblDetaindDate.TabIndex = 2;
            this.lblDetaindDate.Text = "????";
            // 
            // lblDetainedID
            // 
            this.lblDetainedID.AutoSize = true;
            this.lblDetainedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainedID.Location = new System.Drawing.Point(116, 25);
            this.lblDetainedID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetainedID.Name = "lblDetainedID";
            this.lblDetainedID.Size = new System.Drawing.Size(28, 13);
            this.lblDetainedID.TabIndex = 1;
            this.lblDetainedID.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(340, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "Created By : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "License ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("72 Condensed", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Fees : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("72 Condensed", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(340, 90);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Fine Fees : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detained Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detained ID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(151, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Release Detained Licenses";
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(8, 185);
            this.ctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(585, 315);
            this.ctrlDriverLicenseInfo1.TabIndex = 13;
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(609, 746);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.llblLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.gbFinder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.gbFinder.ResumeLayout(false);
            this.gbFinder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFinder;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.Label label2;
        private Controls.LicenseControls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.LinkLabel llblLicenseHistory;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblDetaindDate;
        private System.Windows.Forms.Label lblDetainedID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}