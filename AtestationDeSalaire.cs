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
    public partial class AtestationDeSalaire : Form
    {
        public AtestationDeSalaire()
        {
            InitializeComponent();
        }

        private void AtestationDeSalaire_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter df = new DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter();
            df.Fill(ds.CLIENT_EVENEMENT);
            AtestationSalaire cn = new AtestationSalaire();
            cn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cn;
        }
    }
}
