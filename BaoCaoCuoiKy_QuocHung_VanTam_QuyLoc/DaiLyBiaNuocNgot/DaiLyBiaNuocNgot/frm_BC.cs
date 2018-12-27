using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyBiaNuocNgot
{
    public partial class frm_BC : Form
    {
        public frm_BC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_BCCT fr = new frm_BCCT();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_BCCC fr = new frm_BCCC();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_BCKHMN fr = new frm_BCKHMN();
            fr.ShowDialog();
        }
    }
}
