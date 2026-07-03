using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_02_07_26
{
    public class Alieno
    {

        public string colore { get; set; } // al posto del nome
        public int numeroOcchi { get; set; }
        public int numeroBraccia { get; set; }
        public double altezza { get; set; }
        public bool haPoteri { get; set; }
        public bool haArmi { get; set; }
        public double? energia { get; set; }
        public bool ostilità { get; set; }
        public string pianetaDiProvenienza { get; set; }

        public string telefono { get; set; } = "000000000";



        public void StampaInfo()
        {
            Console.WriteLine($"Colore: {colore}, Numero Occhi: {numeroOcchi}, Numero Braccia: {numeroBraccia}, Altezza: {altezza}, Ha Poteri: {haPoteri}, Ha Armi: {haArmi}, Energia: {energia}, È Ostile: {ostilità}, Pianeta di Provenienza: {pianetaDiProvenienza}, Telefono: {telefono}");
        }

        public Alieno ControllaEnergia(Alieno alieno1, Alieno alieno2)
        {

            return alieno1.energia > alieno2.energia ? alieno1 : alieno2;
        }

        public void PassaEnergia(Alieno alieno1, Alieno alieno2)
        {
            if (alieno1.energia > alieno2.energia)
            {
                double? x = alieno1.energia / 2;

                alieno1.energia -= x;
                alieno2.energia += x;

            }
            else if (alieno1.energia < alieno2.energia)
            {
                double? x = alieno2.energia / 2;

                alieno2.energia -= x;
                alieno1.energia += x;

            }
        }


        public bool ControlloEnergiaEOstilita(Alieno alieno)
        {
            return alieno.energia > 150 && alieno.ostilità;

        }

        public void ControlloColore(Alieno alieno1, Alieno alieno2, Alieno alieno3)
        {
            if (string.Equals(alieno1.colore, alieno2.colore) && string.Equals(alieno2.colore, alieno3.colore))
            {
                Console.WriteLine("Gli alieni hanno lo stesso colore");
            }
            else
            {
                Console.WriteLine("Gli alieni hanno colori diversi");
            }
        }

        public bool ControlloMarte(Alieno alieno)
        {
            return string.Equals(alieno.pianetaDiProvenienza, "Marte") ? true : false;
            
        }



    }
}
