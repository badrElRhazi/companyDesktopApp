using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3.Classes
{
    class FormateurFormationGroupe_Classe : Employe_Classe
    {
        private int ID_FORMATEUR;
        private int ID_FORMATIONIGROUPE;

        public FormateurFormationGroupe_Classe() { }
        public FormateurFormationGroupe_Classe(int iD_FORMATEUR, int iD_FORMATIONIGROUPE)
        {
            ID_FORMATEUR = iD_FORMATEUR;
            ID_FORMATIONIGROUPE = iD_FORMATIONIGROUPE;
        }

        public int ID_FORMATEUR1 { get => ID_FORMATEUR; set => ID_FORMATEUR = value; }
        public int ID_FORMATIONIGROUPE1 { get => ID_FORMATIONIGROUPE; set => ID_FORMATIONIGROUPE = value; }
    }
}
