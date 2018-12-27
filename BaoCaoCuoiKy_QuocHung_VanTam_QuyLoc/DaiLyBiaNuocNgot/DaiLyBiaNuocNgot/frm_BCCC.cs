using DaiLyBiaNuocNgot.Statement;
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
    public partial class frm_BCCC : Form
    {
        
        public frm_BCCC()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_HDN thucthi = new E_tb_HDN();
        
        private void frm_BCCC_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NCCReport rp = new NCCReport();
            rp.SetDataSource(ReportNCC(d1.Value, d2.Value));

            crystalReportViewer2.ReportSource = rp;

        
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

             NCCReport rptNCC = new NCCReport();
            rptNCC.SetDataSource(table.DefaultView);
            crystalReportViewer2.ReportSource = rptNCC;

            return table;
            
        }

    }
}
