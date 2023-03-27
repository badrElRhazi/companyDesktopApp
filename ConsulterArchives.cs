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
    public partial class ConsulterArchives : Form
    {
        public ConsulterArchives()
        {
            InitializeComponent();
        }
        string connection = @"Data Source = DESKTOP-OM8F40H\SQLEXPRESS; Initial Catalog=ProjetFinFormation1 ;" + "Integrated Security=true";
        private void DGV_Archive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //Archives oe = new Archives();
                //oe.Show();
                panel5.Visible = true;
                cb_archive.Text = DGV_Archive.CurrentRow.Cells[1].Value.ToString();
                txtx_nomA.Text = DGV_Archive.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker2.Value= DateTime.Parse( DGV_Archive.CurrentRow.Cells[3].Value.ToString());
               
            }
            if (e.ColumnIndex == 5)
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete Archives  where Id_Archive=@id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                   
                    param.Value = DGV_Archive.CurrentRow.Cells[0].Value;
                    cmd.Parameters.Add(param);
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        DGV_Archive.Rows.Remove(DGV_Archive.CurrentRow);
                    }
                }
            }
        }

        private void ConsulterArchives_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection con1 = new SqlConnection(connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select *from Archives", con1);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_typeArchive.Items.Add("evenement");
                        cb_typeArchive.Items.Add("Formation");
                        cb_typeArchive.Items.Add("Convention");

                       
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

        private void cb_typeArchive_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Archives where Type_Archive=@type", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_typeArchive.Text;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Archive.DataSource = dt;
                        DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                        bt.Name = "Modifier";
                        bt.HeaderText = "Opération";
                        bt.Text = "Modifier";
                        bt.UseColumnTextForButtonValue = true;
                        DGV_Archive.Columns.Add(bt);


                        DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                        bt1.Name = "Supprimer";
                        bt1.HeaderText = "Opération";
                        bt1.Text = "Supprimer";
                        bt1.UseColumnTextForButtonValue = true;
                        DGV_Archive.Columns.Add(bt1);

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

        private void bt_modufierArchive_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Archives set Type_Archive=@type ,Nom_Archive=@nom,Date_Archive=@date where Id_Archive=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Archive.CurrentRow.Cells[0].Value;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_archive.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@nom";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txtx_nomA.Text;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@date";
                param.SqlDbType = SqlDbType.Date;
                // param.Size = 30;
                param.Value = dateTimePicker2.Value;
                cmd.Parameters.Add(param);

                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Archive.CurrentRow.Cells[1].Value = cb_archive.Text ;
                    DGV_Archive.CurrentRow.Cells[2].Value= txtx_nomA.Text;
                   DGV_Archive.CurrentRow.Cells[3].Value = dateTimePicker2.Value ;
                    panel5.Visible = false;

                }
            }

        }
    }
}
