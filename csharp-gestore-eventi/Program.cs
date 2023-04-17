using System;

namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto/a nel gestore degli eventi!\n");

            Console.WriteLine("Inserisci il titolo per il programma eventi...");
            string titoloProgramma = Console.ReadLine();
            while (string.IsNullOrEmpty(titoloProgramma))
            {
                Console.WriteLine("Devi inserire un titolo!");
                titoloProgramma = Console.ReadLine();

            }

            ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);


            

            while (true)
            {
                Console.WriteLine("\n-----------------------------------------------------");
                Console.WriteLine($"Cosa preferisci fare con il programma '{titoloProgramma}'?\n");
                Console.WriteLine($"1) Creare evento\n" +
                    $"2) Creare conferenza\n" +
                    $"3) Cercare programma per data\n" +
                    $"4) Visaluzzare lista completa programmi\n" +
                    $"5) Visaluzzare il numero dei programmi presenti nella lista\n" +
                    $"Esc) Esci\n");

                ConsoleKey tastoUtente = Console.ReadKey(true).Key;

                switch (tastoUtente)
                {
                    case ConsoleKey.D1:
                       
                        try
                        {
                            Console.WriteLine("Quanti eventi vuoi aggiungere?");
                            int numeroEventi = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numeroEventi; i++)
                            {
                                try
                                {
                                    Console.WriteLine("Inserisci titolo evento!");
                                    string titolo = Console.ReadLine();

                                    Console.WriteLine("Inserisci data evento!");
                                    DateTime data = DateTime.Parse(Console.ReadLine());

                                    Console.WriteLine("Inserisci capienza massima dell'evento!");
                                    int capienzaMax = int.Parse(Console.ReadLine());

                                    Evento newEvento = new Evento(titolo, data, capienzaMax);

                                    Console.WriteLine($"Evento '{newEvento.Titolo}' creato!");

                                    Console.WriteLine("Vuoi fare una prenotazione? (Y/N)");

                                    ConsoleKey sceltaUtentePrenotazione = Console.ReadKey(true).Key;

                                    if (sceltaUtentePrenotazione == ConsoleKey.Y)
                                    {
                                        Console.WriteLine("Imposta prenotazione!1n");


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

                                    else if (sceltaUtentePrenotazione == ConsoleKey.N)
                                        Console.WriteLine("Nessuna disdetta impostata!");

                                    else
                                        Console.WriteLine("Tasto non valido!");

                                    Console.WriteLine("Vuoi fare una disdetta? (Y/N)");

                                    ConsoleKey sceltaUtenteDisdetta = Console.ReadKey(true).Key;

                                    if (sceltaUtenteDisdetta == ConsoleKey.Y)
                                    {
                                        Console.WriteLine("Imposta disdetta!\n");

                                        Console.WriteLine("Quante posti vuoi disdire?");
                                        int numPrenotazioni = int.Parse(Console.ReadLine());

                                        newEvento.DisdiciPosti(numPrenotazioni);

                                        Console.WriteLine($"Hai disdetto {numPrenotazioni} all'evento '{newEvento.Titolo}' che ora ha {newEvento.PostiPrenotati}/{newEvento.CapienzaMax} posti prenotati");
                                    }

                                    else if (sceltaUtenteDisdetta == ConsoleKey.N)
                                        Console.WriteLine("Nessuna disdetta impostata!");

                                    else
                                        Console.WriteLine("Tasto non valido!");

                                    programmaEventi.AggiungiEvento(newEvento);
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine($"-----------------------------------------------------" +
                                        $"\n{ex.Message}\n" +
                                        $"-----------------------------------------------------");
                                }
                               
                            }


                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"-----------------------------------------------------" +
                                $"\n{ex.Message}\n" +
                                $"-----------------------------------------------------");
                        }

                        break;



                    case ConsoleKey.D2:

                        try
                        {
                            Console.WriteLine("Quante conferenze vuoi aggiungere?");
                            int numConferenze = int.Parse(Console.ReadLine());


                            for (int i = 0; i < numConferenze; i++)
                            {
                                try
                                {


                                    Console.WriteLine("Inserisci titolo conferenza!");
                                    string titolo = Console.ReadLine();

                                    Console.WriteLine("Inserisci il nome del relatore della conferenza!");
                                    string relatore = Console.ReadLine();

                                    Console.WriteLine("Inserisci prezzo conferenza!");
                                    double prezzo = double.Parse(Console.ReadLine());

                                    Console.WriteLine("Inserisci data conferenza!");
                                    DateTime data = DateTime.Parse(Console.ReadLine());

                                    Console.WriteLine("Inserisci capienza massima dell'conferenza!");
                                    int capienzaMax = int.Parse(Console.ReadLine());

                                    Conferenza newConferenza = new Conferenza(titolo, relatore, prezzo, data, capienzaMax);

                                    Console.WriteLine($"Evento '{newConferenza.Titolo}' creato!");


                                    Console.WriteLine("Vuoi fare una prenotazione? (Y/N)");
                                    ConsoleKey sceltaUtentePrenotazione = Console.ReadKey(true).Key;

                                    if (sceltaUtentePrenotazione == ConsoleKey.Y)
                                    {
                                        Console.WriteLine("Imposta prenotazione!\n");


                                        Console.WriteLine("Quante prenotazioni vuoi effettuare?");
                                        int numPrenotazioni = int.Parse(Console.ReadLine());

                                        for (int j = 0; j < numPrenotazioni; j++)
                                        {
                                            Console.WriteLine($"Prenotazione numero: {j + 1}\n Inserisci numero di posti per l'evento: ");
                                            int posti = int.Parse(Console.ReadLine());
                                            newConferenza.PrenotaPosti(posti);

                                            Console.WriteLine($"Rimangono {newConferenza.CapienzaMax - newConferenza.PostiPrenotati} posti!");

                                        }

                                        Console.WriteLine($"L'evento '{newConferenza.Titolo}' ha {newConferenza.PostiPrenotati}/{newConferenza.CapienzaMax} posti prenotati");
                                    }
                                    else if (sceltaUtentePrenotazione == ConsoleKey.N)
                                        Console.WriteLine("Nessuna prenotazione impostata!");

                                    else
                                        Console.WriteLine("Tasto non valido!");


                                    Console.WriteLine("Vuoi fare una prenotazione? (Y/N)");
                                    ConsoleKey sceltaUtenteDisdetta = Console.ReadKey(true).Key;

                                    if (sceltaUtenteDisdetta == ConsoleKey.Y)
                                    {
                                        Console.WriteLine("Imposta disdetta!\n");


                                        Console.WriteLine("Quante posti vuoi disdire?");
                                        int numPrenotazioni = int.Parse(Console.ReadLine());

                                        newConferenza.DisdiciPosti(numPrenotazioni);

                                        Console.WriteLine($"Hai disdetto {numPrenotazioni} all'evento '{newConferenza.Titolo}' che ora ha {newConferenza.PostiPrenotati}/{newConferenza.CapienzaMax} posti prenotati");
                                    }
                                    else if (sceltaUtenteDisdetta == ConsoleKey.N)
                                        Console.WriteLine("Nessuna disdetta impostata!");

                                    else
                                        Console.WriteLine("Tasto non valido!");

                                    programmaEventi.AggiungiEvento(newConferenza);

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"-----------------------------------------------------" +
                                        $"\n{ex.Message}\n" +
                                        $"-----------------------------------------------------");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"-----------------------------------------------------" +
                                $"\n{ex.Message}\n" +
                                $"-----------------------------------------------------");
                        }
                        break;

                    case ConsoleKey.D3:
                        try
                        {
                            Console.WriteLine($"Cerca per data (dd/MM/yyyy):");
                            DateTime dataRicercata = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine(ProgrammaEventi.EventiToString(programmaEventi.CercaPerData(dataRicercata)));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"-----------------------------------------------------" +
                                $"\n{ex.Message}\n" +
                                $"-----------------------------------------------------");
                        }

                        break;

                    case ConsoleKey.D4:
                        if (programmaEventi.eventi.Count() > 1)
                            Console.WriteLine($"Lista completa eventi: {programmaEventi.ShowTitoloProgramma(programmaEventi.eventi)}");

                        else
                            Console.WriteLine("La lista è vuota!");

                        break;


                    case ConsoleKey.D5:

                        Console.WriteLine($"Numero di eventi presenti nel programma: {programmaEventi.CounterEventi(programmaEventi.eventi)}");
                        
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Programma terminato!");
                        return;

                    default:
                        Console.WriteLine($"'{tastoUtente}' no è un tasto valido!\n");
                        break;
                }    
            
            }

        }
    }
}