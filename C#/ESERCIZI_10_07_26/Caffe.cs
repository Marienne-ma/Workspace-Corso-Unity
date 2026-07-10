using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{
    internal class Caffe
    { 
        public string Miscela { get; set; }
        public double PrezzoAlChilo { get; set; }


        public Caffe(string miscela, double prezzoAlChilo)
        {
            Miscela = miscela;
            PrezzoAlChilo = prezzoAlChilo;
        }


        public virtual void Prepara()
        {
            Console.WriteLine("Preparo il caffè");
        }
    }
}
