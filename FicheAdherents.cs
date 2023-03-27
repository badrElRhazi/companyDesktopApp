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
    public partial class FicheAdherents : Form
    {
        public FicheAdherents()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        DataSet1TableAdapters.ADHERENTTableAdapter da = new DataSet1TableAdapters.ADHERENTTableAdapter();
        DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter df = new DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter();
        DataSet1TableAdapters.EQUIPETableAdapter de = new DataSet1TableAdapters.EQUIPETableAdapter();
        DataSet1TableAdapters.EquipeAdherentTableAdapter dea = new DataSet1TableAdapters.EquipeAdherentTableAdapter();
        private void bt_Imprimer1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            panel2.Visible = false;
            CrystalReport2 et = new CrystalReport2();
            et.SetDataSource(ds);
            et.SetParameterValue(0, Convert.ToInt16(cb_equipe.SelectedValue));
            crystalReportViewer1.ReportSource = et;

        }

        private void FicheAdherents_Load(object sender, EventArgs e)
        {
            da.Fill(ds.ADHERENT);
            df.Fill(ds.FORMATION_INDIVIDUAL);
            de.Fill(ds.EQUIPE);
            dea.Fill(ds.EquipeAdherent);

            cb_equipe.DisplayMember = ds.EQUIPE.NOM_EQUIPEColumn.ColumnName;
            cb_equipe.ValueMember = ds.EQUIPE.ID_EQUIPEColumn.ColumnName;
            cb_equipe.DataSource = ds.EQUIPE;
        }
    }
}
