using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_16_07_26
{
    internal class Abbigliamento
    {
        public string Modello { get; set; }
        public string Reparto { get; set; }
        public decimal PrezzoOriginale { get; set; }

        public void Stampa()
        {
            Console.WriteLine($"Modello: {Modello}\nReparto: {Reparto}\nPrezzo Originale: {PrezzoOriginale}€");
        }
    }
}
