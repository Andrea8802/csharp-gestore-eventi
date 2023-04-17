using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Conferenza : Evento
    {
        private string relatore;
        public string Relatore
        {
            get
            {
                return relatore;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Il relatore deve avere un nome!");

                relatore = value;
            }
        }
        public double Prezzo { get; set; }
  

        public Conferenza(string titolo, string relatore, double prezzo, DateTime data, int capienzaMax) : base(titolo, data, capienzaMax)
        {
            Relatore = relatore;
            if (prezzo <= 0)
                throw new Exception("Il prezzo deve essere positivo!");

            else
                Prezzo = prezzo;
        }

        public string FormattazioneData()
        {
            return Data.ToString("dd/MM/yyyy");
        }

        public string FormattazionePrezzo()
        {
            return Prezzo.ToString("0.00");
        }

        public override string ToString()
        {
            return $"{FormattazioneData()} - {Titolo} - {Relatore} - {FormattazionePrezzo()}";
        }
    }
}

