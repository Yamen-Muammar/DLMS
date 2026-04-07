using DVLD__Presentation_Tier.Controls.SechduleTestsControls;

namespace DVLD__Presentation_Tier.Forms.TestsAppointment
{
    partial class frmSechduleTest
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
            this.ctrlSechduleVisionTest1 = new DVLD__Presentation_Tier.Controls.SechduleTestsControls.ctrlSechduleVisionTest();
            this.SuspendLayout();
            // 
            // ctrlSechduleVisionTest1
            // 
            this.ctrlSechduleVisionTest1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSechduleVisionTest1.Name = "ctrlSechduleVisionTest1";
            this.ctrlSechduleVisionTest1.Size = new System.Drawing.Size(609, 870);
            this.ctrlSechduleVisionTest1.TabIndex = 0;
            // 
            // frmSechduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(631, 892);
            this.Controls.Add(this.ctrlSechduleVisionTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSechduleTest";
            this.Text = "frmSechduleTest";
            this.Load += new System.EventHandler(this.frmSechduleTest_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private ctrlSechduleVisionTest ctrlSechduleVisionTest1;
    }
}