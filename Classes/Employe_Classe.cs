using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace csse3.Classes
{
    class Employe_Classe
    {
        //private int ID_Employe;
        //private string Nom_Employe;
        //private string Prenom_Employe;
        //private DateTime Date_Naissance;
        //private string Lieu_Naissance;
        //private string Adresse;
        //private string Tel_Employe;
        //private string Email_Employe;
        //private string Diplome_Employe;
        //private string Poste_Employe;
        //private string CIN;
        //private string mot_de_passe;
        ////private int Id_Connexion;
        ////private int Id_AgendaEmploye;

        //public Employe_Classe() { }

        //public Employe_Classe(int iD_Employe, string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe, string cIN, string Mot_De_Passe)
        //{
        //    ID_Employe = iD_Employe;
        //    Nom_Employe = nom_Employe;
        //    Prenom_Employe = prenom_Employe;
        //    Date_Naissance = date_Naissance;
        //    Lieu_Naissance = lieu_Naissance;
        //    Adresse = adresse;
        //    Tel_Employe = tel_Employe;
        //    Email_Employe = email_Employe;
        //    Diplome_Employe = diplome_Employe;
        //    CIN = cIN;
        //    mot_de_passe = Mot_De_Passe;

        //    //Id_Connexion = id_Connexion;
        //    //Id_AgendaEmploye = id_AgendaEmploye;
        //}




        //public string Nom_Employe1 { get => Nom_Employe; set => Nom_Employe = value; }
        //public string Prenom_Employe1 { get => Prenom_Employe; set => Prenom_Employe = value; }
        //public DateTime Date_Naissance1 { get => Date_Naissance; set => Date_Naissance = value; }
        //public string Lieu_Naissance1 { get => Lieu_Naissance; set => Lieu_Naissance = value; }
        //public string Adresse1 { get => Adresse; set => Adresse = value; }
        //public string Tel_Employe1 { get => Tel_Employe; set => Tel_Employe = value; }
        //public string Email_Employe1 { get => Email_Employe; set => Email_Employe = value; }
        //public string Diplome_Employe1 { get => Diplome_Employe; set => Diplome_Employe = value; }
        //public string Poste_Employe1 { get => Poste_Employe; set => Poste_Employe = value; }
        //public string CIN1 { get => CIN; set => CIN = value; }
        //public string Mot_de_passe { get => mot_de_passe; set => mot_de_passe = value; }

        //public int Id_Connexion1 { get => Id_Connexion; set => Id_Connexion = value; }
        //public int Id_AgendaEmploye1 { get => Id_AgendaEmploye; set => Id_AgendaEmploye = value; }

        private int ID_Employe;
        //private int ID_AGENDAEMPLOYE;
        private string Nom_Employe;
        private string Prenom_Employe;
        private DateTime Date_Naissance;
        private string Lieu_Naissance;
        private string Adresse;
        private string Tel_Employe;
        private string Email_Employe;
        private string Diplome_Employe;
        private string Poste_Employe;
        private string CIN;
        private string mot_de_passe;


        public Employe_Classe() { }

        public Employe_Classe(int iD_Employe, string nom_Employe, string prenom_Employe,
            DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe,
            string diplome_Employe, string poste_Employe, string cIN, string Mot_De_Passe)
        {
            ID_Employe = iD_Employe;
            //ID_AGENDAEMPLOYE = iD_AGENDAEMPLOYE;
            Nom_Employe = nom_Employe;
            Prenom_Employe = prenom_Employe;
            Date_Naissance = date_Naissance;
            Lieu_Naissance = lieu_Naissance;
            Adresse = adresse;
            Tel_Employe = tel_Employe;
            Email_Employe = email_Employe;
            Diplome_Employe = diplome_Employe;
            Poste_Employe = poste_Employe;
            CIN = cIN;
            mot_de_passe = Mot_De_Passe;
        }

        public int ID_Employe1 { set => ID_Employe = value; }
        //public int ID_AGENDAEMPLOYE1 { get => ID_AGENDAEMPLOYE; set => ID_AGENDAEMPLOYE = value; }
        public string Nom_Employe1 { get => Nom_Employe; set => Nom_Employe = value; }
        public string Prenom_Employe1 { get => Prenom_Employe; set => Prenom_Employe = value; }
        public DateTime Date_Naissance1 { get => Date_Naissance; set => Date_Naissance = value; }
        public string Lieu_Naissance1 { get => Lieu_Naissance; set => Lieu_Naissance = value; }
        public string Adresse1 { get => Adresse; set => Adresse = value; }
        public string Tel_Employe1 { get => Tel_Employe; set => Tel_Employe = value; }
        public string Email_Employe1 { get => Email_Employe; set => Email_Employe = value; }
        public string Diplome_Employe1 { get => Diplome_Employe; set => Diplome_Employe = value; }
        public string Poste_Employe1 { get => Poste_Employe; set => Poste_Employe = value; }
        public string CIN1 { get => CIN; set => CIN = value; }
        public string Mot_de_passe { get => mot_de_passe; set => mot_de_passe = value; }



        public void ajouteremploye(string Nom_Employe, string Prenom_Employe,
          DateTime Date_Naissance, string Lieu_Naissance, string Adresse, string Tel_Employe, string Email_Employe,
          string Diplome_Employe, string Poste_Employe, string CIN,string mdp)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into EMPLOYE values(@Nom_Employe,@Prenom_Employe," +
                    "@Date_Naissance," +
                    "@Lieu_Naissance,@Adresse,@Tel_Employe,@Email_Employe,@Diplome_Employe,@Poste_Employe,@CIN,@mdp)";

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Nom_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Nom_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Prenom_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Prenom_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Date_Naissance";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(Date_Naissance);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Lieu_Naissance";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Lieu_Naissance;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Adresse";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Adresse;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Tel_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Tel_Employe;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@Email_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Email_Employe;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@Diplome_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Diplome_Employe;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@Poste_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = Poste_Employe;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@CIN";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = CIN;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mdp";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = CIN;
                cmd.Parameters.Add(param);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussit !");
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Number + ":" + ex.Message);
                }
            }
        }
    }
}
