using DaiLyBiaNuocNgot.Statement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot
{
    public partial class frm_Sanpham : Form
    {
        public frm_Sanpham()
        {
            InitializeComponent();
        }
        E_tb_Sanpham thucthi = new E_tb_Sanpham();
        ConnectDB cn = new ConnectDB();
        EC_tb_Sanpham ck = new EC_tb_Sanpham();
        bool themmoi;
        int dong = 0;




        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbmahang.Text = "";
            cbnoisx.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtgc.Text = "";
            txtsl.Text = "0";
            txtngay.Text = "";
           
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbmahang.Enabled = false;
            cbnoisx.Enabled = false;
            txtgc.Enabled = false;
            txtngay.Enabled = false;
            txtdgb.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbmahang.Enabled = true;
            txtdgb.Enabled = true;
            cbnoisx.Enabled = true;
            txtgc.Enabled = true;
            txtngay.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
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

            msds.Columns[8].HeaderText = "Hạn sử dụng";
            msds.Columns[8].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT     masp, tensp, mahang, manoisx, dongianhap, dongiaban, ghichu, soluong, hansd, ghichu FROM tb_Sanpham";
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




        private void cbmahang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtenhsx(lbhang.Text, cbmahang.Text);
        }

        private void cbnoisx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbnoisx.Text = thucthi.loadtensx(lbnoisx.Text, cbnoisx.Text);
        }

       
        private void frm_Sanpham_Load(object sender, EventArgs e)
        {
           
            thucthi.loadmahsx(cbmahang);
            thucthi.loadmasx(cbnoisx);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void btmoi_Click_1(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btluu_Click_1(object sender, EventArgs e)
        {
                        if (themmoi == true)
                        {
                            try
                            {
                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MAHANG = cbmahang.Text;
                                ck.MANOISX = cbnoisx.Text;
                                ck.DONGIABAN = txtdgb.Text;
                                ck.SOLUONG = txtsl.Text;
                                ck.HANSD = txtngay.Text;
                                ck.GHICHU = txtgc.Text;

                                thucthi.themoitv(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MAHANG = cbmahang.Text;
                                ck.MANOISX = cbnoisx.Text;
                                ck.DONGIABAN = txtdgb.Text;
                                ck.SOLUONG = txtsl.Text;
                                ck.HANSD = txtngay.Text;
                                ck.GHICHU = txtgc.Text;

                                thucthi.suatv(ck);
                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        txtma.Enabled = true;
                        locktext();
                        hienthi();
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MASP = txtma.Text;

                    thucthi.xoatv(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbmahang.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbnoisx.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtgc.Text = msds.Rows[dong].Cells[6].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[7].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[8].Value.ToString();
            locktext();
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
