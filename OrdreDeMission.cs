using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csse3
{
    public partial class OrdreDeMission : Form
    {
        public OrdreDeMission()
        {
            InitializeComponent();
        }

        private void OrdreDeMission_Load(object sender, EventArgs e)
        {
            PRJT ds = new PRJT();
            PRJTTableAdapters.EVENEMENTTableAdapter ev = new PRJTTableAdapters.EVENEMENTTableAdapter();
            ev.Fill(ds.EVENEMENT);
            OrdreMissionn cn = new OrdreMissionn();
            cn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cn;
        }
    }
}
