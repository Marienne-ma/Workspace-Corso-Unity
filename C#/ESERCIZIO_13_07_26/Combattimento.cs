using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESERCIZIO_13_07_26.Pirata;

namespace ESERCIZIO_13_07_26
{
    internal class Combattimento
    {

        public delegate void GestoreAttacco(object sender, EventArgsAttacco e);

        public event GestoreAttacco AttaccoRiuscito;

        public event GestoreAttacco AttaccoFallito;

        public void LanciaAttacco(Attacco attacco, int energia, string ciurma)
        {
            bool successo = energia >= 70;

            EventArgsAttacco invioAttacco = new EventArgsAttacco(attacco, energia, successo, ciurma);

            if (successo)
            {
                AttaccoRiuscito?.Invoke(this, invioAttacco);
            }
            else
            {
                AttaccoFallito?.Invoke(this, invioAttacco);
            }

        }
    }
}
