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
    public partial class frm_CTHDN : Form
    {
        public frm_CTHDN()
        {
            InitializeComponent();
        }
        E_tb_CTHDN thucthi = new E_tb_CTHDN();
        ConnectDB cn = new ConnectDB();
        EC_tb_CTHDN ck = new EC_tb_CTHDN();
        bool themmoi;
        int dong = 0;

        private string sohdn;
        public string SOHDN
        {
            get
            {
                return sohdn;
            }
            set
            {
                sohdn = value;
            }
        }

        public void setnull()
        {
            txtsl.Text = "0";
            txtdg.Text = "0";
            txtgg.Text = "0";
            txttt.Text = "0";
            cbhang.Text = "";
        }
        public void locktext()
        {
            txtsl.Enabled = false;
            txtdg.Enabled = false;
            txtgg.Enabled = false;
            cbhang.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtsl.Enabled = true;
            txtdg.Enabled = true;
            txtgg.Enabled = true;
            cbhang.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
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



        private void btquaylai_Click(object sender, EventArgs e)
        {
            frm_HDN fr = new frm_HDN();
            this.Close();
            fr.Show();
        }

        private void cbhd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            cbhd.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbhang.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtdg.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtgg.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[5].Value.ToString();
            locktext();
        }

        private void cbhang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtensp(lbhang.Text, cbhang.Text);
        }

        private void btmoi_Click_1(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            string sql = "SELECT sohdn, masp, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN where sohdn='" + sohdn + "'";
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

        private void btluu_Click_1(object sender, EventArgs e)
        {
            if (cbhang.Text != "")
            {
                if (Int32.Parse(txtsl.Text) > 0 && Int32.Parse(txtdg.Text) > 0)
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);

                            ck.SOHDN = cbhd.Text;
                            ck.MASP = cbhang.Text;
                            ck.SOLUONG = txtsl.Text;
                            ck.DONGIA = txtdg.Text;
                            ck.GIAMGIA = txtgg.Text;
                            ck.THANHTIEN = tt.ToString();

                            thucthi.themoicthdn(ck);
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
                            float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                            ck.SOHDN = cbhd.Text;
                            ck.MASP = cbhang.Text;
                            ck.SOLUONG = txtsl.Text;
                            ck.DONGIA = txtdg.Text;
                            ck.GIAMGIA = txtgg.Text;
                            ck.THANHTIEN = tt.ToString();

                            thucthi.suacthdn(ck);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    float gn = float.Parse(txtdg.Text);
                    float gb = (gn * 110) / 100;

                    string upsl = "UPDATE tb_Sanpham SET soluong =soluong + '" + txtsl.Text + "' where masp='" + cbhang.Text + "'";
                    string upsl1 = "UPDATE tb_Sanpham SET dongianhap ='" + txtdg.Text + "' where masp ='" + cbhang.Text + "'";
                    string upsl2 = "UPDATE tb_Sanpham SET dongiaban ='" + gb + "'where masp='" + cbhang.Text + "'";
                    cn.ExcuteNonQuery(upsl);
                    cn.ExcuteNonQuery(upsl1);
                    cn.ExcuteNonQuery(upsl2);
                    locktext();
                    hienthi();
                    float t1 = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                    txttt.Text = t1.ToString();
                }
                else 
                {
                    MessageBox.Show("Số lượng hoặc đơn giá phải lớn hơn 0", "Chú Ý", MessageBoxButtons.OK);
                    cbhang.Focus();
                }
            }

            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cbhang.Focus();
            }
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.SOHDN = cbhd.Text;
                    ck.MASP = cbhang.Text;

                    thucthi.xoacthdn(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void frm_CTHDN_Load_1(object sender, EventArgs e)
        {
            cbhd.Text = sohdn;
            thucthi.loadmahd(cbhd);
            thucthi.loadmasp(cbhang);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
