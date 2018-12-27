using DaiLyBiaNuocNgot.Statement;
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

namespace DaiLyBiaNuocNgot
{
    public partial class frm_Timkiem_HDN : Form
    {
        public frm_Timkiem_HDN()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_CTHDN thucthi = new E_tb_CTHDN();

        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Sản Phẩm";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Số Lượng";
            msds.Columns[2].Width = 80;
            msds.Columns[3].HeaderText = "Đơn Giá";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Giảm Giá";
            msds.Columns[4].Width = 80;
            msds.Columns[5].HeaderText = "Thành Tiền";
            msds.Columns[5].Width = 80;
        }
        public void hienthi()
        {
            string sql = "SELECT sohdn, masp, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        private void cbhang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtensp(lbhang.Text, cbhang.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = @"SELECT     sohdn, masp, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN where masp='" + cbhang.Text + "' ";
            msds.DataSource = cn.taobang(sql);

            SqlConnection con = cn.getcon();
            con.Open();
        }

        private void frm_Timkiem_HDN_Load(object sender, EventArgs e)
        {
            thucthi.loadmasp(cbhang);
            hienthi();
            khoitaoluoi();
        }

    }
}
