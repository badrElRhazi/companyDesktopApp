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
    public partial class Administrateur : Form
    {
        public Administrateur()
        {
            InitializeComponent();
            
        }

        string connection = @"Data Source =DESKTOP-OM8F40H\SQLEXPRESS ; Initial Catalog=BD5 ;" + "Integrated Security=true";



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
            pa_sousMenu.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            pictureBox2.Visible = false;
            if (pa_menuGlobal.Width == 46)
            {
                pa_menuGlobal.Width = 152;
                pictureBox2.Visible = true;
            }
            else
            {
                pa_menuGlobal.Width = 46;
                pa_sousMenu.Visible = false;

            }
        }

        private void Administrateur_Load(object sender, EventArgs e)
        {
            pa_menuGlobal.Width = 45;

        }
        //public void pannel(Panel p1,Panel p2,Panel p3,Panel p4)
        //{
        //    if (p1.Visible == false)
        //    {
        //        p2.Visible = false;
        //        p3.Visible = false;
        //        p4.Visible = false;
        //        p1.Visible = true;
        //        p1.BringToFront();
        //    }
        //    else
        //    {
        //        p2.Visible = false;
        //        p3.Visible = false;
        //        p4.Visible = false;
        //        p1.Visible = false;
        //        p1.BringToFront();
        //    }
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            //if (pa_sousMenu.Visible == false)
            //{
            //    pa_sousMenu.Visible = true;
            //}
            //else
            //{
            //    pa_sousMenu.Visible = false;
            //}
           Program.pannel(pa_sousMenu, panel5, panel6,panel7);
            
        }
       

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
          MAJPaiementDirecteur fe = new  MAJPaiementDirecteur ();
            if (fe == null)
            {
                fe = new  MAJPaiementDirecteur ();
            }
            else
            {
                if (fe.IsDisposed)
                {
                    fe = new  MAJPaiementDirecteur ();
                }
            }
            Program.Change(fe,panel4);

        }
        //private Form activeForm = null;
        //private void Change(Form enfant)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    activeForm = enfant;
        //    enfant.TopLevel = false;
        //    enfant.FormBorderStyle = FormBorderStyle.None;
        //    enfant.Dock = DockStyle.Fill;
        //    panel4.Controls.Add(enfant);
        //    panel4.Tag = enfant;
        //    enfant.BringToFront();
        //    enfant.Show();
        //}

       
       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_salaire_Click(object sender, EventArgs e)
        {
           Program.pannel(panel5, panel6, pa_sousMenu,panel7);
        }

        private void bt_conge_Click(object sender, EventArgs e)
        {
            Program.pannel(panel6, panel5, pa_sousMenu, panel7);
            panel9.Visible = false;
        }

        private void bt_AjouterSalaire_Click(object sender, EventArgs e)
        {
            Salaire fs = new Salaire();
            if (fs == null)
            {
                fs = new  Salaire();
            }
            else
            {
                if (fs.IsDisposed)
                {
                    fs = new  Salaire();
                }
            }
            Program.Change(fs, panel4);
        }

        private void bt_paiement_Click(object sender, EventArgs e)
        {
            PaiementEmploye fcs = new   PaiementEmploye  ();
            if (fcs == null)
            {
                fcs = new   PaiementEmploye ();
            }
            else
            {
                if (fcs.IsDisposed)
                {
                    fcs = new   PaiementEmploye ();
                }
            }
            Program.Change(fcs, panel4);
        }

        private void bt_AjouterConge_Click(object sender, EventArgs e)
        {
            Conge fC = new Conge();
            if (fC == null)
            {
                fC = new  Conge();
            }
            else
            {
                if (fC.IsDisposed)
                {
                    fC = new  Conge();
                }
            }
            Program.Change(fC, panel4);
        }

        private void bt_traiterConge_Click(object sender, EventArgs e)
        {
            ConsulterConge fcc = new  ConsulterConge();
            if (fcc == null)
            {
                fcc = new  ConsulterConge();
            }
            else
            {
                if (fcc.IsDisposed)
                {
                    fcc= new  ConsulterConge();
                }
            }
            Program.Change(fcc, panel4);
        }

        private void bt_Adherent_Click(object sender, EventArgs e)
        {
            ConsulterAdherent fca = new  ConsulterAdherent();
            if (fca == null)
            {
                fca = new  ConsulterAdherent();
            }
            else
            {
                if (fca.IsDisposed)
                {
                    fca = new  ConsulterAdherent();
                }
            }
            Program.Change(fca, panel4);
        }

        private void bt_parametre_Click(object sender, EventArgs e)
        {
           Program.pannel(panel7, pa_sousMenu, panel6,panel5);
          
        }

        private void bt_ChangeMP_Click(object sender, EventArgs e)
        {
            MotPasse fmp = new  MotPasse ();
            if (fmp == null)
            {
                fmp= new  MotPasse ();
            }
            else
            {
                if (fmp.IsDisposed)
                {
                    fmp = new  MotPasse ();
                }
            }
            Program.Change(fmp, panel4);
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            MAJPaiementEmploye fce = new   MAJPaiementEmploye  ();
            if (fce == null)
            {
                fce = new   MAJPaiementEmploye  ();
            }
            else
            {
                if (fce.IsDisposed)
                {
                    fce = new   MAJPaiementEmploye  ();
                }
            }
            Program.Change(fce, panel4);
        }

        private void bt_paimentFormateur_Click(object sender, EventArgs e)
        {
            PaiementFormateur ff = new  PaiementFormateur ();
            if (ff == null)
            {
                ff = new  PaiementFormateur ();
            }
            else
            {
                if (ff.IsDisposed)
                {
                    ff = new  PaiementFormateur ();
                }
            }
            Program.Change(ff, panel4);
        }

        private void bt_SpaimentFormateur_Click(object sender, EventArgs e)
        {
            ConsulterSalaire cs= new  ConsulterSalaire ();
            if (cs == null)
            {
                cs= new  ConsulterSalaire ();
            }
            else
            {
                if (cs.IsDisposed)
                {
                    cs = new   ConsulterSalaire  ();
                }
            }
            Program.Change(cs, panel4);

        }

        private void bt_Agenda1_Click(object sender, EventArgs e)
        {
            AgendaAdministrateur cs = new  AgendaAdministrateur ();
            if (cs == null)
            {
                cs = new  AgendaAdministrateur ();
            }
            else
            {
                if (cs.IsDisposed)
                {
                    cs = new  AgendaAdministrateur ();
                }
            }
            Program.Change(cs, panel4);
        }

        private void bt_AjourdHui_Click(object sender, EventArgs e)
        {
            AujourdHui cs = new  AujourdHui ();
            if (cs == null)
            {
                cs = new  AujourdHui ();
            }
            else
            {
                if (cs.IsDisposed)
                {
                    cs = new  AujourdHui ();
                }
            }
            Program.Change(cs, panel4);
        }

        private void bt_Agenda_Click(object sender, EventArgs e)
        {
            pa_sousMenu.Visible = true;
            //Program.pannel(panel8, panel7, panel6, panel5);
            //pa_sousMenu.Visible = false;
        }

        private void bt_Deconncte_Click(object sender, EventArgs e)
        {
            //Acceuil oa = new Acceuil();
            Program.menu.Show();
            Program.menu.BTN_agentAdministratif.Enabled = false;
            Program.user1 = null;
            this.Close();


           
        }

        private void bt_Statistique_Click(object sender, EventArgs e)
        {
            Program.pannel(panel9, panel5, pa_sousMenu, panel7);
            panel6.Visible = false;
        }

        private void bt_SEvenement_Click(object sender, EventArgs e)
        {
            StatiqueEvenement fC = new  StatiqueEvenement ();
            if (fC == null)
            {
                fC = new StatiqueEvenement();
            }
            else
            {
                if (fC.IsDisposed)
                {
                    fC = new StatiqueEvenement();
                }
            }
            Program.Change(fC, panel4);
        }

        private void bt_SFormation_Click(object sender, EventArgs e)
        {
            StatiqueFormation fC = new  StatiqueFormation ();
            if (fC == null)
            {
                fC = new  StatiqueFormation ();
            }
            else
            {
                if (fC.IsDisposed)
                {
                    fC = new  StatiqueFormation ();
                }
            }
            Program.Change(fC, panel4);

        }

        private void bt_SSalle_Click(object sender, EventArgs e)
        {
            StatistiqueSalle fC = new  StatistiqueSalle ();
            if (fC == null)
            {
                fC = new  StatistiqueSalle ();
            }
            else
            {
                if (fC.IsDisposed)
                {
                    fC = new  StatistiqueSalle ();
                }
            }
            Program.Change(fC, panel4);
        }
    }
}
