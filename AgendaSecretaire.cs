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
    public partial class AgendaSecretaire : Form
    {
        public AgendaSecretaire()
        {
            InitializeComponent();
        }
        DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
        DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
        DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn();
        Classes.Agenda_Classe ca;

        private void AgendaSecretaire_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();

                SqlCommand cmd = new SqlCommand("select A. ID_AGENDAEMPLOYE,E.Nom ,A.DATE,A.TITRE from EMPLOYE E inner join AGENDA_EMPLOYE A on A.ID_EMPLOYE=E.ID_EMPLOYE where E.POSTE='Conseiliere Relation Clientéle'", con1);
                try
                {
                    panel4.Visible = false;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Agenda.DataSource = dt;

                        //cb_Date.DisplayMember = "NOM";

                        //cb_Date.ValueMember = "ID_EMPLOYE";

                        //cb_Date.DataSource = dt;
                        //DGV_Congé.DataSource = null;
                        //  cb_emplyeConge.Text = "";
                        // DGV_Congé.DataSource = null;

                        //bt.Name = "Ajouter";
                        //bt.HeaderText = "Opération";
                        //bt.Text = "Nouveau";
                        //bt.UseColumnTextForButtonValue = true;
                        ////bt.Visible = false;
                        //DGV_Agenda.Columns.Add(bt);

                        bt1.Name = "Modifier";
                        bt1.HeaderText = "Opération";
                        bt1.Text = "Modifier";
                        bt1.UseColumnTextForButtonValue = true;
                        //bt.Visible = false;
                        DGV_Agenda.Columns.Add(bt1);



                        bt2.Name = "Supprimer";
                        bt2.HeaderText = "Opération";
                        bt2.Text = "Supprimer";
                        bt2.UseColumnTextForButtonValue = true;

                        DGV_Agenda.Columns.Add(bt2);
                    }
                    else
                    {
                        MessageBox.Show("Aucun Redez-Vous");
                        DGV_Agenda.Visible = false;
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

        private void DGV_Agenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                panel4.Visible = false;
                ca = new Classes.Agenda_Classe();
                ca.Supprimer(DGV_Agenda);


            }
            if (e.ColumnIndex == 4)
            {
                using (SqlConnection con1 = new SqlConnection(Program.connection))
                {
                    con1.Open();

                    SqlCommand cmd = new SqlCommand("select *from EMPLOYE where POSTE='Conseiliere Relation Clientéle'", con1);
                    try
                    {

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {

                            DataTable dt = new DataTable();
                            dt.Load(dr);

                            cb_Date.DisplayMember = "NOM";

                            cb_Date.ValueMember = "ID_EMPLOYE";

                            cb_Date.DataSource = dt;

                            panel4.Visible = true;
                            bt_valider.Visible = false;
                            bt_modifier.Visible = true;

                            dateTimePicker1.Value = DateTime.Parse(DGV_Agenda.CurrentRow.Cells[2].Value.ToString());
                            txt_titre.Text = DGV_Agenda.CurrentRow.Cells[3].Value.ToString();
                            cb_Date.Text = DGV_Agenda.CurrentRow.Cells[1].Value.ToString();

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
        }

        private void bt_nouveau_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            using (SqlConnection con1 = new SqlConnection(Program.connection))
            {
                con1.Open();

                SqlCommand cmd = new SqlCommand("select *from EMPLOYE where POSTE='ConseillereRelationClientele'", con1);
                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        cb_Date.DisplayMember = "NOM";

                        cb_Date.ValueMember = "ID_EMPLOYE";

                        cb_Date.DataSource = dt;

                        panel4.Visible = true;
                        bt_valider.Visible = true;
                        bt_modifier.Visible = false;
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
            ca = new Classes.Agenda_Classe();
            ca.AjouterRendezVous(dateTimePicker1.Value, txt_titre.Text, Convert.ToInt16(cb_Date.SelectedValue));
            panel4.Visible = false;
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            ca = new Classes.Agenda_Classe();
            ca.ModifierConge(dateTimePicker1.Value, txt_titre.Text, Convert.ToInt16(cb_Date.SelectedValue), DGV_Agenda);
            DGV_Agenda.CurrentRow.Cells[1].Value = cb_Date.Text;
            panel4.Visible = false;
        }
    }
}
