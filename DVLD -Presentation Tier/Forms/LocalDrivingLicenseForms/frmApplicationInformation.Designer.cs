namespace DVLD__Presentation_Tier.Forms.LocalDrivingLicenseForms
{
    partial class frmApplicationInformation
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
            // frmApplicationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.ctrlLDLAwithApplicationInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApplicationInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationInformation";
            this.ResumeLayout(false);

        }

        private void InitializeComponent(int lDLAppID)
        {
            this.ctrlLDLAwithApplicationInformation1 = new DVLD__Presentation_Tier.Controls.LocalDLApplicationsControls.ctrlLDLAwithApplicationInformation(lDLAppID);
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
            // frmApplicationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.ctrlLDLAwithApplicationInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApplicationInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationInformation";
            this.ResumeLayout(false);

        }
        #endregion

        private Controls.LocalDLApplicationsControls.ctrlLDLAwithApplicationInformation ctrlLDLAwithApplicationInformation1;
    }
}