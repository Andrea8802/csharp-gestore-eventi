namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Inserisci titolo evento!");
                string titolo = Console.ReadLine();

                Console.WriteLine("Inserisci data evento!");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci capienza massima dell'evento!");
                int capienzaMax = int.Parse(Console.ReadLine());

                Evento evento1 = new Evento(titolo, data, capienzaMax);

                Console.WriteLine($"Evento '{evento1.Titolo}' creato!");

                Console.WriteLine("Vuoi fare una prenotazione? (Si/No)");

                if(Console.ReadLine().ToLower() == "si")
                {
                    Console.WriteLine("Quante prenotazioni vuoi effettuare?");
                    int numPrenotazioni = int.Parse(Console.ReadLine());
                    
                    for(int i = 0; i < numPrenotazioni; i++)
                    {
                        Console.WriteLine($"Prenotazione numero: {i + 1}\n Inserisci numero di posti per l'evento: ");
                        int posti = int.Parse(Console.ReadLine());
                        evento1.PrenotaPosti(posti);

                        Console.WriteLine($"Rimangono {evento1.CapienzaMax - evento1.PostiPrenotati} posti!");

                    }

                    Console.WriteLine($"L'evento '{evento1.Titolo}' ha {evento1.PostiPrenotati}/{evento1.CapienzaMax} posti prenotati");
                }

                Console.WriteLine("Vuoi disdire una prenotazione? (Si/No)");

                if (Console.ReadLine().ToLower() == "si")
                {
                    Console.WriteLine("Quante posti vuoi disdire?");
                    int numPrenotazioni = int.Parse(Console.ReadLine());

                    evento1.DisdiciPosti(numPrenotazioni);

                    Console.WriteLine($"Hai disdetto {numPrenotazioni} all'evento '{evento1.Titolo}' che ora ha {evento1.PostiPrenotati}/{evento1.CapienzaMax} posti prenotati");
                }
            

        }
    }
}