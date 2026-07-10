using ESERCIZI_10_07_26;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        //ESERCIZIO 1 

        CaffeInCapsule caffeInCapsule = new CaffeInCapsule("Arabica", 12.50, MaterialeCapsula.Compostabile, Compatibilita.Borbone);
        
        caffeInCapsule.Prepara();
        Console.WriteLine();
        Console.Write(caffeInCapsule.ToString());
        Console.WriteLine();//non so perchè questo non funzioni




        //ESERCIZIO 2

        List<OperaGiapponese> opere = new List<OperaGiapponese>();

        Manga yona = new Manga("Yona of the Dawn", "Mizuho Kusanagi", 48);
        Manga kamisama = new Manga("Kamisama Kiss", "Julietta Suzuki", 25);
        Manga vampireKnight = new Manga("Vampire Knight", "Matsuri Hino", 19);
        Manga dreamingFreedom = new Manga("Dreaming Freedom", "2L", 180);
        Manga fruitsBasket = new Manga("Fruits Basket", "Natsuki Takaya", 23);


        Anime sailorMoon = new Anime("Sailor Moon", "Naoko Takeuchi", 200, "Toei Animation");
        Anime dragonBall = new Anime("Dragon Ball", "Akira Toriyama", 153, "Toei Animation");
        Anime jujutsuKaisen = new Anime("Jujutsu Kaisen", "Gege Akutami", 47, "MAPPA");
        Anime inuyasha = new Anime("Inuyasha", "Rumiko Takahashi", 193, "Sunrise");
        Anime spyXFamily = new Anime("Spy x Family", "Tatsuya Endo", 37, "Wit Studio e CloverWorks");


        opere.Add(yona);
        opere.Add(kamisama);
        opere.Add(vampireKnight);
        opere.Add(dreamingFreedom);
        opere.Add(fruitsBasket);

        opere.Add(sailorMoon);
        opere.Add(dragonBall);
        opere.Add(jujutsuKaisen);
        opere.Add(inuyasha);
        opere.Add(spyXFamily);

        foreach (OperaGiapponese opera in opere)
        {
            opera.MostraInfo();
            Console.WriteLine();
        }



        //ESERCIZIO 3

        Pomodoro pomodoro = new Pomodoro();

        //pomodoro.StatoCrescita = "Maturo"; non è accessibile per il livello di sicurezza

        pomodoro.Irriga();
        Console.WriteLine($"POMODORO IRRIGATO: {pomodoro.ToString()}");
        Console.WriteLine();



        //ESERCIZIO 4

        Dispositivo smartphone = new Smartphone("smartphone1");
        Dispositivo televisore = new Televisore("televisore1");


        smartphone.Accendi();
        televisore.Accendi();
    }
}