namespace DVLD__Presentation_Tier.Forms.UserForms
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
            this.ctrlUsersList1 = new DVLD__Presentation_Tier.Controls.UserControls.ctrlUsersList();
            this.SuspendLayout();
            // 
            // ctrlUsersList1
            // 
            this.ctrlUsersList1.Location = new System.Drawing.Point(12, -1);
            this.ctrlUsersList1.Name = "ctrlUsersList1";
            this.ctrlUsersList1.Size = new System.Drawing.Size(1554, 983);
            this.ctrlUsersList1.TabIndex = 0;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1567, 983);
            this.Controls.Add(this.ctrlUsersList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD__Presentation_Tier.Controls.UserControls.ctrlUsersList ctrlUsersList1;
    }
}