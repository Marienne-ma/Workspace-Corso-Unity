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
        public DateTime DataTicket {  get; set; }


        public Ticket(int id, string problema, string dipendente, DateTime dataTicket)
        {
            Id = id;
            Problema = problema;
            Dipendente = dipendente;
            DataTicket = dataTicket;
        }

        public void MostraTicket()
        {
            Console.WriteLine($"Ticket: {Id}, \ndata: {DataTicket.ToString("dd/MM/yyyy HH:mm:ss")} \nDipendente: {Dipendente}, \nproblema: {Problema}");

        }

        public abstract void Priorita();
    }
}
