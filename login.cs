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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            //Acceuil ol = new  Acceuil ();
            //ol.Show();
            Program.menu.Show();
            string _cin = txt_cin.Text;
            string _mot_de_passe = txt_mdp.Text;

            Classes.Directeur_Classe user = authentificationD(_cin, _mot_de_passe);
            Classes.Employe_Classe user1 = authentificationE(_cin, _mot_de_passe);
            Program.user = user;
            if (user != null)
            {


                if (user.CIN1 == "F2222")
                {
                    this.Close();
                    Program.menu.BTN_Directeur.Enabled = true;

                }

            }


            else if (user1 != null)
            {

                Program.user1 = user1;
                if (user1.CIN1 == "F3333")
                {
                    this.Close();
                    Program.menu.BTN_conseilere.Enabled = true;

                }
                else if (user1.CIN1 == "F0202")
                {
                    this.Close();
                    Program.menu.BTN_ResponsableFormation.Enabled = true;

                }
                else if (user1.CIN1 == "F3434")
                {
                    this.Close();
                    Program.menu.BTN_agentAdministratif.Enabled = true;

                }


            }

            else
            {
                MessageBox.Show("veuillez verifier vos données");
            }




        }
        private Classes.Directeur_Classe authentificationD(string cin, string mot_de_passe)
        {
            Classes.Directeur_Classe user = null;

            using (SqlConnection cnx = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand("select CIN,Mot_De_Passe from DIRECTEUR where CIN=@cin and Mot_De_Passe=@mdp", cnx);
                cmd.Parameters.AddWithValue("@CIN", cin);
                cmd.Parameters.AddWithValue("@mdp", mot_de_passe);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    user = new Classes.Directeur_Classe();
                    user.CIN1 = dr[0].ToString();
                    user.Mot_de_passe = dr[1].ToString();

                }
                return user;
            }

        }

        private Classes.Employe_Classe authentificationE(string cin, string mot_de_passe)
        {
            Classes.Employe_Classe user1 = null;

            using (SqlConnection cnx = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand("select CIN,Mot_De_Passe from EMPLOYE where CIN=@cin and Mot_De_Passe=@mdp", cnx);
                cmd.Parameters.AddWithValue("@CIN", cin);
                cmd.Parameters.AddWithValue("@mdp", mot_de_passe);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    user1 = new Classes.Employe_Classe();
                    user1.CIN1 = dr[0].ToString();
                    user1.Mot_de_passe = dr[1].ToString();

                }
                return user1;
            }

        }

        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
