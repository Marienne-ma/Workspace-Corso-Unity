using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class Goblin : Nemico
    {
        public Goblin(string nome, int salute)
           : base(nome, salute)
        {

        }

        public override void Attacco()
        {
            Console.WriteLine("Il Goblin colpisce con una daga!");
        }
    }
}
