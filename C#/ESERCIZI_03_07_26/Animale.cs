using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_03_07_26
{
    public class Animale
    {
        public string Nome { get; set; }
        public int Eta { get; set; }
        public void CambiaEta(int nuovaEta)
        {
            Eta = nuovaEta;
        }

        public void ModificaAnimale(Animale animale)
        {
            animale.Nome = "Papera";
        }
    }



    public record AnimaleRecord(string Nome, int Eta);
}
