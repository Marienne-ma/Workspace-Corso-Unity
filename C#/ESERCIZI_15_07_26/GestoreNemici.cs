using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_15_07_26
{
    internal class GestoreNemici
    {
        private List<Nemico> nemici = new List<Nemico>();

        public void AggiungiNemico(Nemico n)
        {
            nemici.Add(n);
        }

        public void FaiAttaccareNemici()
        {
            foreach (var n in nemici)
            {
                Console.WriteLine($"{n.Nome} attacca:");
                n.Attacco();
            }
        }

        public void InfliggiDanno(int danno)
        {
            foreach (var n in nemici)
            {
                n.DannoSubito(danno);
            }
        }
    }
}
