namespace 超市管理系统
{
    partial class signIn
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QDZT = new System.Windows.Forms.Label();
            this.JF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_QD = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.NowTime = new System.Windows.Forms.TextBox();
            this.icNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(27, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "签到状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(331, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前积分为：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(331, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名";
            // 
            // QDZT
            // 
            this.QDZT.AutoSize = true;
            this.QDZT.Font = new System.Drawing.Font("宋体", 12F);
            this.QDZT.Location = new System.Drawing.Point(142, 238);
            this.QDZT.Name = "QDZT";
            this.QDZT.Size = new System.Drawing.Size(69, 20);
            this.QDZT.TabIndex = 4;
            this.QDZT.Text = "未签到";
            // 
            // JF
            // 
            this.JF.AutoSize = true;
            this.JF.Location = new System.Drawing.Point(466, 180);
            this.JF.Name = "JF";
            this.JF.Size = new System.Drawing.Size(15, 15);
            this.JF.TabIndex = 5;
            this.JF.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(27, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "当前时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 25F);
            this.label8.Location = new System.Drawing.Point(254, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "签到";
            // 
            // Btn_QD
            // 
            this.Btn_QD.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_QD.Location = new System.Drawing.Point(290, 289);
            this.Btn_QD.Name = "Btn_QD";
            this.Btn_QD.Size = new System.Drawing.Size(75, 50);
            this.Btn_QD.TabIndex = 8;
            this.Btn_QD.Text = "签到";
            this.Btn_QD.UseVisualStyleBackColor = true;
            this.Btn_QD.Click += new System.EventHandler(this.Btn_QD_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(396, 289);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 50);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(396, 98);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(151, 25);
            this.TextBox_Name.TabIndex = 10;
            // 
            // NowTime
            // 
            this.NowTime.Location = new System.Drawing.Point(144, 170);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(151, 25);
            this.NowTime.TabIndex = 11;
            // 
            // icNo
            // 
            this.icNo.Location = new System.Drawing.Point(143, 97);
            this.icNo.Margin = new System.Windows.Forms.Padding(4);
            this.icNo.Name = "icNo";
            this.icNo.Size = new System.Drawing.Size(152, 25);
            this.icNo.TabIndex = 12;
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.icNo);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_QD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.JF);
            this.Controls.Add(this.QDZT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signIn";
            this.Text = "signIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label QDZT;
        private System.Windows.Forms.Label JF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_QD;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox NowTime;
        private System.Windows.Forms.TextBox icNo;
    }
}