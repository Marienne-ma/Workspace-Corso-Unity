using ESERCIZI_09_07_26;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //ESERCIZIO 1
        Studente studente = new Studente("Mario", new int[] { 8, 7, 9, 6, 8 });


        double media = studente.CalcolaMediaVoti(studente.Voti);
        string giudizio = studente.GiudizioVoti(studente.Voti);

        Console.WriteLine($"Nome: {studente.Nome.ToUpper()}, media dei voti: {media:F2}, giudizio: {giudizio}");


        //ESERCIZIO 2
        string[] codici =  {
            " ANT-4922 ",
            "ANT-1234",
            "ABC-5678",
            "",
            null,
            "ANT  -9999"
        };
        NegozioAntiquariato negozioAntiquariato
            = new NegozioAntiquariato(codici);

        negozioAntiquariato.ControllaCodici(negozioAntiquariato.Codici);


        //ESERCIZIO 3
        Acquario acquario = new Acquario();

        acquario.StampaAcquario();
        acquario.ContaVasche();
        acquario.DiagonalePrincipale();
        acquario.DiagonaleSecondaria();
        acquario.CercaPesceDelfinoOPagliaccio("Pesce Pagliaccio");
        acquario.CercaPesceDelfinoOPagliaccio("Delfino");


        //ESERCIZIO 4
        string testo = "L'articolo è stato venduto a Luca con un prezzo speciale di €250";

        string nomeSbagliato = "Luca";

        string nomeCorretto = "Marco";

        if (testo.Contains(nomeSbagliato))
        {
            Console.WriteLine("Nome errato trovato");

            testo = testo.Replace(nomeSbagliato, nomeCorretto);

            Console.WriteLine($"Nome {nomeSbagliato} sostituito con {nomeCorretto}");
        }
        else
        {
            Console.WriteLine("Nome errato non presente");
        }


        if (testo.Contains("prezzo"))
        {
            testo = testo.Replace("prezzo", "prz");

            Console.WriteLine("Prezzo sostituito con prz");

        }

        Console.WriteLine($"Testo modificato: {testo}");

        int posizioneEuro = testo.IndexOf("€");

        string prezzo = testo.Substring(posizioneEuro+1);

        int prezzoInt = int.Parse(prezzo);

        int risultato = (int)Math.Pow(prezzoInt, 2);

        Console.WriteLine($"Prezzo elevato alla seconda: {risultato}");

        //ESERCIZIO 5
        acquario.VerificaFiltri(acquario.temperature, out int nAnomalie, out double[,] temperatureCorrette);


    }
}
