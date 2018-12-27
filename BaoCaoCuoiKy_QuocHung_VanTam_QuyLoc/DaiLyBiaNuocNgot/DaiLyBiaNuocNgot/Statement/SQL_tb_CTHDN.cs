using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot.Statement
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdn(string shdn, string masp)
        {
            return cn.kiemtra(@"select count(*) from tb_CTHDN where sohdn=N'" + shdn + "' and masp=N'" + masp + "' ");
        }
        public void themmoicthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"INSERT INTO tb_CTHDN
                      (sohdn, masp, soluong,dongia, giamgia,thanhtien) VALUES   (N'" + cthdn.SOHDN + "',N'" + cthdn.MASP + "',N'" + cthdn.SOLUONG + "',N'" + cthdn.DONGIA + "',N'" + cthdn.GIAMGIA + "',N'" + cthdn.THANHTIEN + "')");
            cn.ExcuteNonQuery(sql);
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery(@"DELETE FROM tb_CTHDN WHERE sohdn='" + cthdn.SOHDN + "' and masp='" + cthdn.MASP + "' ");
        }

        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET soluong =N'" + cthdn.SOLUONG + "', giamgia = N'" + cthdn.GIAMGIA + "', dongia = N'" + cthdn.DONGIA + "', thanhtien = N'" + cthdn.THANHTIEN + "' where sohdn=N'" + cthdn.SOHDN + "' and masp=N'" + cthdn.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     masp FROM tb_Sanpham", 0);
        }
        public string Loadtenhang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [tensp] From [tb_Sanpham] where masp= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void loadmahdn(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdn FROM tb_HDN", 0);
        }
    }
}
