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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnx = new SqlConnection(Program.connection))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select ID_CLIENT_SALLE 'Numéro client',CIN_CLIENT 'CIN',NOM_Client 'Nom Client',PRENOM_CLIENT 'Prénom Client',TELEPHONE_CLIENT 'Téléphone', type 'Type Salle', dateDebut 'Date Début',dateFin 'Date Fin' from CLIENT_SALLE C Order by dateDebut DESC", cnx);

                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Reservation.DataSource = dt;
                    }
                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                    bt.Name = "Modifier";
                    bt.HeaderText = "Opération";
                    bt.Text = "Modifier";
                    bt.UseColumnTextForButtonValue = true;
                    DGV_Reservation.Columns.Add(bt);


                    DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                    bt1.Name = "Supprimer";
                    bt1.HeaderText = "Opération";
                    bt1.Text = "Supprimer";
                    bt1.UseColumnTextForButtonValue = true;
                    DGV_Reservation.Columns.Add(bt1);

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
                SqlCommand cmd = new SqlCommand("update   CLIENT_SALLE " +
                    "set NOM_Client=@NomC,PRENOM_CLIENT=@PrenomC,TELEPHONE_CLIENT =@tel,type=@type,dateDebut=@DATED,dateFin=@DATEF where ID_CLIENT_SALLE=@IdC", con);

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
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_typeSalle.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@tel";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_tel.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DATED";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(date_evenement.Value);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DATEF";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(dateTimePicker1.Value);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@IdC";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Reservation.CurrentRow.Cells[0].Value;
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
                    DGV_Reservation.CurrentRow.Cells[2].Value = txt_nomC.Text;

                    DGV_Reservation.CurrentRow.Cells[3].Value = txt_prenomC.Text;
                    DGV_Reservation.CurrentRow.Cells[4].Value = txt_tel.Text;
                    DGV_Reservation.CurrentRow.Cells[5].Value = cb_typeSalle.Text;
                    //DGV_Reservation.CurrentRow.Cells[11].Value = txt_NomE.Text;
                    DGV_Reservation.CurrentRow.Cells[6].Value = date_evenement.Value;
                    DGV_Reservation.CurrentRow.Cells[7].Value = dateTimePicker1.Value;

                    panela.Visible = false;

                }
                DGV_Reservation.Visible = true;
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}

            }


        }

        private void DGV_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                panela.Visible = true;
                DGV_Reservation.Visible = false;
                txt_nomC.Text = DGV_Reservation.CurrentRow.Cells[2].Value.ToString();
                txt_prenomC.Text = DGV_Reservation.CurrentRow.Cells[3].Value.ToString();
                txt_tel.Text = DGV_Reservation.CurrentRow.Cells[4].Value.ToString();
                cb_typeSalle.Text = DGV_Reservation.CurrentRow.Cells[5].Value.ToString();
                date_evenement.Value = DateTime.Parse(DGV_Reservation.CurrentRow.Cells[6].Value.ToString());
                dateTimePicker1.Value = DateTime.Parse(DGV_Reservation.CurrentRow.Cells[7].Value.ToString());

                // txt_dure.Text = DGV_Evenement.CurrentRow.Cells[9].Value.ToString();
                //date_evenement.Text = (DGV_Evenement.CurrentRow.Cells[4].Value.ToString());

            }
            if (e.ColumnIndex == 9)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete CLIENT_SALLE  where ID_CLIENT_SALLE=@id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_Reservation.CurrentRow.Cells[0].Value;
                    cmd.Parameters.Add(param);
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");
                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        DGV_Reservation.Rows.Remove(DGV_Reservation.CurrentRow);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nomC.Clear();
            txt_prenomC.Clear();
            txt_tel.Clear();
            cb_typeSalle.Text = "";

        }
    }
}
