using DaiLyBiaNuocNgot.Statement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot
{
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_User thucthi = new E_tb_User();
        


        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmddn.Enabled = false;
                cmddn_Click_1(sender, e);
            }
        }

        private void cmddn_Click_1(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            string quyen = "";
            EC_tb_User.username = user;
            EC_tb_User.password = pass;
            try
            {
                if (!thucthi.kiemtrauser(user, pass))
                {
                    
                    MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Main fr = new frm_Main();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
