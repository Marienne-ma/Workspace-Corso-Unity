using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class Bonifico : IMetodoPagamento
    {
        public string Iban { get; set; }

        public Bonifico(string iban)
        {
            Iban = iban;
        }

        public void Pagamento(double importo)
        {
            Console.WriteLine($"Hai eseguito un bonifico di {importo}€ con IBAN {Iban}");
        }
    }
}
