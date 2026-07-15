using ESERCIZI_15_07_26;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //ESERCIZIO 1
        GestorePagamenti gestorePagamenti = new GestorePagamenti();

        CartaDiCredito carta = new CartaDiCredito("1111222233334444");
        Paypal paypal = new Paypal("contodapoveri@gmail.com");
        Bonifico bonifico = new Bonifico("IT60X123456301000000123456");

        gestorePagamenti.AggiungiPagamento(carta);
        gestorePagamenti.AggiungiPagamento(paypal);
        gestorePagamenti.AggiungiPagamento(bonifico);

        gestorePagamenti.EseguiPagamento(carta, 100);
        gestorePagamenti.EseguiPagamento(paypal, 250);
        gestorePagamenti.EseguiPagamento(bonifico, 500);


        Console.WriteLine();

        //ESERCIZIO 2
        GestoreNemici gioco = new GestoreNemici();

        Goblin goblin = new Goblin("Goblin", 50);
        Drago drago = new Drago("Drago", 300);

        gioco.AggiungiNemico(goblin);
        gioco.AggiungiNemico(drago);

        gioco.FaiAttaccareNemici();

        Console.WriteLine();
        //ESERCIZIO 3
        GestoreTicket gestoreTicket = new GestoreTicket();


        gestoreTicket.AggiungiTicket(new TicketVerde(1, "Mouse non funziona", "Mario", new DateTime(2026, 7, 10, 9, 15, 0)));

        gestoreTicket.AggiungiTicket(new TicketVerde(2, "Tastiera rotta", "Luca", new DateTime(2026, 7, 11, 10, 30, 0)));

        gestoreTicket.AggiungiTicket(new TicketVerde(3, "Stampante senza carta", "Anna", new DateTime(2026, 7, 12, 14, 20, 0)));

        gestoreTicket.AggiungiTicket(new TicketVerde(4, "Problema con il monitor", "Giulia",new DateTime(2026, 7, 13, 8, 45, 0)));

        gestoreTicket.AggiungiTicket(new TicketVerde(5, "Errore software semplice", "Marco",new DateTime(2026, 7, 14, 16, 10, 0)));


        // Ticket Rossi
        gestoreTicket.AggiungiTicket(new TicketRosso(6, "Server aziendale offline", "Paolo",new DateTime(2026, 7, 10, 11, 30, 0)));

        gestoreTicket.AggiungiTicket(new TicketRosso(7, "Database non raggiungibile", "Francesca",new DateTime(2026, 7, 11, 13, 45, 0)));

        gestoreTicket.AggiungiTicket(new TicketRosso(8, "Blocco totale del gestionale", "Andrea",new DateTime(2026, 7, 12, 17, 25, 0)));

        gestoreTicket.AggiungiTicket(new TicketRosso(9, "Attacco informatico rilevato", "Davide",new DateTime(2026, 7, 13, 7, 50, 0)));

        gestoreTicket.AggiungiTicket(new TicketRosso(10, "Rete aziendale fuori servizio", "Sara",new DateTime(2026, 7, 14, 19, 40, 0)));



        gestoreTicket.GestisciTicket();

    }
}