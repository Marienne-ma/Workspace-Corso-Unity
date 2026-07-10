using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Manga : OperaGiapponese
    {
        public int VolumiRilasciati { get; set; }

        public Manga(string titolo, string autore, int volumiRilasciati)
            : base(titolo, autore)
        {
            VolumiRilasciati = volumiRilasciati;
        }

        public override void MostraInfo()
        {
            Console.WriteLine($"Manga \nTitolo: {Titolo}; Autore: {Autore}; Volumi: {VolumiRilasciati}");
        }

    }
}
