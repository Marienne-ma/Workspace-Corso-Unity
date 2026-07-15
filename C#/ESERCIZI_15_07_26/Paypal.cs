using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class Paypal : IMetodoPagamento
    {
        public string Email { get; set; }

        public Paypal(string email)
        {
            Email = email;
        }

        public void Pagamento(double importo)
        {
            Console.WriteLine($"Hai pagato {importo}€ tramite PayPal ({Email})");
        }
    }
}
