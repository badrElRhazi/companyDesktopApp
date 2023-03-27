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
    public partial class ConsulterSalle : Form
    {
        public ConsulterSalle()
        {
            InitializeComponent();
        }
        string dispo;
        private void DGV_salle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Salle os1 = new Salle();
                os1.Show();
            }
        }

        private void ConsulterSalle_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select *from SALLE", con1);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_Salle.DisplayMember = "ID_SALLE";
                        cb_Salle.ValueMember = "ID_SALLE";
                        cb_Salle.DataSource = dt;


                    }

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                    bt.Name = "Modifier";
                    bt.HeaderText = "Opération";
                    bt.Text = "Modifier";
                    bt.UseColumnTextForButtonValue = true;
                    DGV_salle.Columns.Add(bt);


                    DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                    bt1.Name = "Supprimer";
                    bt1.HeaderText = "Opération";
                    bt1.Text = "Supprimer";
                    bt1.UseColumnTextForButtonValue = true;
                    DGV_salle.Columns.Add(bt1);


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

        private void cb_Salle_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select C.ID_SALLE as 'ID',C.ID_EVENEMENT as 'Id Evenement',C.CAPACITE as 'Capacite',C.DISPONIBILITE as 'Disponibilite',C.PRIX as'Prix Salle' from SALLE C where C.ID_SALLE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Convert.ToInt16(cb_Salle.SelectedValue);
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_salle.DataSource = dt;



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
                SqlCommand cmd = new SqlCommand("update  SALLE " +
                    "Set  ID_EVENEMENT=@ID_EVENEMENT, CAPACITE=@CAPACITE, DISPONIBILITE=@DISPONIBILITE,PRIX=@PRIX  from SALLE where ID_SALLE=@ID_SALLE", con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID_SALLE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_salle.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@ID_EVENEMENT";
                param.SqlDbType = SqlDbType.Int;
                param.Value = Convert.ToInt32(cb_evenement.Text);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@CAPACITE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(txt_capacite.Text);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DISPONIBILITE";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = dispo;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@PRIX";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(txt_prix.Text);
                cmd.Parameters.Add(param);

                //param = new SqlParameter();
                //param.ParameterName = "@DURE_EVENEMENT";
                //param.SqlDbType = SqlDbType.Int;
                //param.Value = int.Parse(txt_dure.Text);
                //cmd.Parameters.Add(param);

                //param = new SqlParameter();
                //param.ParameterName = "@PRIX_EVENEMENT";
                //param.SqlDbType = SqlDbType.Int;
                //param.Value = int.Parse(txt_prix.Text);
                //cmd.Parameters.Add(param);
                try
                {
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        //DGV_Convention.CurrentRow.Cells[2].Value = cb_id.SelectedValue;
                        DGV_salle.CurrentRow.Cells[3].Value = cb_evenement.Text;
                        DGV_salle.CurrentRow.Cells[4].Value = txt_capacite.Text;
                        DGV_salle.CurrentRow.Cells[5].Value = dispo;

                        DGV_salle.CurrentRow.Cells[6].Value = txt_prix.Text;

                        //cb_Salle.Text = CB.Text;
                        panela.Visible = false;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void rd_Indisponible_CheckedChanged(object sender, EventArgs e)
        {
            dispo = "Indisponible";
        }

        private void rd_dispo_CheckedChanged(object sender, EventArgs e)
        {
            dispo = "Disponible";
        }
    }
}
