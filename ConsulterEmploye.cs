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
    public partial class ConsulterEmploye : Form
    {
        public ConsulterEmploye()
        {
            InitializeComponent();
        }


        private void ConsulterEmploye_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Agent Administratif");
            comboBox1.Items.Add("Directeur");
            comboBox1.Items.Add("Conseiliere Relation Clientéle");
            comboBox1.Items.Add("Formateur");
            comboBox1.Items.Add("Responsable Formation");

            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "Modifier";
            bt.HeaderText = "Opération";
            bt.Text = "Modifier";
            bt.UseColumnTextForButtonValue = true;
            DGV_employe.Columns.Add(bt);


            DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
            bt1.Name = "Supprimer";
            bt1.HeaderText = "Opération";
            bt1.Text = "Supprimer";
            bt1.UseColumnTextForButtonValue = true;
            DGV_employe.Columns.Add(bt1);
            DGV_employe.Visible = false;

            //using (SqlConnection cnx = new SqlConnection(Program.connection))
            //{
            //    cnx.Open();
            //    SqlCommand cmd;
            //    DataTable dt;


            //    try
            //    {

            //        cmd = new SqlCommand("select * from EMPLOYE", cnx);


            //        SqlDataReader dr = cmd.ExecuteReader();
            //        if (dr.HasRows)
            //        {
            //            dt = new DataTable();
            //            dt.Load(dr);
            //            comboBox1.DisplayMember = "POSTE";
            //            comboBox1.ValueMember = "ID_EMPLOYE";
            //            comboBox1.DataSource = dt;

            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);

            //    }
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel5.Visible = false;
            if (comboBox1.Text == "Formateur")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    DGV_employe.Visible = true;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select ID_FORMATEUR as'Identifiant', NOM as'Nom' ,PRENOM as 'Prénom' ,DATE_NAISSANCE as 'Date Naissance' ,LIEU_NAISSANCE as 'Lieu'," +
                        "ADRESSE as 'Adresse',TELEPHONE as 'Téléphone',EMAIL as 'Email',DIPLOME as 'Diplome',CIN as'Cin',FONCTION as'fonction'," +
                        " SPECIALITE as'Spécialité' from Formateur";



                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DGV_employe.DataSource = dt;
                    con.Close();
                }
            }
            if (comboBox1.Text == "Directeur")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    DGV_employe.Visible = true;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select ID_DIRECTEUR as'Identifiant', NOM as'Nom' ,PRENOM as 'Prénom' ,DATE_NAISSANCE as 'Date Naissance' ,LIEU_NAISSANCE as 'Lieu'," +
                        "ADRESSE as 'Adresse',TELEPHONE as 'Téléphone',EMAIL as 'Email',DIPLOME as 'Diplome',CIN as'Cin' from Directeur";



                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DGV_employe.DataSource = dt;
                    con.Close();
                }
            }

            if (DGV_employe.Text == "Conseiliere Relation Clientéle")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    DGV_employe.Visible = true;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select ID_EMPLOYE as'Identifiant', NOM as'Nom' ,PRENOM as 'Prénom' ,DATE_NAISSANCE as 'Date Naissance' ,LIEU_NAISSANCE as 'Lieu'," +
                        "ADRESSE as 'Adresse',TELEPHONE as 'Téléphone',EMAIL as 'Email',DIPLOME as 'Diplome',CIN as'Cin' from Employe e where e.POSTE='Conseiliere Relation Clientéle'";



                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DGV_employe.DataSource = dt;

                }
            }

            if (comboBox1.Text == "Agent Administratif")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    DGV_employe.Visible = true;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select ID_EMPLOYE as'Identifiant', NOM as'Nom' ,PRENOM as 'Prénom' ,DATE_NAISSANCE as 'Date Naissance' ,LIEU_NAISSANCE as 'Lieu'," +
                        "ADRESSE as 'Adresse',TELEPHONE as 'Téléphone',EMAIL as 'Email',DIPLOME as 'Diplome',CIN as'Cin'from Employe e where e.POSTE='Agent Administratif'";



                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DGV_employe.DataSource = dt;

                }
            }

            if (comboBox1.Text == "Responsable Formation")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    DGV_employe.Visible = true;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select  ID_EMPLOYE as'Identifiant', NOM as'Nom' ,PRENOM as 'Prénom' ,DATE_NAISSANCE as 'Date Naissance' ,LIEU_NAISSANCE as 'Lieu'," +
                        "ADRESSE as 'Adresse',TELEPHONE as 'Téléphone',EMAIL as 'Email',DIPLOME as 'Diplome',CIN as'Cin' from Employe e where e.POSTE='Responsable Formation'";



                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DGV_employe.DataSource = dt;

                }
            }
            //using (SqlConnection cnx = new SqlConnection(Program.connection))
            //{
            //    try
            //    {
            //        cnx.Open();
            //        SqlCommand cmd = new SqlCommand("select ID_EMPLOYE as'ID',NOM as'Nom',PRENOM as'prenom',DATE_NAISSANCE as'Date Naissance',LIEU_NAISSANCE as'lieu De Naissance',ADRESSE as'Adresse',TELEPHONE as'Telephonne',EMAIL as'Email',DIPLOME as'Diplome',POSTE as'Poste',CIN as'Cin' from EMPLOYE where ID_EMPLOYE=@idemploye", cnx);
            //        SqlParameter param = new SqlParameter();

            //        param.ParameterName = "@idemploye";
            //        param.SqlDbType = SqlDbType.Int;
            //        param.Value = comboBox1.SelectedValue;
            //        cmd.Parameters.Add(param);


            //        SqlDataReader dtr = cmd.ExecuteReader();
            //        DataTable dt = new DataTable();
            //        dt.Load(dtr);
            //        DGV_employe.DataSource = dt;

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);

            //    }


            //}
        }

        private void DGV_employe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                panel5.Visible = true;
                DGV_employe.Visible = false;
                txt_nom.Text = DGV_employe.CurrentRow.Cells[3].Value.ToString();
                txt_prenom.Text = DGV_employe.CurrentRow.Cells[4].Value.ToString();
                date_n.Value = DateTime.Parse(DGV_employe.CurrentRow.Cells[5].Value.ToString());
                txt_lieu.Text = DGV_employe.CurrentRow.Cells[6].Value.ToString();
                txt_adresse.Text = DGV_employe.CurrentRow.Cells[7].Value.ToString();
                txt_tel.Text = DGV_employe.CurrentRow.Cells[8].Value.ToString();
                txt_email.Text = DGV_employe.CurrentRow.Cells[9].Value.ToString();
                txt_diplome.Text = DGV_employe.CurrentRow.Cells[10].Value.ToString();
                txt_cin.Text = DGV_employe.CurrentRow.Cells[11].Value.ToString();


            }

            if (e.ColumnIndex == 1)
            {
                panel5.Visible = false;
                if (comboBox1.Text == "Directeur")
                {
                    using (SqlConnection con = new SqlConnection(Program.connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete Directeur  where ID_Directeur=@id", con);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                        cmd.Parameters.Add(param);
                        int nbr = cmd.ExecuteNonQuery();
                        if (nbr == 0)
                        {
                            MessageBox.Show("Operation Annuler");
                        }
                        else
                        {
                            MessageBox.Show("Operation Reussit");
                            DGV_employe.Rows.Remove(DGV_employe.CurrentRow);
                        }
                    }
                }

                if (comboBox1.Text == "Agent Administratif" || comboBox1.Text == "Conseiliere Relation Clientéle" || comboBox1.Text == "Responsable Formation ")
                {
                    using (SqlConnection con = new SqlConnection(Program.connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete Employe  where ID_EMPLOYE=@id", con);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                        cmd.Parameters.Add(param);
                        int nbr = cmd.ExecuteNonQuery();
                        if (nbr == 0)
                        {
                            MessageBox.Show("Operation Annuler");
                        }
                        else
                        {
                            MessageBox.Show("Operation Reussit");
                            DGV_employe.Rows.Remove(DGV_employe.CurrentRow);
                        }
                    }


                }
                if (comboBox1.Text == "Formateur")
                {
                    using (SqlConnection con = new SqlConnection(Program.connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete Formateur  where ID_FORMATEUR=@id", con);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                        cmd.Parameters.Add(param);
                        int nbr = cmd.ExecuteNonQuery();
                        if (nbr == 0)
                        {
                            MessageBox.Show("Operation Annuler");
                        }
                        else
                        {
                            MessageBox.Show("Operation Reussit");
                            DGV_employe.Rows.Remove(DGV_employe.CurrentRow);
                        }
                    }

                }
            }
        }

        private void bt_modufier_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Directeur")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Directeur set Nom=@nom ,PRENOM=@prenom,DATE_NAISSANCE=@date," +
                        "LIEU_NAISSANCE=@lieu,ADRESSE=@adresse,TELEPHONE=@tel,EMAIL=@email,DIPLOME=@dip,CIN=@cin where ID_Directeur = @id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@nom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_nom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@prenom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_prenom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@date";
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Value = Convert.ToDateTime(date_n.Text);
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@lieu";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_lieu.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@adresse";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_adresse.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@tel";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_tel.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@email";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_email.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@dip";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_diplome.Text;
                    cmd.Parameters.Add(param);


                    param = new SqlParameter();
                    param.ParameterName = "@cin";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_cin.Text;
                    cmd.Parameters.Add(param);



                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");

                        DGV_employe.CurrentRow.Cells[3].Value = txt_nom.Text;
                        DGV_employe.CurrentRow.Cells[4].Value = txt_prenom.Text;
                        DGV_employe.CurrentRow.Cells[5].Value = date_n.Value;
                        DGV_employe.CurrentRow.Cells[6].Value = txt_lieu.Text;

                        DGV_employe.CurrentRow.Cells[7].Value = txt_adresse.Text;
                        DGV_employe.CurrentRow.Cells[8].Value = txt_tel.Text;
                        DGV_employe.CurrentRow.Cells[9].Value = txt_email.Text;
                        DGV_employe.CurrentRow.Cells[10].Value = txt_diplome.Text;
                        DGV_employe.CurrentRow.Cells[12].Value = txt_cin.Text;
                        panel5.Visible = false;

                    }
                }

            }

            if (comboBox1.Text == "Agent Administratif" || comboBox1.Text == "Conseiliere Relation Clientéle" || comboBox1.Text == "Responsable Formation ")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employe set Nom=@nom ,PRENOM=@prenom,DATE_NAISSANCE=@date," +
                        "LIEU_NAISSANCE=@lieu,ADRESSE=@adresse,TELEPHONE=@tel,EMAIL=@email,DIPLOME=@dip,CIN=@cin where ID_EMPLOYE = @id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@nom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_nom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@prenom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_prenom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@date";
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Value = Convert.ToDateTime(date_n.Text);
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@lieu";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_lieu.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@adresse";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_adresse.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@tel";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_tel.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@email";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_email.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@dip";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_diplome.Text;
                    cmd.Parameters.Add(param);


                    param = new SqlParameter();
                    param.ParameterName = "@cin";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_cin.Text;
                    cmd.Parameters.Add(param);



                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");

                        DGV_employe.CurrentRow.Cells[3].Value = txt_nom.Text;
                        DGV_employe.CurrentRow.Cells[4].Value = txt_prenom.Text;
                        DGV_employe.CurrentRow.Cells[5].Value = date_n.Value;
                        DGV_employe.CurrentRow.Cells[6].Value = txt_lieu.Text;

                        DGV_employe.CurrentRow.Cells[7].Value = txt_adresse.Text;
                        DGV_employe.CurrentRow.Cells[8].Value = txt_tel.Text;
                        DGV_employe.CurrentRow.Cells[9].Value = txt_email.Text;
                        DGV_employe.CurrentRow.Cells[10].Value = txt_diplome.Text;
                        DGV_employe.CurrentRow.Cells[12].Value = txt_cin.Text;
                        panel5.Visible = false;

                    }
                }

            }
            if (comboBox1.Text == "Formateur")
            {
                using (SqlConnection con = new SqlConnection(Program.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Formateur set Nom=@nom ,PRENOM=@prenom,DATE_NAISSANCE=@date," +
                        "LIEU_NAISSANCE=@lieu,ADRESSE=@adresse,TELEPHONE=@tel,EMAIL=@email,DIPLOME=@dip,CIN=@cin where ID_FORMATEUR = @id", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = DGV_employe.CurrentRow.Cells[2].Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@nom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_nom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@prenom";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_prenom.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@date";
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Value = Convert.ToDateTime(date_n.Text);
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@lieu";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_lieu.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@adresse";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_adresse.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@tel";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_tel.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@email";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_email.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@dip";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_diplome.Text;
                    cmd.Parameters.Add(param);


                    param = new SqlParameter();
                    param.ParameterName = "@cin";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    param.Value = txt_cin.Text;
                    cmd.Parameters.Add(param);



                    int nbr = cmd.ExecuteNonQuery();
                    if (nbr == 0)
                    {
                        MessageBox.Show("Operation Annuler");

                    }
                    else
                    {
                        MessageBox.Show("Operation Reussit");

                        DGV_employe.CurrentRow.Cells[3].Value = txt_nom.Text;
                        DGV_employe.CurrentRow.Cells[4].Value = txt_prenom.Text;
                        DGV_employe.CurrentRow.Cells[5].Value = date_n.Value;
                        DGV_employe.CurrentRow.Cells[6].Value = txt_lieu.Text;

                        DGV_employe.CurrentRow.Cells[7].Value = txt_adresse.Text;
                        DGV_employe.CurrentRow.Cells[8].Value = txt_tel.Text;
                        DGV_employe.CurrentRow.Cells[9].Value = txt_email.Text;
                        DGV_employe.CurrentRow.Cells[10].Value = txt_diplome.Text;
                        DGV_employe.CurrentRow.Cells[12].Value = txt_cin.Text;
                        panel5.Visible = false;

                    }
                   
                }
                DGV_employe.Visible = true;

            }
        }
    
    }
}
