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
    public partial class AjouterEquipe : Form
    {
        public AjouterEquipe()
        {
            InitializeComponent();
        }
        string type;
       
        private void AjouterEquipe_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select * FROM EMPLOYE where POSTE='ResponsableFormation'", con1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cb_employe.DisplayMember = "NOM";
                    cb_employe.ValueMember = "ID_EMPLOYE";
                    cb_employe.DataSource = dt;

                    cmd = new SqlCommand("select * from FORMATION_INDIVIDUAL", con1);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                         dt = new DataTable();
                        dt.Load(dr);
                        cb_Formation.DisplayMember = "NOM_FR";
                        cb_Formation.ValueMember = "ID_FORMATIONINDIVIDUAL";
                        cb_Formation.DataSource = dt;
                    }

                    con1.Close();

                    }
            }
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            Classes.Equipe_Classe.Valider(Convert.ToInt32(cb_employe.SelectedValue), txt_NomEquipe.Text,int.Parse(txt_nbr.Text),Convert.ToInt16(cb_Formation.SelectedValue));
            cb_employe.Text = "";

            txt_NomEquipe.Clear();
            txt_nbr.Clear();
            cb_Formation.Text = "";
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            cb_employe.Text = "";
           
            txt_NomEquipe.Clear();
            txt_nbr.Clear();
            cb_Formation.Text = "";
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
