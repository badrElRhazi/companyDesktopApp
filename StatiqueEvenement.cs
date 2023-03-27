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
    public partial class StatiqueEvenement : Form
    {
        public StatiqueEvenement()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter de = new DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter();
        private void StatiqueEvenement_Load(object sender, EventArgs e)
        {
           
            de.Fill(ds.CLIENT_EVENEMENT);
            for(int i=2017; i<2030; i++)
            {
                cb_Annee.Items.Add(i);
            }

           
        }

        private void cb_Annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrystalReportEvenement et = new CrystalReportEvenement();
           
            et.SetDataSource(ds);
            et.SetParameterValue(0, int.Parse(cb_Annee.Text));
            crystalReportViewer1.ReportSource = et;
        }
    }
}
