// using Systemintegration_Gadenavne;
//
// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
//
// app.MapGet("/", () => new InformationExtractor().Extract());
//
// app.Run();

using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Systemintegration_Gadenavne;
using Systemintegration_Gadenavne.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<InformationExtractor>();
builder.Services.AddSwaggerGen(c=>  
{  
    c.SwaggerDoc("v1", new OpenApiInfo  
    {  
        Version = "v1",
        Title = "Gadenavne API",
        Description = "Et API til udtræk af gadenavne."
    });  
}); 
var app = builder.Build();

app.MapGet("/FilterByKommuneAndVejKode/{kommuneKode}/{vejkode}",
    (string kommuneKode, string vejkode, [FromServices] InformationExtractor extractor)
        => extractor.GetRecords()
            .Where(record => record!.Kommunekode.Equals(kommuneKode) && record!.Vejkode.Equals(vejkode)));

app.MapGet("/FilterByVejnavn/vejnavn", (string vejnavn, [FromServices] InformationExtractor extractor) 
    => extractor.GetRecords()
        .OfType<AktVej>()
        .Where(record => record.Vejnavn.ToLower().StartsWith(vejnavn.ToLower()))
        .Take(25));

app.UseSwagger();
app.UseSwaggerUI(c=>    
{    
    c.SwaggerEndpoint("/swagger/v1/swagger.json","Gadenavne API");    
});  
app.Run();