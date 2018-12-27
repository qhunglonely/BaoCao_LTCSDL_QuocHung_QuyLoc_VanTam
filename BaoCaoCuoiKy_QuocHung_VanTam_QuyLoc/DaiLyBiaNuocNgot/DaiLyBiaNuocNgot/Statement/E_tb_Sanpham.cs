using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot.Statement
{
    class E_tb_Sanpham
    {
        SQL_tb_Sanpham tvsql = new SQL_tb_Sanpham();
        public void themoitv(EC_tb_Sanpham sp)
        {
            
            
            if (!tvsql.kiemtraSP(sp.MASP))
            {
                tvsql.themmoiSP(sp);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suatv(EC_tb_Sanpham sp)
        {
            tvsql.suatv(sp);
        }
        public void xoatv(EC_tb_Sanpham sp)
        {
            tvsql.xoaTV(sp);
        }


        //load hsx
        public void loadmahsx(ComboBox cbhsx)
        {
            tvsql.loadmaHSX(cbhsx);
        }
        public string loadtenhsx(string Tenhsx, string Mahsx)
        {
            Tenhsx = tvsql.LoadtenHSX(Tenhsx, Mahsx);
            return Tenhsx;
        }
        public void loadmasx(ComboBox cbsx)
        {
            tvsql.loadmasx(cbsx);
        }
        public string loadtensx(string Tensx, string Masx)
        {
            Tensx = tvsql.Loadtensx(Tensx, Masx);
            return Tensx;
        }
    }
}
