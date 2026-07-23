namespace WEBAPI.Models.Repository
{
    /*La classe viene fatta statica perchè non si vuole che debba
     essere creata come oggetto (non serve usare il "new" )
    Essendo un repository in-memory:
    - i dati devono essere condivisi da tutta l'applicazione
    - non serve creare più istanze della stessa classe
    - risulta più semplice accedere direttamente ai metori

    In questo modo si può usare la classe direttamente, ad esempio:
    Magliette_db.GetShirtById(id);

    Senza dover creare una istanza del repository
     */
    public static class Magliette_DB
    {
        private static List<Maglia> listaMaglie = new List<Maglia>
        {
            new Maglia { ShirtID = 1, Brand = "Armani", Color = "Nero",
                        Size = 50, Gender = "uomo", Price = 250.00},
            new Maglia { ShirtID = 2, Brand = "H&M", Color = "Bianco",
                        Size = 42, Gender = "donna", Price = 29.99},
            new Maglia { ShirtID = 3, Brand = "Armani", Color = "Blu",
                        Size = 60, Gender = "donna", Price = 3250.00},
            new Maglia { ShirtID = 4, Brand = "H&M", Color = "Grigio",
                        Size = 44, Gender = "unisex", Price = 19.99}
        };

        //metodo che controlla se una maglia esiste (ritorna true/false)
        public static bool magliaEsiste(int id) {
            return listaMaglie.Any(x => x.ShirtID == id);
        }

        //Cerca e ritorna una maglietta. Il punto interrogativo (Maglia?)
        //indica che il metodo può restituire "null" se l'ID non esiste
        public static Maglia? GetShirtById(int id) {
            return listaMaglie.FirstOrDefault(x => x.ShirtID == id);
        }
    }
}
