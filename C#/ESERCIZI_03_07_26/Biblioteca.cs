using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_03_07_26
{
    public class Biblioteca
    {
        public string Titolo { get; set; }
        public TipoLibro Tipo { get; set; }
        public object RegistroGenerico { get; set; }

        public void CambiaTitolo(string nuovoTitolo)
        {
            Titolo = nuovoTitolo;
        }

    }

    public enum TipoLibro
    {
        Narrativa,
        Saggistica,
        Fumetti
    }
}


