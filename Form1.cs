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
    public partial class Form1 : Form
    {
        public Form1()
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
            panel4.Visible = false;
            pa_sousMenu.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;
            pictureBox2.Visible = false;
            if (pa_menuGlobal.Width == 41)
            {
                pa_menuGlobal.Width = 152;
                pictureBox2.Visible = true;
            }
            else
            {
                pa_menuGlobal.Width = 41;

            }
        }

        private void Archive_Click(object sender, EventArgs e)
        {
            //Program.pannel(pa_sousMenu, panel7, panel4, panel5);
            ConsulterEmploye fa = new ConsulterEmploye();
            if (fa == null)
            {
                fa = new ConsulterEmploye();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new ConsulterEmploye();
                }
            }
            Program.Change(fa, panel2);
        }

        private void bt_Archives_Click(object sender, EventArgs e)
        {
            //ConsulterEmploye fa = new ConsulterEmploye();
            //if (fa == null)
            //{
            //    fa = new ConsulterEmploye();
            //}
            //else
            //{
            //    if (fa.IsDisposed)
            //    {
            //        fa = new ConsulterEmploye();
            //    }
            //}
            //Program.Change(fa, panel2);
        }

        private void bt_ConsulterArchive_Click(object sender, EventArgs e)
        {
            ConsulterArchives fa = new  ConsulterArchives();
            if (fa == null)
            {
                fa = new  ConsulterArchives();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  ConsulterArchives();
                }
            }
            Program.Change(fa, panel2);
        }

        private void bt_parametre_Click(object sender, EventArgs e)
        {
            Program.pannel(panel7, pa_sousMenu,panel4,panel5);
        }

        private void bt_formateur_Click(object sender, EventArgs e)
        {
            Program.pannel(panel5, pa_sousMenu, panel4, panel7);
        }

        private void bt_agenda_Click(object sender, EventArgs e)
        {
            Program.pannel(panel4, pa_sousMenu, panel4, panel5);
        }

        private void bt_AjouterFormateur_Click(object sender, EventArgs e)
        {
            FormNouveauEmploye fe = new FormNouveauEmploye();
            if (fe == null)
            {
                fe = new FormNouveauEmploye();
            }
            else
            {
                if (fe.IsDisposed)
                {
                    fe = new FormNouveauEmploye();
                }
            }
            Program.Change(fe, panel2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pa_menuGlobal.Width = 45;
        }

        private void bt_ChangeMP_Click(object sender, EventArgs e)
        {
            MotPasse fmp = new MotPasse();
            if (fmp == null)
            {
                fmp = new MotPasse();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new MotPasse();
                }
            }
            Program.Change(fmp, panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Directeur_Click(object sender, EventArgs e)
        {
            AgendaDirecteur fmp = new  AgendaDirecteur ();
            if (fmp == null)
            {
                fmp = new  AgendaDirecteur ();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new  AgendaDirecteur ();
                }
            }
            Program.Change(fmp, panel2);
        }

        private void bt_Responsable_Click(object sender, EventArgs e)
        {
            AgandaResponsable fmp = new AgandaResponsable ();
            if (fmp == null)
            {
                fmp = new  AgandaResponsable ();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new  AgandaResponsable ();
                }
            }
            Program.Change(fmp, panel2);
        }

        private void bt_Agent_Click(object sender, EventArgs e)
        {
            AgendaAdministrateur fmp = new  AgendaAdministrateur ();
            if (fmp == null)
            {
                fmp = new  AgendaAdministrateur ();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new  AgendaAdministrateur ();
                }
            }
            Program.Change(fmp, panel2);
        }

        private void bt_Secetaire_Click(object sender, EventArgs e)
        {
            AgendaSecretaire fmp = new  AgendaSecretaire ();
            if (fmp == null)
            {
                fmp = new  AgendaSecretaire ();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new  AgendaSecretaire ();
                }
            }
            Program.Change(fmp, panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtestationDeConge fa = new   AtestationDeConge  ();
            if (fa == null)
            {
                fa = new   AtestationDeConge  ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new   AtestationDeConge ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AtestationDeSalaire fa = new  AtestationDeSalaire ();
            if (fa == null)
            {
                fa = new  AtestationDeSalaire ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  AtestationDeSalaire ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtestationDeTravail fa = new  AtestationDeTravail ();
            if (fa == null)
            {
                fa = new  AtestationDeTravail ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  AtestationDeTravail ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borderau fa = new  Borderau ();
            if (fa == null)
            {
                fa = new  Borderau ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  Borderau ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LettreDoffre fa = new   LettreDoffre  ();
            if (fa == null)
            {
                fa = new   LettreDoffre  ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new   LettreDoffre  ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OrdreDeMission fa = new  OrdreDeMission ();
            if (fa == null)
            {
                fa = new  OrdreDeMission ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  OrdreDeMission ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LettreDemande fa = new  LettreDemande ();
            if (fa == null)
            {
                fa = new  LettreDemande ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  LettreDemande ();
                }
            }
            Program.Change(fa, panel2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.pannel( pa_sousMenu, panel4, panel4, panel5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cantact fa = new  Cantact ();
            if (fa == null)
            {
                fa = new  Cantact ();
            }
            else
            {
                if (fa.IsDisposed)
                {
                    fa = new  Cantact ();
                }
            }
            Program.Change(fa, panel2);
        }

        private void bt_Deconncte_Click(object sender, EventArgs e)
        {
            Acceuil oa = new Acceuil();
           
            oa.BTN_conseilere.Enabled = false;
            Program.user1 = null;
            this.Hide();


            Program.menu.Show();
        }
    }
}
