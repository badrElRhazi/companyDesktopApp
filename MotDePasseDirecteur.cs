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
    public partial class MotDePasseDirecteur : Form
    {
        public MotDePasseDirecteur()
        {
            InitializeComponent();
        }

        private void bt_confirmer_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select Mot_de_Passe from Connexion c inner join DIRECTEUR d on c.cin = d.cin where d.poste = 'directeur'";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (txt_mdpActuel.Text == dr[0].ToString())
                    {
                        if (txt_nvMdp.Text == txt_mdpActuel.Text)
                        {
                            dr.Close();
                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            //con.Open();
                            cmd.CommandText = "update Connexion set Mot_De_Passe=@mdps where CIN=@cin";

                            SqlParameter param = new SqlParameter();
                            param.ParameterName = "@cin";
                            param.SqlDbType = SqlDbType.VarChar;
                            param.Size = 30;
                            param.Value = txt_cin.Text;
                            cmd.Parameters.Add(param);

                            param = new SqlParameter();
                            param.ParameterName = "@mdps";
                            param.SqlDbType = SqlDbType.VarChar;
                            param.Size = 30;
                            param.Value = txt_mdpActuel.Text;
                            cmd.Parameters.Add(param);

                            try
                            {
                                int nbrligne = cmd.ExecuteNonQuery();
                                if (nbrligne != 0)
                                    MessageBox.Show("Votre Mot de Passe est modifié !!");

                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Number + ":" + ex.Message);
                            }

                        }
                        else
                        {
                            if (txt_nvMdp.Text != txt_mdpActuel.Text)
                                MessageBox.Show("Veulliez Verifier votre nouveau Mot de passe !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez vérifier votre ancien Mot de passe !");
                    }
                }
            }
        }
        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MotDePasseDirecteur_Load(object sender, EventArgs e)
        {

        }
    }
}
