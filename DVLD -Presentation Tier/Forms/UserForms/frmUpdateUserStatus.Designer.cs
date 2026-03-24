namespace DVLD__Presentation_Tier.Forms.UserForms
{
    partial class frmUpdateUserStatus
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
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("72 Monospace", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(181, 126);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(142, 35);
            this.cbIsActive.TabIndex = 0;
            this.cbIsActive.Text = "Active";
            this.cbIsActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Monospace", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("72 Monospace", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(223, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "????";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("72 Monospace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update User Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("72 Monospace", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(145, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateUserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 257);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIsActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateUserStatus";
            this.Text = "frmUpdateUserStatus";
            this.Load += new System.EventHandler(this.frmUpdateUserStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}