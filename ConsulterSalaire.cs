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
    public partial class ConsulterSalaire : Form
    {
        public ConsulterSalaire()
        {
            InitializeComponent();
        }
        string paiment;
        Paiement_Classe op = new Paiement_Classe();
        private void DGV_Salaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

                if (e.ColumnIndex == 0)
                {
                    panel5.Visible = true;
                    txt_nom.Text = DGV_Salaire.CurrentRow.Cells[3].Value.ToString();
                    txt_prenomE.Text = DGV_Salaire.CurrentRow.Cells[4].Value.ToString();
                   
                    txt_salaire.Text = DGV_Salaire.CurrentRow.Cells[5].Value.ToString();
                    txt_prime.Text = DGV_Salaire.CurrentRow.Cells[6].Value.ToString();
                    date_paiment.Value = DateTime.Parse(DGV_Salaire.CurrentRow.Cells[8].Value.ToString());
                   
                }
                if (e.ColumnIndex == 1)
                {
                op.SuppPaiementFormateur(DGV_Salaire);
                }
            
        }

        private void ConsulterSalaire_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select *from FORMATEUR", con1);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_employeS.DisplayMember = "NOM";
                        cb_employeS.ValueMember = "ID_FORMATEUR";
                        cb_employeS.DataSource = dt;


                        DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                        bt.Name = "Modifier";
                        bt.HeaderText = "Opération";
                        bt.Text = "Modifier";
                        bt.UseColumnTextForButtonValue = true;
                        DGV_Salaire.Columns.Add(bt);


                        DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                        bt1.Name = "Supprimer";
                        bt1.HeaderText = "Opération";
                        bt1.Text = "Supprimer";
                        bt1.UseColumnTextForButtonValue = true;
                        DGV_Salaire.Columns.Add(bt1);

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

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
           
        }

        private void ch_effectuer_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "effectuer";
        }

        private void ch_encour_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "En cours";
        }

        private void bt_modifierS_Click(object sender, EventArgs e)
        {
            op.ModifierPaiementFormateur(DGV_Salaire, int.Parse(txt_salaire.Text), int.Parse(txt_prime.Text), paiment, date_paiment.Value, txt_nom.Text, txt_prenomE.Text,panel5);
        }

        private void cb_employeS_SelectedIndexChanged(object sender, EventArgs e)
        {
            op.RechercherPaiFormateur(DGV_Salaire, Convert.ToInt16(cb_employeS.SelectedValue));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
