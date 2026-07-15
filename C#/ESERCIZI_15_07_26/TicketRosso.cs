using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class TicketRosso : Ticket, IManager
    {
        public TicketRosso(int id, string problema, string dipendente, DateTime dataTicket)
        : base(id, problema, dipendente, dataTicket)
        {

        }


        public override void Priorita()
        {
            Console.WriteLine("Priorità: Urgente");
        }

        public void ApprovaTicket()
        {
            Random random = new Random();

            bool approvato = Math.Round(random.NextDouble()) == 1;

            Console.WriteLine( approvato ? 
                "Il Manager ha approvato il ticket." : 
                "Il Manager NON ha approvato il ticket.");
        }
    }
}
