using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        public string Titolo { get; set; }

        public List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> CercaPerData(DateTime dataCercata)
        {
            var eventiCercati = eventi.Where(evento => evento.Data == dataCercata).ToList();
            return eventiCercati;
        }

        public static string EventiToString(List<Evento> eventi)
        {
            StringBuilder listaStringa = new StringBuilder();

            foreach(Evento evento in eventi)
            {
                listaStringa.AppendLine($"Titolo: {evento.Titolo}, Data: {evento.Data.ToString("d")}, Posti Prenotati: {evento.PostiPrenotati}/{evento.CapienzaMax}");
                Console.WriteLine(evento.Titolo);
            }

            return listaStringa.ToString();
        }

        public int CounterEventi(List <Evento> eventi)
        {
            return (int)eventi.Count;
        }

        public void SvuotaListaEventi(List <Evento> eventi)
        {
            eventi.Clear();
        }

        public string ShowTitoloProgramma(List <Evento> eventi)
        {
            StringBuilder titoloProgramma = new StringBuilder();

            foreach(Evento evento in eventi)
            {
                titoloProgramma.AppendLine($"{evento.Data.ToString("d")} - {evento.Titolo}\n");
            }

            return titoloProgramma.ToString();
        }
    }
}
