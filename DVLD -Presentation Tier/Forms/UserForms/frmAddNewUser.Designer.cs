namespace DVLD__Presentation_Tier.Forms.UserForms
{
    partial class frmAddNewUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonInformationWithFilter1 = new DVLD__Presentation_Tier.Controls.ctrlPersonInformationWithFilter();
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbNewID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfo);
            this.tabControl1.Controls.Add(this.LoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(8, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 383);
            this.tabControl1.TabIndex = 1;
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.btnNext);
            this.PersonInfo.Controls.Add(this.ctrlPersonInformationWithFilter1);
            this.PersonInfo.Location = new System.Drawing.Point(4, 22);
            this.PersonInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonInfo.Size = new System.Drawing.Size(634, 357);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person Info";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLD__Presentation_Tier.Properties.Resources.Next32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(508, 300);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInformationWithFilter1
            // 
            this.ctrlPersonInformationWithFilter1.Location = new System.Drawing.Point(4, 4);
            this.ctrlPersonInformationWithFilter1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ctrlPersonInformationWithFilter1.Name = "ctrlPersonInformationWithFilter1";
            this.ctrlPersonInformationWithFilter1.Size = new System.Drawing.Size(629, 292);
            this.ctrlPersonInformationWithFilter1.TabIndex = 0;
            this.ctrlPersonInformationWithFilter1.ReturnPersonID_OnFindPerson += new DVLD__Presentation_Tier.Controls.ctrlPersonInformationWithFilter.ReturnPersonIDEvent(this.ctrlPersonInformationWithFilter1_ReturnPersonID_OnFindPerson);
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.cbIsActive);
            this.LoginInfo.Controls.Add(this.tbConfirmPassword);
            this.LoginInfo.Controls.Add(this.tbPassword);
            this.LoginInfo.Controls.Add(this.tbUsername);
            this.LoginInfo.Controls.Add(this.lbNewID);
            this.LoginInfo.Controls.Add(this.label4);
            this.LoginInfo.Controls.Add(this.label3);
            this.LoginInfo.Controls.Add(this.label2);
            this.LoginInfo.Controls.Add(this.label1);
            this.LoginInfo.Location = new System.Drawing.Point(4, 22);
            this.LoginInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginInfo.Size = new System.Drawing.Size(634, 357);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "Login Info";
            this.LoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Checked = true;
            this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsActive.Location = new System.Drawing.Point(185, 177);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(63, 17);
            this.cbIsActive.TabIndex = 4;
            this.cbIsActive.Text = "isActive";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(184, 140);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(167, 20);
            this.tbConfirmPassword.TabIndex = 3;
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbConfirmPassword_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(185, 111);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(167, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(185, 81);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(167, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lbNewID
            // 
            this.lbNewID.AutoSize = true;
            this.lbNewID.Font = new System.Drawing.Font("Simplified Arabic Fixed", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewID.ForeColor = System.Drawing.Color.Red;
            this.lbNewID.Location = new System.Drawing.Point(213, 55);
            this.lbNewID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewID.Name = "lbNewID";
            this.lbNewID.Size = new System.Drawing.Size(40, 17);
            this.lbNewID.TabIndex = 0;
            this.lbNewID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD__Presentation_Tier.Properties.Resources.Save32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(549, 431);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(453, 431);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(230, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 45);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Add New User";
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 468);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.tabControl1.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPersonInformationWithFilter ctrlPersonInformationWithFilter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage LoginInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNewID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblTitle;
    }
}