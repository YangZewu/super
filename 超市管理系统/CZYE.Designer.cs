namespace 超市管理系统
{
    partial class CZYE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Get_label_icNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Get_comboBox_JE = new System.Windows.Forms.ComboBox();
            this.Btn_Set_CZ = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.Get_label_name = new System.Windows.Forms.Label();
            this.Get_label_YE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(145, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(145, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(95, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前余额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(45, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "选择充值金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "仅支持选择，不支持自定义充值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // Get_label_icNo
            // 
            this.Get_label_icNo.AutoSize = true;
            this.Get_label_icNo.Font = new System.Drawing.Font("宋体", 12F);
            this.Get_label_icNo.Location = new System.Drawing.Point(226, 133);
            this.Get_label_icNo.Name = "Get_label_icNo";
            this.Get_label_icNo.Size = new System.Drawing.Size(129, 20);
            this.Get_label_icNo.TabIndex = 32;
            this.Get_label_icNo.Text = "201906292118";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(225, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "￥";
            // 
            // Get_comboBox_JE
            // 
            this.Get_comboBox_JE.FormattingEnabled = true;
            this.Get_comboBox_JE.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "500"});
            this.Get_comboBox_JE.Location = new System.Drawing.Point(230, 330);
            this.Get_comboBox_JE.Name = "Get_comboBox_JE";
            this.Get_comboBox_JE.Size = new System.Drawing.Size(121, 23);
            this.Get_comboBox_JE.TabIndex = 34;
            // 
            // Btn_Set_CZ
            // 
            this.Btn_Set_CZ.Location = new System.Drawing.Point(137, 427);
            this.Btn_Set_CZ.Name = "Btn_Set_CZ";
            this.Btn_Set_CZ.Size = new System.Drawing.Size(75, 33);
            this.Btn_Set_CZ.TabIndex = 35;
            this.Btn_Set_CZ.Text = "充值";
            this.Btn_Set_CZ.UseVisualStyleBackColor = true;
            this.Btn_Set_CZ.Click += new System.EventHandler(this.Btn_Set_CZ_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(272, 427);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(80, 33);
            this.Btn_Close.TabIndex = 36;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
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
            // Get_label_name
            // 
            this.Get_label_name.AutoSize = true;
            this.Get_label_name.Font = new System.Drawing.Font("宋体", 12F);
            this.Get_label_name.Location = new System.Drawing.Point(226, 201);
            this.Get_label_name.Name = "Get_label_name";
            this.Get_label_name.Size = new System.Drawing.Size(49, 20);
            this.Get_label_name.TabIndex = 37;
            this.Get_label_name.Text = "XLin";
            // 
            // Get_label_YE
            // 
            this.Get_label_YE.AutoSize = true;
            this.Get_label_YE.Font = new System.Drawing.Font("宋体", 12F);
            this.Get_label_YE.Location = new System.Drawing.Point(268, 271);
            this.Get_label_YE.Name = "Get_label_YE";
            this.Get_label_YE.Size = new System.Drawing.Size(39, 20);
            this.Get_label_YE.TabIndex = 38;
            this.Get_label_YE.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F);
            this.label6.Location = new System.Drawing.Point(144, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 34);
            this.label6.TabIndex = 39;
            this.label6.Text = "余额充值";
            // 
            // CZYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Get_label_YE);
            this.Controls.Add(this.Get_label_name);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Set_CZ);
            this.Controls.Add(this.Get_comboBox_JE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Get_label_icNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CZYE";
            this.Text = "CZYE";
            this.Load += new System.EventHandler(this.CZYE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Get_label_icNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Get_comboBox_JE;
        private System.Windows.Forms.Button Btn_Set_CZ;
        private System.Windows.Forms.Button Btn_Close;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label Get_label_name;
        private System.Windows.Forms.Label Get_label_YE;
        private System.Windows.Forms.Label label6;
    }
}