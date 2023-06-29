
public class Pokemon<T> : IPokeMon, IhasId
{
    public int Id { get; set; }  
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }

    public List<Attacks<int>>? Powers { get; set; }
    public List<ClassPokeTypes>? Types { get; set; }

    public Pokemon(string name, int hp, int power, int speed)
    {
        Id = IdMaker();
        Name = name;
        Hp = hp; 
        Power = power;
        Speed = speed;
        Powers = new List<Attacks<int>>();
        Types = new List<ClassPokeTypes>();
    }

    private int Idvalue = 0;
    private int IdMaker()
    {
        Id = Idvalue++;
        return Idvalue;
    }

    public override string ToString()
    {
        string PokemonString = 
            $"{Name} : {TypesPrinter()} type\n" +
            $"HP:{Hp}   PWR:{Power}  SPD{Speed}\n";
        foreach (var power in Powers)
        {
            PokemonString += "///////////////////////\n";
            PokemonString += $"{power}";
        }
        return PokemonString;  
    }
    
    public string TypesPrinter()
    {
        string PokemonTypes = "";
        foreach (var type in Types)
        {
            PokemonTypes += type.ToString();
        }
        return PokemonTypes;
    }

    public void Addpower(Attacks<int>? powerToAdd)
    {
        if (powerToAdd == null) { return; }
        if (Powers.Contains(powerToAdd)) { Console.WriteLine($"{Name} already has {powerToAdd.Name}"); return; }
        if (Powers.Count() >= 4) { powerCapReached(powerToAdd); }
        Powers?.Add(powerToAdd);
    }

    private void powerCapReached(Attacks<int>? powerToAdd)
    {
        string? playerIntput = null;
        Console.WriteLine($"{Name} allready has 4 powers, make room for {powerToAdd.Name}");
        Console.WriteLine("[Y  /  N] ?");
        playerIntput = Console.ReadLine()?.ToLower().Replace(" ", "");
        if (playerIntput == null) { powerCapReached(powerToAdd); }
        if (playerIntput == "n") { return; }
        if (playerIntput == "y")
        {
            foreach (var Power in Powers)
            {
                Console.WriteLine(Powers.IndexOf(Power) + " -----------------------------------------------");
                Console.WriteLine(Power);
            }
            while (true)
            {
                Console.WriteLine("Write the number of the power u want to replace [1 - 4]");
                playerIntput = Console.ReadLine()?.ToLower().Replace(" ", "");
                if (playerIntput == null) { return; }
            }
            
        }
    }   
}       