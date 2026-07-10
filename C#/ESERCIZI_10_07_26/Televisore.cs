using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Televisore : Dispositivo
    {
        public Televisore(string nome) : base(nome)
        {
        }

        public new void Accendi()
        {
            Console.WriteLine($"{nome} ACCESO");
        }
    }
}
