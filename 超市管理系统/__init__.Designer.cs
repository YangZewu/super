﻿using System.Windows.Forms;

namespace 超市管理系统
{
    partial class __init__
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
            this.icNo = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.image_Code = new System.Windows.Forms.PictureBox();
            this.Click_Code = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_GeticNo = new System.Windows.Forms.Button();
            this.Btn_Land = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_Code)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(403, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // icNo
            // 
            this.icNo.Location = new System.Drawing.Point(487, 191);
            this.icNo.Margin = new System.Windows.Forms.Padding(4);
            this.icNo.Name = "icNo";
            this.icNo.Size = new System.Drawing.Size(152, 25);
            this.icNo.TabIndex = 1;
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(748, 190);
            this.Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(155, 25);
            this.Pwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(663, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(487, 261);
            this.Code.Margin = new System.Windows.Forms.Padding(4);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(152, 25);
            this.Code.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(376, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "验证码：";
            // 
            // image_Code
            // 
            this.image_Code.Location = new System.Drawing.Point(648, 261);
            this.image_Code.Margin = new System.Windows.Forms.Padding(4);
            this.image_Code.Name = "image_Code";
            this.image_Code.Size = new System.Drawing.Size(73, 25);
            this.image_Code.TabIndex = 6;
            this.image_Code.TabStop = false;
            // 
            // Click_Code
            // 
            this.Click_Code.AutoSize = true;
            this.Click_Code.BackColor = System.Drawing.Color.Transparent;
            this.Click_Code.Font = new System.Drawing.Font("宋体", 15F);
            this.Click_Code.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Click_Code.Location = new System.Drawing.Point(729, 261);
            this.Click_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Click_Code.Name = "Click_Code";
            this.Click_Code.Size = new System.Drawing.Size(137, 25);
            this.Click_Code.TabIndex = 7;
            this.Click_Code.Text = "更换验证码";
            this.Click_Code.Click += new System.EventHandler(this.Click_Code_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(484, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "温馨提示：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(579, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "先读卡后登录，验证码严格区分大小写！！";
            // 
            // Btn_GeticNo
            // 
            this.Btn_GeticNo.Location = new System.Drawing.Point(487, 354);
            this.Btn_GeticNo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_GeticNo.Name = "Btn_GeticNo";
            this.Btn_GeticNo.Size = new System.Drawing.Size(84, 39);
            this.Btn_GeticNo.TabIndex = 10;
            this.Btn_GeticNo.Text = "读卡";
            this.Btn_GeticNo.UseVisualStyleBackColor = true;
            this.Btn_GeticNo.Click += new System.EventHandler(this.Btn_GeticNo_Click);
            // 
            // Btn_Land
            // 
            this.Btn_Land.Location = new System.Drawing.Point(625, 354);
            this.Btn_Land.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Land.Name = "Btn_Land";
            this.Btn_Land.Size = new System.Drawing.Size(84, 39);
            this.Btn_Land.TabIndex = 11;
            this.Btn_Land.Text = "登录";
            this.Btn_Land.UseVisualStyleBackColor = true;
            this.Btn_Land.Click += new System.EventHandler(this.Btn_Land_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(764, 354);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(84, 39);
            this.Btn_Close.TabIndex = 12;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(785, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "忘记密码，请点击这里！";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // __init__
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::超市管理系统.Properties.Resources.登陆背景图;
            this.ClientSize = new System.Drawing.Size(979, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Land);
            this.Controls.Add(this.Btn_GeticNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Click_Code);
            this.Controls.Add(this.image_Code);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "__init__";
            this.Text = "__init__";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.@__init___Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_Code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox icNo;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox image_Code;
        private System.Windows.Forms.Label Click_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_GeticNo;
        private System.Windows.Forms.Button Btn_Land;
        private System.Windows.Forms.Button Btn_Close;
        private Label label6;
    }
}