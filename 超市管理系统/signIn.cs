using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace 超市管理系统
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        string QD;
        private void SignIn_Load(object sender, EventArgs e)
        {
            TextBox_Name.Text = userManag.Name;
            icNo.Text = userManag.icNo;
            NowTime.Text= DateTime.Now.ToLongDateString().ToString();
            SqlDataReader Lin = userManag.getDataReader(userManag.icNo);
            while (Lin.Read())
            {
                QD = Lin["QDTime"].ToString();
            }
            if (QD == "")
            {
                QDZT.Text = "未签到";
            }
            else if (QD != NowTime.Text)
            {
                QDZT.Text = "未签到";
            }
            else
            {
                QDZT.Text = "已签到";
            }
        
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_QD_Click(object sender, EventArgs e)
        {
            if (QDZT.Text == "未签到")
            {
                if (QD == "")
                {
                    //插入操作
                    
                    if (userManag.QDJF(NowTime.Text, 05) == 1)
                    {
                        QDZT.Text = "已签到";
                        JF.Text = "05"; 
                    }
                }
                else
                {
                    //修改操作
                    
                }
            }
            else if(QDZT.Text=="已签到")
            {
                if (MessageBox.Show("今天已经签到过了，请12点过后再进行签到", "签到提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
