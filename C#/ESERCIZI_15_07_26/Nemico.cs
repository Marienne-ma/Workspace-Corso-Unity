using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal abstract class Nemico
    {
        public string Nome { get; set; }
        public int Salute { get; set; }

        public Nemico(string nome, int salute)
        {
            Nome = nome;
            Salute = salute;
        }

        public void DannoSubito(int danno)
        {
            Salute -= danno;

            Console.WriteLine($"{Nome} ha subito {danno} danni.");

            if (Salute <= 0)
            {
                Salute = 0;
                Console.WriteLine($"{Nome} è stato sconfitto!");
            }
            else
            {
                Console.WriteLine($"Salute rimasta: {Salute}");
            }
        }

        public abstract void Attacco();
    }
}
