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
    public partial class ConsulterConvention : Form
    {
        public ConsulterConvention()
        {
            InitializeComponent();
        }
        string type;
        private void DGV_Convention_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ConsulterConvention_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
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

                        cb_Employe.DisplayMember = "NOM";
                        cb_Employe.ValueMember = "ID_EMPLOYE";
                        cb_Employe.DataSource = dt;

                        cb_convention.Items.Add("Etat");
                        cb_convention.Items.Add("Privée");


                    }

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                    bt.Name = "Modifier";
                    bt.HeaderText = "Opération";
                    bt.Text = "Modifier";
                    bt.UseColumnTextForButtonValue = true;
                    DGV_Convention.Columns.Add(bt);


                    DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                    bt1.Name = "Supprimer";
                    bt1.HeaderText = "Opération";
                    bt1.Text = "Supprimer";
                    bt1.UseColumnTextForButtonValue = true;
                    DGV_Convention.Columns.Add(bt1);


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

        private void cb_convention_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select C.ID_CONVENTION as 'ID',ID_EMPLOYE as 'Employe',C.TYPE_CONVENTION as 'Type Convention' ,C.NOM_CONVENTION as 'NOM CONVENTION',C.DATE_CONVENTION as 'Date Convention' from CONVENTION C where C.TYPE_CONVENTION=@type", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_convention.Text;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DGV_Convention.Visible = true;
                        ///panel5.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Convention.DataSource = dt;



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
                SqlCommand cmd = new SqlCommand("update  CONVENTION " +
                    "Set   ID_EMPLOYE=@ID_EMPLOYE, TYPE_CONVENTION=@TYPE_CONVENTION , NOM_CONVENTION=@NOM_CONVENTION, DATE_CONVENTION=@DATE_CONVENTION  from CONVENTION where ID_CONVENTION=@ID_CONVENTION", con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID_CONVENTION";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Convention.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);



                param = new SqlParameter();
                param.ParameterName = "@ID_EMPLOYE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = Convert.ToInt16(cb_convention.SelectedValue);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TYPE_CONVENTION";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = type;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOM_CONVENTION";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_nom.Text;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@DATE_CONVENTION";
                param.SqlDbType = SqlDbType.DateTime;
                param.Value = Convert.ToDateTime(dateTimePicker1.Value);
                cmd.Parameters.Add(param);

                
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
                        DGV_Convention.CurrentRow.Cells[3].Value = cb_Employe.Text;
                        DGV_Convention.CurrentRow.Cells[4].Value = type;
                        DGV_Convention.CurrentRow.Cells[5].Value = txt_nom.Text;

                        DGV_Convention.CurrentRow.Cells[6].Value = dateTimePicker1.Value;

                        cb_convention.Text = type;
                        panela.Visible = false;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void rd_Etat_CheckedChanged(object sender, EventArgs e)
        {
            type = "Etat";
        }

        private void rd_Prive_CheckedChanged(object sender, EventArgs e)
        {
            type = "Prive";
        }

        private void DGV_Convention_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panela.Visible = true;
               
                cb_Employe.Text = DGV_Convention.CurrentRow.Cells[3].Value.ToString();
                type = DGV_Convention.CurrentRow.Cells[4].Value.ToString();
                txt_nom.Text = DGV_Convention.CurrentRow.Cells[5].Value.ToString();

                //dateTimePicker1.Text = DGV_Convention.CurrentRow.Cells[6].Value.ToString();


            }
            if (e.ColumnIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete CONVENTION  where ID_CONVENTION=@id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_Convention.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        DGV_Convention.Rows.Remove(DGV_Convention.CurrentRow);
                    }
                }
            }

        }
    }
}
