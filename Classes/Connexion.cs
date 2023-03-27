using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class Connexion
    {
        private int Id_Connexion;
        private string CIN;
        private string MotDePasse;

        public Connexion() { }
        public Connexion(int id_Connexion, string cIN, string motDePasse)
        {
            Id_Connexion = id_Connexion;
            CIN = cIN;
            MotDePasse = motDePasse;
        }

        public int Id_Connexion1 { get => Id_Connexion; set => Id_Connexion = value; }
        public string CIN1 { get => CIN; set => CIN = value; }
        public string MotDePasse1 { get => MotDePasse; set => MotDePasse = value; }
    }
}
