using System;

class Acquario
{
    public string[,] vasche;
    public double[] temperature;


    public Acquario()
    {
        vasche = new string[,]
        {
            { "Pesce Leone", "Vuota", "Pesce Pagliaccio", "Axolotl" },
            { "Pesce Mandarino", "Squalo Martello", "Vuota", "Pesce Chirurgo" },
            { "Medusa", "Vuota", "Cavalluccio Marino", "Delfino" },
            { "Pesce Pietra", "Pesce Angelo", "Vuota", "Pesce Arciere" }
        };

        temperature = new double[]
        {
            24.0,
            26.0,
            28.0,
            22.0
        };


    }

    public void StampaAcquario()
    {
        Console.WriteLine("Mappa dell'acquario:");

        for (int i = 0; i < vasche.GetLength(0); i++)
        {
            for (int j = 0; j < vasche.GetLength(1); j++)
            {
                Console.Write(vasche[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public void ContaVasche()
    {
        int pesci = 0;
        int vuote = 0;

        for (int i = 0; i < vasche.GetLength(0); i++)
        {
            for (int j = 0; j < vasche.GetLength(1); j++)
            {
                if (vasche[i, j] == "Vuota")
                {
                    vuote++;
                }
                else
                {
                    pesci++;
                }
            }
        }

        Console.WriteLine("Pesci presenti: " + pesci);
        Console.WriteLine("Vasche vuote: " + vuote);
    }

    public void DiagonalePrincipale()
    {
        Console.WriteLine("Diagonale principale:");

        for (int i = 0; i < vasche.GetLength(0); i++)
        {
            Console.WriteLine($"-{vasche[i, i]}");
        }
    }

    public void DiagonaleSecondaria()
    {
        Console.WriteLine("Diagonale secondaria:");

        for (int i = 0; i < vasche.GetLength(0); i++)
        {
            Console.WriteLine($"-{vasche[i, vasche.GetLength(0) - 1 - i]}");
        }
    }

    public void CercaPesceDelfinoOPagliaccio(string target)
    {
     
        for (int i = 0; i < vasche.GetLength(0); i++)
        {
            for (int j = 0; j < vasche.GetLength(1); j++)
            {
                if (vasche[i, j].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Trovato {target} nella posizione [{i},{j}]");

                    if (target.Equals("Pesce Pagliaccio", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Hai trovato il pesce sfortunato!");
                        return;
                    }

                    if (target.Equals("Delfino", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Hai trovato il pesce fortunato!");
                        return;
                    }

                }
            }
        }

    }

    public bool VerificaFiltri(double[] temperature, out int nAnomalie, out double[,] temperatureModificate)
    {
        nAnomalie = 0;
        temperatureModificate = new double[2, temperature.Length];

        for (int i = 0; i < temperature.Length; i++)
        {

            temperatureModificate[0, i] = temperature[i];

            if (temperature[i] < 22.0 || temperature[i] > 26.0)
            {
                nAnomalie++;
                temperatureModificate[1, i] = 22;

            }
            else
            {
                temperatureModificate[1, i] = temperature[i];
            }
        }

        Console.WriteLine("Temperature originali:");

        for (int j = 0; j < temperatureModificate.GetLength(1); j++)
        {
            Console.WriteLine($"-{temperatureModificate[0, j]}");
        }

        Console.WriteLine("Temperature corrette:");

        for (int j = 0; j < temperatureModificate.GetLength(1); j++)
        {
            Console.WriteLine($"-{temperatureModificate[1, j]}");
        }

        return nAnomalie > 0 ? false : true;
    }
}