using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_13_07_26
{
    internal class Pirata
    {
        private Combattimento Combattimento;

        public string Ciurma { get; set; }
        public int Energia { get; set; }
        public enum Attacco
        {
            Sciabola,
            Pistola,
            Cannone,
            Assalto
        }

        public Pirata(Combattimento combattimento, string ciurma, int energia )
        {
            Combattimento = combattimento;
            Ciurma = ciurma;
            Energia = energia;
        }

        public void LanciaAttacco(Attacco nomeAttacco)
        {
            Console.WriteLine($"Il capitano di {Ciurma} ordina di attaccare utilizzando {nomeAttacco}");

            Combattimento.LanciaAttacco(nomeAttacco, Energia, Ciurma);
        }
    }
}
