

namespace ESERCIZI_01_07_26
{
    public class Spettacolo
    {

        public int Sala { get; set; }
        public int Posti { get; set; }
           
        public string SpettacoloName { get; set; }

        public Spettacolo(int sala, int posti, string spettacolo) {

            Sala = sala;
            Posti = posti;
            SpettacoloName = spettacolo;
        }

        public void infoSpettacolo()
        {
            Console.WriteLine($"Sala n: {Sala}, posti totali: {Posti}, Spettacolo: {SpettacoloName}");
        }

        public int infoPostiDisponibili(int postiTotali, int postiOccupati) { 
            return postiTotali - postiOccupati;
        }



    }
}
