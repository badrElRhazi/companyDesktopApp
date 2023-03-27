using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace csse3
{
    public partial class Cantact : Form
    {
        public Cantact()
        {
            InitializeComponent();
        }

        private void Cantact_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select NOM,PRENOM,TELEPHONE 'Cantact' from FORMATEUR ", con1);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);




                        DGV_cantact.DataSource = dt;

                    }




                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
