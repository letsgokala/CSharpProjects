namespace PokemonPractical
{
    public class NotificationService
    {
        public void Announce(int gainedAmount)
        {
            Console.WriteLine($"A Pokémon leveled up! Gained {gainedAmount} levels!");
        }
    }
}