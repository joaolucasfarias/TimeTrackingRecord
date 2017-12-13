namespace TimeTrackingRecord
{
    partial class FrmStartStop
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnFinalReport = new System.Windows.Forms.Button();
            this.lblWorkedTimeText = new System.Windows.Forms.Label();
            this.lblWorkedTimeNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(73, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(12, 89);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(61, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Config.";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // btnFinalReport
            // 
            this.btnFinalReport.Location = new System.Drawing.Point(157, 89);
            this.btnFinalReport.Name = "btnFinalReport";
            this.btnFinalReport.Size = new System.Drawing.Size(78, 23);
            this.btnFinalReport.TabIndex = 2;
            this.btnFinalReport.Text = "Final Report";
            this.btnFinalReport.UseVisualStyleBackColor = true;
            // 
            // lblWorkedTimeText
            // 
            this.lblWorkedTimeText.AutoSize = true;
            this.lblWorkedTimeText.Location = new System.Drawing.Point(12, 9);
            this.lblWorkedTimeText.Name = "lblWorkedTimeText";
            this.lblWorkedTimeText.Size = new System.Drawing.Size(70, 13);
            this.lblWorkedTimeText.TabIndex = 3;
            this.lblWorkedTimeText.Text = "Worked time:";
            // 
            // lblWorkedTimeNumbers
            // 
            this.lblWorkedTimeNumbers.AutoSize = true;
            this.lblWorkedTimeNumbers.Location = new System.Drawing.Point(88, 9);
            this.lblWorkedTimeNumbers.Name = "lblWorkedTimeNumbers";
            this.lblWorkedTimeNumbers.Size = new System.Drawing.Size(50, 13);
            this.lblWorkedTimeNumbers.TabIndex = 4;
            this.lblWorkedTimeNumbers.Text = "2h 22min";
            // 
            // FrmStartStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 124);
            this.Controls.Add(this.lblWorkedTimeNumbers);
            this.Controls.Add(this.lblWorkedTimeText);
            this.Controls.Add(this.btnFinalReport);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStartStop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Tracking Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnFinalReport;
        private System.Windows.Forms.Label lblWorkedTimeText;
        private System.Windows.Forms.Label lblWorkedTimeNumbers;
    }
}

