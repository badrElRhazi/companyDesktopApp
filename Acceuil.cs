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
    public partial class Acceuil : Form
    {
        public Button BTN_Directeur { get { return bt_directeur; } }
        public Button BTN_ResponsableFormation { get { return bt_responsable; } }
        public Button BTN_agentAdministratif { get { return bt_AgentAdministratif; } }
        public Button BTN_conseilere { get { return bt_conseillere; } }

       

        public Button BTN_Connexion { get { return bt_connexion; } }
        public Acceuil()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Appeler()
        {
            this.Hide();


            login ol = new login();
            ol.Show();
        }
        private void bt_directeur_Click(object sender, EventArgs e)
        {
            Program.menu = null;
           // this.Hide();


            Directeur ol = new Directeur();
            ol.Show();
            //Appeler();


        }

        private void bt_conseillere_Click(object sender, EventArgs e)
        {
            //Appeler();
            this.Hide();


            Form1 ol = new  Form1 ();
            ol.Show();
        }

        private void bt_AgentAdministratif_Click(object sender, EventArgs e)
        {
            // Appeler();
            this.Hide();


            Administrateur ol = new  Administrateur ();
            ol.Show();
        }

        private void bt_responsable_Click(object sender, EventArgs e)
        {
            // Appeler();
            this.Hide();


            ResponsableFormations ol = new  ResponsableFormations ();
            ol.Show();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            Acceuil oa = new Acceuil();

            oa.BTN_Directeur.Enabled = false;
            //string _cin = txt_cin.Text;
            //string _mot_de_passe = txt_mdp.Text;

            //Classes.Directeur_Classe user = authentificationD(_cin, _mot_de_passe);
            //Classes.Employe_Classe user1 = authentificationE(_cin, _mot_de_passe);
            //Program.user = user;
            //if (user != null)
            //{


            //    if (user.CIN1 == "F2222")
            //    {
            //        this.Close();
            //        Program.menu.BTN_Directeur.Enabled = true;

            //    }

            //}


            //else if (user1 != null)
            //{

            //    Program.user1 = user1;
            //    if (user1.CIN1 == "F3333")
            //    {
            //        this.Close();
            //        Program.menu.BTN_conseilere.Enabled = true;

            //    }
            //    else if (user1.CIN1 == "F0202")
            //    {
            //        this.Close();
            //        Program.menu.BTN_ResponsableFormation.Enabled = true;

            //    }
            //    else if (user1.CIN1 == "F3434")
            //    {
            //        this.Close();
            //        Program.menu.BTN_agentAdministratif.Enabled = true;

            //    }


            //}

            //else
            //{
            //    MessageBox.Show("veuillez verifier vos données");
            //}

        }

        private void bt_connexion_Click(object sender, EventArgs e)
        {
            //login lg = new login();
            //if (lg == null)
            //{
            //    lg = new login();
            //}
            //else
            //{
            //    if (lg.IsDisposed)
            //    {
            //        lg = new login();
            //    }
            //}
            //Program.Change(lg, panel4);
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void bt_deconnection_Click(object sender, EventArgs e)
        {
            Acceuil oa = new Acceuil();
           oa.bt_directeur.Enabled = false;
           oa.bt_AgentAdministratif.Enabled = false;
            oa.bt_responsable.Enabled = false;
            oa.BTN_conseilere.Enabled = false;
            Program.user1 = null;
            Program.user = null;
            oa.Close();
        }
        //private Classes.Directeur_Classe authentificationD(string cin, string mot_de_passe)
        //{
        //    Classes.Directeur_Classe user = null;

        //    using (SqlConnection cnx = new SqlConnection(Program.connection))
        //    {
        //        SqlCommand cmd = new SqlCommand("select CIN,Mot_De_Passe from DIRECTEUR where CIN=@cin and Mot_De_Passe=@mdp", cnx);
        //        cmd.Parameters.AddWithValue("@CIN", cin);
        //        cmd.Parameters.AddWithValue("@mdp", mot_de_passe);
        //        cnx.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read() == true)
        //        {
        //            user = new Classes.Directeur_Classe();
        //            user.CIN1 = dr[0].ToString();
        //            user.Mot_de_passe = dr[1].ToString();

        //        }
        //        return user;
        //    }

        //}

        //private Classes.Employe_Classe authentificationE(string cin, string mot_de_passe)
        //{
        //    Classes.Employe_Classe user1 = null;

        //    using (SqlConnection cnx = new SqlConnection(Program.connection))
        //    {
        //        SqlCommand cmd = new SqlCommand("select CIN,Mot_De_Passe from EMPLOYE where CIN=@cin and Mot_De_Passe=@mdp", cnx);
        //        cmd.Parameters.AddWithValue("@CIN", cin);
        //        cmd.Parameters.AddWithValue("@mdp", mot_de_passe);
        //        cnx.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read() == true)
        //        {
        //            user1 = new Classes.Employe_Classe();
        //            user1.CIN1 = dr[0].ToString();
        //            user1.Mot_de_passe = dr[1].ToString();

        //        }
        //        return user1;
        //    }

        //}
    }
}
