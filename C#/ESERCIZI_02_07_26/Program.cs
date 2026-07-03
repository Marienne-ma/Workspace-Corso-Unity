using ESERCIZI_02_07_26;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {

        //ESERCIZIO 1

        int n = 150;
        double nDouble = (double)n;
        char l = 'a';
        string s = l.ToString();
        Console.WriteLine($"n = {n} tipo {n.GetType()}, nDouble = {nDouble} tipo {typeof(double)}, l = {l} tipo {l.GetType()}, s = {s} tipo {typeof(string)}");


        //ESERCIZIO 2

        string nome = "pluto";
        string cognome = "paperino";
        DateOnly dataDiNascita = DateOnly.Parse("01/01/2010");


        Console.WriteLine($"Nome: {nome}, Cognome: {cognome}, Data di nascita: {dataDiNascita.ToString("dd/MM/yyyy")}, {(IsMaggiorenne(dataDiNascita) ? "" : "non ")} può conseguire la patente ");


        //ESERCIZIO ALIENO
        Alieno alieno1 = new Alieno
        {
            colore = "Verde",
            numeroOcchi = 2,
            numeroBraccia = 4,
            altezza = 1.8,
            haPoteri = true,
            haArmi = false,
            energia = 200,
            ostilità = true,
            pianetaDiProvenienza = "Marte",
            telefono = "333111222"
        };

        Alieno alieno2 = new Alieno
        {
            colore = "Rosso",
            numeroOcchi = 3,
            numeroBraccia = 6,
            altezza = 2.1,
            haPoteri = true,
            haArmi = true,
            energia = 120,
            ostilità = false,
            pianetaDiProvenienza = "Giove",
            telefono = "444555666"
        };

        Alieno alieno3 = new Alieno
        {
            colore = "Blu",
            numeroOcchi = 1,
            numeroBraccia = 2,
            altezza = 1.5,
            haPoteri = false,
            haArmi = false,
            energia = null,
            ostilità = true,
            pianetaDiProvenienza = "Marte",

        };

        alieno1.StampaInfo();
        alieno2.StampaInfo();
        alieno3.StampaInfo();

        Console.WriteLine(alieno1.ostilità ? "Alieno 1 ostile" : "Alieno 1 amico");
        Console.WriteLine(alieno2.ostilità ? "Alieno 2 ostile" : "Alieno 2 amico");

        Alieno piuForte = alieno1.ControllaEnergia(alieno1, alieno2);
        Console.WriteLine($"Alieno con più energia: {piuForte.colore}");

        alieno1.PassaEnergia(alieno1, alieno2);

        Console.WriteLine($"Energia Alieno 3 : {Convert.ToInt32(alieno3.energia)}");

        bool risultato = alieno1.ControlloEnergiaEOstilita(alieno1);
        Console.WriteLine(risultato);

        alieno1.ControlloColore(alieno1, alieno2, alieno3);

        Console.WriteLine($"Alieno 1 {(alieno1.ControlloMarte(alieno1) ? "da Marte" : "non da Marte")}");
        Console.WriteLine($"Alieno 2 {(alieno2.ControlloMarte(alieno2) ? "da Marte" : "non da Marte")}");
        Console.WriteLine($"Alieno 3 {(alieno3.ControlloMarte(alieno3) ? "da Marte" : "non da Marte")}");


        Console.WriteLine($"Alieno 3 {(alieno3 is Alieno ? "è un alieno" : "non è un alieno")}");

        Console.WriteLine($"Numero di telefono di Alieno 3: {alieno3.telefono}");



        //ESERCIZIO 3
        string nome1 = "Leila";
        nome1.ToUpper();
        Console.WriteLine(nome1);
        //viene stampato sempre Leila perchè ToUpper() restituisce una nuova stringa e non modifica la stringa originale a meno chè non si sovrascrivi nome1 


        //ESERCIZIO 4

        string[] colori = new string[]{
            "rosso",
            "blu", 
            "verde", 
            "giallo", 
            "nero",
            "bianco", 
            "arancione", 
            "viola", 
            "rosa", 
            "marrone",
            "grigio", 
            "azzurro",
            "indaco", 
            "turchese", 
            "magenta"
        };

        string[] ultime10 = new string[10];
        string[] prime5 = new string[5];
        string[] dalla4alla8 = new string[5];

        for (int i = 0; i < colori.Length; i++)
        {

            if (i < 5)
            {
                prime5[i]    = colori[i];
            }


            if (i > 4)
            {
                ultime10[i - (colori.Length - 10)] = colori[i];
            }

            if (i >= 3 && i < 8)
            {
                dalla4alla8[i - 3] = colori[i];
            }
        }

        foreach (string colore in prime5)
        {
            Console.WriteLine($"Prime 5: {colore}");
        }

        foreach (var colore in ultime10)
        {
            Console.WriteLine($"Ultime 10: {colore}");
        }

        foreach (var colore in dalla4alla8)
        {
            Console.WriteLine($"Dalla 4 alla 8: {colore}");
        }



        //ESERCIZIO 5

        Console.WriteLine(16 >> 1);
        Console.WriteLine(120 << 1);



    }

    static bool IsMaggiorenne(DateOnly dataDiNascita)
    {
        DateOnly oggi = DateOnly.FromDateTime(DateTime.Now);

        //recupero gli anni di differenza tra oggi e la data di nascita
        int eta = oggi.Year - dataDiNascita.Year;

        //aggiungo gli anni per vedere se la data di nascita è già passata quest'anno, se non è passata tolgo 1 anno
        if (dataDiNascita > oggi.AddYears(-eta)) eta--;


        return eta >= 18 ? true : false;
    }



}