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
        }

        public void EseguiPagamento(IMetodoPagamento metodo, double importo)
        {
            metodo.Pagamento(importo);
        }
    }
}
