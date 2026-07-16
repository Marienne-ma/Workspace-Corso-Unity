using ESERCIZI_16_07_26;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //ESERCIZIO 1

        List<Citta> citta = new List<Citta>()
        {
            new Citta(){Nome="Cagliari", Temperatura=41, Umidita=55},   
            new Citta(){Nome="Palermo", Temperatura=38, Umidita=60},   
            new Citta(){Nome="Catanzaro", Temperatura=32, Umidita=65},  
            new Citta(){Nome="Venezia", Temperatura=27, Umidita=75},    
            new Citta(){Nome="Milano", Temperatura=24, Umidita=80}     
        };

        var cittaCalde = citta.Where(c => c.Temperatura > 30);

        Console.WriteLine("Città con temperature sopra i 30 gradi:");

        foreach (var c in cittaCalde)
        {
            Console.WriteLine(); 
            c.Stampa();
        }


        var cittaOrdinate = citta.OrderBy(c => c.Temperatura);

        Console.WriteLine();
        Console.WriteLine("Città in ordine decrescente di temperature:");

        foreach (var c in cittaOrdinate)
        {
            Console.WriteLine();
            c.Stampa();
        }
        Console.WriteLine();

        //ESERCIZIO 2

        List<ComponentePc> componenti = new List<ComponentePc>()
            {
                new ComponentePc(){Nome="SSD",Categoria="Memoria",Prezzo=120,PresenzaMagazzino=true},
                new ComponentePc(){Nome="RAM 16GB",Categoria="RAM",Prezzo=80,PresenzaMagazzino=true},
                new ComponentePc(){Nome="RTX4070",Categoria="GPU",Prezzo=650,PresenzaMagazzino=true},
                new ComponentePc(){Nome="Monitor",Categoria="Monitor",Prezzo=220,PresenzaMagazzino=true},
                new ComponentePc(){Nome="CPU i7",Categoria="CPU",Prezzo=360,PresenzaMagazzino=false},
                new ComponentePc(){Nome="Mouse",Categoria="Periferiche",Prezzo=35,PresenzaMagazzino=true}
            };

      
        var sotto_300 = componenti.Where(c => c.Prezzo < 300 && c.PresenzaMagazzino);

        Console.WriteLine("Sotto i 300€ sono disponibili i seguenti prodotti:");
        
        foreach (var c in sotto_300)
        {
            Console.WriteLine();
            c.Stampa();
        }

       
        List<string> nomiComponenti = componenti
            .Where(c => c.PresenzaMagazzino)
            .Select(c => c.Nome)
            .ToList();

        Console.WriteLine();
        Console.WriteLine("Nomi dei prodotti disponibili");

        foreach (var n in nomiComponenti)
        {
            Console.WriteLine();
            Console.WriteLine(n);
        }
       
        bool prodottoCostoso = componenti.Any(c => c.Prezzo > 500);
        Console.WriteLine();
        Console.WriteLine($"C'è un prodotto che costa più di 500€? {prodottoCostoso}");
        Console.WriteLine();


        //ESERCIZIO 3

        List<Abbigliamento> prodotti = new List<Abbigliamento>()
            {
                new Abbigliamento(){Modello="Gonna plissettata",Reparto="Donna",PrezzoOriginale=90},
                new Abbigliamento(){Modello="Camicetta estiva",Reparto="Donna",PrezzoOriginale=45},
                new Abbigliamento(){Modello="Pantaloncino corto",Reparto="Bambino",PrezzoOriginale=30},
                new Abbigliamento(){Modello="T-shirt",Reparto="Uomo",PrezzoOriginale=30},
                new Abbigliamento(){Modello="Vestitino a sbuffo",Reparto="Bambina",PrezzoOriginale=60},
                new Abbigliamento(){Modello="Trench",Reparto="Donna",PrezzoOriginale=150}
            };

        var donna = prodotti
            .Where(p => p.Reparto == "Donna")
            .OrderBy(p => p.PrezzoOriginale);

        Console.WriteLine("Reparto Donna");

        foreach (var c in donna)
        {
            Console.WriteLine();
            c.Stampa();
        }

        Console.WriteLine();
        Console.WriteLine("\nProdotti in saldo:");
        
        var scontati = prodotti.Select(p =>
            $"Modello: {p.Modello} - Reparto: {p.Reparto} - Prezzo Originale: {p.PrezzoOriginale}€ - Prezzo Scontato: {(p.PrezzoOriginale * 0.80m):F2}€");

        foreach (var s in scontati)
        {
            Console.WriteLine();
            Console.WriteLine(s);
        }
            


    }
}
