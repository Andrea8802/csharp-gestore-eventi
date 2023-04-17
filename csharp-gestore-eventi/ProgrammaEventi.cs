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

        List <Evento> eventi = new List <Evento> ();

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
          
        }
    }
}
