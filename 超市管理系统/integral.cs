using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;
namespace 超市管理系统
{
    public partial class integral : Form
    {
        public integral()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        string yenum;
        private void Integral_Load(object sender, EventArgs e)
        {

            Lin = userManag.getJF(userManag.icNo);
            while (Lin.Read())
            {
                Get_label_Name.Text = Lin["userName"].ToString();
                Get_label_JF.Text = Lin["JF"].ToString();
                Get_label_KYYE.Text = Lin["YE"].ToString();
                yenum = Lin["YE"].ToString();
            }
            
            Lin.Close();




        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_CZ_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(yenum);
            
            if (comboBox_CZJF.Text == "1000")
            {
                if (i > 10)
                {
                    int jf = 1000;
                    int ye = 10;
                    userManag.CZJF(ye, jf, userManag.icNo);
                    MessageBox.Show("充值成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("温馨提示，您的余额不足！！", "提示", MessageBoxButtons.OK);
                }
            }
            else if (comboBox_CZJF.Text == "2000")
            {
                if (i > 20)
                {
                    int jf = 2000;
                    int ye = 20;
                    userManag.CZJF(ye, jf, userManag.icNo);
                    MessageBox.Show("充值成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("温馨提示，您的余额不足！！", "提示", MessageBoxButtons.OK);
                }
            }
            else if (comboBox_CZJF.Text == "3000")
            {
                if (i > 30)
                {
                    int jf = 3000;
                    int ye = 30;
                    userManag.CZJF(ye, jf, userManag.icNo);
                    MessageBox.Show("充值成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("温馨提示，您的余额不足！！", "提示", MessageBoxButtons.OK);
                }
            }
            else if (comboBox_CZJF.Text == "5000")
            {
                if (i > 50)
                {
                    int jf = 5000;
                    int ye = 50;
                    userManag.CZJF(ye, jf, userManag.icNo);
                    MessageBox.Show("充值成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("温馨提示，您的余额不足！！", "提示", MessageBoxButtons.OK);
                }
            }
            else if (comboBox_CZJF.Text == "10000")
            {
                if (i > 100)
                {
                    int jf = 10000;
                    int ye = 100;
                    userManag.CZJF(ye, jf, userManag.icNo);
                    MessageBox.Show("充值成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("温馨提示，您的余额不足！！", "提示", MessageBoxButtons.OK);
                }
            }
        }
    }
}
