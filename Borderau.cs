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
    public partial class Borderau : Form
    {
        public Borderau()
        {
            InitializeComponent();
        }

        private void Borderau_Load(object sender, EventArgs e)
        {

            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter de = new DataSet1TableAdapters.CLIENT_EVENEMENTTableAdapter();
            BORDEREAUU cn = new BORDEREAUU();
            cn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cn;        
        }
    }
}
