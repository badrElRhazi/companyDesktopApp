using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class FormateurFormationIndividuele_Classe
    {
        private int ID_FORMATEUR;
        private int ID_FORMATIONINDIVIDUELE;

        public FormateurFormationIndividuele_Classe() { }
        public FormateurFormationIndividuele_Classe(int iD_FORMATEUR, int iD_FORMATIONINDIVIDUELE)
        {
            ID_FORMATEUR = iD_FORMATEUR;
            ID_FORMATIONINDIVIDUELE = iD_FORMATIONINDIVIDUELE;
        }

        public int ID_FORMATEUR1 { get => ID_FORMATEUR; set => ID_FORMATEUR = value; }
        public int ID_FORMATIONINDIVIDUELE1 { get => ID_FORMATIONINDIVIDUELE; set => ID_FORMATIONINDIVIDUELE = value; }
    }
}
