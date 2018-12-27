using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot.Statement
{
    class SQL_tb_CTHDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdb(string shdb, string masp)
        {
            return cn.kiemtra(@"select count(*) from [tb_CTHDB] where sohdb=N'" + shdb + "' and masp=N'" + masp + "' ");
        }
        public void themmoicthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDB
                      (sohdb, masp, soluong, giamgia,thanhtien) VALUES   (N'" + cthdb.SOHDB + "',N'" + cthdb.MASP + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.GIAMGIA + "',N'" + cthdb.THANHTIEN + "')");
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"DELETE FROM [tb_CTHDB] WHERE  sohdb='" + cthdb.SOHDB + "' and masp='" + cthdb.MASP + "' ");
        }

        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tb_CTHDB
            SET soluong =N'" + cthdb.SOLUONG + "', giamgia = N'" + cthdb.GIAMGIA + "', thanhtien = N'" + cthdb.THANHTIEN + "' where  sohdb=N'" + cthdb.SOHDB + "' and masp=N'" + cthdb.MASP + "'");
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
        public void loadmahd(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdb FROM tb_HDB", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [dongiaban] From [tb_Sanpham] where masp= N'" + masp + "'");
            return dg;
        }
    }
}
