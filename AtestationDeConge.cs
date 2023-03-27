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
    public partial class AtestationDeConge : Form
    {
        public AtestationDeConge()
        {
            InitializeComponent();
        }

        private void AtestationDeConge_Load(object sender, EventArgs e)
        {
            //PRJT ds = new PRJT();
            //PRJTTableAdapters.EVENEMENTTableAdapter ev = new PRJTTableAdapters.EVENEMENTTableAdapter();
            //ev.Fill(ds.EVENEMENT);
            DataSet1 ds = new DataSet1 ();
            DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter de = new DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter();
            AtestationConge cn = new AtestationConge();
            cn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cn;
        }
    }
}
