using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class GestoreTicket
    {
        private List<Ticket> tickets = new List<Ticket>();


        public void AggiungiTicket(Ticket t)
        {
            tickets.Add(t);
        }


        public void GestisciTicket()
        {
            foreach (Ticket t in tickets)
            {
                t.MostraTicket();

                t.Priorita();

                if (t is IManager approvabile)
                {
                    approvabile.ApprovaTicket();
                }
            }
        }
    }
}
