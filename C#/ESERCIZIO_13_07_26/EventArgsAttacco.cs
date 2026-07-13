using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESERCIZIO_13_07_26.Pirata;

namespace ESERCIZIO_13_07_26
{
    internal class EventArgsAttacco : EventArgs
    {
        public Attacco NomeAttacco { get; set; }
        public int GradoEnergia { get; set; }
        public bool Successo { get; set; }
        public string NomeCiurma { get; set; }

        public EventArgsAttacco(Attacco nomeAttacco, int gradoEnergia,bool successo, string nomeCiurma)
        {
            NomeAttacco = nomeAttacco;
            GradoEnergia = gradoEnergia;
            Successo = successo;
            NomeCiurma = nomeCiurma;
        }
    }
}