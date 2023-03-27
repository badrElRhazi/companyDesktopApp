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
    public partial class StatistiqueSalle : Form
    {
        public StatistiqueSalle()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        DataSet1TableAdapters.CLIENT_SALLETableAdapter dsa = new DataSet1TableAdapters.CLIENT_SALLETableAdapter();
        private void StatistiqueSalle_Load(object sender, EventArgs e)
        {
            dsa.Fill(ds.CLIENT_SALLE);
            for (int i = 2017; i < 2030; i++)
            {
                cb_annee.Items.Add(i);
            }
        }

        private void cb_annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrystalReportSalle et = new CrystalReportSalle();
            et.SetDataSource(ds);
            et.SetParameterValue(0, int.Parse(cb_annee.Text));
            crystalReportViewer1.ReportSource = et;
        }
    }
}
