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
    public partial class Archives : Form
    {
        public Archives()
        {
            InitializeComponent();
        }
        string connection = @"Data Source=DESKTOP-1ASM0A6;Initial Catalog=ProjetFinFormationSiteWeb ;" + "Integrated Security=true";
        private void bt_validerArchive_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
               

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Insert into Archives values(@Nom,@type,@date)";
                    cmd.Connection = con;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Nom";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = txtx_nomA.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@type";
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 30;
                param.Value = cb_archive.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@date";
                param.SqlDbType = SqlDbType.Date;
               
                param.Value = dateTimePicker2.Value;
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
                
        }   }

        private void Archives_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from Archives", con);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                    }

                        cb_archive.Items.Add( "Evénement");
                        cb_archive.Items.Add("Formation");
                        cb_archive.Items.Add("Convention");

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
