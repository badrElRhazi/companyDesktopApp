﻿using System;
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
    public partial class MAJPaiementEmploye : Form
    {
        public MAJPaiementEmploye()
        {
            InitializeComponent();
        }
        string paiment;
        Paiement_Classe op = new Paiement_Classe();
        private void MAJPaiementEmploye_Load(object sender, EventArgs e)
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

                        cb_employeS.DisplayMember = "NOM";
                        cb_employeS.ValueMember = "ID_EMPLOYE";
                        cb_employeS.DataSource = dt;


                        DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                        bt.Name = "Modifier";
                        bt.HeaderText = "Opération";
                        bt.Text = "Modifier";
                        bt.UseColumnTextForButtonValue = true;
                        DGV_SalaireE.Columns.Add(bt);


                        DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                        bt1.Name = "Supprimer";
                        bt1.HeaderText = "Opération";
                        bt1.Text = "Supprimer";
                        bt1.UseColumnTextForButtonValue = true;
                        DGV_SalaireE.Columns.Add(bt1);

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

        private void cb_employeS_SelectedIndexChanged(object sender, EventArgs e)
        {
            op.RechercherPaEmploye(Convert.ToInt16(cb_employeS.SelectedValue), DGV_SalaireE);
        }

        private void ch_effectuer_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "Effectuer";
        }

        private void ch_encour_CheckedChanged(object sender, EventArgs e)
        {
            paiment = "En cours";
        }

        private void bt_modifierS_Click(object sender, EventArgs e)
        {
            op.ModifierPaEmploye(DGV_SalaireE, int.Parse(txt_salaire.Text), int.Parse(txt_prime.Text), paiment, date_paiment.Value, txt_nom.Text, txt_prenomE.Text, panel7);
        }

        private void DGV_SalaireE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panel7.Visible = true;
                txt_nom.Text = DGV_SalaireE.CurrentRow.Cells[3].Value.ToString();
                txt_prenomE.Text = DGV_SalaireE.CurrentRow.Cells[4].Value.ToString();

                txt_salaire.Text = DGV_SalaireE.CurrentRow.Cells[5].Value.ToString();
                txt_prime.Text = DGV_SalaireE.CurrentRow.Cells[6].Value.ToString();
                date_paiment.Value = DateTime.Parse(DGV_SalaireE.CurrentRow.Cells[8].Value.ToString());

            }
            if (e.ColumnIndex == 1)
            {
                op.SuppPAIeMPLOYE(DGV_SalaireE);
            }
        }
    }
}
