using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 超市管理系统
{
    public partial class Supermarket : Form
    {
        public Supermarket()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        int jf;
        int ye;
        int jqjf;
        int jqye;
        private void Supermarket_Load(object sender, EventArgs e)
        {
            Lin = userManag.getJF(userManag.icNo);
            while (Lin.Read())
            {
                jf = Convert.ToInt32(Lin["JF"].ToString());
                ye = Convert.ToInt32(Lin["YE"].ToString());
            }
            Lin.Close();

        }

        private void Ben_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_HF_Click(object sender, EventArgs e)
        {
            if (radio_10.Checked == true)
            {
                if (jf >= 500 & ye >= 2)
                {

                    jqjf = 500;
                    jqye = 2;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 2) + "积分为：" + (jf - 500) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换10元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                     
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 500 || ye > 2)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 500)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }

                }
            }
            else if (radio_15.Checked == true)
            {
                if (jf >= 700 & ye >= 5)
                {

                    jqjf = 700;
                    jqye = 5;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 5) + "积分为：" + (jf - 700) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换15元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                      
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 700 || ye > 5)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 700)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_20.Checked == true)
            {
                if (jf >= 900 & ye > 8)
                {

                    jqjf = 900;
                    jqye = 8;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 8) + "积分为：" + (jf - 900) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换20元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 900 || ye > 8)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 900)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_30.Checked == true)
            {
                if (jf >= 1200 & ye > 15)
                {

                    jqjf = 1200;
                    jqye = 15;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 15) + "积分为：" + (jf - 1200) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换30元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1200 || ye > 15)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1200)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_10.Checked == true)
            {
                if (jf >= 2100 & ye > 50)
                {

                    jqjf = 2100;
                    jqye = 50;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 25) + "积分为：" + (jf - 2100) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换50元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 2100 || ye > 25)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 2100)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_10.Checked == true)
            {
                if (jf >= 3500 & ye > 60)
                {

                    jqjf = 3500;
                    jqye = 60;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 60) + "积分为：" + (jf - 3500) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换100元话费，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 3500 || ye > 60)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 3500)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }

            }
        }

        private void Btn_LPK_Click(object sender, EventArgs e)
        {
            if (radio_10.Checked == true)
            {
                if (jf >= 1500 & ye >= 80)
                {

                    jqjf = 1500;
                    jqye = 80;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 80) + "积分为：" + (jf - 1500) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换KFC100元电子卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1500 || ye > 80)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1500)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }

                }
            }
            else if (radio_DD_1000.Checked == true)
            {
                if (jf >= 1800 & ye >= 800)
                {

                    jqjf =1800;
                    jqye = 800;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 800) + "积分为：" + (jf - 1800) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换当当网1000元电子卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1800 || ye > 800)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1800)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_WYXY100.Checked == true)
            {
                if (jf >= 1500 & ye > 80)
                {

                    jqjf = 1500;
                    jqye = 80;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 80) + "积分为：" + (jf - 1500) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换100元网易严选礼品卡，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1500 || ye > 80)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1500)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_JD_50.Checked == true)
            {
                if (jf >= 1800 & ye > 30)
                {

                    jqjf = 1800;
                    jqye = 30;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 30) + "积分为：" + (jf - 1800) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换50元京东e卡，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1800 || ye > 30)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1800)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_JD_100.Checked == true)
            {
                if (jf >= 1500 & ye > 80)
                {

                    jqjf = 1500;
                    jqye = 80;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 80) + "积分为：" + (jf -1500) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换100元京东e卡，即将为你充值到预留手机号码，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 1500 || ye > 80)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 1500)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
            else if (radio_JD_200.Checked == true)
            {
                if (jf >= 2600 & ye > 160)
                {

                    jqjf = 2600;
                    jqye = 160;

                    if (MessageBox.Show("兑换前   余额为：" + ye + "积分为:" + jf + "\n" + "兑换后    余额为:" + (ye - 160) + "积分为：" + (jf - 2600) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.dhsp(jqye, jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换200元京东e卡，請留意", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (jf >= 2600 || ye > 160)
                    {
                        MessageBox.Show("您的积分加上余额还不足以兑换此物品");
                    }
                    else if (jf >= 2600)
                    {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                    }
                    else
                    {
                        MessageBox.Show("您的余额还不足以兑换此物品");
                    }
                }
            }
        }

        private void Btn_dh_Click(object sender, EventArgs e)
        {
            if (radio_txyk.Checked == true)
            {
                if (jf >= 2850)
                {

                    jqjf = 2850;

                    if (MessageBox.Show("兑换前     积分为:" + jf + "\n" + "兑换后     积分为：" + (jf - 2850) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换腾讯视频会员月卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                        MessageBox.Show("您的积分还不足以兑换此物品");
                  
                }
            }
            else if (radio_txjk.Checked == true)
            {
                if (jf >= 7000)
                {

                    jqjf = 7000;

                    if (MessageBox.Show("兑换前     积分为:" + jf + "\n" + "兑换后     积分为：" + (jf - 7000) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换腾讯视频会员季卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("您的积分还不足以兑换此物品");

                }
            }
            else if (radio_txnk.Checked == true)
            {
                if (jf >= 25000)
                {

                    jqjf = 25000;

                    if (MessageBox.Show("兑换前       积分为:" + jf + "\n" + "兑换后        积分为：" + (jf - 25000) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换腾讯视频会员年卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("您的积分还不足以兑换此物品");

                }
            }





            if (radioykyk.Checked == true)
            {
                if (jf >= 2850)
                {

                    jqjf = 2850;

                    if (MessageBox.Show("兑换前     积分为:" + jf + "\n" + "兑换后     积分为：" + (jf - 2850) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换优酷视频会员月卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("您的积分还不足以兑换此物品");

                }
            }
            else if (radioykjk.Checked == true)
            {
                if (jf >= 7000)
                {

                    jqjf = 7000;

                    if (MessageBox.Show("兑换前     积分为:" + jf + "\n" + "兑换后     积分为：" + (jf - 7000) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换优酷视频会员季卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("您的积分还不足以兑换此物品");

                }
            }
            else if (radioyknk.Checked == true)
            {
                if (jf >= 25000)
                {

                    jqjf = 25000;

                    if (MessageBox.Show("兑换前       积分为:" + jf + "\n" + "兑换后        积分为：" + (jf - 25000) + "\n" + "您是否确认兑换？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userManag.Jqjf(jqjf, userManag.icNo);
                        MessageBox.Show("恭喜您成功兑换优酷视频会员年卡，請留意", "提示", MessageBoxButtons.OK);

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("您的积分还不足以兑换此物品");

                }
            }

        }
    }
}