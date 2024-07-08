// Abstract data types are simply classes and objects. Data types that we define and are not preset.

public class Pokemon
{
    // Notice how we define the type of data when making Name(string) and Exp(int)
    // Here we define the Name of our Pokemon.
    public string Name { get; set; }

    // Here we define the exp of our Pokemon.
    public int Exp { get; set; }

    // Here we define whether or not this is in fact a pokemon.
    public bool IsPokemon()
    {
        return true;
    }

    // A class is essentially a box that we store data in.
}