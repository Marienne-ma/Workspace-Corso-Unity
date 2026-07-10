using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class OperaGiapponese
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }

        public OperaGiapponese(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
        }

        public virtual void MostraInfo()
        {
            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Autore: {Autore}");
        }
    }
}
