namespace PokemonPractical
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemons = new List<Pokemon>();
        public void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }
        
        public Pokemon getPokemonByName(String name)
        {
            return _pokemons.FirstOrDefault(p => p.Name == name);
        }

        public List<Pokemon> getAllPokemon()
        {
            return _pokemons;
        }
    }    

}