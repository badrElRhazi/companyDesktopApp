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
    public partial class ConsulterEquipe : Form
    {
        public ConsulterEquipe()
        {
            InitializeComponent();
        }
        string type;
        private void DGV_Equipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                AjouterEquipe oe= new AjouterEquipe();
                oe.Show();
            }
        }

        private void ConsulterEquipe_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select *from EQUIPE", con1);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_equipe.DisplayMember = "NOM_EQUIPE";
                        cb_equipe.ValueMember = "ID_EQUIPE";
                        cb_equipe.DataSource = dt;

                        cmd = new SqlCommand("select *from FORMATION_INDIVIDUAL", con1);
                        dr = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(dr);

                        cb_formation.DisplayMember = "NOM_FR";
                        cb_formation.ValueMember = "ID_FORMATIONINDIVIDUAL";
                        cb_formation.DataSource = dt;

                        cmd = new SqlCommand("select *from EMPLOYE", con1);
                        dr = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(dr);

                        cb_employe.DisplayMember = "NOM";
                        cb_employe.ValueMember = "ID_EMPLOYE";
                        cb_employe.DataSource = dt;

                    }

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                    bt.Name = "Modifier";
                    bt.HeaderText = "Opération";
                    bt.Text = "Modifier";
                    bt.UseColumnTextForButtonValue = true;
                    DGV_Equipe.Columns.Add(bt);


                    DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                    bt1.Name = "Supprimer";
                    bt1.HeaderText = "Opération";
                    bt1.Text = "Supprimer";
                    bt1.UseColumnTextForButtonValue = true;
                    DGV_Equipe.Columns.Add(bt1);


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

        private void cb_equipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select C.ID_EQUIPE as 'Numéro Equipe',C.NOM_EQUIPE as 'Nom Equipe',C.NOMBRE as 'Nombre Equipe',F.NOM_FR as 'Nom Formation' ,E.NOM 'Responsable' from  FORMATION_INDIVIDUAL F inner join EQUIPE C  on F.ID_FORMATIONINDIVIDUAL=C.ID_FORMATIONINDIVIDUAL  inner join EMPLOYE E on E.ID_EMPLOYE=C.ID_EMPLOYE where C.ID_EQUIPE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Convert.ToInt16(cb_equipe.SelectedValue);
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Equipe.DataSource = dt;



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
                SqlCommand cmd = new SqlCommand("update  EQUIPE " +
                    "Set ID_EMPLOYE=@employe ,NOM_EQUIPE=@NOM_EQUIPE, NOMBRE=@NOMBRE, ID_FORMATIONINDIVIDUAL=@formation  where ID_EQUIPE=@ID_EQUIPE", con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID_EQUIPE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Equipe.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@NOM_EQUIPE";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_NomEquipe.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@NOMBRE";
                param.SqlDbType = SqlDbType.Int;
                param.Value = int.Parse(txt_nbr.Text);
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@formation";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Convert.ToInt16(cb_formation.SelectedValue);
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@employe";
                param.SqlDbType = SqlDbType.Int;
                param.Value = Convert.ToInt16(cb_employe.SelectedValue);
                cmd.Parameters.Add(param);


                try
                {
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");
                        panela.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        //DGV_Convention.CurrentRow.Cells[2].Value = cb_id.SelectedValue;
                        DGV_Equipe.CurrentRow.Cells[6].Value = cb_employe.Text;
                        DGV_Equipe.CurrentRow.Cells[3].Value = txt_NomEquipe.Text;
                        DGV_Equipe.CurrentRow.Cells[4].Value = txt_nbr.Text;
                        DGV_Equipe.CurrentRow.Cells[5].Value = cb_formation.Text;
                        //DGV_Equipe.CurrentRow.Cells[4].Value = cb_employe.Text;




                        panela.Visible = false;
                        DGV_Equipe.Visible = true;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

       

        private void DGV_Equipe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panela.Visible = true;
                DGV_Equipe.Visible = false;
                cb_employe.Text = DGV_Equipe.CurrentRow.Cells[6].Value.ToString();

                txt_NomEquipe.Text = DGV_Equipe.CurrentRow.Cells[3].Value.ToString();
               
                txt_nbr.Text = DGV_Equipe.CurrentRow.Cells[4].Value.ToString();

                cb_formation.Text = DGV_Equipe.CurrentRow.Cells[5].Value.ToString();

              

                //dateTimePicker1.Text = DGV_Convention.CurrentRow.Cells[6].Value.ToString();


            }
            if (e.ColumnIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete EQUIPE  where ID_EQUIPE=@id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_Equipe.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        DGV_Equipe.Rows.Remove(DGV_Equipe.CurrentRow);
                    }
                }
            }
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            cb_employe.Text = "";
            txt_NomEquipe.Clear();
            txt_nbr.Clear();
            cb_formation.Text = "";

        }
    }
}
