using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace csse3
{
    class Paiement_Classe
    {
        private int ID_PAIEMENTFORMATEUR;
        private int ID_DIRECTEUR;
        private int SALAIRE;
        private int PRIME;
        private int SALAIREPRIME;
        private string REGLEMENT;
        private DateTime DateP;

        public Paiement_Classe() { }
        public Paiement_Classe(int iD_PAIEMENTFORMATEUR, int iD_DIRECTEUR, int sALAIRE, int pRIME, int sALAIREPRIME, string rEGLEMENT, DateTime DateP)
        {
            ID_PAIEMENTFORMATEUR = iD_PAIEMENTFORMATEUR;
            ID_DIRECTEUR = iD_DIRECTEUR;
            SALAIRE = sALAIRE;
            PRIME = pRIME;
            SALAIREPRIME = sALAIREPRIME;
            REGLEMENT = rEGLEMENT;
            this.DateP1 = DateP;

        }

        public int ID_PAIEMENTFORMATEUR1 { get => ID_PAIEMENTFORMATEUR; set => ID_PAIEMENTFORMATEUR = value; }
        public int ID_DIRECTEUR1 { get => ID_DIRECTEUR; set => ID_DIRECTEUR = value; }
        public int SALAIRE1 { get => SALAIRE; set => SALAIRE = value; }
        public int PRIME1 { get => PRIME; set => PRIME = value; }
        public int SALAIREPRIME1 { get => SALAIREPRIME; set => SALAIREPRIME = value; }
        public string REGLEMENT1 { get => REGLEMENT; set => REGLEMENT = value; }
        public DateTime DateP1 { get => DateP; set => DateP = value; }

        public void Parametre(SqlCommand cmd, int id, int salaire, int prime,  string Paiement, DateTime DateP, string month)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@salaire";
            param.SqlDbType = SqlDbType.Int;

            param.Value = salaire;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@prime";
            param.SqlDbType = SqlDbType.Int;

            param.Value = prime;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@SP";
            param.SqlDbType = SqlDbType.Int;
            param.Value = salaire+prime;
            cmd.Parameters.Add(param);




            param = new SqlParameter();
            param.ParameterName = "@paiment";
            param.SqlDbType = SqlDbType.VarChar;
            param.Size = 30;
            param.Value = Paiement;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@dateP";
            param.SqlDbType = SqlDbType.Date;

            param.Value = DateP;
            cmd.Parameters.Add(param);


            param = new SqlParameter();
            param.ParameterName = "@mois";
            param.SqlDbType = SqlDbType.VarChar;
            param.Size = 30;
            param.Value = month;
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

        public void AjOUTER(int id, int salaire, int prime,  string Paiement, DateTime DateP, string month)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into PAIEMENT_DIRECTEUR values(@id,@salaire,@prime,@SP,@paiment,@dateP,@mois)";
                cmd.Connection = con;
                Parametre(cmd, id, salaire, prime,  Paiement, DateP, month);



               
            }
        }

        public void AjouterPaiementE(int id, int salaire, int prime,string Paiement, DateTime DateP, string month)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into PAIEMENT_EMPLOYE values(@id,@salaire,@prime,@SP,@paiment,@dateP,@mois)";
                cmd.Connection = con;
                Parametre(cmd, id, salaire, prime, Paiement, DateP, month);
            }
        }

        public void PaiementF(int id, int salaire, int prime,  string Paiement, DateTime DateP, string month)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into PAIEMENT_FORMATEUR values(@id,@salaire,@prime,@SP,@paiment,@dateP,@mois)";
                cmd.Connection = con;
                Parametre(cmd, id, salaire, prime, Paiement, DateP, month);
            }
        }

        public void ModifierPaiementFormateur(DataGridView DGV_Salaire, int salaire, int prime, string reglement, DateTime DateP, string nom, string prenom, Panel p1)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update PAIEMENT_FORMATEUR set SALAIRE=@salaire ,PRIME=@prime,REGLEMENT=@paiment,DATE_P=@Dp where ID_FORMATEUR=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@salaire";
                param.SqlDbType = SqlDbType.Int;

                param.Value = salaire;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@prime";
                param.SqlDbType = SqlDbType.Int;

                param.Value = prime;
                cmd.Parameters.Add(param);




                param = new SqlParameter();
                param.ParameterName = "@paiment";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = reglement;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Dp";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DateP;
                cmd.Parameters.Add(param);

                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.CurrentRow.Cells[3].Value = nom;
                    DGV_Salaire.CurrentRow.Cells[4].Value = prenom;

                    DGV_Salaire.CurrentRow.Cells[5].Value = salaire;
                    DGV_Salaire.CurrentRow.Cells[6].Value = prime;
                    DGV_Salaire.CurrentRow.Cells[7].Value = reglement;
                    DGV_Salaire.CurrentRow.Cells[8].Value = DateP;
                    p1.Visible = false;

                }
            }

        }
        public void RechercherPaiFormateur(DataGridView DGV_Salaire, int id)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select F.ID_FORMATEUR,F.NOM,F.PRENOM,P.SALAIRE,P.PRIME,P.REGLEMENT,P.DATE_P from FORMATEUR F inner join PAIEMENT_FORMATEUR P on P.ID_FORMATEUR=F.ID_FORMATEUR where F.ID_FORMATEUR=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = id;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Salaire.DataSource = dt;



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

        public void SuppPaiementFormateur(DataGridView DGV_Salaire)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete  PAIEMENT_FORMATEUR where ID_FORMATEUR =@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.Rows.Remove(DGV_Salaire.CurrentRow);
                }
            }
        }

        public void RechercherPaiDirecteur(int id, DataGridView DGV_Salaire)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select D.ID_DIRECTEUR,D.NOM,D.PRENOM,P.SALAIRE,P.PRIME,P.REGLEMENT,P.DATE_P from DIRECTEUR D inner join PAIEMENT_DIRECTEUR P on P.ID_DIRECTEUR=D.ID_DIRECTEUR where D.ID_DIRECTEUR=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = id;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Salaire.DataSource = dt;



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
        public void SupprimerPaiDirecteur(DataGridView DGV_Salaire)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete  PAIEMENT_DIRECTEUR where ID_DIRECTEUR =@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.Rows.Remove(DGV_Salaire.CurrentRow);
                }
            }
        }
        public void ModifierPaiDirecteur(DataGridView DGV_Salaire, int salaire, int prime, string reglement, DateTime DateP, string nom, string prenom, Panel p1)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update PAIEMENT_DIRECTEUR set SALAIRE=@salaire ,PRIME=@prime,REGLEMENT=@paiment,DATE_P=@Dp where ID_DIRECTEUR=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@salaire";
                param.SqlDbType = SqlDbType.Int;

                param.Value = salaire;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@prime";
                param.SqlDbType = SqlDbType.Int;

                param.Value = prime;
                cmd.Parameters.Add(param);




                param = new SqlParameter();
                param.ParameterName = "@paiment";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = reglement;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Dp";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DateP;
                cmd.Parameters.Add(param);

                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.CurrentRow.Cells[3].Value = nom;
                    DGV_Salaire.CurrentRow.Cells[4].Value = prenom;

                    DGV_Salaire.CurrentRow.Cells[5].Value = salaire;
                    DGV_Salaire.CurrentRow.Cells[6].Value = prime;
                    DGV_Salaire.CurrentRow.Cells[7].Value = reglement;
                    DGV_Salaire.CurrentRow.Cells[8].Value = DateP;
                    p1.Visible = false;

                }
            }
        }

        public void RechercherPaEmploye(int id, DataGridView DGV_Salaire)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select E.ID_EMPLOYE,E.NOM,E.PRENOM,P.SALAIRE,P.PRIME,P.REGLEMENT,P.DATE_P from EMPLOYE E inner join PAIEMENT_EMPLOYE P on P.ID_EMPLOYE=E.ID_EMPLOYE where E.ID_EMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = id;
                cmd.Parameters.Add(param);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGV_Salaire.DataSource = dt;



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

        public void ModifierPaEmploye(DataGridView DGV_Salaire, int salaire, int prime, string reglement, DateTime DateP, string nom, string prenom, Panel p1)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update PAIEMENT_EMPLOYE set SALAIRE=@salaire ,PRIME=@prime,REGLEMENT=@paiment,DATE_P=@Dp where ID_EMPLOYE=@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;
                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@salaire";
                param.SqlDbType = SqlDbType.Int;

                param.Value = salaire;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@prime";
                param.SqlDbType = SqlDbType.Int;

                param.Value = prime;
                cmd.Parameters.Add(param);




                param = new SqlParameter();
                param.ParameterName = "@paiment";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = reglement;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Dp";
                param.SqlDbType = SqlDbType.Date;

                param.Value = DateP;
                cmd.Parameters.Add(param);

                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.CurrentRow.Cells[3].Value = nom;
                    DGV_Salaire.CurrentRow.Cells[4].Value = prenom;

                    DGV_Salaire.CurrentRow.Cells[5].Value = salaire;
                    DGV_Salaire.CurrentRow.Cells[6].Value = prime;
                    DGV_Salaire.CurrentRow.Cells[7].Value = reglement;
                    DGV_Salaire.CurrentRow.Cells[8].Value = DateP;
                    p1.Visible = false;

                }
            }
        }
        public void SuppPAIeMPLOYE(DataGridView DGV_Salaire)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete  PAIEMENT_EMPLOYE where ID_EMPLOYE =@id", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = DGV_Salaire.CurrentRow.Cells[2].Value;
                cmd.Parameters.Add(param);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr == 0)
                {
                    MessageBox.Show("Operation Annuler");

                }
                else
                {
                    MessageBox.Show("Operation Reussit");
                    DGV_Salaire.Rows.Remove(DGV_Salaire.CurrentRow);
                }
            }
        }
        public static int Salaire1(string mois, int employe)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PAIEMENT_EMPLOYE where ID_EMPLOYE=@num and  Mois= @mois", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@num";
                param.SqlDbType = SqlDbType.Int;
                param.Value = employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mois";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = mois;
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

        public static int SalaireF(string mois, int employe)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PAIEMENT_FORMATEUR where ID_FORMATEUR =@numf and  Mois= @mois", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@numf";
                param.SqlDbType = SqlDbType.Int;
                param.Value = employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mois";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = mois;
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
        public static int SalaireD(string mois, int employe)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PAIEMENT_DIRECTEUR where ID_DIRECTEUR =@numD and  Mois= @mois", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@numD";
                param.SqlDbType = SqlDbType.Int;
                param.Value = employe;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mois";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = mois;
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
