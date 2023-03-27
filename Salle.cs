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
    public partial class Salle : Form
    {
        public Salle()
        {
            InitializeComponent();
        }
        string dispo;
       
        private void Salle_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con1 = new SqlConnection(Program.connection))
            //{
            //    con1.Open();
            //    SqlCommand cmd = new SqlCommand("select * FROM EVENEMENT", con1);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        DataTable dt = new DataTable();
            //        dt.Load(dr);
            //        cb_evenement.DisplayMember = "NOM_EVENEMENT";
            //        cb_evenement.ValueMember = "ID_EVENEMENT";
            //        cb_evenement.DataSource = dt;


            //    }
            //}
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Salle_Classe.Valider( int.Parse(txt_capacite.Text), dispo, int.Parse(txt_prix.Text),txt_TypeSalle.Text,Convert.ToDateTime(dateTimePicker2.Value));
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            txt_capacite.Clear();
            txt_prix.Clear();
            txt_TypeSalle.Text = "";
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            //txt_num.Clear();
            //cb_evenement.Text = "";
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            txt_capacite.Clear();
            txt_prix.Clear();
            txt_TypeSalle.Text = "";

            //cb_responsable.Text = "";;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dispo = "Indispponible";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dispo = "Indispponible";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dispo = "Dispponible";
        }

        private void cb_evenement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
