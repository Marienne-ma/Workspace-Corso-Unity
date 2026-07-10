using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Dispositivo
    {
        public string nome;

        public Dispositivo(string nome)
        {
            this.nome = nome;
        }
        public virtual void Accendi()
        {
            Console.WriteLine($"Dispositivo ACCESO");
        }
    }
}
