using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class TicketVerde : Ticket
    {
        public TicketVerde(int id, string problema, string dipendente, DateTime dataTicket)
            : base(id, problema, dipendente, dataTicket)
        {

        }


        public override void Priorita()
        {
            Console.WriteLine("Priorità: Bassa");
        }
    }
}
