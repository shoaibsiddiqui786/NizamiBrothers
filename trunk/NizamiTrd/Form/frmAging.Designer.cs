﻿namespace NizamiTrd
{
    partial class frmAging
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
            this.pnlCalander = new System.Windows.Forms.Panel();
            this.btn_HideMonth = new System.Windows.Forms.Button();
            this.mCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.msk_AccountID = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAcName = new System.Windows.Forms.TextBox();
            this.lblOpBal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.msk_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.msk_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ToDate = new System.Windows.Forms.Button();
            this.btn_FromDate = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.optAgingGLCode = new System.Windows.Forms.RadioButton();
            this.optAging = new System.Windows.Forms.RadioButton();
            this.pnlCalander.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalander
            // 
            this.pnlCalander.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalander.Controls.Add(this.btn_HideMonth);
            this.pnlCalander.Controls.Add(this.mCalendarMain);
            this.pnlCalander.Location = new System.Drawing.Point(314, 6);
            this.pnlCalander.Name = "pnlCalander";
            this.pnlCalander.Size = new System.Drawing.Size(234, 215);
            this.pnlCalander.TabIndex = 141;
            this.pnlCalander.Visible = false;
            // 
            // btn_HideMonth
            // 
            this.btn_HideMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HideMonth.Location = new System.Drawing.Point(188, 187);
            this.btn_HideMonth.Name = "btn_HideMonth";
            this.btn_HideMonth.Size = new System.Drawing.Size(38, 24);
            this.btn_HideMonth.TabIndex = 18;
            this.btn_HideMonth.Text = "&Hide";
            this.btn_HideMonth.UseVisualStyleBackColor = true;
            this.btn_HideMonth.Click += new System.EventHandler(this.btn_HideMonth_Click);
            // 
            // mCalendarMain
            // 
            this.mCalendarMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mCalendarMain.Location = new System.Drawing.Point(4, 16);
            this.mCalendarMain.Margin = new System.Windows.Forms.Padding(0);
            this.mCalendarMain.Name = "mCalendarMain";
            this.mCalendarMain.TabIndex = 19;
            this.mCalendarMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendarMain_DateChanged);
            // 
            // msk_AccountID
            // 
            this.msk_AccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_AccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msk_AccountID.Location = new System.Drawing.Point(142, 6);
            this.msk_AccountID.Mask = "#-#-##-##-####";
            this.msk_AccountID.Name = "msk_AccountID";
            this.msk_AccountID.Size = new System.Drawing.Size(137, 20);
            this.msk_AccountID.TabIndex = 125;
            this.msk_AccountID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msk_AccountID_KeyDown);
            this.msk_AccountID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.msk_AccountID_MouseDoubleClick);
            this.msk_AccountID.Validating += new System.ComponentModel.CancelEventHandler(this.msk_AccountID_Validating);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(142, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 18);
            this.label15.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(142, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 18);
            this.label14.TabIndex = 139;
            // 
            // txtAcName
            // 
            this.txtAcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcName.Location = new System.Drawing.Point(452, 6);
            this.txtAcName.Name = "txtAcName";
            this.txtAcName.Size = new System.Drawing.Size(304, 20);
            this.txtAcName.TabIndex = 137;
            // 
            // lblOpBal
            // 
            this.lblOpBal.BackColor = System.Drawing.Color.White;
            this.lblOpBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpBal.Location = new System.Drawing.Point(452, 61);
            this.lblOpBal.Name = "lblOpBal";
            this.lblOpBal.Size = new System.Drawing.Size(304, 18);
            this.lblOpBal.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 18);
            this.label7.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(359, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 135;
            this.label10.Text = "Op.Balance : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 134;
            this.label11.Text = "Balance : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 133;
            this.label12.Text = "Account Name : ";
            // 
            // msk_ToDate
            // 
            this.msk_ToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msk_ToDate.Location = new System.Drawing.Point(143, 63);
            this.msk_ToDate.Mask = "00/00/0000";
            this.msk_ToDate.Name = "msk_ToDate";
            this.msk_ToDate.Size = new System.Drawing.Size(82, 20);
            this.msk_ToDate.TabIndex = 132;
            this.msk_ToDate.Text = "30102012";
            this.msk_ToDate.ValidatingType = typeof(System.DateTime);
            // 
            // msk_FromDate
            // 
            this.msk_FromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msk_FromDate.Location = new System.Drawing.Point(143, 34);
            this.msk_FromDate.Mask = "00/00/0000";
            this.msk_FromDate.Name = "msk_FromDate";
            this.msk_FromDate.Size = new System.Drawing.Size(82, 20);
            this.msk_FromDate.TabIndex = 131;
            this.msk_FromDate.Text = "25082012";
            this.msk_FromDate.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 130;
            this.label5.Text = "Credit Limit : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 129;
            this.label4.Text = "Phone # : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 128;
            this.label3.Text = "To Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "From Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 126;
            this.label1.Text = "Group Account ID : ";
            // 
            // btn_ToDate
            // 
            this.btn_ToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ToDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ToDate.Image = global::NizamiTrd.Properties.Resources.BaBa_Calendar;
            this.btn_ToDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ToDate.Location = new System.Drawing.Point(231, 61);
            this.btn_ToDate.Name = "btn_ToDate";
            this.btn_ToDate.Size = new System.Drawing.Size(62, 26);
            this.btn_ToDate.TabIndex = 151;
            this.btn_ToDate.TabStop = false;
            this.btn_ToDate.Text = "&Month";
            this.btn_ToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ToDate.UseVisualStyleBackColor = true;
            this.btn_ToDate.Click += new System.EventHandler(this.btn_ToDate_Click);
            // 
            // btn_FromDate
            // 
            this.btn_FromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FromDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_FromDate.Image = global::NizamiTrd.Properties.Resources.BaBa_Calendar;
            this.btn_FromDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FromDate.Location = new System.Drawing.Point(231, 32);
            this.btn_FromDate.Name = "btn_FromDate";
            this.btn_FromDate.Size = new System.Drawing.Size(62, 26);
            this.btn_FromDate.TabIndex = 150;
            this.btn_FromDate.TabStop = false;
            this.btn_FromDate.Text = "&Month";
            this.btn_FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FromDate.UseVisualStyleBackColor = true;
            this.btn_FromDate.Click += new System.EventHandler(this.btn_FromDate_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::NizamiTrd.Properties.Resources.FormExit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(680, 132);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(74, 30);
            this.btn_Exit.TabIndex = 144;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::NizamiTrd.Properties.Resources.PrinterSmall_ico;
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(591, 132);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(83, 32);
            this.btn_Print.TabIndex = 142;
            this.btn_Print.Text = "&Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // optAgingGLCode
            // 
            this.optAgingGLCode.AutoSize = true;
            this.optAgingGLCode.Location = new System.Drawing.Point(553, 91);
            this.optAgingGLCode.Margin = new System.Windows.Forms.Padding(2);
            this.optAgingGLCode.Name = "optAgingGLCode";
            this.optAgingGLCode.Size = new System.Drawing.Size(97, 17);
            this.optAgingGLCode.TabIndex = 153;
            this.optAgingGLCode.Text = "Aging GL Code";
            this.optAgingGLCode.UseVisualStyleBackColor = true;
            // 
            // optAging
            // 
            this.optAging.AutoSize = true;
            this.optAging.Checked = true;
            this.optAging.Location = new System.Drawing.Point(479, 91);
            this.optAging.Margin = new System.Windows.Forms.Padding(2);
            this.optAging.Name = "optAging";
            this.optAging.Size = new System.Drawing.Size(52, 17);
            this.optAging.TabIndex = 152;
            this.optAging.TabStop = true;
            this.optAging.Text = "Aging";
            this.optAging.UseVisualStyleBackColor = true;
            // 
            // frmAging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 214);
            this.Controls.Add(this.optAgingGLCode);
            this.Controls.Add(this.optAging);
            this.Controls.Add(this.btn_ToDate);
            this.Controls.Add(this.btn_FromDate);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.pnlCalander);
            this.Controls.Add(this.msk_AccountID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAcName);
            this.Controls.Add(this.lblOpBal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.msk_ToDate);
            this.Controls.Add(this.msk_FromDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAging";
            this.Text = "Aging Report";
            this.Load += new System.EventHandler(this.frmAging_Load);
            this.pnlCalander.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ToDate;
        private System.Windows.Forms.Button btn_FromDate;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel pnlCalander;
        private System.Windows.Forms.Button btn_HideMonth;
        private System.Windows.Forms.MonthCalendar mCalendarMain;
        private System.Windows.Forms.MaskedTextBox msk_AccountID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAcName;
        private System.Windows.Forms.Label lblOpBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox msk_ToDate;
        private System.Windows.Forms.MaskedTextBox msk_FromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optAgingGLCode;
        private System.Windows.Forms.RadioButton optAging;
    }
}