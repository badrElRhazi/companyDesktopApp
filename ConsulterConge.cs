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
    public partial class ConsulterConge : Form
    {
        public ConsulterConge()
        {
            InitializeComponent();
        }
        Classes.Conge_Classe OC;
        DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
        DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();



        private void DGV_Congé_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                pa_modifierC.Visible = true;
                //pa_modifierC.Show();
                txt_nome.Text = DGV_Congé.CurrentRow.Cells[3].Value.ToString();
                txt_prenom.Text = DGV_Congé.CurrentRow.Cells[4].Value.ToString();
                //  txt_cin.Text = DGV_Congé.CurrentRow.Cells[3].Value.ToString();
                date_debut.Value = DateTime.Parse(DGV_Congé.CurrentRow.Cells[5].Value.ToString());
                date_fin.Value = DateTime.Parse(DGV_Congé.CurrentRow.Cells[6].Value.ToString());
                txtx_Duree.Text = DGV_Congé.CurrentRow.Cells[7].Value.ToString();
                
            }
            else
            {
                OC = new Classes.Conge_Classe();
                OC.Supprimer(pa_modifierC, DGV_Congé);


            }
        }
        private void ConsulterConge_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                
                SqlCommand cmd = new SqlCommand("select *from EMPLOYE", con1);
                try
                {
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                      
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_emplyeConge.DisplayMember = "NOM";

                        cb_emplyeConge.ValueMember = "ID_EMPLOYE";

                        cb_emplyeConge.DataSource = dt;
                       
                        
                            bt.Name = "Modifier";
                            bt.HeaderText = "Opération";
                            bt.Text = "Modifier";
                            bt.UseColumnTextForButtonValue = true;
                            //bt.Visible = false;
                            DGV_Congé.Columns.Add(bt);



                            bt1.Name = "Supprimer";
                            bt1.HeaderText = "Opération";
                            bt1.Text = "Supprimer";
                            bt1.UseColumnTextForButtonValue = true;
                            //bt1.Visible = false;
                            DGV_Congé.Columns.Add(bt1);
                        
                       
                      
                        //DGV_Congé.Rows.Clear();
                        //DGV_Congé.Visible = false;







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

        private void cb_emplyeConge_SelectedIndexChanged(object sender, EventArgs e)
        {

            DGV_Congé.Visible = true;
            OC = new Classes.Conge_Classe();
            OC.Recherche(Convert.ToInt16(cb_emplyeConge.SelectedValue), DGV_Congé);

        }

        private void bt_modufierConge_Click(object sender, EventArgs e)
        {
            OC = new Classes.Conge_Classe();
            OC.ModifierConge(date_debut.Value,date_fin.Value,int.Parse(txtx_Duree.Text),DGV_Congé,pa_modifierC,txt_nome.Text,txt_prenom.Text);
          
        }

        

        private void DGV_Congé_Click(object sender, EventArgs e)
        {
           

        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
          

            //bt1.Visible = true;
            //bt.Visible = true;

            //using (SqlConnection con = new SqlConnection(Program.connection))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("select E.Id_Employe,E.Nom_Employe,E.Prenom_Employe,C.DateDebut_Conge,C.DateFin_Conge,C.Descision from Employe E inner join Conge C on E.Id_Employe=C.Id_Employe where E.Id_Employe=@id", con);
            //    SqlParameter param = new SqlParameter();
            //    param.ParameterName = "@id";
            //    param.SqlDbType = SqlDbType.Int;

            //    param.Value = Convert.ToInt16(cb_emplyeConge.SelectedValue);
            //    cmd.Parameters.Add(param);
            //    try
            //    {
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        if (dr.HasRows)
            //        {
            //            DataTable dt = new DataTable();
            //            dt.Load(dr);
            //            DGV_Congé.DataSource = dt;
            //            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            //            bt.Name = "Modifier";
            //            bt.HeaderText = "Opération";
            //            bt.Text = "Modifier";
            //            bt.UseColumnTextForButtonValue = true;
            //            DGV_Congé.Columns.Add(bt);


            //            DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
            //            bt1.Name = "Supprimer";
            //            bt1.HeaderText = "Opération";
            //            bt1.Text = "Supprimer";
            //            bt1.UseColumnTextForButtonValue = true;
            //            DGV_Congé.Columns.Add(bt1);


            //        }
            //        else
            //        {
            //            MessageBox.Show("Aucune Resultat");
            //        }


            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //}
        }

        private void pa_modifierC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
