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
    public partial class StatiqueFormation : Form
    {
        public StatiqueFormation()
        {
            InitializeComponent();
        }

        private void StatiqueFormation_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.ADHERENTTableAdapter da = new DataSet1TableAdapters.ADHERENTTableAdapter();
            DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter df = new DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter();
            da.Fill(ds.ADHERENT);
            df.Fill(ds.FORMATION_INDIVIDUAL);
            CrystalReportFormation et = new CrystalReportFormation();
            et.SetDataSource(ds);
            crystalReportViewer1.ReportSource = et;
        }
    }
}
