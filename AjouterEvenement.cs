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
    public partial class AjouterEvenement : Form
    {
        public AjouterEvenement()
        {
            InitializeComponent();
        }
        string type;
        
        private void rb_intérieur_CheckedChanged(object sender, EventArgs e)
        {
            //if (rb_intérieur.Checked == true)
            //{
            //    lb_salle.Visible = true;
            //    cb_salle.Visible = true;
            //}
            //else
            //{
            //    lb_salle.Visible = false;
            //    cb_salle.Visible = false;
            //}
            type = "Exterieur";
        }

        private void AjouterEvenement_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from EMPLOYE where POSTE='ResponsableFormation'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cb_employe.DisplayMember = "NOM";
                    cb_employe.ValueMember = "ID_EMPLOYE";
                    cb_employe.DataSource = dt;

                    cmd = new SqlCommand("select * from Salle", con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dt = new DataTable();
                        dt.Load(dr);
                        cb_salle.DisplayMember = "ID_SALLE";
                        cb_salle.ValueMember = "ID_SALLE";
                        cb_salle.DataSource = dt;
                    }

                    con.Close();


                }

            }
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            Classes.Evenement_Classe.Valider(Convert.ToInt32(cb_employe.SelectedValue), type, txt_nomEv.Text, Convert.ToDateTime(dateTimePicker1.Value), int.Parse(txt_dure.Text), int.Parse(txt_prix.Text),Convert.ToInt16(cb_salle.SelectedValue));
            txt_prix.Clear();
            cb_employe.Text = "";
            rb_Exterieur.Checked = false;
            rb_intérieur.Checked = false;
            txt_nomEv.Clear();
            txt_dure.Clear();
            cb_salle.Text = "";
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {

            txt_prix.Clear();
            cb_employe.Text = "";
            rb_Exterieur.Checked = false;
            rb_intérieur.Checked = false;
            txt_nomEv.Clear();
            txt_dure.Clear();
        }

        private void rb_Exterieur_CheckedChanged(object sender, EventArgs e)
        {
            type = "Exterieur";
            cb_salle.Visible = false;

        }

        private void rb_intérieur_CheckedChanged_1(object sender, EventArgs e)
        {
            type = "Intérieur";
            cb_salle.Visible = true;
        }

        private void txt_dure_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dure_Click(object sender, EventArgs e)
        {
            int tr = Classes.Evenement_Classe.DisponibiliteSalle(Convert.ToDateTime(dateTimePicker1.Value), Convert.ToInt16(cb_salle.SelectedValue));
            if (tr == 1)
            {
                MessageBox.Show("Cette Salle Occupée au cette Date ");
            }
        }
    }
}
