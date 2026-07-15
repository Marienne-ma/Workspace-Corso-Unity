using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class GestorePagamenti
    {
        private List<IMetodoPagamento> pagamenti = new List<IMetodoPagamento>();

        public void AggiungiPagamento(IMetodoPagamento p)
        {
            pagamenti.Add(p);
            Console.WriteLine("Metodo di pagamento aggiunto.");
        }

        public void EseguiPagamenti(double importo)
        {
            foreach (var p in pagamenti)
            {
                p.Pagamento(importo);
            }
        }
    }
}
