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
    public partial class MotPasse : Form
    {
        public MotPasse()
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
                
                cmd.CommandText ="select CIN,Mot_De_Passe  from  EMPLOYE where CIN='"+txt_cin.Text+"' and Mot_De_Passe='"+txt_mdpActuel.Text+"' ";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                        if (txt_nvMdp.Text == txt_confirmationnv.Text)
                        {
                            dr.Close();
                            cmd = new SqlCommand();
                            cmd.Connection = con;

                            //con.Open();
                            cmd.CommandText = "update EMPLOYE set Mot_De_Passe=@mdps where CIN=@cin";
                            cmd.Parameters.AddWithValue("@mdps",txt_nvMdp.Text);
                            cmd.Parameters.AddWithValue("@cin", txt_cin.Text);
                            /*SqlParameter param = new SqlParameter();
                            param.ParameterName = "@cin";
                            param.SqlDbType = SqlDbType.VarChar;
                            param.Size = 30;
                            param.Value = txt_cin.Text;
                            cmd.Parameters.Add(param);*/

                            /*param = new SqlParameter();
                            param.ParameterName = "@mdps";
                            param.SqlDbType = SqlDbType.VarChar;
                            param.Size = 30;
                            param.Value = txt_mdpActuel.Text;
                            cmd.Parameters.Add(param);*/

                            try
                            {
                                 cmd.ExecuteNonQuery();
                                 MessageBox.Show("Votre Mot de Passe est modifié !!");
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Number + ":" + ex.Message);
                            }

                        }
                        else
                        {
                            if (txt_nvMdp.Text != txt_confirmationnv.Text)
                                MessageBox.Show("Veulliez Verifier votre nouveau Mot de passe !");
                        }

                    
                    /*else
                    {
                        MessageBox.Show("Veuillez vérifier votre ancien Mot de passe !");
                    }*/

                }

            }
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
