
namespace ESERCIZI_01_07_26
{
    public class Cinema
    {
        string Nome = "Cinema Prova";
        int NumeroSale = 10;
        int PostiPerSala = 130;
        int PostiOccupati = 50;

        public void MostraInformazioni()
        {
            Console.WriteLine($"Nome del cinema: {Nome}");
            Console.WriteLine($"Numero di sale: {NumeroSale}");
        }

        public int PostiTotali()
        {
            int PostiTotali = NumeroSale * PostiPerSala;
            return PostiTotali;
        }

        public int PostiLiberi()
        {
            int PostiLiberi = PostiTotali() - PostiOccupati;
            return PostiLiberi;
        }






    }
}
