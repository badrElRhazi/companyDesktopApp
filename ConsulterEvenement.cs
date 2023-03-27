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
    public partial class ConsulterEvenement : Form
    {
        public ConsulterEvenement()
        {
            InitializeComponent();
        }
        string type;
       
        private void DGV_Evenement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
               AjouterEvenement oa = new AjouterEvenement();
                oa.Show();
            }
        }

        private void ConsulterEvenement_Load(object sender, EventArgs e)
        {

            
            cb_evenement.Items.Add("Intérieur");
            cb_evenement.Items.Add("Exterieur");
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "Modifier";
            bt.HeaderText = "Opération";
            bt.Text = "Modifier";
            bt.UseColumnTextForButtonValue = true;
            DGV_Evenement.Columns.Add(bt);
           


            DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
            bt1.Name = "Supprimer";
            bt1.HeaderText = "Opération";
            bt1.Text = "Supprimer";
            bt1.UseColumnTextForButtonValue = true;
            DGV_Evenement.Columns.Add(bt1);

            DGV_Evenement.DataSource = null;
        }

        private void cb_evenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            panela.Visible = false;
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ID_CLIENT 'Numéro Client',CIN_CLIENT 'CIN',NOM_Client 'Nom Client',PRENOM_CLIENT 'Prénom Client',TELEPHONE_CLIENT 'Téléphone',TYPE_EVENEMENT 'Type',NOM_EVENEMENT 'Nom Evénement',DATE_EVENEMENT 'Date',DURE 'Durée' from  CLIENT_EVENEMENT where TYPE_EVENEMENT=@type", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;

                param.Value = cb_evenement.Text;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DGV_Evenement.Visible = true;
                        //panel5.Visible = false;
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Evenement.DataSource = dt;



                    }
                    else
                    {
                        MessageBox.Show("Aucune Resultat");
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

        private void bt_valider_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update   CLIENT_EVENEMENT " +
                    "set NOM_Client=@NomC,PRENOM_CLIENT=@PrenomC,TELEPHONE_CLIENT =@tel,TYPE_EVENEMENT=@type,NOM_EVENEMENT=@NOM_EVENEMENT,DATE_EVENEMENT=@DATE_EVENEMENT,DURE=@DURE_EVENEMENT where ID_CLIENT=@IdC", con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@NomC";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_nomC.Text;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@PrenomC";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_prenomC.Text;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@tel";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_tel.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = type;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOM_EVENEMENT";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_NomE.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DATE_EVENEMENT";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(date_evenement.Value);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DURE_EVENEMENT";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(txt_dure.Text);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@IdC";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Evenement.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);
                //try
                //{
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    //DGV_Evenement.CurrentRow.Cells[2].Value = txt_nom.Text;
                    DGV_Evenement.CurrentRow.Cells[4].Value = txt_nomC.Text;

                    DGV_Evenement.CurrentRow.Cells[5].Value = txt_prenomC.Text;
                    DGV_Evenement.CurrentRow.Cells[6].Value = txt_tel.Text;
                    DGV_Evenement.CurrentRow.Cells[7].Value = type;
                    DGV_Evenement.CurrentRow.Cells[8].Value =txt_NomE.Text;
                    DGV_Evenement.CurrentRow.Cells[9].Value = date_evenement.Value;
                    DGV_Evenement.CurrentRow.Cells[9].Value = date_evenement.Value;
                    DGV_Evenement.CurrentRow.Cells[10].Value = txt_dure.Text;

                    panela.Visible = false;

                }
                DGV_Evenement.Visible = true;
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}

            }



        }

        private void ch_interne_CheckedChanged(object sender, EventArgs e)
        {
            type = "Interne";
        }

        private void ch_Externe_CheckedChanged(object sender, EventArgs e)
        {
            type = "Externe";
        }

        private void DGV_Evenement_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panela.Visible = true;
                DGV_Evenement.Visible = false;
                txt_nomC.Text = DGV_Evenement.CurrentRow.Cells[4].Value.ToString();
                txt_prenomC.Text = DGV_Evenement.CurrentRow.Cells[5].Value.ToString();
                txt_tel.Text= DGV_Evenement.CurrentRow.Cells[6].Value.ToString();
             
                txt_NomE.Text = DGV_Evenement.CurrentRow.Cells[8].Value.ToString();
                date_evenement.Value = DateTime.Parse(DGV_Evenement.CurrentRow.Cells[9].Value.ToString());
                txt_dure.Text = DGV_Evenement.CurrentRow.Cells[10].Value.ToString();
              
               // txt_dure.Text = DGV_Evenement.CurrentRow.Cells[9].Value.ToString();
                //date_evenement.Text = (DGV_Evenement.CurrentRow.Cells[4].Value.ToString());

            }
            if (e.ColumnIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete CLIENT_EVENEMENT  where ID_CLIENT=@id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_Evenement.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        DGV_Evenement.Rows.Remove(DGV_Evenement.CurrentRow);
                    }
                }
            }
        }

        private void panela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_NomE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dure_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
