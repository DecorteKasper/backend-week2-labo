var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/locations", (IVaccinationLocationRepository repository) =>{

});

app.Run();
