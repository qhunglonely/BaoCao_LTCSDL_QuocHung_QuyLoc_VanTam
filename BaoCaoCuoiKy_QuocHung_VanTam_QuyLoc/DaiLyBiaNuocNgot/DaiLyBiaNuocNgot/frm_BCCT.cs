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
    public partial class frm_BCCT : Form
    {
        QL_DaiLyBiaNuocNgotDataSetTableAdapters.bao_caoTableAdapter bc = new QL_DaiLyBiaNuocNgotDataSetTableAdapters.bao_caoTableAdapter();
        public frm_BCCT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.SetDataSource(ReportNCC(d1.Value, d2.Value));

            crystalReportViewer1.ReportSource = rp;
          
        }
        private DataTable ReportNCC(DateTime tu, DateTime den)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_DaiLyBiaNuocNgot;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("bao_cao", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tu", SqlDbType.DateTime).Value = tu;
            cmd.Parameters.Add("@den", SqlDbType.DateTime).Value = den;

            DataTable table = new DataTable();
            SqlDataAdapter apdapter = new SqlDataAdapter(cmd);
            apdapter.Fill(table);

            Report rptCT = new Report();
            rptCT.SetDataSource(table.DefaultView);
            crystalReportViewer1.ReportSource = rptCT;


            return table;
        }
        private void frm_BCCT_Load(object sender, EventArgs e)
        {

        }
    }
}
