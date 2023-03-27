using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csse3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
         public static Acceuil menu ;
        public static Classes.Directeur_Classe user;
        public static Classes.Employe_Classe user1;
        [STAThread]
        //public static listeEmploye menu;
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           menu = new Acceuil();
           // Application.Run(menu);
            Application.Run(new Archives());
        }
       static private Form activeForm = null;
       static public  string connection = @"Data Source=DESKTOP-1ASM0A6;Initial Catalog=ProjetFinFormationSiteWeb;" + "Integrated Security=true";
        static  public void Change(Form enfant,Panel p)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = enfant;
            enfant.TopLevel = false;
            enfant.FormBorderStyle = FormBorderStyle.None;
            enfant.Dock = DockStyle.Fill;
            p.Controls.Add(enfant);
            p.Tag = enfant;
            enfant.BringToFront();
            enfant.Show();
        }
        static public void pannel(Panel p1, Panel p2, Panel p3, Panel p4)
        {
            if (p1.Visible == false)
            {
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p1.Visible = true;
                p1.BringToFront();
            }
            else
            {
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p1.Visible = false;
                p1.BringToFront();
            }
        }

    }
}
