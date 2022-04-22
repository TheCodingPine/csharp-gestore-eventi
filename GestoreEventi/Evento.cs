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
        

        //capienzaMax: solo lettura (con setter!)
        public uint GetCapienzaMassima()
        { return this.capienzaMassima; }

        public void SetCapienzaMassima(uint capienzaMassima)
        {
            if (capienzaMassima.GetType() != typeof (uint))
            {
                throw new ArgumentException("capienzaMassima");
            }
            else
            {
                this.capienzaMassima = capienzaMassima;
            }
        }

        //prenotazioni: solo lettura;
        public uint GetPrenotazioni()
        { return this.prenotazioni; }


        //constructor con titolo, data, posti a disposizione, posti attuali =0


        public Evento (string titolo, DateTime data, uint capienzaMassima)
        {
            try //exception per il TItolo
            {
                SetTitolo (titolo);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Il titolo è NULL. Errore in " + e.ParamName); //get the name of parameter causing the exception
            }

            try //exception per la data
            {
                SetData (data);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine ("La data è antecedente a quelle possibili. Errore " + e.ParamName);
            }

            try //exception per la capienza
            {
                SetCapienzaMassima (capienzaMassima);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Inserisci un valore corretto. Errore " + e.ParamName);
            }


            //prenotazioni attuali = 0
            this.prenotazioni = 0;

        }


    }
}
