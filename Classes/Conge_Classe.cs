using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace csse3.Classes
{
    class Conge_Classe
    {
        private int Id_Conge;
        private int Id_Employe;
        private DateTime DateDebut;
        private DateTime DateFin;
        private int Duree;

        public Conge_Classe() { }
        public Conge_Classe(int id_Conge, int id_Employe, DateTime dateDebut, DateTime dateFin, int duree)
        {
            Id_Conge = id_Conge;
            Id_Employe = id_Employe;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Duree = duree;
        }

        public int Id_Conge1 { get => Id_Conge; set => Id_Conge = value; }
        public int Id_Employe1 { get => Id_Employe; set => Id_Employe = value; }
        public DateTime DateDebut1 { get => DateDebut; set => DateDebut = value; }
        public DateTime DateFin1 { get => DateFin; set => DateFin = value; }
        public int Duree1 { get => Duree; set => Duree = value; }


        public void AjouterConge(int Employe,DateTime DD,DateTime DF)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into CONGE values(@employe,@dated,@datef,@Dure)";
                cmd.Connection = con;

                SqlParameter param = new SqlParameter();


                param = new SqlParameter();
                param.ParameterName = "@employe";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@dated";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DD;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@datef";
                param.SqlDbType = SqlDbType.Date;
                param.Value = DF;
                cmd.Parameters.Add(param);


                TimeSpan ts = DF - DD; ;
                param = new SqlParameter();
                param.ParameterName = "@Dure";
                param.SqlDbType = SqlDbType.Int;
                param.Value = ts.Days.ToString();
                cmd.Parameters.Add(param);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operation reussit");
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

        public void ModifierConge( DateTime DD, DateTime DF, int Duree,DataGridView DGVConge,Panel P1,string nom,string prenom)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update CONGE set DATE_DEBUT=@DD ,DATE_FIN=@DF,DURE=@Duree where ID_EMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGVConge.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);

               

                param = new SqlParameter();
                param.ParameterName = "@DD";
                param.SqlDbType = SqlDbType.Date;
                //param.Size = 30;
                param.Value = DD;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DF";
                param.SqlDbType = SqlDbType.Date;
                //param.Size = 30;
                param.Value = DF;
                cmd.Parameters.Add(param);

                TimeSpan ts =DF-DD;;
                param = new SqlParameter();
                param.ParameterName = "@Duree";
                param.SqlDbType = SqlDbType.Int;
                param.Value = ts.Days.ToString();
                cmd.Parameters.Add(param);

               



                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGVConge.CurrentRow.Cells[3].Value = nom;
                    DGVConge.CurrentRow.Cells[4].Value = prenom;

                    DGVConge.CurrentRow.Cells[5].Value = DD;
                    DGVConge.CurrentRow.Cells[6].Value = DF;
                    DGVConge.CurrentRow.Cells[7].Value = Duree;
                   

                    P1.Visible = false;

                }
            }
        }

        public void Recherche(int Employe,DataGridView DGVConge)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select E.ID_EMPLOYE,E.NOM,E.PRENOM,C.DATE_DEBUT,C.DATE_FIN ,C.DURE from EMPLOYE E inner join CONGE C on E.ID_EMPLOYE=C.ID_EMPLOYE where E.ID_EMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Employe;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGVConge.DataSource = dt;
                      
                        //DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                        //bt.Name = "Modifier";
                        //bt.HeaderText = "Opération";
                        //bt.Text = "Modifier";
                        //bt.UseColumnTextForButtonValue = true;
                        //DGVConge.Columns.Add(bt);


                        //DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn();
                        //bt1.Name = "Supprimer";
                        //bt1.HeaderText = "Opération";
                        //bt1.Text = "Supprimer";
                        //bt1.UseColumnTextForButtonValue = true;
                        //DGVConge.Columns.Add(bt1);


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
        public void Supprimer(Panel P1,DataGridView DGV_Congé)
        {
            P1.Visible = false;
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete CONGE  where ID_EMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = DGV_Congé.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Congé.Rows.Remove(DGV_Congé.CurrentRow);
                }
            }
        }
        public static int Conge( int employe)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CONGE where ID_EMPLOYE =@num ", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@num";
                param.SqlDbType = SqlDbType.Int;
                param.Value = employe;
                cmd.Parameters.Add(param);

                int tr = 0;
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        return tr = 1;



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
                return tr;

            }

        }
    }
}
