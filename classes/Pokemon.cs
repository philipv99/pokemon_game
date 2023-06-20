
public class Pokemon<T> : IPokeMon<T> where T : IhasId
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }

    public List<Attacks<T>>? Powers { get; set; }
    public List<ClassPokeTypes>? Types { get; set; }

    public Pokemon(string name, int hp, int power, int speed)
    {
        Id = IdMaker();
        Name = name;
        Hp = hp; 
        Power = power;
        Speed = speed;
    }

    private int Idvalue = 0;
    private int IdMaker()
    {
        Id = Idvalue++;
        return Idvalue;
    }
}       