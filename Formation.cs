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
    public partial class Formation : Form
    {
        public Formation()
        {
            InitializeComponent();
        }
        string formation;
        private void Formation_Load(object sender, EventArgs e)
        {

            
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            
            txt_nom.Clear();
            txt_secteur.Clear();
            rb_cheque.Checked = false;
           
            rb_versement.Checked = false;
            rb_virement.Checked = false;
           
        }
        
       

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into  FORMATION_INDIVIDUAL values(@Nom_Formation,@Secteur_Activite,@Type_Reglement)", con);
                SqlParameter param = new SqlParameter();
                param = new SqlParameter();
                param.ParameterName = "@Nom_Formation";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_nom.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Secteur_Activite";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_secteur.Text;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@Type_Reglement";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = formation;
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

        private void rb_cheque_CheckedChanged(object sender, EventArgs e)
        {
            formation = "Chéque";
        }

        private void rb_virement_CheckedChanged(object sender, EventArgs e)
        {
            formation = "Virement";
        }

        private void rb_versement_CheckedChanged(object sender, EventArgs e)
        {
            formation = "Versement";
        }

       
    }
}
