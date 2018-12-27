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
    public partial class frmThongKeNCC : Form
    {
        public frmThongKeNCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NCCReport rp = new NCCReport();
            rp.SetDataSource(ReportNCC(dateTimePicker1.Value, dateTimePicker2.Value));

            crystalReportViewer1.ReportSource = rp;
        }

        private DataTable ReportNCC(DateTime ngay1, DateTime ngay2)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_DaiLyBiaNuocNgot;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("ReportTheoNgay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ngay1", SqlDbType.DateTime).Value = ngay1;
            cmd.Parameters.Add("@ngay2", SqlDbType.DateTime).Value = ngay2;

            DataTable table = new DataTable();
            SqlDataAdapter apdapter = new SqlDataAdapter(cmd);
            apdapter.Fill(table);

            return table;
        }
    }
}
