namespace DVLD__Presentation_Tier.Forms
{
    partial class frmInternationalLicenseApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblILicExpiration = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblIsuueDate = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblILicID = new System.Windows.Forms.Label();
            this.lblILAppID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfo1 = new DVLD__Presentation_Tier.Controls.LicenseControls.ctrlDriverLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Monospace", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "International License Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License Finder";
            // 
            // button1
            // 
            this.button1.Image = global::DVLD__Presentation_Tier.Properties.Resources.LicenseView32;
            this.button1.Location = new System.Drawing.Point(353, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLocalLicenseID);
            this.groupBox2.Controls.Add(this.lblILicExpiration);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblAppFees);
            this.groupBox2.Controls.Add(this.lblIsuueDate);
            this.groupBox2.Controls.Add(this.lblAppDate);
            this.groupBox2.Controls.Add(this.lblILicID);
            this.groupBox2.Controls.Add(this.lblILAppID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 443);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(585, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(431, 52);
            this.lblLocalLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(31, 13);
            this.lblLocalLicenseID.TabIndex = 2;
            this.lblLocalLicenseID.Text = "????";
            // 
            // lblILicExpiration
            // 
            this.lblILicExpiration.AutoSize = true;
            this.lblILicExpiration.Location = new System.Drawing.Point(431, 79);
            this.lblILicExpiration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblILicExpiration.Name = "lblILicExpiration";
            this.lblILicExpiration.Size = new System.Drawing.Size(31, 13);
            this.lblILicExpiration.TabIndex = 2;
            this.lblILicExpiration.Text = "????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(431, 107);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(31, 13);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "????";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Location = new System.Drawing.Point(125, 105);
            this.lblAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(31, 13);
            this.lblAppFees.TabIndex = 2;
            this.lblAppFees.Text = "????";
            // 
            // lblIsuueDate
            // 
            this.lblIsuueDate.AutoSize = true;
            this.lblIsuueDate.Location = new System.Drawing.Point(125, 78);
            this.lblIsuueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsuueDate.Name = "lblIsuueDate";
            this.lblIsuueDate.Size = new System.Drawing.Size(31, 13);
            this.lblIsuueDate.TabIndex = 2;
            this.lblIsuueDate.Text = "????";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Location = new System.Drawing.Point(125, 51);
            this.lblAppDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(31, 13);
            this.lblAppDate.TabIndex = 2;
            this.lblAppDate.Text = "????";
            // 
            // lblILicID
            // 
            this.lblILicID.AutoSize = true;
            this.lblILicID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILicID.Location = new System.Drawing.Point(431, 25);
            this.lblILicID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblILicID.Name = "lblILicID";
            this.lblILicID.Size = new System.Drawing.Size(28, 13);
            this.lblILicID.TabIndex = 1;
            this.lblILicID.Text = "???";
            // 
            // lblILAppID
            // 
            this.lblILAppID.AutoSize = true;
            this.lblILAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblILAppID.Location = new System.Drawing.Point(125, 25);
            this.lblILAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblILAppID.Name = "lblILAppID";
            this.lblILAppID.Size = new System.Drawing.Size(28, 13);
            this.lblILAppID.TabIndex = 1;
            this.lblILAppID.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(343, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "Created By : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "I.License ID : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "I.L.Expiration Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Local License ID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fees : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Issue Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Application Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("72 Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "I.L.Application ID : ";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD__Presentation_Tier.Properties.Resources.International32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(461, 613);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ISSUE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(323, 613);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(133, 624);
            this.llblShowLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(93, 13);
            this.llblShowLicenseInfo.TabIndex = 4;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llblLicenseHistory
            // 
            this.llblLicenseHistory.AutoSize = true;
            this.llblLicenseHistory.Location = new System.Drawing.Point(12, 624);
            this.llblLicenseHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblLicenseHistory.Name = "llblLicenseHistory";
            this.llblLicenseHistory.Size = new System.Drawing.Size(107, 13);
            this.llblLicenseHistory.TabIndex = 4;
            this.llblLicenseHistory.TabStop = true;
            this.llblLicenseHistory.Text = "show License History";
            this.llblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(8, 124);
            this.ctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(585, 315);
            this.ctrlDriverLicenseInfo1.TabIndex = 2;
            // 
            // frmInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 656);
            this.Controls.Add(this.llblLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInternationalLicenseApplication";
            this.Load += new System.EventHandler(this.frmInternationalLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Controls.LicenseControls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llblLicenseHistory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIsuueDate;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblILicID;
        private System.Windows.Forms.Label lblILAppID;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label lblILicExpiration;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFees;
    }
}