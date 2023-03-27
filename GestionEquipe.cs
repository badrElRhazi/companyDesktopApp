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
    public partial class GestionEquipe : Form
    {
        public GestionEquipe()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        DataSet1TableAdapters.ADHERENTTableAdapter da = new DataSet1TableAdapters.ADHERENTTableAdapter();
        DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter df = new DataSet1TableAdapters.FORMATION_INDIVIDUALTableAdapter();
        DataSet1TableAdapters.EQUIPETableAdapter de = new DataSet1TableAdapters.EQUIPETableAdapter();
        DataSet1TableAdapters.EquipeAdherentTableAdapter dea = new DataSet1TableAdapters.EquipeAdherentTableAdapter();
        //----------------------------------------
        /*SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-1ASM0A6;Initial Catalog=ProjetFinFormationSiteWeb;" + "Integrated Security=true");
        SqlDataAdapter df = new SqlDataAdapter(Select * from db.FORMATION_INDIVIDUAL)
        SqlDataAdapter de = new SqlDataAdapter("select * from EQUIPE", con1);
        SqlDataAdapter dea = new SqlDataAdapter("select * from ADHERENT", con1);*/

        //----------------------------------------
        static private Form activeForm = null;
        DataRow dr;
        private void GestionEquipe_Load(object sender, EventArgs e)
        {
            da.Fill(ds.ADHERENT);
            df.Fill(ds.FORMATION_INDIVIDUAL);
            de.Fill(ds.EQUIPE);
            dea.Fill(ds.EquipeAdherent);
            
            cb_Formation.DisplayMember = ds.FORMATION_INDIVIDUAL.NOM_FRColumn.ColumnName;
            cb_Formation.ValueMember = ds.FORMATION_INDIVIDUAL.ID_FORMATIONINDIVIDUALColumn.ColumnName;
            cb_Formation.DataSource = ds.FORMATION_INDIVIDUAL;

            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.Name = "cb_equipe";
            cb.HeaderText = "Equipe";
            var query =
                      from eq in ds.EQUIPE
                      join fo in ds.FORMATION_INDIVIDUAL on eq.ID_FORMATIONINDIVIDUAL equals fo.ID_FORMATIONINDIVIDUAL
                      where eq.ID_FORMATIONINDIVIDUAL == Convert.ToInt16(cb_Formation.SelectedValue)
                      select eq;

            cb.DisplayMember = ds.EQUIPE.NOM_EQUIPEColumn.ColumnName;
            cb.ValueMember = ds.EQUIPE.ID_EQUIPEColumn.ColumnName;
            cb.DataSource = query.ToList();
            DGV_Equipe1.Columns.Add(cb);

            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "bt_Ajouter";
            bt.HeaderText = "Opération";
            bt.Text = "Ajouter";
            bt.UseColumnTextForButtonValue = true;
            DGV_Equipe1.Columns.Add(bt);
        }

        private void cb_Formation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV_Equipe1.Visible = true;




            var query1 =
                     from ad in ds.ADHERENT
                     join fo in ds.FORMATION_INDIVIDUAL on ad.ID_FORMATIONINDIVIDUAL equals fo.ID_FORMATIONINDIVIDUAL
                     where ad.ID_FORMATIONINDIVIDUAL == Convert.ToInt16(cb_Formation.SelectedValue)
                     select new
                     {
                         Id = ad.ID_ADHERENT,
                         CIN = ad.CIN,
                         Nom = ad.NOM,
                         Prénom = ad.PRENOM,
                         DateN = ad.DATE_NAISSANCE,
                         Adresse = ad.ADRESSE,
                         Sexe = ad.SEXE,
                         Téléphone = ad.TELEPHONE,
                         formation = fo.NOM_FR,
                     };
            DGV_Equipe1.DataSource = query1.ToList();


        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void DGV_Equipe1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex == 10)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("NbrEquipe", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = cmd.Parameters.Add("@Equipe", SqlDbType.Int);
                    param.Direction = ParameterDirection.Input;
                    param = cmd.Parameters.Add("@nbr", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters["@Equipe"].Value = DGV_Equipe1.CurrentRow.Cells[9].Value;
                    cmd.ExecuteNonQuery();
                   
                    //txt_duree.Text = cmd.Parameters["@nbr"].Value.ToString();


                    int i = (int)cmd.Parameters["@nbr"].Value;
                    cmd = new SqlCommand("select NOMBRE from EQUIPE",con);
                    int nbrMembre = (int)cmd.ExecuteScalar();
                    //i = cmd.Parameters["nbr"].Value;
                    //string i = cmd.Parameters["@nbr"].Value.ToString();

                    if (i <= nbrMembre)
                    {
                        MessageBox.Show("Cette Equipe est Plein");
                    }
                    else
                    {
                        dr = ds.EquipeAdherent.NewRow();
                        dr[0] = DGV_Equipe1.CurrentRow.Cells[9].Value;
                        dr[1] = DGV_Equipe1.CurrentRow.Cells[0].Value.ToString();
                        ds.EquipeAdherent.Rows.Add(dr);
                        MessageBox.Show("Operation ok");
                        DGV_Equipe1.Rows.Remove(DGV_Equipe1.CurrentRow);
                        dea.Update(ds.EquipeAdherent);
                    }




                }


                
            }
        }

        private void GestionEquipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                da.Update(ds.ADHERENT);
                df.Update(ds.FORMATION_INDIVIDUAL);
                dea.Update(ds.EquipeAdherent);
                de.Update(ds.EQUIPE);

            }
            catch (Exception)
            {

                MessageBox.Show("Validation non");
            }
        }

        private void bt_imprimer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FicheAdherents fa = new FicheAdherents();
            //fa.Show();

          
        }

        private void bt_Imprimer1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(Program.connection))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("select NOMBRE from EQUIPE where ID_FORMATIONINDIVIDUAL=@formation", con);
            //    SqlParameter param = new SqlParameter();
            //    param.ParameterName = "@formation";
            //    param.SqlDbType = SqlDbType.Int;
            //    param.Value = Convert.ToInt16(cb_Formation.SelectedValue);
            //    cmd.Parameters.Add(param);
            //    int  i = (Int16) cmd.ExecuteScalar();
            //    if (i == nbr)
            //    {
            //        MessageBox.Show("Cette Equipe Est Plein");
            //    }
            //    else
            //    {

            //    }
            //}
        }

        private void cb_Formation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DGV_Equipe1.Visible = true;




            var query1 =
                     from ad in ds.ADHERENT
                     join fo in ds.FORMATION_INDIVIDUAL on ad.ID_FORMATIONINDIVIDUAL equals fo.ID_FORMATIONINDIVIDUAL
                     where ad.ID_FORMATIONINDIVIDUAL == Convert.ToInt16(cb_Formation.SelectedValue)
                     select new
                     {
                         Id = ad.ID_ADHERENT,
                         CIN = ad.CIN,
                         Nom = ad.NOM,
                         Prénom = ad.PRENOM,
                         DateN = ad.DATE_NAISSANCE,
                         Adresse = ad.ADRESSE,
                         Sexe = ad.SEXE,
                         Téléphone = ad.TELEPHONE,
                         formation = fo.NOM_FR,
                     };
            DGV_Equipe1.DataSource = query1.ToList();

        }

        private void DGV_Equipe1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("NbrEquipe", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = cmd.Parameters.Add("@Equipe", SqlDbType.Int);
                    param.Direction = ParameterDirection.Input;
                    param = cmd.Parameters.Add("@nbr", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters["@Equipe"].Value = DGV_Equipe1.CurrentRow.Cells[9].Value;
                    cmd.ExecuteNonQuery();

                    //txt_duree.Text = cmd.Parameters["@nbr"].Value.ToString();


                    int i = (int)cmd.Parameters["@nbr"].Value;
                    cmd = new SqlCommand("select NOMBRE from EQUIPE", con);
                    int nbrMembre = (int)cmd.ExecuteScalar();
                    //i = cmd.Parameters["nbr"].Value;
                    //string i = cmd.Parameters["@nbr"].Value.ToString();

                    if (i <= nbrMembre)
                    {
                        MessageBox.Show("Cette Equipe est Plein");
                    }
                    else
                    {
                        dr = ds.EquipeAdherent.NewRow();
                        dr[0] = DGV_Equipe1.CurrentRow.Cells[9].Value;
                        dr[1] = DGV_Equipe1.CurrentRow.Cells[0].Value.ToString();
                        ds.EquipeAdherent.Rows.Add(dr);
                        MessageBox.Show("Operation ok");
                        DGV_Equipe1.Rows.Remove(DGV_Equipe1.CurrentRow);
                        dea.Update(ds.EquipeAdherent);
                    }




                }



            }
        }

        private void bt_imprimer_Click_1(object sender, EventArgs e)
        {
            //FicheAdherents cs = new FicheAdherents();
            //if (cs == null)
            //{
            //    cs = new FicheAdherents();
            //}
            //else
            //{
            //    if (cs.IsDisposed)
            //    {
            //        cs = new FicheAdherents();
            //    }
            //}
            //Program.Change(cs, panel3);
            //this.Hide();
            FicheAdherents fa = new FicheAdherents();
            // fa.Tag = panel3;
            activeForm = fa;
            fa.TopLevel = false;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.Dock = DockStyle.Fill;

            fa.Dock = DockStyle.Fill;
            panel3.Controls.Add(fa);
            panel3.Tag = fa;
            fa.BringToFront();
            fa.Show();
        }
    }
}
