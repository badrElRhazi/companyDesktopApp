using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace csse3
{
    class Salle_Classe
    {

        private int ID_SALLE;
        //private int ID_EVENEMENT;
        private int CAPACITE;
        private int DISPONIBILITE;
        private int PRIX;
        private DateTime date;
        public Salle_Classe() { }
        public Salle_Classe(int iD_SALLE, int cAPACITE, int dISPONIBILITE, int pRIX, DateTime date)
        {
            ID_SALLE = iD_SALLE;
            //ID_EVENEMENT = iD_EVENEMENT;
            CAPACITE = cAPACITE;
            DISPONIBILITE = dISPONIBILITE;
            PRIX = pRIX;
            this.date = date;
        }

        public int ID_SALLE1 { get => ID_SALLE; set => ID_SALLE = value; }
        //public int ID_EVENEMENT1 { get => ID_EVENEMENT; set => ID_EVENEMENT = value; }
        public int CAPACITE1 { get => CAPACITE; set => CAPACITE = value; }
        public int DISPONIBILITE1 { get => DISPONIBILITE; set => DISPONIBILITE = value; }
        public int PRIX1 { get => PRIX; set => PRIX = value; }
        public DateTime DATE1 { get => this.date; set => this.date = value; }
        public static void Valider(int CAPACITE, string DISPONIBILITE, int PRIX,string type,DateTime date1)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into SALLE_list values( @CAPACITE,@DISPONIBILITE,@PRIX,@type,@Date)", con);
                SqlParameter param = new SqlParameter();


                //param = new SqlParameter();
                //param.ParameterName = "@ID_EVENEMENT";
                //param.SqlDbType = SqlDbType.Int;
                //param.Value = int.Parse(ID_EVENEMENT.ToString());
                //cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@CAPACITE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(CAPACITE.ToString());
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@DISPONIBILITE";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = DISPONIBILITE;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@PRIX";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(PRIX.ToString());
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = type;
                cmd.Parameters.Add(param);




                param = new SqlParameter();
                param.ParameterName = "@Date";
                param.SqlDbType = SqlDbType.Date;
                param.Value = date1.Date;
                cmd.Parameters.Add(param);
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
    }
}
