using ESERCIZI_15_07_26;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //ESERCIZIO 1
        GestorePagamenti gestore = new GestorePagamenti();

        CartaDiCredito carta = new CartaDiCredito("1111222233334444");
        Paypal paypal = new Paypal("contodapoveri@gmail.com");
        Bonifico bonifico = new Bonifico("IT60X123456301000000123456");

        gestore.AggiungiPagamento(carta);
        gestore.AggiungiPagamento(paypal);
        gestore.AggiungiPagamento(bonifico);

        gestore.EseguiPagamento(carta, 100);
        gestore.EseguiPagamento(paypal, 250);
        gestore.EseguiPagamento(bonifico, 500);


        //ESERCIZIO 2
        GestoreNemici gioco = new GestoreNemici();

        Goblin goblin = new Goblin("Goblin", 50);
        Drago drago = new Drago("Drago", 300);

        gioco.AggiungiNemico(goblin);
        gioco.AggiungiNemico(drago);

        gioco.FaiAttaccareNemici();
    }
}