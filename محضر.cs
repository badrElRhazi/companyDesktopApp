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
    public partial class محضر : Form
    {
        public محضر()
        {
            InitializeComponent();
        }

        private void محضر_Load(object sender, EventArgs e)
        {

            PRJT ds = new PRJT();
            PRJTTableAdapters.EVENEMENTTableAdapter ev = new PRJTTableAdapters.EVENEMENTTableAdapter();
            ev.Fill(ds.EVENEMENT);
            CrystalReport1 cn = new CrystalReport1();
            cn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cn;
        }
    }
}
