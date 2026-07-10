using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Smartphone : Dispositivo
    {
        public Smartphone(string nome) : base(nome)
        {
        }

        public override void Accendi()
        {
            Console.WriteLine($"{nome} ACCESO");
        }
    }
}
