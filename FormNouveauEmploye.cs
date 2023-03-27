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
    public partial class FormNouveauEmploye : Form
    {
        public FormNouveauEmploye()
        {
            InitializeComponent();
        }
        string sexe;

        public void Parametre(SqlCommand cmd)
        {
            

        }
        SqlCommand cmd = new SqlCommand();
        private void bt_Valider_Click(object sender, EventArgs e)
        {
            if (cb_poste.Text == "Directeur")
            {
                Classes.Directeur_Classe cd = new Classes.Directeur_Classe();
                cd.ajouterdirecteur(txt_Nom.Text, txt_prenom.Text, Convert.ToDateTime(date_n.Text), txt_lieuN.Text, txt_Adresse.Text,
                    txt_tel.Text, txtx_email.Text, txt_diplome.Text, cb_poste.Text, txt_cin.Text,txt_mdp.Text);

            }
            if (cb_poste.Text == "Formateur")
            {
                Classes.Formateur_Classe fm = new Classes.Formateur_Classe();
                fm.ajouterformateur(txt_Nom.Text, txt_prenom.Text, Convert.ToDateTime(date_n.Text), txt_lieuN.Text,
                    txt_Adresse.Text, txt_tel.Text, txtx_email.Text, txt_cin.Text, txt_diplome.Text, cb_poste.Text,
                     cb_fonction.Text, txt_specialite.Text);


            }
            else
            {
                if (cb_poste.Text == "Agent Administratif" || cb_poste.Text == "Conseiliere Relation Clientéle" || cb_poste.Text == "Responsable Formation")
                {
                    Classes.Employe_Classe em = new Classes.Employe_Classe();
                    em.ajouteremploye(txt_Nom.Text, txt_prenom.Text, Convert.ToDateTime(date_n.Text),
                        txt_lieuN.Text, txt_Adresse.Text, txt_tel.Text, txtx_email.Text, txt_diplome.Text, cb_poste.Text, txt_cin.Text,txt_mdp.Text
                        );
                }

            }
            Annuler();


        }

        private void rb_femme_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rb_homme_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNouveauEmploye_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();

                try
                {
                    cb_fonction.Items.Add("Vacataire");
                    cb_fonction.Items.Add("Permanant");

                    cb_poste.Items.Add("Agent Administratif");
                    cb_poste.Items.Add("Directeur");
                    cb_poste.Items.Add("Conseiliere Relation Clientéle");
                    cb_poste.Items.Add("Formateur");
                    cb_poste.Items.Add("Responsable Formation");


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

        private void cb_poste_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Annuler() {
            txt_Nom.Clear();
            txt_prenom.Clear();
            date_n.Text = "";
            txt_lieuN.Clear();
            txt_Adresse.Clear();
            txt_tel.Clear();
            txtx_email.Clear();
            txt_diplome.Clear();
            cb_poste.Text = "";
            txt_cin.Clear();
            txt_mdp.Clear();
            lb_Specialite.Visible = false;
            txt_specialite.Visible = false;
            lb_fonction.Visible = false;
            cb_fonction.Visible = false;
        }
        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            Annuler();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_poste_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_poste.Text == "Formateur")
            {
                lb_fonction.Visible = true;
                cb_fonction.Visible = true;
                lb_Specialite.Visible = true;
                txt_specialite.Visible = true;
            }
            else
            {
                lb_fonction.Visible = false;
                cb_fonction.Visible = false;
                lb_Specialite.Visible = false;
                txt_specialite.Visible = false;
            }
        }
    }
}
