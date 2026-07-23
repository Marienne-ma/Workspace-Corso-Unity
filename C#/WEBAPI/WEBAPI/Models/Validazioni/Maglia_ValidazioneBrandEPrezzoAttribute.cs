using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Models.Validazioni
{
    /*Questa classe rappresenta una custom Validation Attribute per la classe MAglia
     serve a definire le regole di business specifiche che non possono
    essere espresse con i normali DATA Annotation di C#.
    
     In questo caso la validazione dipende dalla combinazione di più
    proprietà (Brand e Rpice) quindi viene usata una logica
    personalizzata*/
    public class Maglia_ValidazioneBrandEPrezzoAttribute : ValidationAttribute
    {
        /*Bisogna effettuare l'override del metodo base IsValid che viene
         definito all'interno di ValidationAttribute. Questo meotodo viene
        chiamato direttamente dal framework ASP.Net  Core durante la fase
        del model validation.
        Qui viene implimentata la logica personalizzata per verificare se l'oggetto
        Maglia rispetta le regole di business definite.
        
        Se la validazione fallisce viene restituito un ValidationResult
        con il relativo messaggio di errore, altrimneti ValidationResult.Success
         */

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //Recupero l'intera istanza dell'oggetto dal contesto di validazione
            var shirt = validationContext.ObjectInstance as Maglia;
            //se ho la maglietta e se il brand non è null
            if(shirt != null && !string.IsNullOrEmpty(shirt.Brand)){
                //controllo se il brand è armani
                if (shirt.Brand.Equals("armani", StringComparison.OrdinalIgnoreCase))
                {
                    //controllo se il prezzo è < 200
                    if (shirt.Price != null && shirt.Price < 200)
                    {
                        return new ValidationResult("Armani costa più di 200!!!! POLLO");
                    }
                } //controlliamo se il Brand è H&M
                else if(shirt.Brand.Equals("H&M", StringComparison.OrdinalIgnoreCase)){
                    //allora il prezzo > 100 ERRORE!!!
                    if (shirt.Price.HasValue && shirt.Price > 100) {
                        return new ValidationResult("H&M costa meno di 100 EURO IMBROGLIONE!!!");
                    }
                }                
            }
            //se supera tutti i controlli
            return ValidationResult.Success;
        }
    }
}
