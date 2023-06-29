
public interface IPokeMon
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }

    public List<Attacks<int>>? Powers {get; set;}
    public List<ClassPokeTypes>? Types { get; set; }

}
