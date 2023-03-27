using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class EmployeFils_Classe : Employe_Classe
    {
        private string Poste;
        private int Id_AgendaEmploye;
        private int Id_Connexion;
        public EmployeFils_Classe() : base() { }

        //public EmployeFils_Classe(int iD_Employe, string nom_Employe, string prenom_Employe, DateTime date_Naissance, string lieu_Naissance, string adresse, string tel_Employe, string email_Employe, string diplome_Employe,string Poste, int id_AgendaEmploye, int id_Connexion) : base(iD_Employe, nom_Employe, prenom_Employe, date_Naissance, lieu_Naissance, adresse, tel_Employe, email_Employe, diplome_Employe)
        //{
        //    this.Poste = Poste;
        //    this.Id_AgendaEmploye = id_AgendaEmploye;
        //    this.Id_Connexion = id_Connexion;
        //}

        public string Poste1 { get => Poste; set => Poste = value; }
        public int Id_AgendaEmploye1 { get => Id_AgendaEmploye; set => Id_AgendaEmploye = value; }
    }
}
