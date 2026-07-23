using Microsoft.AspNetCore.Mvc;
using WEBAPI.Filtri;
using WEBAPI.Models;
using WEBAPI.Models.Repository;
/*il controller serve a organizzare la logica .
 * dell'API in modo strutturato,
 evitando di avere tutti gli endpoint sparsi in 
un unico file, come nelle Minimal API*/
namespace WEBAPI.Controllers
{
    /*l'attributo [APIController] serve a dire al framework
     che questa classe deve essere trattata come un controller API
    attivando automaticamente comportamente utili come la
    gestione semplificata dei parametri e delle validazioni*/
    [ApiController]
    [Route("api/[Controller]")] //SECONDA MODALITA'
    /*La classe MagliaController rappresenta un controller,
     cioè un componente che raggruppa più operazioni
    relative alla stessa entità (in questo caso le megliette)
    Eredita da ControllerBase che è un controller pensato
    per le Web API*/
    public class MagliaController : ControllerBase
    {
       /* //Creazione della lista di magliette in-memory
        private List<Maglia> listaMaglie = new List<Maglia>
        {
            new Maglia { ShirtID = 1, Brand = "Armani", Color = "Nero",
                        Size = 50, Gender = "uomo", Price = 250.00},
            new Maglia { ShirtID = 2, Brand = "H&M", Color = "Bianco",
                        Size = 42, Gender = "donna", Price = 29.99},
            new Maglia { ShirtID = 3, Brand = "Armani", Color = "Blu",
                        Size = 60, Gender = "donna", Price = 3250.00},
            new Maglia { ShirtID = 4, Brand = "H&M", Color = "Grigio",
                        Size = 44, Gender = "unisex", Price = 19.99}
        };*/



        /*ogni metodo dovrebbe corrispondere ad un endopoint HTTP,
         cioè ad una richiesta specifica (GET, POST, PUT,DELETE)
        che proviene da un browser (o postman...)
        Quindi le funzioni del controller vengono eseguite
        solo quando arriva una richiesta HTTP dall'esterno.
        Sono Action Method cioè un metodo dentro un controller
        che viene eseguito quando arriva una richieta HTTP ("evento")
        e restituisce ua risposta al client */

        //1. Leggere tutte le magliette
        [HttpGet]
        public IActionResult GetShirt() => Ok("Mi sto leggendo tutte le magliette");
      
        /*2. Leggere una singola maglia tramite un ID      
         tramite un id, usa la LINQ Firt per ritornare il primo
        risultato utile esatto
        Ok, BadRequest e NotFound sono metodi di ControllerBase */
        [HttpGet("{id}")]
        [Maglia_ValidationFilter]
        public IActionResult GetShirtById(int id)
        {
          /*  if (id < 1) return BadRequest();
            /*First() -> dammi il primo elmento...se non c'è => genera eccezione
             * FirstOfDefault() -> dammi il primo...se non c'è => null 
           // var m = listaMaglie.FirstOrDefault(x => x.ShirtID == id);
           var m = Magliette_DB.GetShirtById(id);

            if (m == null)
                return NotFound();
            return Ok(m);*/
          return Ok(Magliette_DB.GetShirtById(id));
        }

        //3. Creazione di una maglietta        
        [HttpPost] 
        public IActionResult CreateShirt([FromBody] Maglia maglia) 
                                             => Ok("viene creata una maglietta!");
        //4. aggiornamento della maglietta tramite id
         [HttpPut("{id}")] 
        public IActionResult UpdateShirt(int id) 
                                         => Ok($"Aggiornamento della maglia con id {id}");
        //5. eliminazione di una maglietta
        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id) 
                                        => Ok($"Cancellazione della maglietta con id: {id}");
    }
}
