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
    public partial class Salaire : Form
    {
        public Salaire()
        {
            InitializeComponent();
        }
        Paiement_Classe OP=new Paiement_Classe();
        string paiment;
        private void bt_validerSalaire_Click(object sender, EventArgs e)
        {
            int salaire = Paiement_Classe.SalaireD(dateTimePicker2.Value.Month.ToString(), Convert.ToInt16(cb_employe1.SelectedValue));
            if (salaire == 1)
            {
                MessageBox.Show("Ce Employe est déja payé");
            }
            else
            {
                OP.AjOUTER(Convert.ToInt16(cb_employe1.SelectedValue), int.Parse(txt_salaire1.Text), int.Parse(txt_prime1.Text), paiment, dateTimePicker2.Value,dateTimePicker2.Value.Month.ToString());

            }
            Annuler1();
            
        }

        private void ch_Encour_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "En Cours";
        }

        private void ch_effectuer_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "Effectuer";
        }

        private void Salaire_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select *from DIRECTEUR", con);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        cb_employe1.DisplayMember = "NOM";
                        cb_employe1.ValueMember = "ID_DIRECTEUR";
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
        public void Annuler1()
        {
            cb_employe1.Text = "";
            txt_prime1.Clear();
            txt_salaire1.Clear();
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Fonction_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bt_annulerD_Click(object sender, EventArgs e)
        {
            Annuler1();
        }
    }
}
