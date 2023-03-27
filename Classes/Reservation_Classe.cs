using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csse3
{
    class Reservation_Classe
    {
        private int ID_RESERVATION;
        private DateTime DATE_RESRVATION;
        private int ID_CLIENT;
        private int ID_SALLE;

        public Reservation_Classe() { }
        public Reservation_Classe(int iD_RESERVATION, DateTime DATE_RESRVATION, int iD_CLIENT, int iD_SALLE)
        {
            ID_RESERVATION = iD_RESERVATION;
           this.DATE_RESRVATION = DATE_RESRVATION;
            ID_CLIENT = iD_CLIENT;
            ID_SALLE = iD_SALLE;
        }

        public int ID_RESERVATION1 { get => ID_RESERVATION; set => ID_RESERVATION = value; }
        public DateTime DATE_RESRVATION1 { get => DATE_RESRVATION; set => DATE_RESRVATION = value; }
        public int ID_CLIENT1 { get => ID_CLIENT; set => ID_CLIENT = value; }
        public int ID_SALLE1 { get => ID_SALLE; set => ID_SALLE = value; }
    }
}
