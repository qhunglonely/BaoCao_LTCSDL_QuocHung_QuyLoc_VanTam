using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot.Statement
{
    class E_tb_CongViec
    {
        SQL_tb_CongViec cvsql = new SQL_tb_CongViec();
        public void themoicv(EC_tb_CongViec cv)
        {
            if (!cvsql.kiemtraCV(cv.MACV))
            {
                cvsql.themmoiCV(cv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacv(EC_tb_CongViec cv)
        {
            cvsql.suaCV(cv);
        }
        public void xoacv(EC_tb_CongViec cv)
        {
            cvsql.xoaCV(cv);
        }
    }
}
