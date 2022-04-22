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
            catch (ArgumentException e)
            {
                Console.WriteLine("Inserisci un valore corretto. Errore " + e.ParamName);
            }


            //prenotazioni attuali = 0
            this.prenotazioni = 0;

        }

        //-------metodi public----------

        //Prenota
        public void Prenota(uint numeroPrenotazioni)
        {
            if (this.data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Data errata");
            }
            else if (this.capienzaMassima++ > this.capienzaMassima)
            {
                throw new ArgumentOutOfRangeException("Capienza massima raggiunta");
            }
            else if (numeroPrenotazioni.GetType() != typeof(uint))
            {
                throw new ArgumentException("Inserire un numero valido");
            }
            else
            {
                this.prenotazioni = this.prenotazioni + numeroPrenotazioni;
            }
        }


        //Disdici
        public void Disdici(uint numeroDisdette)
        {
            if (this.data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (this.prenotazioni <= 0)
            {
                throw new ArgumentOutOfRangeException("Nessun posto prenotato");
            }
            else if (numeroDisdette.GetType() != typeof(uint))
            {
                throw new ArgumentException("Inserire un numero valido");
            }
            else
            {
                this.prenotazioni = this.prenotazioni - numeroDisdette;
            }
        }

        //override di TOString

        public override string ToString()
        {
            string stampa = this.data.ToString("dd/MM/yyyy") + " - " + this.titolo;

            return stampa;
        }
    }
}
