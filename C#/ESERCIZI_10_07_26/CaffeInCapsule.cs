using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_10_07_26
{

    public enum MaterialeCapsula
    {
        Alluminio,
        Plastica,
        Compostabile
    }

    public enum Compatibilita
    {
        Nespresso,
        DolceGusto,
        Borbone
    }
    internal class CaffeInCapsule : Caffe
    {

        public MaterialeCapsula MaterialeCapsula { get; set; }
        public Compatibilita Compatibilita { get; set; }
   
        
        public CaffeInCapsule(string miscela, double prezzoAlChilo, MaterialeCapsula materialeCapsula, Compatibilita compatibilita)
            : base(miscela, prezzoAlChilo)
        {


            MaterialeCapsula = materialeCapsula;
            Compatibilita = compatibilita;
        }


        public override void Prepara()
        {
            Console.WriteLine($"Preparo il caffè con la capsula compatibile con: {Compatibilita}");
        }

        public override string ToString()
        {


            return $"Miscela: {Miscela}; \nPrezzo al chilo: {PrezzoAlChilo:F2}€; \nMateriale della capsula: {MaterialeCapsula}; \nCompatibile con macchina caffè: {Compatibilita}";
        }
    }
}
