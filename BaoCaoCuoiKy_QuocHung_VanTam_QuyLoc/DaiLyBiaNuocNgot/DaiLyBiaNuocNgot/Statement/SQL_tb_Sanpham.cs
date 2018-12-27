using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot.Statement
{
    class SQL_tb_Sanpham
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraSP(string masp)
        {
            
            return cn.kiemtra("select count(*) from [tb_Sanpham] where masp=N'" + masp + "'");
        }
        public void themmoiSP(EC_tb_Sanpham sp)
        {
            SqlConnection con = cn.getcon();
            try
            {

                con.Open();
                string sql = @"INSERT INTO tb_Sanpham (masp, tensp, mahang,  manoisx, dongianhap, dongiaban, ghichu, soluong, hansd)
							 VALUES (N'" + sp.MASP + "',N'" + sp.TENSP + "',N'" + sp.MAHANG + "',N'" + sp.MANOISX + "',N'" + sp.DONGIANHAP + "',N'" + sp.DONGIABAN + "',N'" + sp.GHICHU + "',N'" + sp.SOLUONG + "',N'" + sp.HANSD + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void xoaTV(EC_tb_Sanpham sp)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Sanpham] WHERE  masp=N'" + sp.Masp + "'");
        }

        public void suatv(EC_tb_Sanpham sp)
        {
            SqlConnection con = cn.getcon();
            try
            {
                con.Open();
                string sql = @"UPDATE    tb_Sanpham SET tensp =N'" + sp.Tensp + "', mahang =N'" + sp.Mahang +  "', manoisx =N'" + sp.Manoisx + "', dongianhap =N'" + sp.Dongianhap + "', dongiaban =N'" + sp.Dongiaban + "', ghichu =N'" + sp.Ghichu + "', soluong =N'" + sp.Soluong + "', hansd =N'" + sp.Hansd + "' where masp=N'" + sp.Masp + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        //load hang sx
        public void loadmaHSX(ComboBox mah)
        {
            cn.LoadLenCombobox(mah, "SELECT     mahang FROM tb_Hangsx", 0);
        }
        public string LoadtenHSX(string tenh, string mah)
        {
            tenh = cn.LoadLable("SELECT tenhang From tb_Hangsx where mahang= N'" + mah + "'");
            return tenh;
        }
        
        //load nơi sản xuất
        public void loadmasx(ComboBox masx)
        {
            cn.LoadLenCombobox(masx, "SELECT     manoisx FROM tb_NoiSX", 0);
        }
        public string Loadtensx(string tensx, string masx)
        {
            tensx = cn.LoadLable("SELECT tennoisx From tb_NoiSX where manoisx= N'" + masx + "'");
            return tensx;
        }

    }
}
