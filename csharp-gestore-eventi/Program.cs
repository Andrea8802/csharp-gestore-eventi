namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il titolo per il programma eventi");
            string titoloProgramma = Console.ReadLine();

            ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);

            Console.WriteLine("Quanti eventi vuoi aggiungere?");
            int numeroEventi = int.Parse(Console.ReadLine());

            for(int i = 0; i<numeroEventi; i++)
            {
                Console.WriteLine("Inserisci titolo evento!");
                string titolo = Console.ReadLine();

                Console.WriteLine("Inserisci data evento!");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci capienza massima dell'evento!");
                int capienzaMax = int.Parse(Console.ReadLine());

                Evento newEvento = new Evento(titolo, data, capienzaMax);

                Console.WriteLine($"Evento '{newEvento.Titolo}' creato!");

                Console.WriteLine("Vuoi fare una prenotazione? (Si/No)");

                if (Console.ReadLine().ToLower() == "si")
                {
                    Console.WriteLine("Quante prenotazioni vuoi effettuare?");
                    int numPrenotazioni = int.Parse(Console.ReadLine());

                    for (int j = 0; j < numPrenotazioni; j++)
                    {
                        Console.WriteLine($"Prenotazione numero: {j + 1}\n Inserisci numero di posti per l'evento: ");
                        int posti = int.Parse(Console.ReadLine());
                        newEvento.PrenotaPosti(posti);

                        Console.WriteLine($"Rimangono {newEvento.CapienzaMax - newEvento.PostiPrenotati} posti!");

                    }

                    Console.WriteLine($"L'evento '{newEvento.Titolo}' ha {newEvento.PostiPrenotati}/{newEvento.CapienzaMax} posti prenotati");
                }

                Console.WriteLine("Vuoi disdire una prenotazione? (Si/No)");

                if (Console.ReadLine().ToLower() == "si")
                {
                    Console.WriteLine("Quante posti vuoi disdire?");
                    int numPrenotazioni = int.Parse(Console.ReadLine());

                    newEvento.DisdiciPosti(numPrenotazioni);

                    Console.WriteLine($"Hai disdetto {numPrenotazioni} all'evento '{newEvento.Titolo}' che ora ha {newEvento.PostiPrenotati}/{newEvento.CapienzaMax} posti prenotati");
                }

                programmaEventi.AggiungiEvento(newEvento);
            }

            Console.WriteLine($"Numero di eventi presenti nel programma: {programmaEventi.CounterEventi(programmaEventi.eventi)}");


            Console.WriteLine($"Lista completa eventi: {programmaEventi.ShowTitoloProgramma(programmaEventi.eventi)}");



            Console.WriteLine($"Cerca per data (dd/MM/yyyy):");
            DateTime dataRicercata = DateTime.Parse(Console.ReadLine());

            
            Console.WriteLine(ProgrammaEventi.EventiToString(programmaEventi.CercaPerData(dataRicercata)));

            programmaEventi.SvuotaListaEventi(programmaEventi.eventi);


            Console.WriteLine($"Lista completa eventi: {programmaEventi.ShowTitoloProgramma(programmaEventi.eventi)}");

        }
    }
}