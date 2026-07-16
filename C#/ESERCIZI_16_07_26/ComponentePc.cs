using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_16_07_26
{
    internal class ComponentePc
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Prezzo { get; set; }
        public bool PresenzaMagazzino { get; set; }

        public void Stampa()
        {
            Console.WriteLine($"Prodotto: {Nome}\nCategoria: {Categoria}\nPrezzo: {Prezzo}€");
        }
    }
}
