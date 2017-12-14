namespace TimeTrackingRecord
{
    partial class FrmConfig
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
            this.txtSalaryMonth = new System.Windows.Forms.TextBox();
            this.txtSalaryHour = new System.Windows.Forms.TextBox();
            this.chkAutomatic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalaryMonth
            // 
            this.txtSalaryMonth.Location = new System.Drawing.Point(21, 34);
            this.txtSalaryMonth.Name = "txtSalaryMonth";
            this.txtSalaryMonth.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryMonth.TabIndex = 0;
            // 
            // txtSalaryHour
            // 
            this.txtSalaryHour.Location = new System.Drawing.Point(21, 94);
            this.txtSalaryHour.Name = "txtSalaryHour";
            this.txtSalaryHour.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryHour.TabIndex = 1;
            // 
            // chkAutomatic
            // 
            this.chkAutomatic.AutoSize = true;
            this.chkAutomatic.Checked = true;
            this.chkAutomatic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomatic.Location = new System.Drawing.Point(105, 64);
            this.chkAutomatic.Name = "chkAutomatic";
            this.chkAutomatic.Size = new System.Drawing.Size(127, 17);
            this.chkAutomatic.TabIndex = 2;
            this.chkAutomatic.Text = "Automatic calculation";
            this.chkAutomatic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salary per month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salary per hour:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(21, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(139, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 174);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAutomatic);
            this.Controls.Add(this.txtSalaryHour);
            this.Controls.Add(this.txtSalaryMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalaryMonth;
        private System.Windows.Forms.TextBox txtSalaryHour;
        private System.Windows.Forms.CheckBox chkAutomatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}