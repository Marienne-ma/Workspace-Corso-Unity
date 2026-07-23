using System.ComponentModel.DataAnnotations;
using WEBAPI.Models.Validazioni;

namespace WEBAPI.Models
{
    public class Maglia
    {
        /*i punti interrogativi accanto a string indicano
         che quelle propirietà sono Nullable.
        Significa che ASP.NET Core accetterà la richiesta 
        di creazione ance se il clinet dimentica di inserire
        il Brand, il Color, oppure il Gender, impostando
        il loro valore a null senza far crashare l'applicazione. */
        public int ShirtID { get; set; }
        [Required] //rende campo obbligatorio
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }
        public int? Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        //attributi di validazione personalizzato
        [Maglia_ValidazioneBrandEPrezzo]
        public double? Price { get; set; }

    }
}
