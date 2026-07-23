using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WEBAPI.Models.Repository;

namespace WEBAPI.Filtri
{
    /*Questo Filter Personalizzato serve per validare il parametro "id"
     delle richieste e viene eseguito PRIMA che il metodo del controller
    venga richiamato*/
    public class Maglia_ValidationFilterAttribute : ActionFilterAttribute
    {
        //metodo seguito automaticamente prima dell'azione del controller
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //chiama la logica di base del framework (nonè obbligatorio ma è buona pratica lasciarlo)
            base.OnActionExecuting(context);
            /*Si recupera il patametro "id" passato all'endpoint (Action Arguments) 
             e lo converte in un int nullable, altrimenti si può inserire anche la dicitura null 
           e ActionArguments contiene tutti i parametri della richiesta
             */
            var magliaId = context.ActionArguments["id"] as int?;

            //controlla se l'ide della maglia è presente
            if (magliaId.HasValue) {
                //controlla se l'ide della maglia è valido
                if (magliaId.Value <= 0) {
                    /*Aggiunge un errore al ModelState che è un oggetto che tiene
                     traccia dello stato di dati ricevuti da una richiesta*/
                    context.ModelState.AddModelError("ShirtID", "id non valido!!!");
                    //interrompe l'esecuzione dell'azione e restituisce 400 Bad Request
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }
                else if(!Magliette_DB.magliaEsiste(magliaId.Value)){ //se la maglietta esiste nel repository
                    //Aggiunge un errore al ModelState 
                    context.ModelState.AddModelError("ShirtID", "maglia non esistente!!!");

                    //interrompe l'esecuzione dell'azione e restituisce 404 NotFound
                    context.Result = new NotFoundObjectResult(context.ModelState);
                }
            }
        }
    }
}
