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
    public partial class ConsulterFormation : Form
    {
        public ConsulterFormation()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter df = new DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter();
        private void ConsulterFormation_Load(object sender, EventArgs e)
        {
            DGV_Formation.Visible = false;
            //df.Fill(ds.FORMATION_INDIVIDUAL);
            //DGV_Formation.DataSource = ds.FORMATION_INDIVIDUAL;
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "Modifier";
            bt.HeaderText = "Opération";
            bt.Text = "Modifier";
            bt.UseColumnTextForButtonValue = true;
            //DGV_Formation.Columns.Insert(4, bt);
            DGV_Formation.Columns.Add(bt);
            cb_Etat.Items.Add("Fermé");
            cb_Etat.Items.Add("Ouvert");

            cb_etat1.Items.Add("Fermé");
            cb_etat1.Items.Add("Ouvert");

            cb_Mode.Items.Add("Chéque");
            cb_Mode.Items.Add("Virement");
            cb_Mode.Items.Add("Versement");

            //DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
            //bt1.Name = "Supprimer";
            //bt1.HeaderText = "Opération";
            //bt1.Text = "Supprimer";
            //bt1.UseColumnTextForButtonValue = true;
            //DGV_Formation.Columns.Add(bt1);
        }

        private void DGV_formation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panel5.Visible = true;
                DGV_Formation.Visible = false;
                txt_nom.Text=DGV_Formation.CurrentRow.Cells[2].Value.ToString();
                txt_secteur.Text= DGV_Formation.CurrentRow.Cells[3].Value.ToString();
                cb_Mode.Text= DGV_Formation.CurrentRow.Cells[4].Value.ToString();
                cb_etat1.Text= DGV_Formation.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void cb_Etat_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from  FORMATION_INDIVIDUAL  where Etat=@etat", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@etat";
                param.SqlDbType = SqlDbType.VarChar;

                param.Value =cb_Etat.Text;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Formation.DataSource = dt;
                        DGV_Formation.Visible = true;


                    }
                    else
                    {
                        MessageBox.Show("Aucune Resultat");
                        DGV_Formation.Visible = false;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            DGV_Formation.Visible = true;
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update  FORMATION_INDIVIDUAL " +
                    "Set NOM_FR=@NOM_For, SECTEUR_ACTIVITE=@Secteur, MODE_REGLEMENT=@Mode, Etat=@Etat  where ID_FORMATIONINDIVIDUAL=@idF", con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@idF";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Formation.CurrentRow.Cells[1].Value;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@NOM_For";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value =txt_nom.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Secteur";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txt_secteur.Text;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@Mode";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_Mode.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Etat";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_etat1.Text;
                cmd.Parameters.Add(param);


                try
                {
                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");
                        panel5.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");
                        //DGV_Convention.CurrentRow.Cells[2].Value = cb_id.SelectedValue;

                        DGV_Formation.CurrentRow.Cells[2].Value = txt_nom.Text;
                        DGV_Formation.CurrentRow.Cells[3].Value = txt_secteur.Text;
                        DGV_Formation.CurrentRow.Cells[4].Value = cb_Mode.Text;
                        DGV_Formation.CurrentRow.Cells[5].Value = cb_etat1.Text;




                        panel5.Visible = false;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
