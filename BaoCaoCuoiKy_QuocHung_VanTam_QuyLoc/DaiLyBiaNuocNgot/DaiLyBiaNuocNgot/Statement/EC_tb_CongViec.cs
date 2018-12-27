using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaiLyBiaNuocNgot.Statement
{
    class EC_tb_CongViec
    {
        private string macv;
        private string tencv;

        public string MACV
        {
            get
            {
                return macv;
            }
            set
            {
                macv = value;
                if (macv == "")
                {
                    throw new Exception("Mã công việc không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENCV
        {
            get
            {
                return tencv;
            }
            set
            {
                tencv = value;
            }
        }
    }
}
