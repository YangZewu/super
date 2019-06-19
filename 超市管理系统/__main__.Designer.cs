namespace 超市管理系统
{
    partial class __main__
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员卡管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建会员卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销会员卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Time1 = new System.Windows.Forms.Label();
            this.Label_Time2 = new System.Windows.Forms.Label();
            this.images_L = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images_L)).BeginInit();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.个人信息ToolStripMenuItem,
            this.会员卡管理ToolStripMenuItem,
            this.关于我们ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于我们ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.首页ToolStripMenuItem.Text = "签到";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            // 
            // 会员卡管理ToolStripMenuItem
            // 
            this.会员卡管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建会员卡ToolStripMenuItem,
            this.注销会员卡ToolStripMenuItem});
            this.会员卡管理ToolStripMenuItem.Name = "会员卡管理ToolStripMenuItem";
            this.会员卡管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.会员卡管理ToolStripMenuItem.Text = "会员卡管理";
            // 
            // 新建会员卡ToolStripMenuItem
            // 
            this.新建会员卡ToolStripMenuItem.Name = "新建会员卡ToolStripMenuItem";
            this.新建会员卡ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建会员卡ToolStripMenuItem.Text = "新建会员卡";
            this.新建会员卡ToolStripMenuItem.Click += new System.EventHandler(this.新建会员卡ToolStripMenuItem_Click);
            // 
            // 注销会员卡ToolStripMenuItem
            // 
            this.注销会员卡ToolStripMenuItem.Name = "注销会员卡ToolStripMenuItem";
            this.注销会员卡ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.注销会员卡ToolStripMenuItem.Text = "注销会员卡";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于我们ToolStripMenuItem.Text = "个人中心";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于我们ToolStripMenuItem1
            // 
            this.关于我们ToolStripMenuItem1.Name = "关于我们ToolStripMenuItem1";
            this.关于我们ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.关于我们ToolStripMenuItem1.Text = "关于我们";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 188);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 153);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前时间为：";
            // 
            // Label_Time1
            // 
            this.Label_Time1.AutoSize = true;
            this.Label_Time1.BackColor = System.Drawing.Color.Transparent;
            this.Label_Time1.Location = new System.Drawing.Point(481, 9);
            this.Label_Time1.Name = "Label_Time1";
            this.Label_Time1.Size = new System.Drawing.Size(71, 12);
            this.Label_Time1.TabIndex = 4;
            this.Label_Time1.Text = "Label_Time1";
            // 
            // Label_Time2
            // 
            this.Label_Time2.AutoSize = true;
            this.Label_Time2.BackColor = System.Drawing.Color.Transparent;
            this.Label_Time2.Location = new System.Drawing.Point(568, 9);
            this.Label_Time2.Name = "Label_Time2";
            this.Label_Time2.Size = new System.Drawing.Size(71, 12);
            this.Label_Time2.TabIndex = 5;
            this.Label_Time2.Text = "Label_Time2";
            // 
            // images_L
            // 
            this.images_L.Image = global::超市管理系统.Properties.Resources.image_2017年物联网2班;
            this.images_L.Location = new System.Drawing.Point(12, 40);
            this.images_L.Name = "images_L";
            this.images_L.Size = new System.Drawing.Size(594, 142);
            this.images_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images_L.TabIndex = 1;
            this.images_L.TabStop = false;
            // 
            // __main__
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 446);
            this.Controls.Add(this.Label_Time2);
            this.Controls.Add(this.Label_Time1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.images_L);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "__main__";
            this.Text = "__main__";
            this.Load += new System.EventHandler(this.@__main___Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.images_L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员卡管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建会员卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销会员卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem1;
        private System.Windows.Forms.PictureBox images_L;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Time1;
        private System.Windows.Forms.Label Label_Time2;
    }
}