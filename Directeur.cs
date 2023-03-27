using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csse3
{
    public partial class Directeur : Form
    {
        public Directeur()
        {
            InitializeComponent();
        }

        private void bt_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_restaurer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pi_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pi_min.Visible = false;
            pi_max.Visible = true;
        }

        private void pi_max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pi_max.Visible = false;
            pi_min.Visible = true;
        }

        private void pi_menu_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            pictureBox2.Visible = false;
            if (pa_menuGlobal.Width == 45)
            {
                pa_menuGlobal.Width = 152;
                pictureBox2.Visible = true;
            }
            else
            {
                pa_menuGlobal.Width = 45;

            }
        }

        private void bt_Equipe_Click(object sender, EventArgs e)
        {
            ConsulterEquipe fce = new ConsulterEquipe();
            if (fce == null)
            {
                fce = new ConsulterEquipe();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new ConsulterEquipe();
                }
            }
            Program.Change(fce, panel2);
        }

        private void bt_Evenement_Click(object sender, EventArgs e)
        {
            ConsulterEvenement fce = new ConsulterEvenement();
            if (fce == null)
            {
                fce = new ConsulterEvenement();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new ConsulterEvenement();
                }
            }
            Program.Change(fce, panel2);
        }

        private void bt_Conge_Click(object sender, EventArgs e)
        {
            ConsulterConge fcc = new ConsulterConge();
            if (fcc == null)
            {
                fcc = new ConsulterConge();
            }
            else
            {
                if (fcc.IsDisposed)
                {
                    fcc = new ConsulterConge();
                }
            }
            Program.Change(fcc, panel2);
        }

        private void Directeur_Load(object sender, EventArgs e)
        {
            pa_menuGlobal.Width = 45;
        }

        private void bt_parametre_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {

                panel7.Visible = true;
                panel4.Visible = false;
                panel7.BringToFront();
            }
            else
            {

                panel7.Visible = false;
                panel4.Visible = false;
                panel7.BringToFront();
            }
        }

        private void bt_ChangeMP_Click(object sender, EventArgs e)
        {
            MotDePasseDirecteur fmp = new MotDePasseDirecteur();
            if (fmp == null)
            {
                fmp = new MotDePasseDirecteur();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new MotDePasseDirecteur();
                }
            }
            Program.Change(fmp, panel2);
            //Program.Change(fmp, panel2);
        }

        private void bt_Formateur_Click(object sender, EventArgs e)
        {
            ConsulterEmploye fce = new ConsulterEmploye();
            if (fce == null)
            {
                fce = new ConsulterEmploye();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new ConsulterEmploye();
                }
            }
            Program.Change(fce, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AgendaDirecteur fce = new AgendaDirecteur();
            if (fce == null)
            {
                fce = new AgendaDirecteur();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new AgendaDirecteur();
                }
            }
            Program.Change(fce, panel2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AujourdHuiDirecteur fce = new AujourdHuiDirecteur();
            if (fce == null)
            {
                fce = new AujourdHuiDirecteur();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new AujourdHuiDirecteur();
                }
            }
            Program.Change(fce, panel2);
        }

        private void bt_agenda_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {

                panel7.Visible = false;
                panel4.Visible = true;
                panel4.BringToFront();
            }
            else
            {
                panel7.Visible = false;
                panel4.Visible = false;
                panel4.BringToFront();
            }
        }

        private void bt_Deconncte_Click(object sender, EventArgs e)
        {
            Acceuil oa = new Acceuil();

            oa.BTN_Directeur.Enabled = false;
            Program.user = null;
            
            this.Close();


           // Program.menu.Show();
           // Acceuil oa = new Acceuil();
            if (oa == null)
            {
                oa = new  Acceuil ();
            }
            else
            {
                if (oa.IsDisposed)
                {
                    oa = new  Acceuil ();
                }
            }
            Program.Change(oa, panel2);
            //oa.BTN_Deconnexion.Visible = true;
            //oa.BTN_Connexion.Visible = false;


        }
    }
}
