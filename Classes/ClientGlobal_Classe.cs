using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class ClientGlobal_Classe
    {
        private int ID_Client;
        private string CIN_client;
        private string Nom_Client;
        private string Prenom_Client;
        private DateTime Date_NaissanceClient;
        private string AdresseClient;
        private string sexe;
        private string telClient;

        public ClientGlobal_Classe() { }

        public ClientGlobal_Classe(int iD_Client, string CIN_client, string nom_Client, string prenom_Client, DateTime date_NaissanceClient, string adresseClient, string sexe, string telClient)
        {
            ID_Client = iD_Client;
            this.CIN_client = CIN_client;
            Nom_Client = nom_Client;
            Prenom_Client = prenom_Client;
            Date_NaissanceClient = date_NaissanceClient;
            AdresseClient = adresseClient;
            this.sexe = sexe;
            this.telClient = telClient;
        }

        public int ID_Client1 { get => ID_Client; set => ID_Client = value; }
        public string Nom_Client1 { get => Nom_Client; set => Nom_Client = value; }
        public string Prenom_Client1 { get => Prenom_Client; set => Prenom_Client = value; }
        public DateTime Date_NaissanceClient1 { get => Date_NaissanceClient; set => Date_NaissanceClient = value; }
        public string AdresseClient1 { get => AdresseClient; set => AdresseClient = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string TelClient { get => telClient; set => telClient = value; }
    }
}
