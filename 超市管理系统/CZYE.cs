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
using BLL;

namespace 超市管理系统
{
    public partial class CZYE : Form
    {
        public CZYE()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        private void CZYE_Load(object sender, EventArgs e)
        {
            Lin = userManag.getJF(userManag.icNo);
            while (Lin.Read())
            {
                Get_label_name.Text = Lin["userName"].ToString();
                Get_label_YE.Text = Lin["YE"].ToString();              
            }

            Lin.Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //充值金额
        private void Btn_Set_CZ_Click(object sender, EventArgs e)
        {
            if (Get_comboBox_JE.Text == "20")
            {
                int ye = 20;
                userManag.CZYE(ye, userManag.icNo);
                MessageBox.Show("充值成功！");
                this.Close();
            }
            else if (Get_comboBox_JE.Text == "50")
            {
                int ye = 50;
                userManag.CZYE(ye, userManag.icNo);
                MessageBox.Show("充值成功！");
                this.Close();
            }
            else if (Get_comboBox_JE.Text == "100")
            {
                int ye = 100;
                userManag.CZYE(ye, userManag.icNo);
                MessageBox.Show("充值成功！");
                this.Close();
            }
            else if (Get_comboBox_JE.Text == "200")
            {
                int ye = 200;
                userManag.CZYE(ye, userManag.icNo);
                MessageBox.Show("充值成功！");
                this.Close();
            }
            else if (Get_comboBox_JE.Text == "500")
            {
                int ye = 500;
                userManag.CZYE(ye, userManag.icNo);
                MessageBox.Show("充值成功！");
                this.Close();
            }
        }
    }
}
