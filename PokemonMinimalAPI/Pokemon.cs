public class Pokemon
{
    public string Name { get; set; }
    public int Level { get; private set; }

    public Pokemon(string name)
    {
        Name = name;
        Level = 1;
    }

    public void GainExperience(int amount)
    {
        Level += amount; 
    }
}