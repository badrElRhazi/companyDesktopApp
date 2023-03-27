using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace csse3.Classes
{
    class Convention_Classe
    {
        private int Id_Convention ;
        private int Id_Employe;
        private string TypeConvention;
        private string NomConvention;
        private DateTime DateConvention;

        public Convention_Classe() { }

        public Convention_Classe(int id_Convention, int id_Employe, string typeConvention, string nomConvention, DateTime dateConvention)
        {
            Id_Convention = id_Convention;
            Id_Employe = id_Employe;
            TypeConvention = typeConvention;
            NomConvention = nomConvention;
            DateConvention = dateConvention;
        }

        public int Id_Convention1 { get => Id_Convention; set => Id_Convention = value; }
        public int Id_Employe1 { get => Id_Employe; set => Id_Employe = value; }
        public string TypeConvention1 { get => TypeConvention; set => TypeConvention = value; }
        public string NomConvention1 { get => NomConvention; set => NomConvention = value; }
        public DateTime DateConvention1 { get => DateConvention; set => DateConvention = value; }


        public static void Valider(int ID_EMPLOYE, string TYPE_CONVENTION, string NOM_CONVENTION, DateTime DATE_CONVENTION)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into CONVENTION values(@ID_EMPLOYE,@TYPE_CONVENTION,@NOM_CONVENTION,@DATE_CONVENTION)", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID_EMPLOYE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(ID_EMPLOYE.ToString());
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TYPE_CONVENTION";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = TYPE_CONVENTION;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@NOM_CONVENTION";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = NOM_CONVENTION;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DATE_CONVENTION";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(DATE_CONVENTION.ToString());
                cmd.Parameters.Add(param);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussit");


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
