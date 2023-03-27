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
    class Directeur_Classe:Employe_Classe
    {
        // private int  Id_Connexion;
        //private int Id_AgendaEmploye;

        //public Directeur_Classe(int iD_Employe, string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe,  int Id_Connexion, int id_AgendaEmploye) : base(iD_Employe, nom_Employe, prenom_Employe, date_Naissance, lieu_Naissance, adresse, tel_Employe, email_Employe, diplome_Employe, cIN, Mot_De_Passe)
        //{
        //   // this.Id_Connexion = Id_Connexion;
        //    this.Id_AgendaEmploye = id_AgendaEmploye;
        //}

        //public Directeur_Classe() { }

        ////public int Id_Connexion2 { get => Id_Connexion; set => Id_Connexion = value; }
        //public int Id_AgendaEmploye1 { get => Id_AgendaEmploye; set => Id_AgendaEmploye = value; }

        private int Id_directeur;
        public Directeur_Classe() { }

        public Directeur_Classe(int iD_Employe, string nom_Employe, string prenom_Employe,
            DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe,
            string diplome_Employe, string poste_Employe, string cIN, int Id_directeur, string Mot_De_Passe) : base(iD_Employe, nom_Employe, prenom_Employe,
            date_Naissance, lieu_Naissance, adresse, tel_Employe, email_Employe,
             diplome_Employe, poste_Employe, cIN, Mot_De_Passe)
        {
            this.Id_directeur = Id_directeur;
        }

        public int Id_directeur1 { set => Id_directeur = value; }

        public void ajouterdirecteur(string nom_Employe, string prenom_Employe,
            DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe,
            string diplome_Employe, string poste_Employe, string cIN ,string mdp)
        {


            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into DIRECTEUR values(@NOM,@Prenom,@Date_Naissance,@Lieu_Naissance,@Adresse,@Tel_Employe,@Email_Employe,@Diplome_Employe," +
                    "@Poste_Employe,@CIN,@mdp)";

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CIN";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cIN;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOM";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = nom_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Prenom";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = prenom_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Date_Naissance";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(date_Naissance);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Lieu_Naissance";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = lieu_Naissance;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Adresse";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = adresse;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Tel_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = tel_Employe;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@Email_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = email_Employe;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@Diplome_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = diplome_Employe;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@Poste_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = poste_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mdp";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = poste_Employe;
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
