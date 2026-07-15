using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class CartaDiCredito : IMetodoPagamento
    {
        public string NumeroCarta { get; set; }

        public CartaDiCredito(string numeroCarta)
        {
            NumeroCarta = numeroCarta;
        }

        public void Pagamento(double importo)
        {
            Console.WriteLine($"Hai pagato {importo}€ con carta {NumeroCarta}");
        }
    }
}
