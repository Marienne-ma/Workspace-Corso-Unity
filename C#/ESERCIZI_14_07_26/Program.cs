using ESERCIZI_14_07_26;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Sei iscritto alla biblioteca? (s/n): ");
            bool iscritto = Console.ReadLine().ToLower() == "s";

            if (!iscritto) throw new Exception("Devi essere iscritto alla biblioteca per usufruire dei servizi");

            Console.WriteLine("Quanti libri vuoi prendere? ");
            int libri = Convert.ToInt32(Console.ReadLine());

            if (libri > 3) throw new Exception("Puoi prendere massimo 3 libri");

            DateTime oggi = DateTime.Now;

            bool ferragosto = oggi.Day == 15 && oggi.Month == 8;
            bool natale = (oggi.Month == 12 && oggi.Day >= 24) ||
                          (oggi.Month == 1 && oggi.Day <= 6);

            if (natale || ferragosto) throw new Exception("La biblioteca è chiusa in questo periodo");

            Console.WriteLine("Età: ");
            int eta = Convert.ToInt32(Console.ReadLine());

            if (eta < 18 && iscritto) throw new Exception("I minorenni non possono iscriversi");

            Console.WriteLine("Genere del libro: ");
            string genere = Console.ReadLine().ToLower();

            if ((genere == "horror" || genere == "giallo") && eta < 14) throw new Exception("Non puoi leggere questo genere");

            Console.WriteLine("La copia è disponibile? (s/n): ");
            bool disponibile = Console.ReadLine().ToLower() == "s";

            if (!disponibile) throw new LibroNonDisponibileException("La copia del libro non è disponibile");

            Console.WriteLine("Donazione (5, 10 o 15): ");
            int donazione = Convert.ToInt32(Console.ReadLine());

            if (donazione != 5 && donazione != 10 && donazione != 15) throw new DonazioneNonValidaException("La donazione deve essere di 5, 10 o 15 euro");

            Console.WriteLine("Prestito completato");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hai inserito un formato non valido");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Numero troppo grande");
        }
        catch (DonazioneNonValidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (LibroNonDisponibileException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Operazione conclusa");
        }
    }
}



