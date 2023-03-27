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
    public partial class PaiementFormateur : Form
    {
        public PaiementFormateur()
        {
            InitializeComponent();
        }
        string paiment;
        private void PaiementFormateur_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select *from FORMATEUR", con);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        cb_employe1.DisplayMember = "NOM";
                        cb_employe1.ValueMember = "ID_FORMATEUR";
                        cb_employe1.DataSource = dt;

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
        private void ch_Encour_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "En Cours";

        }

        private void ch_effectuer_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "Effectuer";
        }

        private void bt_validerSalaire_Click(object sender, EventArgs e)
        {

            int salaire = Paiement_Classe.SalaireF(dateTimePicker2.Value.Month.ToString(), Convert.ToInt16(cb_employe1.SelectedValue));
            if (salaire == 1)
            {
                MessageBox.Show("Ce Employe est déja payé");
            }
            else
            {
                Paiement_Classe op = new Paiement_Classe();
                op.PaiementF(Convert.ToInt16(cb_employe1.SelectedValue), int.Parse(txt_salaire1.Text), int.Parse(txt_prime1.Text),  paiment, dateTimePicker2.Value, dateTimePicker2.Value.Month.ToString());


            }
            Annuler1();
            
        }
        public void Annuler1()
        {
            cb_employe1.Text = "";
            txt_prime1.Clear();
            txt_salaire1.Clear();
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void bt_annuler1_Click(object sender, EventArgs e)
        {
            Annuler1();
        }
    }
}
