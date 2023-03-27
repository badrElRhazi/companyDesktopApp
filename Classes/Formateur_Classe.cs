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
    class Formateur_Classe:Employe_Classe
    {
        
        private string FONCTION;
        private string SPECIALITE;

        public Formateur_Classe() :base() { }
        //public Formateur_Classe(int iD_Employe, string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe, string FONCTION, string SPECIALITE, string cIN, string Mot_De_Passe) :base(iD_Employe,nom_Employe,prenom_Employe,date_Naissance,lieu_Naissance, adresse,tel_Employe, email_Employe,diplome_Employe, cIN, Mot_De_Passe)
        //{
        //    this.FONCTION = FONCTION;
        //    this.SPECIALITE = SPECIALITE;


        //}


        public Formateur_Classe(int Id_Employe, string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe, string poste_Employe, string cIN, string FONCTION, string SPECIALITE, string Mot_De_Passe) : base(Id_Employe, nom_Employe, prenom_Employe, date_Naissance, lieu_Naissance, adresse, tel_Employe, email_Employe, diplome_Employe, poste_Employe, cIN, Mot_De_Passe)

        {
            this.FONCTION = FONCTION;
            this.SPECIALITE = SPECIALITE;

        }
        public string FONCTION1 { get => FONCTION; set => FONCTION = value; }
        public string SPECIALITE1 { get => SPECIALITE; set => SPECIALITE = value; }

        public void ajouterformateur(string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe, string poste_Employe, string cIN, string FONCTION, string SPECIALITE)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into FORMATEUR values(@Nom_Employe,@Prenom_Employe," +
                    "@Date_Naissance,@Lieu_Naissance,@Adresse,@Tel_Employe,@Email_Employe,@Diplome_Employe," +
                    "@Poste_Employe,@CIN,@Fonction,@Specialite)";

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CIN";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cIN;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Nom_Employe";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = nom_Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Prenom_Employe";
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
                param.ParameterName = "@Fonction";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = FONCTION;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Specialite";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = SPECIALITE;
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
