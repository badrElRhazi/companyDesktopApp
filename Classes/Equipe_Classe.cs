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
    class Equipe_Classe
    {
        private int ID_EQUIPE;
        private int ID_ADHERENT;
        private int ID_EMPLOYE;
        private string NOM_EQUIPE;
        private int Nombre;
        private string TYPE_FORMATION;

        public Equipe_Classe() { }
        public Equipe_Classe(int iD_EQUIPE, int iD_ADHERENT, int iD_EMPLOYE, string nOM_EQUIPE, int nombre, string tYPE_FORMATION)
        {
            ID_EQUIPE = iD_EQUIPE;
            ID_ADHERENT = iD_ADHERENT;
            ID_EMPLOYE = iD_EMPLOYE;
            NOM_EQUIPE = nOM_EQUIPE;
            Nombre = nombre;
            TYPE_FORMATION = tYPE_FORMATION;
        }

        public int ID_EQUIPE1 { get => ID_EQUIPE; set => ID_EQUIPE = value; }
        public int ID_ADHERENT1 { get => ID_ADHERENT; set => ID_ADHERENT = value; }
        public int ID_EMPLOYE1 { get => ID_EMPLOYE; set => ID_EMPLOYE = value; }
        public string NOM_EQUIPE1 { get => NOM_EQUIPE; set => NOM_EQUIPE = value; }
        public int Nombre1 { get => Nombre; set => Nombre = value; }
        public string TYPE_FORMATION1 { get => TYPE_FORMATION; set => TYPE_FORMATION = value; }

        static public void Valider(int EMPLOYE, string NOM_EQUIPE, int Nombre, int idFormation)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into EQUIPE values(@Id_EMPLOYE,@NOM_EQUIPE,@NOMBRE,@id_Formation)", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Id_EMPLOYE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(EMPLOYE.ToString());
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOM_EQUIPE";
                param.SqlDbType = SqlDbType.VarChar;
                param.Value = (NOM_EQUIPE);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOMBRE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = Nombre;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@id_Formation";
                param.SqlDbType = SqlDbType.Int;
              
                param.Value = idFormation;
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
        public static void vidertxtBox(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
                else if (c is ComboBox)
                {
                    ComboBox t = (ComboBox)c;
                    t.Text = "";
                }
            }
        }
    }
}
