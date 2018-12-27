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
    public partial class frm_Timkiem : Form
    {
        public frm_Timkiem()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT * FROM tb_Sanpham";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Sản Phẩm";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Sản Phẩm";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Hãng SX";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Nơi Sản Xuất";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Giá Nhập";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Gía Bán";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Ghi Chú";
            msds.Columns[6].Width = 100;

            msds.Columns[7].HeaderText = "Số Lượng";
            msds.Columns[7].Width = 100;

            msds.Columns[8].HeaderText = "Hạn Sử Dụng";
            msds.Columns[8].Width = 100;

        }
        public void hienthi()
        {
            string sql = @"SELECT * FROM tb_Sanpham";
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


        private void frm_Timkiem_Load_1(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (op4.Checked)
            {
                string sql = @"SELECT * FROM tb_Sanpham WHERE tb_Sanpham.tenhang  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);
                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op5.Checked)
            {
                string sql = @"SELECT * FROM tb_Sanpham WHERE tb_Sanpham.tensp  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);
                SqlConnection con = cn.getcon();
                con.Open();
            }
        }

        private void op4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void op5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
