using ESERCIZI_15_07_26;

public class Program
{
    static void Main(string[] args)
    {
        //ESERCIZIO 1
        GestorePagamenti gestore = new GestorePagamenti();

        CartaDiCredito carta = new CartaDiCredito("1111222233334444");
        Paypal paypal = new Paypal("contodapoveri@gmail.com");
        Bonifico bonifico = new Bonifico("IT60X123456301000000123456");

        gestore.AggiungiPagamento(carta);
        gestore.AggiungiPagamento(paypal);
        gestore.AggiungiPagamento(bonifico);

        gestore.EseguiPagamenti(250);

    }
}