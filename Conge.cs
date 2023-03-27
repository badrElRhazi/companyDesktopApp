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
    public partial class Conge : Form
    {
        public Conge()
        {
            InitializeComponent();
        }
        string Decision;
        string connection = @"Data Source=DESKTOP-1ASM0A6;Initial Catalog=ProjetFinFormationSiteWeb;Integrated Security=True";
       

      

       

        private void Conge_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from EMPLOYE", con);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_employe.DisplayMember = "NOM";
                        cb_employe.ValueMember = "ID_EMPLOYE";
                        cb_employe.DataSource = dt;
                    }



                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int conge1= Classes.Conge_Classe.Conge(Convert.ToInt16(cb_employe.SelectedValue));
            if (conge1 == 1)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("NbrConge", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = cmd.Parameters.Add("@Employe", SqlDbType.Int);
                    param.Direction = ParameterDirection.Input;
                    param = cmd.Parameters.Add("@nbr", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters["@Employe"].Value = cb_employe.SelectedValue;
                    cmd.ExecuteNonQuery();
                    //txt_duree.Text = cmd.Parameters["@nbr"].Value.ToString();


                    int i = (int)cmd.Parameters["@nbr"].Value;
                    //txt_duree.Text= cmd.Parameters["@nbr"].Value.ToString() ;
                    //i = cmd.Parameters["nbr"].Value;
                    //string i = cmd.Parameters["@nbr"].Value.ToString();

                    if (i > 30)
                    {
                        MessageBox.Show("Ce Congé Est Annulé ");
                    }
                    //else
                    //{
                    //    if (i == 0)
                    //    {
                    //        Classes.Conge_Classe og = new Classes.Conge_Classe();
                    //        og.AjouterConge(Convert.ToInt16(cb_employe.SelectedValue), Date_Debut.Value, Date_Fin.Value);
                    //    }

                    //}

                }
            }
            else
            {
                Classes.Conge_Classe og = new Classes.Conge_Classe();
                og.AjouterConge(Convert.ToInt16(cb_employe.SelectedValue), Date_Debut.Value, Date_Fin.Value);
            }

            //using (SqlConnection con = new SqlConnection(Program.connection))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("NbrConge", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlParameter param = cmd.Parameters.Add("@Employe", SqlDbType.Int);
            //    param.Direction = ParameterDirection.Input;
            //    param = cmd.Parameters.Add("@nbr", SqlDbType.Int);
            //    param.Direction = ParameterDirection.Output;
            //    cmd.Parameters["@Employe"].Value = cb_employe.SelectedValue;
            //    cmd.ExecuteNonQuery();
            //    //txt_duree.Text = cmd.Parameters["@nbr"].Value.ToString();


            //    int i = (int)cmd.Parameters["@nbr"].Value;
            //    //txt_duree.Text= cmd.Parameters["@nbr"].Value.ToString() ;
            //    //i = cmd.Parameters["nbr"].Value;
            //    //string i = cmd.Parameters["@nbr"].Value.ToString();

            //    if (i > 30)
            //    {
            //        MessageBox.Show("Ce Congé Est Annulé ");
            //    }
            //    //else
            //    //{
            //    //    if (i == 0)
            //    //    {
            //    //        Classes.Conge_Classe og = new Classes.Conge_Classe();
            //    //        og.AjouterConge(Convert.ToInt16(cb_employe.SelectedValue), Date_Debut.Value, Date_Fin.Value);
            //    //    }

            //    //}

           // }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_annulerConge_Click(object sender, EventArgs e)
        {
            cb_employe.Text = "";
        }
    }
}
