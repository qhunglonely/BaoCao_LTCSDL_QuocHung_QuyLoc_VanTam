using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaiLyBiaNuocNgot.Statement;
using System.Data.SqlClient;

namespace DaiLyBiaNuocNgot
{
    public partial class frm_Main : Form
    {
        EC_tb_User ck = new EC_tb_User();
        ConnectDB cn = new ConnectDB();
        public frm_Main()
        {
            InitializeComponent();
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
          
          SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_DaiLyBiaNuocNgot;Integrated Security=True");

            
          SqlDataAdapter daQuyen = new SqlDataAdapter("select * from tb_USER where username = '" + ck.USERNAME +"'", con);
          DataTable dtQ = new DataTable();
          daQuyen.Fill(dtQ);
          dgvQuyen.DataSource = dtQ;
          ck.Quyen = dgvQuyen.Rows[0].Cells[2].Value.ToString();
           if(ck.Quyen == "2")
           {
               buttonItem15.Visible = false;
               buttonItem26.Visible = false;
               buttonItem28.Visible = false;
           }
           else
           {
               buttonItem15.Visible = true;
               buttonItem26.Visible = true;
               buttonItem28.Visible = true;
           }
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            
            TabItem tab = tabControl1.CreateTab("Quản lý nhân viên");
            frm_Taikhoan f_NHANVIEN = new frm_Taikhoan();
            f_NHANVIEN.Dock = DockStyle.Fill;
            f_NHANVIEN.FormBorderStyle = FormBorderStyle.None;
            f_NHANVIEN.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_NHANVIEN);
            f_NHANVIEN.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Dangnhap fr = new frm_Dangnhap();
            fr.Show();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý người dùng");
            frm_Khachhang f_KHANG = new frm_Khachhang();
            f_KHANG.Dock = DockStyle.Fill;
            f_KHANG.FormBorderStyle = FormBorderStyle.None;
            f_KHANG.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_KHANG);
            f_KHANG.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý nhà cung cấp");
            frm_Ncc f_NCC = new frm_Ncc();
            f_NCC.Dock = DockStyle.Fill;
            f_NCC.FormBorderStyle = FormBorderStyle.None;
            f_NCC.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_NCC);
            f_NCC.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý sản phẩm");
            frm_Sanpham f_SP = new frm_Sanpham();
            f_SP.Dock = DockStyle.Fill;
            f_SP.FormBorderStyle = FormBorderStyle.None;
            f_SP.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_SP);
            f_SP.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý hóa đơn nhập");
            frm_HDN f_HDN = new frm_HDN();
            f_HDN.Dock = DockStyle.Fill;
            f_HDN.FormBorderStyle = FormBorderStyle.None;
            f_HDN.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_HDN);
            f_HDN.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý chi tiết hóa đơn nhập");
            frm_CTHDN f_CTHDN = new frm_CTHDN();
            f_CTHDN.Dock = DockStyle.Fill;
            f_CTHDN.FormBorderStyle = FormBorderStyle.None;
            f_CTHDN.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_CTHDN);
            f_CTHDN.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý hóa đơn xuất");
            frm_HDB f_HDB = new frm_HDB();
            f_HDB.Dock = DockStyle.Fill;
            f_HDB.FormBorderStyle = FormBorderStyle.None;
            f_HDB.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_HDB);
            f_HDB.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Quản lý chi tiết hóa đơn xuất");
            frm_CTHDB f_CTHDB = new frm_CTHDB();
            f_CTHDB.Dock = DockStyle.Fill;
            f_CTHDB.FormBorderStyle = FormBorderStyle.None;
            f_CTHDB.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_CTHDB);
            f_CTHDB.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Báo cáo cung cấp");
            frm_BCCC f_fCC = new frm_BCCC();
            f_fCC.Dock = DockStyle.Fill;
            f_fCC.FormBorderStyle = FormBorderStyle.None;
            f_fCC.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_fCC);
            f_fCC.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Báo cáo chi tiết");
            frm_BCCT f_fCT = new frm_BCCT();
            f_fCT.Dock = DockStyle.Fill;
            f_fCT.FormBorderStyle = FormBorderStyle.None;
            f_fCT.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_fCT);
            f_fCT.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Báo cáo khách hàng");
            frm_BCKHMN f_fT = new frm_BCKHMN();
            f_fT.Dock = DockStyle.Fill;
            f_fT.FormBorderStyle = FormBorderStyle.None;
            f_fT.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_fT);
            f_fT.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Đổi mật khẩu");
            frm_DoiMK f_doimk = new frm_DoiMK();
            f_doimk.Dock = DockStyle.Fill;
            f_doimk.FormBorderStyle = FormBorderStyle.None;
            f_doimk.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_doimk);
            f_doimk.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Tìm kiếm");
            frm_Timkiem f_Tk = new frm_Timkiem();
            f_Tk.Dock = DockStyle.Fill;
            f_Tk.FormBorderStyle = FormBorderStyle.None;
            f_Tk.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_Tk);
            f_Tk.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Tìm kiếm HĐN");
            frm_Timkiem_HDN f_Tk = new frm_Timkiem_HDN();
            f_Tk.Dock = DockStyle.Fill;
            f_Tk.FormBorderStyle = FormBorderStyle.None;
            f_Tk.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_Tk);
            f_Tk.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }
    }
}
