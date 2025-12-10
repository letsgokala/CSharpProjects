using System;

namespace PokemonPractical
{
    public class Pokemon
{
    // Private fields (encapsulation)
    private string _name;
    private int _level;

    // Public properties
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public int Level
    {
        get { return _level; }
        private set { _level = value; }
    }

    // Event (Action<int> means it will send an int parameter)
    public event Action<int> LeveledUp;

    // Constructor
    public Pokemon(string name)
    {
        Name = name;
        Level = 1;
    }

    // Method that increases the level & triggers the event
    public void GainExperience(int amount)
    {
        Level += amount;

        // Trigger event if someone subscribed
        LeveledUp?.Invoke(amount);
    }
    }
}