using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class Adherent_Classe:ClientGlobal_Classe
    {
        private int Id_Equipe;
        public Adherent_Classe() : base() { }

        public Adherent_Classe(int iD_Client, string CIN_client, string nom_Client, string prenom_Client, DateTime date_NaissanceClient, string adresseClient, string sexe, string telClient,int Id_Equipe):base(iD_Client,CIN_client,nom_Client,prenom_Client,date_NaissanceClient,  adresseClient,sexe,  telClient)
        {
            this.Id_Equipe = Id_Equipe;
        }

        public int Id_Equipe1 { get => Id_Equipe; set => Id_Equipe = value; }
    }
}
