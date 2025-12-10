namespace PokemonPractical
{
    public class PokemonService
    {
        private PokemonRepository _repository = new PokemonRepository();
        public void RegisterPokemon(String name)
        {
            var newPokemon = new Pokemon(name);
            _repository.AddPokemon(newPokemon);
        }

        public void Train(String name, int amount)
        {
            _repository.getPokemonByName(name).GainExperience(amount);
        }

        public List<Pokemon> GetPokemons()
        {
            return _repository.getAllPokemon();
        }
    }
}