using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Anime : OperaGiapponese
    {

        public int NumeroEpisodi { get; set; }
        public string StudioAnimazione { get; set; }

        public Anime(string titolo, string autore, int numeroEpisodi, string studioAnimazione)
            : base(titolo, autore)
        {
            NumeroEpisodi = numeroEpisodi;
            StudioAnimazione = studioAnimazione;
        }

        public override void MostraInfo()
        {
            Console.WriteLine($"Anime \nTitolo: {Titolo}; Autore: {Autore}; Episodi: {NumeroEpisodi}; Studio: {StudioAnimazione}");
        }

    }
}
