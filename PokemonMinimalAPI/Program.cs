using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var pokemons = new List<Pokemon>(){new Pokemon("pikachu"), new Pokemon("chamander"), new Pokemon("raibus")}; // In-memory Pokémon database

app.MapGet("/pokemon", () =>
{
    return Results.Ok(pokemons);
});

app.MapGet("/pokemon/{name}", (string name) =>
{
    var pokemon = pokemons.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

    if (pokemon == null)
        return Results.NotFound($"Pokemon '{name}' not found.");

    return Results.Ok(pokemon);
});

app.MapPost("/pokemon", (Pokemon newPokemon) =>
{
    pokemons.Add(newPokemon);

    return Results.Created($"/pokemon/{newPokemon.Name}", newPokemon);
});

app.MapDelete("/pokemon/{name}", (string name) =>
{
    var pokemon = pokemons.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

    if (pokemon == null)
        return Results.NotFound($"Pokemon '{name}' not found.");

    pokemons.Remove(pokemon);

    return Results.Ok(pokemons);
});

app.MapPost("/pokemon/{name}/train/{amount}", (string name, int amount) =>
{
    var pokemon = pokemons.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

    if (pokemon == null)
        return Results.NotFound($"Pokemon '{name}' not found.");

    pokemon.GainExperience(amount);

    return Results.Ok(pokemon);
});

app.MapGet("/iyasu", (string name) =>
{
    return Results.Ok("iyasu is shushing" + name);
});



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "something random"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(0, 8).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
