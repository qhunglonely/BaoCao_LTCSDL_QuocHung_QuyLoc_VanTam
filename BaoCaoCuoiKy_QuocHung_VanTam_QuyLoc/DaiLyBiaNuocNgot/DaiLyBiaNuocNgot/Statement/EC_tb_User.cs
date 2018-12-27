using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaiLyBiaNuocNgot.Statement
{
    public class EC_tb_User
    {
        public static string username;
        public static string password;
        public static string quyen;

        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public string USERNAME
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                if (username == "")
                {
                    throw new Exception("Tên Đăng Nhập Không Được Để Trống !");
                }
            }
        }
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                if (password == "")
                {
                    throw new Exception("Mật Khẩu Nhập Không Được Để Trống !");
                }
            }
        }

        public string Password { get; set; }
    }
}
