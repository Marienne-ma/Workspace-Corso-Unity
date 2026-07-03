using ESERCIZI_03_07_26;

public class Program
{

    public static void Main(string[] args)
    {
        //ESERCIZIO 1

        int[] temperatureSettimana = [20, 27, 28, 25, 18, 22, 21];

        int[] tempMerSab = temperatureSettimana[2..6];

        Console.WriteLine(string.Join(", ", tempMerSab));


        int tempMin = temperatureSettimana.Min();
        int tempMax = temperatureSettimana.Max();

        Console.WriteLine($"La temperatura minima della settimana è: {tempMin}");
        Console.WriteLine($"La temperatura massima della settimana è: {tempMax}");

        //Con i dictionary

        Dictionary<string, int> temperatureSettimanaDictionary = new Dictionary<string, int>(){
                                        { "Lunedì", 20 },
                                        { "Martedì", 27 },
                                        { "Mercoledì", 28 },
                                        { "Giovedì", 25 },
                                        { "Venerdì", 18 },
                                        { "Sabato", 22 },
                                        { "Domenica", 21 }
                                    };


        var tempMerSabD = temperatureSettimanaDictionary.Skip(2).Take(4); //parti da indicem2 e preleva 4 elementi

        foreach (var giorno in tempMerSabD)
        {
            Console.WriteLine($"{giorno.Key}: {giorno.Value}");
        }


        int tempMinD = temperatureSettimanaDictionary.Values.Min();
        int tempMaxD = temperatureSettimanaDictionary.Values.Max();

        Console.WriteLine($"Temperatura minima dictionary: {tempMinD}");
        Console.WriteLine($"Temperatura massima dictionary: {tempMaxD}");


        //ESERCIZIO 2

        Animale a1 = new Animale{ Nome = "Leone", Eta = 5 };

        Animale a2 = a1; 
        a2.Nome = a2.Nome + " Africano"; 

        a2.CambiaEta(6);

        //Descrivi dettagliatamente cosa succede nella memoria centrale (Stack e Heap) durante l'esecuzione di questo codice, ed  in particolare, rispondi ai seguenti punti:

        //Nello stack viene creata la variabile a1 che contiene un riferimento all'oggetto Animale, non contiene l'animale stesso che invece viene allocato nell'Heap. a2 viene creata nello stack e contiene lo stesso riferimento all'oggetto Animale di a1. Sia a1 che a2 puntano allo stesso animale nell'Heap

        //Quanti oggetti di tipo Animale vengono effettivamente allocati nell'Heap?
        //1


        //Spiega il comportamento dell'assegnazione Animale a2 = a1;(punto1)
        //come scritto su tutte e 2 le variabili di tipo Animale punteranno allo stesso oggetto dell'Heap


        //Cosa accade in memoria quando viene eseguita la riga a2.Nome = a2.Nome + " Africano";?
        //viene modificato il nome dell'oggetto Animale nell'Heap, quindi sia a1 che a2 avranno lo stesso nome e il vecchio verrà gestito dal garbage collector



        //Qual è il valore finale di a1.Eta e a2.Eta? Spiega la differenza di comportamento rispetto al punto 1 basandoti sulla distinzione tra Tipi Valore e Tipi Riferimento.
        //viene modificata l'età dell'oggetto a cui puntano le 2 variabili, quindi sia a1 che a2 avranno la stessa età perchè sono entrambi riferimenti allo stesso oggetto, se fossero stati tipi valore avrebbero avuto valori distinti e ognuno potrebbe essere modificato senza influenzare l'altro.



        //spiega anche che cosa si sta scrivendo nella forma “compatta” quando si dichiarano le proprietà della classe
        //la forma compatta della classe sono le proprietà con i metodi get e set definiti senza andare a scrivere il codice completo di cosa fa il set e il get, la forma non compatta è questa:
        //public string Nome
        //{
        //    get
        //    {
        //        return nome;
        //    }

        //    set
        //    {
        //        nome = value;
        //    }
        //}


        //ESERCIZIO 3

        //AnimaleRecord è nella classe Animale 


        Animale leone = new Animale
        { 
            Nome = "Leone", 
            Eta = 2 
        };

        Animale elefante = new Animale
        { 
            Nome = "Elefante", 
            Eta = 15 
        };

        Animale tigre = new Animale
        {
            Nome = "Tigre",
            Eta = 7
        };


        Animale animaleCopiato = leone;

        leone.CambiaEta(3);//cambia sia di animale 1 che della copia


        Console.WriteLine($"Animale 1: {leone.Nome}, Età: {leone.Eta}, animale copiato: {animaleCopiato.Nome}, Età: {animaleCopiato.Eta}");


        Animale animale1 = new Animale { Nome = "Lupo", Eta = 10 };
        Animale animale2 = new Animale { Nome = "Lupo", Eta = 10 };

        AnimaleRecord animaleRecord1 = new AnimaleRecord( "Rinoceronte", 12 );
        AnimaleRecord animaleRecord2 = new AnimaleRecord("Rinoceronte", 12);

        Console.WriteLine($"animale1 == animale2? {animale1 == animale2}");//false perché sono due oggetti (new()) distinti anche se hanno gli stessi valori

        Console.WriteLine($"animaleRecord1 == animaleRecord2? {animaleRecord1 == animaleRecord2}");//true perché sono due record con gli stessi valori, quindi sono considerati uguali anche se sono due oggetti diversi (new()).

        leone.ModificaAnimale(leone);
        Console.WriteLine(leone.Nome);
        //viene visualizzato il nuovo nome dell'animale, perché il metodo ModificaAnimale modifica il nome a cui punta la variabile leone.



        //ESERCIZIO 4   

        //enum creato nella classe biblioteca

        Biblioteca libro = new Biblioteca
        {
            Titolo = "Jujutsu Kaisen",
            Tipo = TipoLibro.Fumetti,
            RegistroGenerico = 100
        };

        
        libro.CambiaTitolo("Topolino");
        Console.WriteLine($"Titolo di libro: {libro.Titolo}");


        dynamic registro = libro.RegistroGenerico;
        registro = "Registro Biblioteca";
        Console.WriteLine(registro);
        //ora registro è di tipo string, quindi il tipo di dato è cambiato da int a string, perché la variabile registro è di tipo dynamic e può cambiare tipo in fase di esecuzione. Può risultare rischioso perchè le string non accettano metodi per int.

        string stato = registro is string ? 
            "Registro valido" : "Registro non valido";
        Console.WriteLine(stato);

        Console.WriteLine($"{(libro.Tipo == TipoLibro.Fumetti ? "È un Fumetto." : "Non è un Fumetto.")}");



    }
}
