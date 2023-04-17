using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;


        public string Titolo
        {
            get
            {
                return titolo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Il titolo non può essere vuoto!");

                    titolo = value;
            }
        }


        public DateTime Data {
            get
            {
                return data;
            }
            set
            {
                if (value < DateTime.Now)
                    throw new InvalidDataException("La data deve essere nel futuro!");

                    data = value;
            }
        }
        public int CapienzaMax { get; }
        public int PostiPrenotati { get { return postiPrenotati; } }


        public Evento(string titolo, DateTime data, int capienzaMax)
        {
                Titolo = titolo;
                Data = data;

                if (capienzaMax <= 0)
                    throw new Exception("La capienza massima deve avere un numeoro positivo!");

                else
                    CapienzaMax = capienzaMax;

                postiPrenotati = 0;
            
        }

        public int GetPostiPrenotati()
        {
            return PostiPrenotati;
        }

        public void PrenotaPosti(int numPosti)
        {
                if (Data < DateTime.Now)
                    throw new Exception("Evento già passato!");

                if ((CapienzaMax - postiPrenotati) == 0)
                    throw new Exception("Questo evento non ha più posti disponibili!");

                if (numPosti > (CapienzaMax - postiPrenotati))
                    throw new Exception("Non ci sono abbastanza posti!");

                postiPrenotati += numPosti;
        }

        public void DisdiciPosti(int numPosti)
        {
            if (Data < DateTime.Now)
                throw new Exception("Evento già passato!");

            if ((CapienzaMax - postiPrenotati) == 0)
                throw new Exception("Questo evento non ha nessuna prenotazione!");

            if (numPosti > (CapienzaMax - postiPrenotati))
                throw new Exception("Non ci sono abbastanza posti da disdire!");

            postiPrenotati -= numPosti;

        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy");
        }


    }
}
