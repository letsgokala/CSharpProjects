using PokemonPractical;


// solution for part one & two 

//objects creation

// var pikachu = new Pokemon("Pikachu");
// var notification = new NotificationService();

//event subscription

// pikachu.LeveledUp += Onnotification;
// pikachu.LeveledUp += notification.Announce;


// pikachu.GainExperience(5);
// Console.WriteLine($"{pikachu.Name} has gained experience! it's now level {pikachu.Level}");

// static void Onnotification(int level)
// {
//     Console.WriteLine($"the level currently leveled up to  {level}");
// }



// Solution for part three and four

var service = new PokemonService();

service.RegisterPokemon("Chamandar");
service.RegisterPokemon("squirtle");

service.Train("Chamandar", 3);
service.Train("squirtle", 10);

var pokemons = service.GetPokemons();
foreach (Pokemon pokemon in pokemons)
{
    Console.WriteLine($"{pokemon.Name} = Level {pokemon.Level}");
}
// what shall I add in my .gitignore of my c# project