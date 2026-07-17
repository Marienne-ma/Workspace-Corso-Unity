public class Program()
{
    static string folder = Path.Combine(Environment.CurrentDirectory, "files");
    static string filePath = Path.Combine(folder, "messaggio.txt");
    static string csv = Path.Combine(folder, "canzoni.csv");
    static string playlist = Path.Combine(folder, "playlist.txt");
    static string savegame = Path.Combine(folder, "savegame.txt");

    static void Main(string[] args)
    {
        //ESERCIZIO 1

        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
            Console.WriteLine("Cartella files creata");
        }

        

        //string fileMessaggio = Path.Combine(folder, "messaggio.txt");

        //Console.Write("Scrivi un messaggio: ");
        //string risposta = Console.ReadLine();

        //string cifrato = "";

        //foreach (char c in risposta)
        //{
        //    cifrato += (char)(c + 3);
        //}

        //using (StreamWriter writer = new StreamWriter(filePath))
        //{
        //    writer.WriteLine(cifrato);
        //}

        //Console.WriteLine("Messaggio salvato");

        //using (StreamReader reader = new StreamReader(filePath))
        //{
        //    string testo = reader.ReadToEnd();

        //    Console.Write("Sei il vero destinatario? (s/n): ");
        //    risposta = Console.ReadLine();

        //    if (risposta.ToLower() == "s")
        //    {
        //        string decifrato = "";

        //        foreach (char c in testo)
        //        {
        //            decifrato += (char)(c - 3);
        //        }

        //        Console.WriteLine(decifrato);
        //    }
        //    else
        //    {
        //        Console.WriteLine(testo);
        //    }
        //}


        //ESERCIZIO 2

        //using (StreamWriter streamWriter = new StreamWriter(playlist))
        //{
          
        //    foreach (string riga in File.ReadLines(csv).Skip(1))
        //    {
                
        //        string[] canzoni = riga.Split(';');

        //        string titolo = canzoni[0];
        //        string artista = canzoni[1];
        //        string genere = canzoni[2];
        //        int bpm = int.Parse(canzoni[3]);

                
        //        if (genere == "Metal" && bpm > 120)
        //        {
        //            streamWriter.WriteLine(riga);
        //        }
        //    }
        //}

        //Console.WriteLine("Playlist creata");


        //ESERCIZIO 3

        using (FileStream fileStream = new FileStream(savegame, FileMode.Open, FileAccess.ReadWrite))
        {
            Console.WriteLine("CanRead: " + fileStream.CanRead);
            Console.WriteLine("CanWrite: " + fileStream.CanWrite);
        }

        FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(folder);

        fileSystemWatcher.Filter = "savegame.txt";

        fileSystemWatcher.IncludeSubdirectories = false;

        fileSystemWatcher.Changed += Allarme;
        fileSystemWatcher.Created += Allarme;
        fileSystemWatcher.Renamed += Allarme;

   
        fileSystemWatcher.EnableRaisingEvents = true;

        Console.WriteLine("Prova a modificare savegame.txt oppure premi invio per chiudere la console");
 
        Console.ReadLine();
    }

    static void Allarme(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine("ATTENZIONE: Tentativo di modifica non autorizzato rilevato!");
    }
}