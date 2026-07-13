using ESERCIZIO_13_07_26;

using static ESERCIZIO_13_07_26.Pirata;

public class Program
{
    static void Main(string[] args)
    {
  
        Combattimento combattimento = new Combattimento();

        Pirata ciurma1 = new Pirata(combattimento, "Ciurma 1", 94);
        Pirata ciurma2 = new Pirata(combattimento, "Ciurma 2", 68);
        Marina marina = new Marina();

        combattimento.AttaccoRiuscito += marina.ControllaAttacco;

        combattimento.AttaccoFallito += marina.ControllaAttacco;


        ciurma1.LanciaAttacco(Attacco.Sciabola);

        ciurma2.LanciaAttacco(Attacco.Cannone);

    }
}

