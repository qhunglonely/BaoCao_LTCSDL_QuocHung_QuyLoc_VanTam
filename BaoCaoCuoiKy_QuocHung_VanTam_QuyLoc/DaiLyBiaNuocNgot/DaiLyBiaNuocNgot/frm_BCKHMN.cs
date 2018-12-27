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
    public partial class frm_BCKHMN : Form
    {
        QL_DaiLyBiaNuocNgotDataSetTableAdapters.BCKHANGTableAdapter kh = new QL_DaiLyBiaNuocNgotDataSetTableAdapters.BCKHANGTableAdapter();
        public frm_BCKHMN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHReport rp = new KHReport();
            rp.SetDataSource(ReportNCC(d1.Value, d2.Value));

            crystalReportViewer3.ReportSource = rp;
        }
        private DataTable ReportNCC(DateTime ngay1, DateTime ngay2)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_DaiLyBiaNuocNgot;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("BCKHANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tu", SqlDbType.DateTime).Value = ngay1;
            cmd.Parameters.Add("@den", SqlDbType.DateTime).Value = ngay2;

            DataTable table = new DataTable();
            SqlDataAdapter apdapter = new SqlDataAdapter(cmd);
            apdapter.Fill(table);

            KHReport rptKH = new KHReport();
            rptKH.SetDataSource(table.DefaultView);
            crystalReportViewer3.ReportSource = rptKH;

            return table;
        }
    }
}
