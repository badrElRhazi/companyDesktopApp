using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace csse3.Classes
{
    class Agenda_Classe
    {
        //private int Id_Agenda;
        private DateTime Date_Agenda;
        private string Titre;
       
        private int Employe;
       

        public Agenda_Classe() { }
        public Agenda_Classe(DateTime date_Agenda, string titre,int employe)
        {
            //Id_Agenda = id_Agenda;
            Employe = employe;
             Date_Agenda = date_Agenda;
            Titre = titre;

        }

        //public int Id_Agenda1 { get => Id_Agenda; set => Id_Agenda = value; }
        public DateTime Date_Agenda1 { get => Date_Agenda; set => Date_Agenda = value; }
        public string Titre1 { get => Titre; set => Titre = value; }
        public int Employe1 { get => Employe; set => Employe = value; }

        public void AjouterRendezVous(DateTime DD, string titre, int Employe)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into AGENDA_EMPLOYE values(@DD,@titre,@employe)";
                cmd.Connection = con;
                SqlParameter param = new SqlParameter();
                param = new SqlParameter();
                param.ParameterName = "@employe";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DD";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DD;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@titre";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = titre;
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

        public void ModifierConge(DateTime DD, string titre, int Employe, DataGridView DGVaGENDA)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update AGENDA_EMPLOYE set DATE=@DD ,TITRE=@titre,ID_EMPLOYE=@employe where ID_AGENDAEMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGVaGENDA.CurrentRow.Cells[0].Value;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@employe";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DD";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DD;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@titre";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = titre;
                cmd.Parameters.Add(param);







                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGVaGENDA.CurrentRow.Cells[2].Value = DD;
                    DGVaGENDA.CurrentRow.Cells[3].Value = titre;
                  //  DGVaGENDA.CurrentRow.Cells[].Value=e

                   


                   

                }
            }
           
        }
        public void Supprimer( DataGridView DGV_Agenda)
        {

            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete AGENDA_EMPLOYE  where  ID_AGENDAEMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = DGV_Agenda.CurrentRow.Cells[0].Value;
                cmd.Parameters.Add(param);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Agenda.Rows.Remove(DGV_Agenda.CurrentRow);
                }
            }
        }

        public void Recherche(int Employe, DataGridView DGVConge)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from AGENDA_EMPLOYE  where ID_EMPLOYE=@id And DATE=@date", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@date";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DateTime.Now;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGVConge.DataSource = dt;

                        


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
    }
}
