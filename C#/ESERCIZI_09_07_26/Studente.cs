using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZI_09_07_26
{
    internal class Studente
    {

        public string Nome { get; set; }
        public int[] Voti { get; set; }


        public Studente(string Nome, int[] Voti)
        {
            this.Nome = Nome;
            this.Voti = Voti;
        }

        public double CalcolaMediaVoti(int[] Voti)
        {
            int somma = 0;

            foreach (int voto in Voti)
            {
                somma += voto;
            }

            return (double)somma / Voti.Length;
        }

        public string GiudizioVoti(int[] Voti) 
        {
            double media = CalcolaMediaVoti(Voti);

            if (media >= 9) 
            {
                return "Eccellente";
            }
            else if (media >= 6)
            {
                return "Superato";
            }
            else
            {
                return "Non Superato";
            }
        }
    }
}
