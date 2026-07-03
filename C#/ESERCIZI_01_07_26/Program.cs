
using ESERCIZI_01_07_26;

public class Program
{

    static void Main()
    {

        //ESERCIZIO 1
        double NumeroDouble = 123.78;

        int NumeroIntDaDouble = Convert.ToInt32(NumeroDouble);

        Console.WriteLine($"Numero double {NumeroDouble.ToString()}");
        //arrotonda il numero per trasformarlo in int.
        Console.WriteLine($"Numero double convertito in integer {NumeroIntDaDouble.ToString()}");

        int Numero2 = 150;

        double Numero2Double = Numero2;

        Console.WriteLine($"Tipo di Numero2: {Numero2.GetType()}");
        Console.WriteLine($"Tipo di Numero2Double: {Numero2Double.GetType()}");

        char Lettera = 'A';
        Console.WriteLine($"Lettera: {Lettera.ToString()}");

        int LetteraInt = Convert.ToInt32(Lettera);
        Console.WriteLine($"Lettera convertita in intero: {LetteraInt.ToString()}");
        //Preleva il codice ascii della lettera a e lo converte in intero.

        double LetteraDouble = Convert.ToDouble(LetteraInt);
        Console.WriteLine($"LetteraInt convertita in double: {LetteraDouble.ToString()}");
        //Preleva il valore della letteraInt e lo converte in double.

        LetteraInt = Convert.ToInt32(LetteraDouble);
        Console.WriteLine($"LetteraDouble convertita in intero: {LetteraInt.ToString()}");
        //Preleva il valore della letteraDouble e lo converte in intero.

        Lettera = Convert.ToChar(LetteraInt);
        Console.WriteLine($"LetteraInt convertita in char: {Lettera.ToString()}");
        //Preleva il valore della letteraInt e lo converte in char utilizzando il codice ASCII.



        //ESERCIZIO 2
        int eta = 25;
        float altezza = 1.83f;
        double voto = 10.2;
        decimal prezzo = 19.99m;
        string nome = "Giulia";
        char inizialeNome = nome[0];
        bool isMaggiorenne = eta >= 18;


        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Iniziale del nome: {inizialeNome}");
        Console.WriteLine($"Età: {eta}");
        Console.WriteLine($"Altezza: {altezza} metri");
        Console.WriteLine($"Voto: {voto.ToString("F1")}");
        Console.WriteLine($"Prezzo: {prezzo}");
        Console.WriteLine($"È maggiorenne: {isMaggiorenne}");



        //ESERCIZIO 3

        string nome1 = "Marianna";
        string cognome1 = "Masala";

        string nomeCompleto = $"{nome1} {cognome1}";
        Console.WriteLine($"Nome completo: {nomeCompleto}");


        
        //ESERCIZIO 4

        //var x; i var vanno inizializzati subito

        //var y = null; i var non possono essere null

        //int numero = null; i numeri non possono essere null a meno che non si facciano nullable con ?

        //char c = "A"; i char si scrivono con '' non con ""    

        //float f = 3.14; i float si scrivono con f alla fine del numero

        //decimal prezzo = 15.5; i decimal si scrivono con m alla fine del numero


    }
}