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
        private uint capienzaMassima; //uint perchè > 0
        private uint prenotazioni; //uint perchè > 0




        //----------- getter - setter --------------

        //titolo: lettura e scrittura
        public string GetTitolo()
        { return this.titolo; }

        public void SetTitolo(string titolo)
        {
            if (titolo == null)
            { 
               throw new ArgumentNullException ("Il titolo è nullo");
            } else 
            {
                this.titolo = titolo; 
            }

        }
            


        //data: lettura e scrittura
        public DateTime GetData()
        { return this.data; }

        public void SetData(DateTime data)
        {
            if (data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException ("data");
            }
            else
            {
                this.data = data;
            }
        }
        

        //capienzaMax: solo lettura
        public uint GetCapienzaMassima()
        { return this.capienzaMassima; }

        //prenotazioni: solo lettura;
        public uint GetPrenotazioni()
        { return this.prenotazioni; }





        // metodo che inizializzi i posti a 0







    }
}
