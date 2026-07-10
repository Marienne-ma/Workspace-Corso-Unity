using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_09_07_26
{
    internal class NegozioAntiquariato
    {
        public string[] Codici { get; set; }

        public NegozioAntiquariato(string[] codici)
        {
            Codici = codici;
        }

        public void ControllaCodici(string[] codici)
        {
            foreach (string codice in codici)
            {
           
                string _codice = codice;

                if (string.IsNullOrEmpty(_codice)) goto Errore;

                _codice = _codice.Trim().Replace(" ", "");

                //ricontrollo che non sia una stringa fatta di soli spazi
                if (_codice == "") goto Errore;

                if (_codice.StartsWith("ANT-")) goto Accettato;
                else goto Errore;

                Accettato: Console.WriteLine($"Codice pulito e accettato: {_codice}");
                    continue;
                
                Errore: Console.WriteLine($"Codice non valido: {codice}");
           
            }
        }
    }
}
