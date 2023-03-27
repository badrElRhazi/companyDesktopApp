using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class FormationGroupe_Classe
    {
        private int ID_FORMATIONGROUPE;
        private int ID_EQUIPE;
        private string NOM_FORMATION;
        private string SECTEUR_ACTIVITE;
        private string MISSION;
        private string OBJECTIF;
        private int EFFECTIF;
        private string BESOIN_INDIVIDUELE;
        private string BESOIN;

        public FormationGroupe_Classe() { }
        public FormationGroupe_Classe(int iD_FORMATIONGROUPE, int iD_EQUIPE, string nOM_FORMATION, string sECTEUR_ACTIVITE, string mISSION, string oBJECTIF, int eFFECTIF, string bESOIN_INDIVIDUELE, string bESOIN)
        {
            ID_FORMATIONGROUPE = iD_FORMATIONGROUPE;
            ID_EQUIPE = iD_EQUIPE;
            NOM_FORMATION = nOM_FORMATION;
            SECTEUR_ACTIVITE = sECTEUR_ACTIVITE;
            MISSION = mISSION;
            OBJECTIF = oBJECTIF;
            EFFECTIF = eFFECTIF;
            BESOIN_INDIVIDUELE = bESOIN_INDIVIDUELE;
            BESOIN = bESOIN;
        }

        public int ID_FORMATIONGROUPE1 { get => ID_FORMATIONGROUPE; set => ID_FORMATIONGROUPE = value; }
        public int ID_EQUIPE1 { get => ID_EQUIPE; set => ID_EQUIPE = value; }
        public string NOM_FORMATION1 { get => NOM_FORMATION; set => NOM_FORMATION = value; }
        public string SECTEUR_ACTIVITE1 { get => SECTEUR_ACTIVITE; set => SECTEUR_ACTIVITE = value; }
        public string MISSION1 { get => MISSION; set => MISSION = value; }
        public string OBJECTIF1 { get => OBJECTIF; set => OBJECTIF = value; }
        public int EFFECTIF1 { get => EFFECTIF; set => EFFECTIF = value; }
        public string BESOIN_INDIVIDUELE1 { get => BESOIN_INDIVIDUELE; set => BESOIN_INDIVIDUELE = value; }
        public string BESOIN1 { get => BESOIN; set => BESOIN = value; }
    }
}
