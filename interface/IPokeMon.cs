
public interface IPokeMon<T> where T : IhasId
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Power { get; set; }
    public int speed { get; set; }

    public List<Attacks<T>>? Powers {get; set;}
    public List<ClassPokeTypes>? Types { get; set; }


}
