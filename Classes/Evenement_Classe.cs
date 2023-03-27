using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace csse3.Classes
{
    class Evenement_Classe
    {
        private int ID_EVENEMENT;
        private int ID_EMPLOYE;
        private string TYPE_EVENEMENT;
        private string NOM_EVENEMENT;
        private DateTime DATE_EVENEMENT;
        private int DURE;
        private int PRIX_EVENEMENT;

        public Evenement_Classe() { }
        public Evenement_Classe(int iD_EVENEMENT, int iD_EMPLOYE, string tYPE_EVENEMENT, string nOM_EVENEMENT, DateTime dATE_EVENEMENT, int dURE, int pRIX_EVENEMENT)
        {
            ID_EVENEMENT = iD_EVENEMENT;
            ID_EMPLOYE = iD_EMPLOYE;
            TYPE_EVENEMENT = tYPE_EVENEMENT;
            NOM_EVENEMENT = nOM_EVENEMENT;
            DATE_EVENEMENT = dATE_EVENEMENT;
            DURE = dURE;
            PRIX_EVENEMENT = pRIX_EVENEMENT;
        }

        public int ID_EVENEMENT1 { get => ID_EVENEMENT; set => ID_EVENEMENT = value; }
        public int ID_EMPLOYE1 { get => ID_EMPLOYE; set => ID_EMPLOYE = value; }
        public string TYPE_EVENEMENT1 { get => TYPE_EVENEMENT; set => TYPE_EVENEMENT = value; }
        public string NOM_EVENEMENT1 { get => NOM_EVENEMENT; set => NOM_EVENEMENT = value; }
        public DateTime DATE_EVENEMENT1 { get => DATE_EVENEMENT; set => DATE_EVENEMENT = value; }
        public int DURE1 { get => DURE; set => DURE = value; }
        public int PRIX_EVENEMENT1 { get => PRIX_EVENEMENT; set => PRIX_EVENEMENT = value; }

        public static void Valider(int ID_EMPLOYE, string TYPE_EVENEMENT, string NOM_EVENEMENT, DateTime DATE_EVENEMENT, int DURE, int PRIX_EVENEMENT,int salle)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Evenement " +
                    "values(@ID_EMPLOYE, @TYPE_EVENEMENT,@NOM_EVENEMENT,@DATE_EVENEMENT,@DURE,@PRIX_EVENEMENT,@salle)", con);
                SqlParameter param = new SqlParameter();

                param = new SqlParameter();
                param.ParameterName = "@ID_EMPLOYE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(ID_EMPLOYE.ToString());
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TYPE_EVENEMENT";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = TYPE_EVENEMENT;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOM_EVENEMENT";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = NOM_EVENEMENT;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DATE_EVENEMENT";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(DATE_EVENEMENT.ToString());
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DURE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(DURE.ToString());
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@PRIX_EVENEMENT";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(PRIX_EVENEMENT.ToString());
                cmd.Parameters.Add(param);
                if (TYPE_EVENEMENT == "Intérieur")
                {
                    param = new SqlParameter();
                    param.ParameterName = "@salle";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = int.Parse(salle.ToString());
                    cmd.Parameters.Add(param);

                }
                else
                {
                    param = new SqlParameter();
                    param.ParameterName = "@salle";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = 0000;
                    cmd.Parameters.Add(param);
                }
               


                //param = new SqlParameter();
                //param.ParameterName = "@Id_Responsable";
                //param.SqlDbType = SqlDbType.Int;
                //param.Value = Convert.ToInt32(cb_Responsable.SelectedValue);
                //cmd.Parameters.Add(param);



                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Reussit");


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Number + ";" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        public static int DisponibiliteSalle( DateTime Date1, int salle)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from EVENEMENT where iD_SALLE=@num and  DATE_EVENEMENT = @date", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@num";
                param.SqlDbType = SqlDbType.Int;
                param.Value =salle ;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@date";
                param.SqlDbType = SqlDbType.Date;
                param.Value = Date1;
                cmd.Parameters.Add(param);


                int tr = 0;
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        return tr = 1;
                        // MessageBox.Show("hhh");


                    }
                    //else
                    //{
                    //    return tr;
                    //    //MessageBox.Show("hkkh");
                    //}

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return tr;

            }

            
        }

        public static void ModifierE(int id_ClientE,string NomC,string prenomc,DateTime DnC,string AdresseC,string SexeC,string TelC,string typeE,DateTime DateD,DateTime DateF)
        {

        }
    }
}
