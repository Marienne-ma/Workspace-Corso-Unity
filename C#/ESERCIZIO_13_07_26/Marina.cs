using System;

namespace ESERCIZIO_13_07_26
{
    internal class Marina
    {
        public void ControllaAttacco(object sender, EventArgsAttacco e)
        {
            if (!e.Successo)
            {
                Console.WriteLine($"Attacco di {e.NomeCiurma} fallito");
                Console.WriteLine($"Energia utilizzata: {e.GradoEnergia}");
                return;
            }

            Console.WriteLine($"Attacco di {e.NomeCiurma} riuscito");

            if (e.NomeAttacco == Pirata.Attacco.Cannone)
            {
                Console.WriteLine("Cannoni non permessi, la Marina interviene.");
            } else if (e.NomeAttacco == Pirata.Attacco.Assalto)
            {
                Console.WriteLine("Assalto non permesso, la Marina interviene.");
            } else if (e.GradoEnergia > 150)
            {
                Console.WriteLine("Forza d'attacco troppo alta, la Marina interviene.");
            } else
            {
                Console.WriteLine("Attacco permesso dalla Marina.");
            }
        }
    }
}