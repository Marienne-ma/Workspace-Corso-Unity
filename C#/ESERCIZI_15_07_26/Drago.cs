using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class Drago : Nemico
    {
        public Drago(string nome, int salute)
            : base(nome, salute)
        {

        }


        public override void Attacco()
        {
            Console.WriteLine("Il Drago sputa fuoco/ghiaccio!");
        }
    }
}
