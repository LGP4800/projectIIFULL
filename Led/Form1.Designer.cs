﻿
namespace Led
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.labelSetPoint = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.lblDenTemp = new System.Windows.Forms.Label();
            this.lblDenSetP = new System.Windows.Forms.Label();
            this.lblDenStatus = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(383, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "SetPlus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(272, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "SetMinus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSetPoint
            // 
            this.labelSetPoint.AutoSize = true;
            this.labelSetPoint.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSetPoint.Location = new System.Drawing.Point(338, 201);
            this.labelSetPoint.Name = "labelSetPoint";
            this.labelSetPoint.Size = new System.Drawing.Size(89, 33);
            this.labelSetPoint.TabIndex = 9;
            this.labelSetPoint.Text = "label2";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(338, 353);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(89, 33);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "label2";
            // 
            // lblDenTemp
            // 
            this.lblDenTemp.AutoSize = true;
            this.lblDenTemp.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDenTemp.Location = new System.Drawing.Point(12, 64);
            this.lblDenTemp.Name = "lblDenTemp";
            this.lblDenTemp.Size = new System.Drawing.Size(181, 31);
            this.lblDenTemp.TabIndex = 11;
            this.lblDenTemp.Text = "Temperature :";
            this.lblDenTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDenSetP
            // 
            this.lblDenSetP.AutoSize = true;
            this.lblDenSetP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDenSetP.Location = new System.Drawing.Point(12, 201);
            this.lblDenSetP.Name = "lblDenSetP";
            this.lblDenSetP.Size = new System.Drawing.Size(213, 31);
            this.lblDenSetP.TabIndex = 12;
            this.lblDenSetP.Text = "Actual SetPoint :";
            // 
            // lblDenStatus
            // 
            this.lblDenStatus.AutoSize = true;
            this.lblDenStatus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDenStatus.Location = new System.Drawing.Point(12, 355);
            this.lblDenStatus.Name = "lblDenStatus";
            this.lblDenStatus.Size = new System.Drawing.Size(187, 31);
            this.lblDenStatus.TabIndex = 13;
            this.lblDenStatus.Text = "Actual Status :";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTemp.Location = new System.Drawing.Point(338, 73);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(89, 33);
            this.labelTemp.TabIndex = 14;
            this.labelTemp.Text = "label2";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(494, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 497);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.lblDenStatus);
            this.Controls.Add(this.lblDenSetP);
            this.Controls.Add(this.lblDenTemp);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSetPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "TERMOSTAT - Main Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label labelSetPoint;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label lblDenTemp;
        private System.Windows.Forms.Label lblDenSetP;
        private System.Windows.Forms.Label lblDenStatus;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Button btnClose;
    }
}


