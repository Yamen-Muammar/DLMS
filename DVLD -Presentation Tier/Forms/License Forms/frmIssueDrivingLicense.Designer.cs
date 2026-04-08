namespace DVLD__Presentation_Tier.Forms.License_Forms
{
    partial class frmIssueDrivingLicense
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
            this.ctrlLDLAwithApplicationInformation1 = new DVLD__Presentation_Tier.Controls.LocalDLApplicationsControls.ctrlLDLAwithApplicationInformation();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnIsuue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLDLAwithApplicationInformation1
            // 
            this.ctrlLDLAwithApplicationInformation1.ApplicatFullName = null;
            this.ctrlLDLAwithApplicationInformation1.licenseClassName = null;
            this.ctrlLDLAwithApplicationInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLDLAwithApplicationInformation1.Name = "ctrlLDLAwithApplicationInformation1";
            this.ctrlLDLAwithApplicationInformation1.Size = new System.Drawing.Size(826, 595);
            this.ctrlLDLAwithApplicationInformation1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes :";
            // 
            // tbNotes
            // 
            this.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotes.Location = new System.Drawing.Point(80, 613);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(755, 115);
            this.tbNotes.TabIndex = 2;
            // 
            // btnIsuue
            // 
            this.btnIsuue.Image = global::DVLD__Presentation_Tier.Properties.Resources.IssueDrivingLicense32;
            this.btnIsuue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIsuue.Location = new System.Drawing.Point(646, 748);
            this.btnIsuue.Name = "btnIsuue";
            this.btnIsuue.Size = new System.Drawing.Size(189, 42);
            this.btnIsuue.TabIndex = 3;
            this.btnIsuue.Text = "Isuue";
            this.btnIsuue.UseVisualStyleBackColor = true;
            this.btnIsuue.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(442, 748);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 802);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIsuue);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLDLAwithApplicationInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent(int ldlAppID)
        {
            this.ctrlLDLAwithApplicationInformation1 = new DVLD__Presentation_Tier.Controls.LocalDLApplicationsControls.ctrlLDLAwithApplicationInformation(ldlAppID);
            this.label1 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnIsuue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLDLAwithApplicationInformation1
            // 
            this.ctrlLDLAwithApplicationInformation1.ApplicatFullName = null;
            this.ctrlLDLAwithApplicationInformation1.licenseClassName = null;
            this.ctrlLDLAwithApplicationInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLDLAwithApplicationInformation1.Name = "ctrlLDLAwithApplicationInformation1";
            this.ctrlLDLAwithApplicationInformation1.Size = new System.Drawing.Size(826, 595);
            this.ctrlLDLAwithApplicationInformation1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes :";
            // 
            // tbNotes
            // 
            this.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotes.Location = new System.Drawing.Point(80, 613);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(755, 115);
            this.tbNotes.TabIndex = 2;
            // 
            // btnIsuue
            // 
            this.btnIsuue.Image = global::DVLD__Presentation_Tier.Properties.Resources.IssueDrivingLicense32;
            this.btnIsuue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIsuue.Location = new System.Drawing.Point(646, 748);
            this.btnIsuue.Name = "btnIsuue";
            this.btnIsuue.Size = new System.Drawing.Size(189, 42);
            this.btnIsuue.TabIndex = 3;
            this.btnIsuue.Text = "Isuue";
            this.btnIsuue.UseVisualStyleBackColor = true;
            this.btnIsuue.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(442, 748);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 802);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIsuue);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLDLAwithApplicationInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LocalDLApplicationsControls.ctrlLDLAwithApplicationInformation ctrlLDLAwithApplicationInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnIsuue;
        private System.Windows.Forms.Button btnClose;
    }
}