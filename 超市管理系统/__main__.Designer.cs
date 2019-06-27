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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZT = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime_NYR = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime_HMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.退出登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.images_L = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.个人信息ToolStripMenuItem,
            this.会员卡管理ToolStripMenuItem,
            this.关于我们ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于我们ToolStripMenuItem1,
            this.退出登陆ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.首页ToolStripMenuItem.Text = "签到";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            // 
            // 会员卡管理ToolStripMenuItem
            // 
            this.会员卡管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建会员卡ToolStripMenuItem,
            this.注销会员卡ToolStripMenuItem});
            this.会员卡管理ToolStripMenuItem.Name = "会员卡管理ToolStripMenuItem";
            this.会员卡管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.会员卡管理ToolStripMenuItem.Text = "会员卡管理";
            // 
            // 新建会员卡ToolStripMenuItem
            // 
            this.新建会员卡ToolStripMenuItem.Name = "新建会员卡ToolStripMenuItem";
            this.新建会员卡ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.新建会员卡ToolStripMenuItem.Text = "新建会员卡";
            this.新建会员卡ToolStripMenuItem.Click += new System.EventHandler(this.新建会员卡ToolStripMenuItem_Click);
            // 
            // 注销会员卡ToolStripMenuItem
            // 
            this.注销会员卡ToolStripMenuItem.Name = "注销会员卡ToolStripMenuItem";
            this.注销会员卡ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.注销会员卡ToolStripMenuItem.Text = "注销会员卡";
            this.注销会员卡ToolStripMenuItem.Click += new System.EventHandler(this.注销会员卡ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.关于我们ToolStripMenuItem.Text = "个人中心";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于我们ToolStripMenuItem1
            // 
            this.关于我们ToolStripMenuItem1.Name = "关于我们ToolStripMenuItem1";
            this.关于我们ToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.关于我们ToolStripMenuItem1.Text = "关于我们";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Name,
            this.toolStripStatusLabel2,
            this.ZT,
            this.NowTime_NYR,
            this.NowTime_HMS});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Name
            // 
            this.TSSL_Name.Name = "TSSL_Name";
            this.TSSL_Name.Size = new System.Drawing.Size(54, 20);
            this.TSSL_Name.Text = "管理员";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(159, 20);
            this.toolStripStatusLabel2.Text = "欢迎使用，当前状态：";
            // 
            // ZT
            // 
            this.ZT.Name = "ZT";
            this.ZT.Size = new System.Drawing.Size(54, 20);
            this.ZT.Text = "登陆中";
            // 
            // NowTime_NYR
            // 
            this.NowTime_NYR.Name = "NowTime_NYR";
            this.NowTime_NYR.Size = new System.Drawing.Size(126, 20);
            this.NowTime_NYR.Text = "2019年06月26日";
            // 
            // NowTime_HMS
            // 
            this.NowTime_HMS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 2);
            this.NowTime_HMS.Name = "NowTime_HMS";
            this.NowTime_HMS.Size = new System.Drawing.Size(49, 20);
            this.NowTime_HMS.Text = "21:19";
            // 
            // 退出登陆ToolStripMenuItem
            // 
            this.退出登陆ToolStripMenuItem.Name = "退出登陆ToolStripMenuItem";
            this.退出登陆ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.退出登陆ToolStripMenuItem.Text = "退出登陆";
            this.退出登陆ToolStripMenuItem.Click += new System.EventHandler(this.退出登陆ToolStripMenuItem_Click);
            // 
            // images_L
            // 
            this.images_L.Location = new System.Drawing.Point(16, 50);
            this.images_L.Margin = new System.Windows.Forms.Padding(4);
            this.images_L.Name = "images_L";
            this.images_L.Size = new System.Drawing.Size(792, 178);
            this.images_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images_L.TabIndex = 1;
            this.images_L.TabStop = false;
            // 
            // __main__
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 558);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.images_L);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "__main__";
            this.Text = "__main__";
            this.Load += new System.EventHandler(this.@__main___Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Name;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ZT;
        private System.Windows.Forms.ToolStripStatusLabel NowTime_NYR;
        private System.Windows.Forms.ToolStripStatusLabel NowTime_HMS;
        private System.Windows.Forms.ToolStripMenuItem 退出登陆ToolStripMenuItem;
    }
}