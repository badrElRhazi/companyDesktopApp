using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class FormationIndividual_Classe
    {
        private int ID_FORMATIONINDIVIDUAL;
        private int ID_EQUIPE;
        private string NOM_FORMATION;
        private string SECTEUR_ACTIVITE;
        private string MODE_REGLEMENT;
        public FormationIndividual_Classe() { }
        public FormationIndividual_Classe(int iD_FORMATIONINDIVIDUAL, int iD_EQUIPE, string nOM_FORMATION, string sECTEUR_ACTIVITE, string mODE_REGLEMENT)
        {
            ID_FORMATIONINDIVIDUAL = iD_FORMATIONINDIVIDUAL;
            ID_EQUIPE = iD_EQUIPE;
            NOM_FORMATION = nOM_FORMATION;
            SECTEUR_ACTIVITE = sECTEUR_ACTIVITE;
            MODE_REGLEMENT = mODE_REGLEMENT;
        }

        public int ID_FORMATIONINDIVIDUAL1 { get => ID_FORMATIONINDIVIDUAL; set => ID_FORMATIONINDIVIDUAL = value; }
        public int ID_EQUIPE1 { get => ID_EQUIPE; set => ID_EQUIPE = value; }
        public string NOM_FORMATION1 { get => NOM_FORMATION; set => NOM_FORMATION = value; }
        public string SECTEUR_ACTIVITE1 { get => SECTEUR_ACTIVITE; set => SECTEUR_ACTIVITE = value; }
        public string MODE_REGLEMENT1 { get => MODE_REGLEMENT; set => MODE_REGLEMENT = value; }
    }
}
