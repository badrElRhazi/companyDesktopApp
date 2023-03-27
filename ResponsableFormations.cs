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
    public partial class ResponsableFormations : Form
    {
        public ResponsableFormations()
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
            panel2.Visible = false;
           // panel4.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
            pictureBox2.Visible = false;
            if (pa_menuGlobal.Width == 42)
            {
                pa_menuGlobal.Width = 152;
                pictureBox2.Visible = true;
            }
            else
            {
                pa_menuGlobal.Width = 42;
                pa_sousMenu.Visible = false;

            }
        }

        private void bt_Evenement_Click(object sender, EventArgs e)
        {
            Program.pannel(pa_sousMenu, panel2, panel5, panel6);
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            //if (pa_sousMenu.Visible == false)
            //{
            //    panel2.Visible = false;
            //    panel5.Visible =false;
            //    panel2.Visible = false;
            //    pa_sousMenu.Visible = true;
            //    pa_sousMenu.BringToFront();
            //}
            //else
            //{
            //    panel2.Visible = false;
            //    panel5.Visible = false;
            //    panel2.Visible = false;
            //    pa_sousMenu.Visible = false;
            //    pa_sousMenu.BringToFront();
            //}
        }

        private void bt_AjouterEve_Click(object sender, EventArgs e)
        {
            AjouterEvenement fe = new  AjouterEvenement();
            if (fe == null)
            {
                fe = new  AjouterEvenement();
            }
            else
            {
                if (fe.IsDisposed)
                {
                    fe = new  AjouterEvenement();
                }
            }
           Program.Change(fe,panel4);
        }
        private Form activeForm = null;
        private void Change(Form enfant)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = enfant;
            enfant.TopLevel = false;
            enfant.FormBorderStyle = FormBorderStyle.None;
            enfant.Dock = DockStyle.Fill;
            panel4.Controls.Add(enfant);
            panel4.Tag = enfant;
            enfant.BringToFront();
            enfant.Show();
        }

        private void bt_Equipe_Click(object sender, EventArgs e)
        {
            Program.pannel(panel2,pa_sousMenu,panel5,panel6);
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            //if (panel2.Visible == false)
            //{
            //    pa_sousMenu.Visible = false;
            //    panel5.Visible = false;
            //    panel2.Visible = true;
            //    panel2.BringToFront();
            //    //timer1.Enabled = true;

            //    //panel2.Height = 130;
            //}
            //else
            //{
            //    pa_sousMenu.Visible = false;
            //    panel5.Visible = false;
            //    panel2.Visible = false ;
            //    panel2.BringToFront();
            //    //panel2.Height = 0;
            //    //panel2.Height = bt_Equipe.Height;
            //}



        }

        private void bt_AjouterEquipe_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            AjouterEquipe fe1 = new  AjouterEquipe();
            if (fe1== null)
            {
                fe1= new  AjouterEquipe();
            }
            else
            {
                if (fe1.IsDisposed)
                {
                    fe1 = new  AjouterEquipe();
                }
            }
            Change(fe1);
        }

        private void bt_Formation_Click(object sender, EventArgs e)
        {
            //if (panel5.Visible == false)
            //{
            //    pa_sousMenu.Visible = false;
            //    panel2.Visible = false;
            //    panel5.Visible = true;
            //    panel5.BringToFront();

            //}
            //else
            //{
            //    pa_sousMenu.Visible = false;
            //    panel2.Visible = false;
            //    panel5.Visible = false;
            //    panel5.BringToFront();

            //}
            Program.pannel(panel5, pa_sousMenu, panel2, panel6);
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;

        }
       // private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (panel2.Height >= 90)
            //{
            //    timer1.Enabled = false;


            //}
            //else
            //{
            //    panel2.Height += 10;
            //}

        }

        private void bt_Equipe_MouseHover(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            //timer1.Enabled = true;
        }

        private void bt_Equipe_MouseLeave(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            //panel2.Height = 0;
        }

        private void bt_ajouterFormaion_Click(object sender, EventArgs e)
        {
            //panel5.Hide();
            Formation  fe2 = new  Formation();
            if (fe2 == null)
            {
                fe2 = new  Formation();
            }
            else
            {
                if (fe2.IsDisposed)
                {
                    fe2 = new  Formation();
                }
            }
          Program. Change(fe2,panel4);
        }

        private void bt_parametre_Click(object sender, EventArgs e)
        {
            Program.pannel(panel7, pa_sousMenu, panel5, panel6);
            panel2.Visible = false;
            panel8.Visible = false;
        }

        private void bt_salle_Click(object sender, EventArgs e)
        {
            Program.pannel(panel6, pa_sousMenu, panel5, panel2);
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void ResponsableFormations_Load(object sender, EventArgs e)
        {
            pa_menuGlobal.Width = 45;
        }

        private void bt_Convention_Click(object sender, EventArgs e)
        {
            Program.pannel(panel8, pa_sousMenu, panel5, panel2);
            panel7.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
        }

        private void NouveauConvention_Click(object sender, EventArgs e)
        {
           // panel2.Hide();
            Convention fc= new  Convention();
            if (fc == null)
            {
                fc = new  Convention();
            }
            else
            {
                if (fc.IsDisposed)
                {
                    fc = new Convention();
                }
            }
           Program.Change(fc,panel4);

        }

        private void bt_ConsulterConvention_Click(object sender, EventArgs e)
        {
            ConsulterConvention fcc = new  ConsulterConvention();
            if (fcc == null)
            {
                fcc = new  ConsulterConvention();
            }
            else
            {
                if (fcc.IsDisposed)
                {
                    fcc = new  ConsulterConvention();
                }
            }
            Program.Change(fcc, panel4);

        }

        private void bt_ModifierEquipe_Click(object sender, EventArgs e)
        {
            ConsulterEquipe fce = new  ConsulterEquipe();
            if (fce == null)
            {
                fce = new  ConsulterEquipe();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new  ConsulterEquipe();
                }
            }
            Program.Change(fce, panel4);

        }

        private void bt_ajouterSalle_Click(object sender, EventArgs e)
        {
            Salle fs = new Salle();
            if (fs == null)
            {
                fs = new Salle ();
            }
            else
            {
                if (fs.IsDisposed)
                {
                    fs = new  Salle();
                }
            }
            Program.Change(fs, panel4);

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
            Program.Change(fmp, panel4);
        }

        private void bt_modifierFormation_Click(object sender, EventArgs e)
        {
            ConsulterFormation fcf= new ConsulterFormation();
            if (fcf == null)
            {
                fcf = new  ConsulterFormation();
            }
            else
            {
                if (fcf.IsDisposed)
                {
                    fcf = new  ConsulterFormation();
                }
            }
            Program.Change(fcf, panel4);

        }

        private void bt_ModifierEve_Click(object sender, EventArgs e)
        {
            ConsulterEvenement fce = new  ConsulterEvenement();
            if (fce == null)
            {
                fce = new  ConsulterEvenement ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new  ConsulterEvenement ();
                }
            }
            Program.Change(fce, panel4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reservation fce = new   Reservation  ();
            if (fce == null)
            {
                fce = new   Reservation ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new Reservation ();
                }
            }
            Program.Change(fce, panel4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgandaResponsable fce = new   AgandaResponsable  ();
            if (fce == null)
            {
                fce = new   AgandaResponsable  ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new   AgandaResponsable  ();
                }
            }
            Program.Change(fce, panel4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AujourdHui fce = new  AujourdHui ();
            if (fce == null)
            {
                fce = new  AujourdHui ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new  AujourdHui ();
                }
            }
            Program.Change(fce, panel4);
        }

        private void bt_Agenda_Click(object sender, EventArgs e)
        {
            Program.pannel(panel9, pa_sousMenu, panel5, panel2);
            panel7.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
        }

        private void bt_Deconncte_Click(object sender, EventArgs e)
        {
            Acceuil oa = new Acceuil();

            oa.BTN_ResponsableFormation.Enabled = false;
            Program.user1 = null;
            this.Hide();


            Program.menu.Show();
        }

        private void pa_sousMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Adherent_Click(object sender, EventArgs e)
        {
            GestionEquipe fce = new  GestionEquipe();
            if (fce == null)
            {
                fce = new  GestionEquipe ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new  GestionEquipe ();
                }
            }
            Program.Change(fce, panel4);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
