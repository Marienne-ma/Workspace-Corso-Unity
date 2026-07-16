using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_16_07_26
{
    internal class Citta
    {
        public string Nome { get; set; }
        public double Temperatura { get; set; }
        public int Umidita { get; set; }

        public void Stampa()
        {
            Console.WriteLine($"Città: {Nome}\nTemperatura: {Temperatura}°C\nUmidità: {Umidita}%");
        }
    }
}
