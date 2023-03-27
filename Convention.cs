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
    public partial class Convention : Form
    {
        public Convention()
        {
            InitializeComponent();
        }
        string type;
       
        private void button2_Click(object sender, EventArgs e)
        {
            Classes.Convention_Classe.Valider(Convert.ToInt32(cb_Employe.SelectedValue), type, txt_nom.Text, Convert.ToDateTime(dateTimePicker1.Value));
        }

        private void Convention_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * FROM EMPLOYE where POSTE='ResponsableFormation'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cb_Employe.DisplayMember = "NOM";
                    cb_Employe.ValueMember = "ID_EMPLOYE";
                    cb_Employe.DataSource = dt;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_Employe.Text = "";
            txt_nom.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "Etat";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "Privée";
        }
    }
}
