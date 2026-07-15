using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal abstract class Ticket
    {
        public int Id { get; set; }
        public string Problema { get; set; }
        public string Dipendente { get; set; }

        public DateTime Data {  get; set; }


        public Ticket(int id, string problema, string dipendente, DateTime data)
        {
            Id = id;
            Problema = problema;
            Dipendente = dipendente;
            Data = data;
        }


        public void MostraTicket()
        {
            Console.WriteLine($"Ticket: {Id}");
            Console.WriteLine($"Dipendente: {Dipendente}");
            Console.WriteLine($"Problema: {Problema}");
        }
    }
}
