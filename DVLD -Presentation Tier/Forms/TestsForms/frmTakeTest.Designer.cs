using System;

namespace DVLD__Presentation_Tier.Forms.TestsForms
{
    partial class frmTakeTest
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
            this.ctrlSechduleVisionTestInfo1 = new DVLD__Presentation_Tier.Controls.SechduleTestsControls.ctrlSechduleVisionTestInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.RadioButton();
            this.btnFail = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSechduleVisionTestInfo1
            // 
            this.ctrlSechduleVisionTestInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSechduleVisionTestInfo1.Name = "ctrlSechduleVisionTestInfo1";
            this.ctrlSechduleVisionTestInfo1.Size = new System.Drawing.Size(602, 596);
            this.ctrlSechduleVisionTestInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test ID :";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("72 Monospace", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.Location = new System.Drawing.Point(108, 629);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(53, 20);
            this.lblTestID.TabIndex = 2;
            this.lblTestID.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result :";
            // 
            // btnPass
            // 
            this.btnPass.AutoSize = true;
            this.btnPass.Location = new System.Drawing.Point(100, 674);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(69, 24);
            this.btnPass.TabIndex = 1;
            this.btnPass.TabStop = true;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            // 
            // btnFail
            // 
            this.btnFail.AutoSize = true;
            this.btnFail.Location = new System.Drawing.Point(175, 672);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(59, 24);
            this.btnFail.TabIndex = 2;
            this.btnFail.TabStop = true;
            this.btnFail.Text = "Fail";
            this.btnFail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Note :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(100, 721);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 94);
            this.textBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(485, 821);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(354, 821);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 884);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSechduleVisionTestInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent(int LDLAppID, string licenseClassName, int tril, string applicantName, DateTime date, decimal fees)
        {
            this.ctrlSechduleVisionTestInfo1 = new DVLD__Presentation_Tier.Controls.SechduleTestsControls.ctrlSechduleVisionTestInfo(LDLAppID, licenseClassName, tril, applicantName, date, fees);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.RadioButton();
            this.btnFail = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSechduleVisionTestInfo1
            // 
            this.ctrlSechduleVisionTestInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSechduleVisionTestInfo1.Name = "ctrlSechduleVisionTestInfo1";
            this.ctrlSechduleVisionTestInfo1.Size = new System.Drawing.Size(602, 596);
            this.ctrlSechduleVisionTestInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test ID :";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("72 Monospace", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.Location = new System.Drawing.Point(108, 629);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(53, 20);
            this.lblTestID.TabIndex = 2;
            this.lblTestID.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result :";
            // 
            // btnPass
            // 
            this.btnPass.AutoSize = true;
            this.btnPass.Location = new System.Drawing.Point(100, 674);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(69, 24);
            this.btnPass.TabIndex = 1;
            this.btnPass.TabStop = true;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            // 
            // btnFail
            // 
            this.btnFail.AutoSize = true;
            this.btnFail.Location = new System.Drawing.Point(175, 672);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(59, 24);
            this.btnFail.TabIndex = 2;
            this.btnFail.TabStop = true;
            this.btnFail.Text = "Fail";
            this.btnFail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Note :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(100, 721);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 94);
            this.textBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(485, 821);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD__Presentation_Tier.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(354, 821);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 884);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSechduleVisionTestInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SechduleTestsControls.ctrlSechduleVisionTestInfo ctrlSechduleVisionTestInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnPass;
        private System.Windows.Forms.RadioButton btnFail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}