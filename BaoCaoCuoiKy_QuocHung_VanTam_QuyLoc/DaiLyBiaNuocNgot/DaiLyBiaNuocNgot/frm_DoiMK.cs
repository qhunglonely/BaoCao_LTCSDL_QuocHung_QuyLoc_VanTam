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
using System.Configuration;
using DaiLyBiaNuocNgot.Statement;

namespace DaiLyBiaNuocNgot
{
    public partial class frm_DoiMK : Form
    {
        public frm_DoiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_DoiMK_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                try
                {
                    if (textBox1.Text == EC_tb_User.password)
                    {
                        SqlConnection con = new SqlConnection("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QL_DaiLyBiaNuocNgot;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("UPDATE tb_User SET Password = '" + textBox2.Text + "' WHERE Username='" + EC_tb_User.username + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau !");
            }
        }
    }
}
