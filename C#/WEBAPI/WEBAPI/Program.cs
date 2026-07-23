var builder = WebApplication.CreateBuilder(args);
/*Abilitare e registrare il supporto ai Controller 
 nel progetto ASP.Net Core. In pratica dice al 
framework che verranno utilizzati i suoi
controller, quindi li deve preparare e renderli disponibili*/
builder.Services.AddControllers();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection(); //converte richieste insicure in https

/*Attiva il sistema dei Controller nella 
 pipeline HTTP di ASP.NET Core.
Quindi informa il framework di cercare tutte le 
classi Controller e collegare automaticamente
le richieste HTTP (URL + verbo) ai
relativi Action Methods.*/
app.MapControllers();
app.Run();


/*
 Questo qui a commento è un esempio di Minimal API
cioè quando si ha tutto all'interno dello stesso
Program.cs.
Per applicazioni molto piccole potrebbe anche andare bene,
ma nel mondo reale non è un giusto approccio 

app.UseRouting();          //decide quale endpoint associare alla richiesta
app.UseAuthentication();   //controlla l'identità dell utente (chi sei????)
app.UseAuthorization();   //controlla i permessi (puoi farlo?!?!??! sì...no)

//Magliette
app.MapGet("/maglia", () =>
{
    return "leggi maglia";
});

app.MapGet("/maglia/{id}", (int id) => {
    return $"leggi maglia attraverso id {id}";
});

app.MapPost("/maglia", () =>
{
    return "crea maglietta";
});

app.MapPut("/maglia/{id}", (int id) =>
{
    return $"modifica maglietta con id: {id}";
});

app.MapDelete("/maglia/{id}", (int id) => {
    return $"Cancella maglietta con id: {id}";
});

app.Run();*/