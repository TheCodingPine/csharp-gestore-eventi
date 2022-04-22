using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int prenotazioni;




        //getter - setter

        //titolo: lettura e scrittura

        //data: lettura e scrittura



        //capienzaMax: solo lettura

        public int GetCapienzaMassima()
        { return capienzaMassima; }

        //prenotazioni: solo lettura;

        public int GetPrenotazioni()
        { return prenotazioni; }












    }
}
