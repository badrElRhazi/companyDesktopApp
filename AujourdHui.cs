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
    public partial class AujourdHui : Form
    {
        public AujourdHui()
        {
            InitializeComponent();
        }

        private void AujourdHui_Load(object sender, EventArgs e)
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

                        cb_Date.DisplayMember = "NOM";

                        cb_Date.ValueMember = "ID_EMPLOYE";

                        cb_Date.DataSource = dt;
                        cb_Date.Text = "";
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

        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select TITRE,DATE from AGENDA_EMPLOYE  where ID_EMPLOYE=@id And DATE=@date", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = SqlDbType.Int;

                param.Value = Convert.ToInt16(cb_Date.SelectedValue);
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
                        DGV_Agenda.DataSource = dt;

                        DGV_Agenda.Visible = true;
                        panel2.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Aucune Rendez-Vous");
                        DGV_Agenda.Visible = false;
                        panel2.Visible = true;
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
