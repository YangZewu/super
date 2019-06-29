namespace 超市管理系统
{
    partial class Personal_Center
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.image_Head = new System.Windows.Forms.PictureBox();
            this.lab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Get_label_ye = new System.Windows.Forms.Label();
            this.Get_label_JF = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Head)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.image_Head);
            this.groupBox2.Location = new System.Drawing.Point(28, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(119, 117);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "头像";
            // 
            // image_Head
            // 
            this.image_Head.Location = new System.Drawing.Point(21, 28);
            this.image_Head.Margin = new System.Windows.Forms.Padding(5);
            this.image_Head.Name = "image_Head";
            this.image_Head.Size = new System.Drawing.Size(79, 74);
            this.image_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_Head.TabIndex = 0;
            this.image_Head.TabStop = false;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(177, 128);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(37, 15);
            this.lab.TabIndex = 35;
            this.lab.Text = "名字";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 38);
            this.button1.TabIndex = 36;
            this.button1.Text = "刷卡";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Get_label_ye);
            this.groupBox1.Controls.Add(this.Get_label_JF);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(379, 115);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "门店会员卡";
            // 
            // Get_label_ye
            // 
            this.Get_label_ye.AutoSize = true;
            this.Get_label_ye.BackColor = System.Drawing.Color.Transparent;
            this.Get_label_ye.Font = new System.Drawing.Font("宋体", 12F);
            this.Get_label_ye.Location = new System.Drawing.Point(289, 39);
            this.Get_label_ye.Name = "Get_label_ye";
            this.Get_label_ye.Size = new System.Drawing.Size(69, 20);
            this.Get_label_ye.TabIndex = 5;
            this.Get_label_ye.Text = "label5";
            // 
            // Get_label_JF
            // 
            this.Get_label_JF.AutoSize = true;
            this.Get_label_JF.BackColor = System.Drawing.Color.Transparent;
            this.Get_label_JF.Font = new System.Drawing.Font("宋体", 12F);
            this.Get_label_JF.Location = new System.Drawing.Point(44, 43);
            this.Get_label_JF.Name = "Get_label_JF";
            this.Get_label_JF.Size = new System.Drawing.Size(69, 20);
            this.Get_label_JF.TabIndex = 4;
            this.Get_label_JF.Text = "label4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "充值余额";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "购买积分";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "余额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "积分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "V2 新手玩家";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "15/200";
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(180, 156);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(55, 15);
            this.Label_name.TabIndex = 41;
            this.Label_name.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(140, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "个人中心";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(261, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "￥";
            // 
            // Personal_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.groupBox2);
            this.Name = "Personal_Center";
            this.Text = "Personal_Center";
            this.Load += new System.EventHandler(this.Personal_Center_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_Head)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox image_Head;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Get_label_ye;
        private System.Windows.Forms.Label Get_label_JF;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}