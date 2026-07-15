using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_14_07_26
{
    internal class Eccezioni
    {
    }

    public class LibroNonDisponibileException : Exception
    {
        public LibroNonDisponibileException() { }

        public LibroNonDisponibileException(string message) : base(message) { }
    }

    public class DonazioneNonValidaException : Exception
    {
        public DonazioneNonValidaException() { }

        public DonazioneNonValidaException(string message) : base(message) { }
    }

}
